using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trens
{
    public partial class Form1 : Form
    {
        private Dictionary<string, PointF> cidades = new Dictionary<string, PointF>();
        private List<Caminho>             caminhos = new List<Caminho>();
        private GrafoCaminhos grafo;

        private bool showMousePos  = false;
        private PointF localCidade = PointF.Empty;

        public readonly static Size TAMANHO_CIRCULO = new Size(10, 10);
        public readonly static Size OFFSET_CIRCULO  = new Size(TAMANHO_CIRCULO.Width / 2, TAMANHO_CIRCULO.Height / 2);

        public Form1()
        {
            InitializeComponent();

            this.Size = new Size(646, 563);
        }

        #region Métodos de cidades
        private void carregarCidades(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                cbxCidades.Items.Clear();
                cbxCidade1.Items.Clear();
                cbxCidade2.Items.Clear();

                StreamReader sr = new StreamReader(dlgOpen.FileName);
                try
                {
                    string linha = sr.ReadLine();
                    while (linha != null && linha.Trim() != "")
                    {
                        PointF p = new PointF();
                        p.X = Convert.ToSingle(linha.Substring(16, 5));
                        p.Y = Convert.ToSingle(linha.Substring(22, 5));

                        //Adiciona a cidade em todos os combobox.
                        string nomeCidade = linha.Substring(0, 15).Trim();
                        cbxCidades.Items.Add(nomeCidade);
                        cbxCidade1.Items.Add(nomeCidade);
                        cbxCidade2.Items.Add(nomeCidade);

                        cidades[linha.Substring(0, 15).Trim()] = p;
                        linha = sr.ReadLine();
                    }

                    grafo = new GrafoCaminhos(caminhos, cidades.Keys.ToList());
                    mapa.Invalidate();
                }
                catch (Exception ex)
                {
                    cbxCidades.Items.Clear();
                    cbxCidade1.Items.Clear();
                    cbxCidade2.Items.Clear();
                    MessageBox.Show("Formato de arquivo inválido! \n" + ex.Message);
                }

                sr.Close();

                cidadesMenu.Visible = true;
                pnlCaminhos.Visible = true;
                this.Size = new Size(929, 563);
                carregarCidadesMenu.Visible = false;
            }
        }

        private void salvarCidades(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlgSave.FileName);

                foreach (string s in cidades.Keys.ToList())
                {
                    PointF p = cidades[s];

                    string nomeCidade = s;
                    while (nomeCidade.Length < 15)
                        nomeCidade = nomeCidade + " ";

                    sw.WriteLine(nomeCidade + " " + p.X.ToString("F3") + " " + p.Y.ToString("F3"));
                }

                sw.Flush();
                sw.Close();
            }
        }

        private void incluirCidade(object sender, EventArgs e)
        {
            string cidade = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome da cidade", "Inclusão de cidade", "");
            if (cidade != null && cidade.Trim() != "")
            {
                cidade = cidade.Trim();

                if (cidade.Length > 15)
                    cidade = cidade.Substring(0, 15);

                if (cidades.ContainsKey(cidade))
                {
                    MessageBox.Show("Cidade ja existente");
                    return;
                }

                cidades.Add(cidade, localCidade);
                showMousePos = false;

                cbxCidades.Items.Add(cidade);
                cbxCidade1.Items.Add(cidade);
                cbxCidade2.Items.Add(cidade);

                grafo = new GrafoCaminhos(caminhos, cidades.Keys.ToList());
                MessageBox.Show("Cidade incluida com sucesso!");
            }
        }

        private void excluirCidade(object sender, EventArgs e)
        {
            if (cbxCidades.SelectedIndex >= 0)
                if (MessageBox.Show("Deseja realmente excluir " + cbxCidades.SelectedItem.ToString() + "? \n (Todas as ligações com ela serão excluidas junto)", 
                                    "Exclusão", 
                                    MessageBoxButtons.YesNo, 
                                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string nomeCidade = cbxCidades.SelectedItem.ToString();
                    cidades.Remove(nomeCidade);

                    //Remove a cidade selecionada dos combobox.
                    cbxCidade1.Items.RemoveAt(cbxCidades.SelectedIndex);
                    cbxCidade2.Items.RemoveAt(cbxCidades.SelectedIndex);
                    cbxCidades.Items.RemoveAt(cbxCidades.SelectedIndex);

                    //Remove todos os caminhos em que a cidade destino ou a cidade inicial é a cidade a ser removida
                    foreach (Caminho c in caminhos)
                        if (c.Cidades[0] == nomeCidade || c.Cidades[1] == nomeCidade)
                            caminhos.Remove(c);

                    grafo = new GrafoCaminhos(caminhos, cidades.Keys.ToList());
                    mapa.Invalidate();
                }
        }

        #endregion

        #region Métodos de caminhos
        private void carregarCaminhos(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                caminhos.Clear();

                StreamReader sr = new StreamReader(dlgOpen.FileName);
                try
                {
                    string linha = sr.ReadLine();
                    while (linha != null && linha.Trim() != "")
                    {
                        string cidade1 = linha.Substring(0, 15).Trim(),
                               cidade2 = linha.Substring(15, 15).Trim();

                        //Faz com que tenha apenas caminhos entre cidades existentes
                        if (!cidades.ContainsKey(cidade1) || !cidades.ContainsKey(cidade2))
                            throw new Exception();

                        caminhos.Add(new Caminho(cidade1, cidade2, Convert.ToInt32(linha.Substring(31, 3).Trim()), Convert.ToInt32(linha.Substring(35, 4))));

                        linha = sr.ReadLine();
                    }

                    grafo = new GrafoCaminhos(caminhos, cidades.Keys.ToList());

                    mapa.Invalidate();
                }
                catch (Exception ex)
                {
                    caminhos.Clear();
                    MessageBox.Show("Formato de arquivo inválido ou cidade inexistente! \n" + ex.Message);
                }

                sr.Close();
            }
        }

        private void salvarCaminhos(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlgSave.FileName);
                foreach (Caminho caminho in caminhos)
                {
                    string cidade1 = caminho.Cidades[0],
                           cidade2 = caminho.Cidades[1],
                           velocidade = caminho.VelocidadeMedia + "",
                           distancia = caminho.Distancia + "";

                    while (cidade1.Length < 15)
                        cidade1 = cidade1 + " ";

                    while (cidade2.Length < 15)
                        cidade2 = cidade2 + " ";

                    while (velocidade.Length < 3)
                        velocidade = velocidade + " ";

                    while (distancia.Length < 4)
                        distancia = distancia + " ";

                    sw.WriteLine(cidade1 + cidade2 + " " + distancia + " " + velocidade);
                }

                sw.Flush();
                sw.Close();
            }
        }

        private void inserirCaminho(object sender, EventArgs e)
        {
            string cidade1 = cbxCidade1.SelectedItem?.ToString(),
                    cidade2 = cbxCidade2.SelectedItem?.ToString();

            if (cidade1 == null || cidade2 == null)
            {
                MessageBox.Show("Selecione duas cidades");
                return;
            }

            foreach (Caminho c in caminhos)
                if ((c.Cidades[0] == cidade1 && c.Cidades[1] == cidade2) || (c.Cidades[1] == cidade1 && c.Cidades[0] == cidade2))
                {
                    MessageBox.Show("Caminho já existente!");
                    return;
                }

            try
            {
                string result = Microsoft.VisualBasic.Interaction.InputBox("Digite a velocidade do percurso", cidade1 + " -> " + cidade2, "0");
                if (result == null)
                    throw new Exception();
                int velocidade = Math.Abs(Convert.ToInt32(result));

                result = Microsoft.VisualBasic.Interaction.InputBox("Digite a distância do percurso", cidade1 + " -> " + cidade2, "0");
                if (result == null)
                    throw new Exception();
                int distancia = Math.Abs(Convert.ToInt32(result));

                caminhos.Add(new Caminho(cidade1, cidade2, velocidade, distancia));

                grafo = new GrafoCaminhos(caminhos, cidades.Keys.ToList());
                mapa.Invalidate();
            }
            catch
            {
                MessageBox.Show("Informações inválidas, inclusão de caminho cancelada");
                return;
            }
        }

        private void excluirCaminho(object sender, EventArgs e)
        {
            string cidade1 = cbxCidade1.SelectedItem?.ToString(),
                   cidade2 = cbxCidade2.SelectedItem?.ToString();

            if (cidade1 == null || cidade2 == null)
            {
                MessageBox.Show("Selecione duas cidades");
                return;
            }

            foreach (Caminho c in caminhos)
                if ((c.Cidades[0] == cidade1 && c.Cidades[1] == cidade2) || (c.Cidades[1] == cidade1 && c.Cidades[0] == cidade2))
                    if (MessageBox.Show("Deseja realmente excluir o caminho entre " + cidade1 + " e " + cidade2 + "?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        caminhos.Remove(c);
                        MessageBox.Show("Caminho removido!");

                        grafo = new GrafoCaminhos(caminhos, cidades.Keys.ToList());
                        mapa.Invalidate();

                        return;
                    }
                    else
                        return;

            MessageBox.Show("Caminho não existente.");
        }
        #endregion

        #region Métodos graficos
        private void Form1_Resize(object sender, EventArgs e)
        {
            mapa.Invalidate();
        }

        private void mapa_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, TAMANHO_CIRCULO.Width / 2);
            foreach (Caminho caminho in caminhos)
            {
                if (caminho.VelocidadeMedia > 200)
                    p.Color = Color.MediumPurple;
                else
                    p.Color = Color.DeepSkyBlue;

                PointF cidade1 = cidades[caminho.Cidades[0]], 
                       cidade2 = cidades[caminho.Cidades[1]];

                e.Graphics.DrawLine(p, 
                                    new Point((int)(cidade1.X * mapa.Width),(int)(cidade1.Y * mapa.Height)),
                                    new Point((int)(cidade2.X * mapa.Width), (int)(cidade2.Y * mapa.Height)));
            }

            foreach (PointF cidade in cidades.Values)
            {
                Point local = new Point((int)(cidade.X * mapa.Width), (int)(cidade.Y * mapa.Height));
                e.Graphics.FillEllipse(Brushes.Red, new Rectangle(Point.Subtract(local, OFFSET_CIRCULO), TAMANHO_CIRCULO));
            }

            if (showMousePos)
            {
                Point local = Point.Subtract(new Point((int)(localCidade.X * mapa.Width), (int)(localCidade.Y * mapa.Height)), new Size(OFFSET_CIRCULO.Width + 2, OFFSET_CIRCULO.Height + 2));
                e.Graphics.FillEllipse(Brushes.Black, new Rectangle(local, new Size(TAMANHO_CIRCULO.Width + 4, TAMANHO_CIRCULO.Height + 4)));
            }
        }

        private void mapa_MouseClick(object sender, MouseEventArgs e)
        {
            this.localCidade = new PointF((float)e.X / mapa.Width, (float)e.Y / mapa.Height);

            posXMenu.Text = "Posição X: " + localCidade.X.ToString("F3");
            posYMenu.Text = "Posição Y: " + localCidade.Y.ToString("F3");

            mapa.Invalidate();
        }

        private void alternarPonto(object sender, EventArgs e)
        {
            if (showMousePos)
            {
                mostrarPontoMenu.Text = "Mostrar Ponto Atual ";
                showMousePos = false;
            }
            else
            {
                mostrarPontoMenu.Text = "Esconder Ponto Atual";
                showMousePos = true;
            }

            mapa.Invalidate();
        }
        #endregion

        private void buscarCaminho(object sender, EventArgs e)
        {
            lbCaminho.Items.AddRange(grafo.AcharCaminho("Madrid", "Viseu", ParametrosDeBusca.Distancia).ToArray());
        }
    }
}
