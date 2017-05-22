﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trens
{
    class Caminho
    {
        private string cidade1, cidade2;
        private int distancia;
        private int velocidade;

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

        public Caminho(string cidadeInicio, string cidadeDestino, int distancia, int velocidadeMedia)
        {
            this.cidade1 = cidadeInicio;
            this.cidade2 = cidadeDestino;
            this.distancia = distancia;
            this.velocidade = velocidadeMedia;

            cidades = new string[] { cidade1, cidade2 };
        }

        public static Stack<Caminho> AcharCaminho(Caminho inicio, Caminho destino, Caminho[] grafoCaminhos)
        {
            Stack<Caminho> percurso = new Stack<Caminho>();

            MelhorCaminho(inicio, destino, grafoCaminhos, ref percurso);
            return percurso;
        }

        private static void MelhorCaminho(Caminho inicio, Caminho destino, Caminho[] grafoCaminhos, ref Stack<Caminho> percurso)
        {
            throw new NotImplementedException();
        }
    }
}