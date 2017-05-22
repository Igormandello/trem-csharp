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
        private Dictionary<string, Point> cidades = new Dictionary<string, Point>();
        private List<Caminho>            caminhos = new List<Caminho>();

        public readonly static Size TAMANHO_CIRCULO = new Size(10, 10);
        public readonly static Size OFFSET_CIRCULO  = new Size(TAMANHO_CIRCULO.Width / 2, TAMANHO_CIRCULO.Height / 2);

        public Form1()
        {
            InitializeComponent();

            this.Size = new Size(646, 563);
        }

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
                        Point p = new Point();
                        p.X = (int)(Convert.ToDouble(linha.Substring(16, 5)) * mapa.Width);
                        p.Y = (int)(Convert.ToDouble(linha.Substring(22, 5)) * mapa.Height);

                        //Adiciona a cidade em todos os combobox.
                        string nomeCidade = linha.Substring(0, 15).Trim();
                        cbxCidades.Items.Add(nomeCidade);
                        cbxCidade1.Items.Add(nomeCidade);
                        cbxCidade2.Items.Add(nomeCidade);

                        cidades[linha.Substring(0, 15).Trim()] = p;
                        linha = sr.ReadLine();
                    }

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

                    mapa.Invalidate();
                }
        }

        private void incluirCidade(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            mapa.Invalidate();
        }

        private void mapa_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.DeepSkyBlue, TAMANHO_CIRCULO.Width / 2);
            foreach (Caminho caminho in caminhos)
            {
                e.Graphics.DrawLine(p, cidades[caminho.Cidades[0]], cidades[caminho.Cidades[1]]);
            }

            foreach (Point cidade in cidades.Values)
                e.Graphics.FillEllipse(Brushes.Red, new Rectangle(Point.Subtract(cidade, OFFSET_CIRCULO), TAMANHO_CIRCULO));
        }

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

                        caminhos.Add(new Caminho(cidade1, cidade2, 0, 0));

                        linha = sr.ReadLine();
                    }

                    mapa.Invalidate();
                }
                catch (Exception ex)
                {
                    caminhos.Clear();
                    MessageBox.Show("Formato de arquivo inválido ou cidade inexistente! \n" + ex.Message);
                }
            }
        }

        private void excluirCaminho(object sender, EventArgs e)
        {
            string cidade1 = cbxCidade1.SelectedItem.ToString(),
                   cidade2 = cbxCidade2.SelectedItem.ToString();

            if (MessageBox.Show("Deseja realmente excluir o caminho entre " + cidade1 + " e " + cidade2 + "?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                bool existe = false;
                foreach (Caminho c in caminhos)
                    if ((c.Cidades[0] == cidade1 && c.Cidades[1] == cidade2) || (c.Cidades[1] == cidade1 && c.Cidades[0] == cidade2))
                    {
                        caminhos.Remove(c);
                        existe = true;
                    }

                if (existe)
                    MessageBox.Show("Caminho removido!");
                else
                    MessageBox.Show("Caminho não existente.");
            }
        }

        private void inserirCaminho(object sender, EventArgs e)
        {

        }
    }
}
