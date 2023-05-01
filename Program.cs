/************ Qestão de prov ************
1) Observe o trecho de código abaixo:

int INDICE = 13, SOMA = 0, K = 0;
enquanto K < INDICE faça
{
    K = K + 1;
    SOMA = SOMA + K;
}
imprimir(SOMA);
Ao final do processamento, qual será o valor da variável SOMA?

2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.
IMPORTANTE:
Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;


3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
• O menor valor de faturamento ocorrido em um dia do mês;
• O maior valor de faturamento ocorrido em um dia do mês;
• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.
IMPORTANTE:
a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;

4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
SP – R$67.836,43
RJ – R$36.678,66
MG – R$29.229,88
ES – R$27.165,48
Outros – R$19.849,53
Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.
 
5) Escreva um programa que inverta os caracteres de um string.
IMPORTANTE:
a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
b) Evite usar funções prontas, como, por exemplo, reverse;
NÃO SE ESQUEÇA DE INSERIR O LINK DO SEU REPOSITÓRIO NO GITHUB COM O CÓDIGO FONTE QUE VOCÊ DESENVOLVEU
***/

/********************************* respostas 1
Console.WriteLine("Questão 1 do teste:");
int indice = 13, soma = 0, k = 0;
while (k < indice)
{
    k = k + 1;
    soma = soma + k;
    Console.WriteLine($"k:{k}, soma: {soma}");
    
}

Console.Write(soma);
Console.WriteLine("Fim da questão 1 do teste:");

    1 , 1
    2 , 3
    3 , 6
    4 , 10
    5 , 15
    6 , 21
    7 , 28
    8 , 36
    9 , 45
    11 , 56
    12 , 68
    13 , 81
    soma: 81
resposta 1 *********************************/

/********************************* respostas 2
Console.Write("Entre com 1 numero ");
int escolha = int.Parse(Console.ReadLine());
int numeroAnterior = 0;
int numeroAtual = 1;
int fibonacci = 0;

if (escolha > 0)
{
    while (fibonacci < escolha)
    {
        fibonacci = numeroAnterior + numeroAtual;
        numeroAnterior = numeroAtual;
        numeroAtual = fibonacci;
    }

    if (fibonacci == escolha)
        Console.WriteLine($"numero anterior a sequencia fibonacci {numeroAnterior}");
    else
        Console.WriteLine($"numero {escolha} não pertence a sequencia fibonacci");
}
else
{
    Console.WriteLine($"numero {escolha} não pertence a sequencia fibonacci");
}
resposta 2 * ********************************/

/********************************* respostas 3
long quantidade;
double maiorFatura, menorFatura, valorMedia;
string dataMaior, dataMenor;
quantidade = 0;
maiorFatura = 0.0;
menorFatura = 9999999999999.9;
valorMedi = 0.0;
foreach (var faturas in listaFaturas)
{
    if ( (Convert.ToDateTime(faturas.data).DayOfWeek != DayOfWeek.Saturday) && (Convert.ToDateTime(faturas.data).DayOfWeek != DayOfWeek.Sunday) )
    {
        //para cada dia pode existir N faturas, percorrendo o faturamento diario
        foreach (var faturaDiaria in listaFaturas.Faturamento)
        {
            if (faturaDiaria.consumo > maiorFatura)
            {
                maiorFatura = faturaDiaria.valor;
                dataMaior = faturas.data.toString("dd/MM/yyyy");
            }

            if (faturaDiaria.consumo < menorFatura)
            {
                menorFatura = faturaDiaria.valor;
                dataMenor = faturas.data.toString("dd/MM/yyyy");
            }

            //calculo de media
            valorMedia += fatura.valor;
            quantidade++;
        }
    }
}

//calculo de media
valorMedia = valorMedia / quantidade;

Console.WriteLine($"Maior consumo - Data: {dataMaior}, Consumo: {maiorFatura}");
Console.WriteLine($"Menor consumo - Data: {dataMenor}, Consumo: {menorFatura}");
Console.WriteLine($"Dias em que o valor de consumo foi superior a media de consumo.  Media: {valorMedia}");

foreach (var faturas in listaFaturas)
{
    if ((Convert.ToDateTime(faturas.data).DayOfWeek != DayOfWeek.Saturday) && (Convert.ToDateTime(faturas.data).DayOfWeek != DayOfWeek.Sunday))
    {
        //para cada dia pode existir N faturas, percorrendo o faturamento diario
        foreach (var faturaDiaria in listaFaturas.Faturamento)
        {
            if (faturaDiaria.consumo > valorMedia)
            {
                Console.WriteLine($"Data: {fatura.data.toString("dd/MM/yyyy")} - Consumo: {faturaDiaria.consumo}");
            }
        }
    }
}
Console.ReadKey();
resposta 3 * ********************************/

/********************************* respostas 4
Console.WriteLine("Questão 4 do teste:");

var SP = 67838.43;
var RJ = 36678.66;
var MG = 29229.88;
var ES = 27165.48;
var outros = 19849.53;

var total = SP + RJ + MG + ES + outros;

var percentSP = (SP * 100) / total;
var percentRJ = (RJ * 100) / total;
var percentMG = (MG * 100) / total;
var percentES = (ES * 100) / total;
var percentOutros = (outros * 100) / total;

Console.WriteLine($"{percentSP.ToString("N2")}%");
Console.WriteLine($"{percentRJ.ToString("N2")}%");
Console.WriteLine($"{percentMG.ToString("N2")}%");
Console.WriteLine($"{percentES.ToString("N2")}%");
Console.WriteLine($"{percentOutros.ToString("N2")}%");

Console.WriteLine("Fim da questão 4 do teste:");

Console.ReadKey();
resposta 4 * ********************************/

/********************************* respostas 5
string str2 = "uma cadeia de caracter";
StringBuilder sb = new StringBuilder();

for (int i = str2.Length - 1; i >= 0; i--)
{
    sb.Append(str2[i]);
}

Console.WriteLine($"{str2}");
Console.WriteLine($"{sb.ToString()}");
Console.ReadKey();
resposta 5 * ********************************/
