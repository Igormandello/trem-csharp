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
            percurso.Push(cidadeInicio);

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
                        cidade.Push(s);

                        return cidade;
                    }
                        
                    Stack<String> caminho = MelhorCaminho(s, cidadeDestino);
                    if (caminho.Count != 0)
                        distanciasFilhos.Add(caminho);
                }

            Stack<String> menor = new Stack<String>();
            foreach (Stack<String> percursos in distanciasFilhos)
                if (percursos.Count < menor.Count)
                    menor = percursos;

            return menor;
        }
    }
}
