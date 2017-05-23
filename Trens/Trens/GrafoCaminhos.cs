using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trens
{
    enum ParametrosDeBusca { Preco, Velocidade, Distancia };

    class GrafoCaminhos
    {
        private Dictionary<String, int> cidadeVet;
        private int[,] grafo;

        public int this[String y, String x]
        {
            get { return grafo[cidadeVet[y], cidadeVet[x]]; }
        }

        public GrafoCaminhos(List<Caminho> caminhos, List<String> cidades)
        {
            grafo     = new int[cidades.Count, cidades.Count];
            cidadeVet = new Dictionary<String, int>();

            for (int i = 0; i < cidades.Count; i++)
                cidadeVet.Add(cidades[i], i);

            foreach (Caminho c in caminhos)
            {
                int c1 = cidadeVet[c.Cidades[0]],
                    c2 = cidadeVet[c.Cidades[1]];
                grafo[c1, c2] = c.Distancia;
                grafo[c2, c1] = c.Distancia;
            }
        }

        public Stack<String> AcharCaminho(String cidadeInicio, String cidadeDestino, ParametrosDeBusca param)
        {
            Stack<String> percurso = MelhorCaminho(cidadeInicio, cidadeDestino);

            return percurso;
        }

        List<String> visitados = new List<String>();
        private Stack<String> MelhorCaminho(String cidadeInicio, String cidadeDestino)
        {
            List<Stack<String>> distanciasFilhos = new List<Stack<String>>();
            visitados.Add(cidadeInicio);

            foreach (String s in cidadeVet.Keys)
                if (!visitados.Contains(s) && this[cidadeInicio, s] != 0)
                {
                    if (cidadeDestino == s)
                    {
                        Stack<String> cidade = new Stack<String>();
                        cidade.Push(cidadeInicio);

                        return cidade;
                    }
                        
                    Stack<String> caminho = MelhorCaminho(s, cidadeDestino);
                    if (caminho != null)
                    {
                        caminho.Push(cidadeInicio);
                        distanciasFilhos.Add(caminho);
                    }
                }

            if (distanciasFilhos.Count == 0)
                return null;

            Stack<String> menor = distanciasFilhos[0];
            int tamanhoMenor    = tamanhoPercurso(menor, cidadeDestino);

            foreach (Stack<String> percurso in distanciasFilhos)
            {
                int tamanhoPercurso = this.tamanhoPercurso(percurso, cidadeDestino);

                if (percurso.Count == 0 || tamanhoPercurso < tamanhoMenor)
                    menor = percurso;
            }

            return menor;
        }

        private int tamanhoPercurso(Stack<String> percurso, String fim)
        {
            Stack<String> percursoClone = new Stack<String>(percurso);

            int tamanho = 0;
            while (percursoClone.Count != 0)
                tamanho += this[percursoClone.Pop(), (percursoClone.Count != 0 ? percursoClone.Peek() : fim)];

            return tamanho;
        }
    }
}
