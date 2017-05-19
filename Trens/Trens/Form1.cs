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

        public readonly static Size TAMANHO_CIRCULO = new Size(10, 10);
        public readonly static Size OFFSET_CIRCULO  = new Size(TAMANHO_CIRCULO.Width / 2, TAMANHO_CIRCULO.Height / 2);

        public Form1()
        {
            InitializeComponent();
        }

        private void carregarCidades(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlgOpen.FileName);

                try
                {
                    string linha = sr.ReadLine();
                    while (linha != null && linha.Trim() != "")
                    {
                        Point p = new Point();
                        p.X = (int)(Convert.ToDouble(linha.Substring(16, 5)) * mapa.Width);
                        p.Y = (int)(Convert.ToDouble(linha.Substring(22, 5)) * mapa.Height);

                        cidades[linha.Substring(0, 15).Trim()] = p;
                        linha = sr.ReadLine();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Formato de arquivo inválido! \n" + ex.Message);
                }

                sr.Close();

                cidadesMenu.Visible = true;
                caminhosMenu.Visible = true;

                desenharCidades();
            }
        }

        private void desenharCidades()
        {
            Graphics g = mapa.CreateGraphics();

            for (int i = 0; i < cidades.Count; i++)
                g.FillEllipse(Brushes.Red, new Rectangle(Point.Subtract(cidades.Values.ElementAt(i), OFFSET_CIRCULO), TAMANHO_CIRCULO));
        }

        private void excluirCidade(object sender, EventArgs e)
        {

        }

        private void incluirCidade(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            desenharCidades();
        }
    }
}
