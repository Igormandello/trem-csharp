using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trens
{
    //Enumerador de tipos de buscas possíveis
    enum ParametrosDeBusca { Preco, Tempo, Distancia };

    //Estrutura para guardar as informações entre o caminho de duas cidades,
    //ja que não é nescessário guardar o nome dessas duas cidades
    struct Dados
    {
        public Dados(int distancia, int velocidade, int preco)
        {
            this.distancia = distancia;
            this.tempo = (float)distancia / velocidade;
            this.preco = preco;
        }

        private int distancia, preco;
        private float tempo;

        public int Distancia
        {
            get { return distancia; }
        }

        public float Tempo
        {
            get { return tempo; }
        }

        public int Preco
        {
            get { return preco; }
        }
    }

    class GrafoCaminhos
    {
        private Dictionary<String, int> cidadeVet;
        private Dados[,] grafo;

        public Dados this[String y, String x]
        {
            get { return grafo[cidadeVet[y], cidadeVet[x]]; }
        }

        public GrafoCaminhos(List<Caminho> caminhos, List<String> cidades)
        {
            grafo     = new Dados[cidades.Count, cidades.Count];
            cidadeVet = new Dictionary<String, int>();

            for (int i = 0; i < cidades.Count; i++)
                cidadeVet.Add(cidades[i], i);

            foreach (Caminho c in caminhos)
            {
                int c1 = cidadeVet[c.Cidades[0]],
                    c2 = cidadeVet[c.Cidades[1]];
                grafo[c1, c2] = new Dados(c.Distancia, c.VelocidadeMedia, c.Preco);
                grafo[c2, c1] = new Dados(c.Distancia, c.VelocidadeMedia, c.Preco);
            }
        }

        public Stack<String> AcharCaminho(String cidadeInicio, String cidadeDestino, ParametrosDeBusca param)
        {
            Stack<String> percurso = MelhorCaminho(cidadeInicio, cidadeDestino, new List<String>(), param);

            return percurso;
        }

        private Stack<String> MelhorCaminho(String objetivo, String atual, List<String> visitados, ParametrosDeBusca param)
        {
            List<Stack<String>> distanciasFilhos = new List<Stack<String>>();

            //Para ele não ficar passando pela mesma cidade de que veio infinitamente
            visitados.Add(atual);

            List<String> vizinhas = Vizinhas(atual);
            foreach (String s in vizinhas)
                if (!visitados.Contains(s))
                {
                    //Se chegou na cidade que estava procurando, retorna o caminho com a cidade atual
                    if (objetivo == s)
                    {
                        Stack<String> cidade = new Stack<String>();
                        cidade.Push(objetivo);
                        cidade.Push(atual);

                        distanciasFilhos.Add(cidade);
                    }
                        
                    //Se ainda não é o objetivo, pergunta para essa cidade vizinha o melhor caminho até o destino
                    Stack<String> caminho = MelhorCaminho(objetivo, s, new List<String>(visitados), param);

                    //Se há algum caminho, coloca esse caminho entre a lista de possíveis caminhos
                    if (caminho != null)
                    {
                        caminho.Push(atual);
                        distanciasFilhos.Add(caminho);
                    }
                }

            //Se não há nenhum caminho até o destino, retorna nulo
            if (distanciasFilhos.Count == 0)
                return null;

            //Coloca o primeiro percurso como o menor
            Stack<String> menor = distanciasFilhos[0];

            float valorMenor;
            if (param == ParametrosDeBusca.Distancia)
                valorMenor = TamanhoPercurso(menor, atual);
            else if (param == ParametrosDeBusca.Preco)
                valorMenor = PrecoPercurso(menor, atual);
            else
                valorMenor = TempoPercurso(menor, atual);

            //Compara entre os possíveis percursos o menor deles, utilizando como critério o parametro passado
            foreach (Stack<String> percurso in distanciasFilhos)
            {
                float valorTrajeto;
                if (param == ParametrosDeBusca.Distancia)
                    valorTrajeto = TamanhoPercurso(percurso, atual);
                else if (param == ParametrosDeBusca.Preco)
                    valorTrajeto = PrecoPercurso(percurso, atual);
                else
                    valorTrajeto = TempoPercurso(percurso, atual);

                if (percurso.Count == 0 || valorTrajeto < valorMenor)
                    menor = percurso;
            }

            return menor;
        }

        private List<String> Vizinhas(String cidade)
        {
            List<String> ret = new List<String>();
            foreach (String s in cidadeVet.Keys)
                if (!this[cidade, s].Equals(default(Dados)))
                    ret.Add(s);

            return ret;
        }

        private int TamanhoPercurso(Stack<String> percurso, String fim)
        {
            Stack<String> percursoClone = new Stack<String>(percurso);

            int tamanho = 0;
            while (percursoClone.Count != 0)
                tamanho += this[percursoClone.Pop(), (percursoClone.Count != 0 ? percursoClone.Peek() : fim)].Distancia;

            return tamanho;
        }

        private int PrecoPercurso(Stack<String> percurso, String fim)
        {
            Stack<String> percursoClone = new Stack<String>(percurso);

            int preco = 0;
            while (percursoClone.Count != 0)
                preco += this[percursoClone.Pop(), (percursoClone.Count != 0 ? percursoClone.Peek() : fim)].Preco;

            return preco;
        }

        private float TempoPercurso(Stack<String> percurso, String fim)
        {
            Stack<String> percursoClone = new Stack<String>(percurso);

            float tempo = 0;
            while (percursoClone.Count != 0)
                tempo += this[percursoClone.Pop(), (percursoClone.Count != 0 ? percursoClone.Peek() : fim)].Tempo;

            return tempo;
        }
    }
}
