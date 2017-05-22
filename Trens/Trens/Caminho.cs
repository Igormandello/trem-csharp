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
        private int velocidade;
        private int distancia;

        private string[] cidades;
        public String[] Cidades
        {
            get { return cidades; }
        }

        public Caminho(string cidadeInicio, string cidadeDestino, int velocidadeMedia, int distancia)
        {
            this.cidade1 = cidadeInicio;
            this.cidade2 = cidadeDestino;
            this.velocidade = velocidadeMedia;
            this.distancia = distancia;

            cidades = new string[] { cidade1, cidade2 };
        }
    }
}
