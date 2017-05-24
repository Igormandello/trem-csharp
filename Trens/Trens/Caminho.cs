using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trens
{
    class Caminho
    {
        private string cidade1, cidade2;
        private int distancia,
                    velocidade,
                    preco;

        private string[] cidades;
        public String[] Cidades
        {
            get { return cidades; }
        }

        public int VelocidadeMedia
        {
            get { return velocidade; }
        }

        public int Distancia
        {
            get { return distancia; }
        }

        public int Preco
        {
            get { return preco; }
        }

        public Caminho(string cidadeInicio, string cidadeDestino, int distancia, int velocidadeMedia)
        {
            this.cidade1 = cidadeInicio;
            this.cidade2 = cidadeDestino;
            this.distancia = distancia;
            this.velocidade = velocidadeMedia;
            this.preco = (velocidadeMedia * distancia) / 100;

            cidades = new string[] { cidade1, cidade2 };
        }
    }
}
