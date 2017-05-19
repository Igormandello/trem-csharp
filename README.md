# CAMINHOS ENTRE CIDADES
A RENFE - Rede Nacional Ferroviária de Espanha - deseja fornecer aos seus usuários um
aplicativo que permita verificar os caminhos entre cidades, através de viagens de trem.
Para tanto, um arquivo texto contendo nomes de cidades, distância entre elas, velocidade média
dos trens e preço da passagem é fornecido.
Esse arquivo se chama GrafoTremEspanhaPortugal.txt e deve ser complementado com as
cidades e ligações que faltam, tomando o mapa abaixo como fonte de informação e consultas ao
Google Maps para conhecer as distâncias e tempos de percurso. Pesquise também quanto custa
a passagem entre uma cidade e outra, no trem mais rápido.
Deseja-se que seja possível executar as operações abaixo:
1. Incluir novas cidades e suas ligações com outras cidades, além da distância, velocidade
média e preço da passagem de cada ligação.
2. Encontrar um roteiro entre uma cidade A e uma cidade B, fornecendo a distância total, o
tempo estimado de percurso e o valor total a ser pago em passagens
3. Relacionar o máximo de quatro caminhos entre as cidades A e B mais vantajosos. O
critério de vantagem pode ser menor tempo gasto, menor distância percorrida ou menor
valor total a ser pago.

#
![Mapa Espanha-Portugal](https://github.com/Igormandello/trem-csharp/blob/master/Recursos/mapaEspanhaPortugal.jpg?raw=true)

Para realizar as operações, deve-se criar uma matriz de adjacências, representando o grafo
(como o apresentado no mapa acima) com as cidades e seus dados de ligações. Em seguida,
deve-se usar o método de backtracking e pilhas para encontrar as possíveis soluções.