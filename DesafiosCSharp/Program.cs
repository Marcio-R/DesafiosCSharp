//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Digite sua idade");
//int idade = int.Parse(Console.ReadLine());

//if (idade <= 59)
//{
//    Console.WriteLine("Você ainda não tem direito do cartão idoso");
//    int anosFaltantes =  60 - idade;
//    int diasFaltantes = anosFaltantes * 365;
//    Console.WriteLine($"Faltam ainda {anosFaltantes} anos para tirar seu cartão");
//    Console.WriteLine($"Faltam ainda {diasFaltantes} dias aproximadamente para tirar seu cartão");
//    idade++;
//    int umAnoMaisVelho = idade;
//    diasFaltantes = (60 - umAnoMaisVelho) * 365;
//    Console.WriteLine($"Faltam ainda {diasFaltantes} dias aproximadamente para tirar seu cartão se tivesse um ano a mais");
//}
//else
//{
//    Console.WriteLine("Você tem direito de cartão idoso!");
//}

string nomeJogador;
Console.WriteLine("Bem vindo ao jogo!");

ExemploForech();
ExemploWhile();

//Console.WriteLine("Qual o nome jogador?");
//nomeJogador = Console.ReadLine().ToString();

//bool validacaoJogador;

//switch (nomeJogador)
//{
//    case "Marcio":
//    case "Ronaldo":
//    case "Alysson":
//    case "Douglas":
//    case "Rogerio":
//    case "Arthur":
//    case "Simone":
//        Console.WriteLine("Jogador autorizado para o torneio de poker");
//        validacaoJogador = true;
//        break;
//    default:
//        Console.WriteLine("Jogador não autorizado para o torneio de poker");
//        validacaoJogador = false;
//        break;
//}

//if (validacaoJogador)
//{
//    Console.WriteLine("Digite o numero de vitorias: ");
//    int quantidadeVitorias = int.Parse(Console.ReadLine());
//    int pontuacaoAtual = Vireficacao(quantidadeVitorias);
//    Console.WriteLine($"Você possui {pontuacaoAtual} pontos no torneio");
//    int pontuacaonova = BonificarParticipacao(pontuacaoAtual);
//    Console.WriteLine($"Parabéns, você ganhou 1 ponto de bônus. Agora sua pontuação é {(pontuacaonova)}");
//}

// metodo de verificação da pontuação do jogador
int Vireficacao(int vitorias)
{
    const int fator = 3;

    int potuacao = fator * vitorias;

    return potuacao;
}
//metodo de bonificação de participação
int BonificarParticipacao(int pontuacaoatual)
{
    pontuacaoatual++;
    var pontosBonus = pontuacaoatual;
    return pontosBonus;
}

void ExemploForech()
{
    List<string> jogadore = new List<string>();

    jogadore.Add("Marcio");
    jogadore.Add("Ronaldo");
    jogadore.Add("Alysson");
    jogadore.Add("Douglas");
    jogadore.Add("Rogerio");
    jogadore.Add("Arthur");
    jogadore.Add("Simone");

    foreach (var item in jogadore)
    {
        Console.WriteLine($"Sejam bem vindo jogador {item}");
    }
   
}

void ExemploWhile()
{
    Console.WriteLine("Qual a sua pontuação atual? ");
    int pontuacaoJogador = int.Parse(Console.ReadLine());
    if(pontuacaoJogador < 27)
    {
        while (pontuacaoJogador < 27)
        {
            Console.WriteLine("Jogando");
            Console.WriteLine("Você ganhou (S/N)");
            string ganhou = Console.ReadLine();
            if (ganhou == "S")
            {
                pontuacaoJogador += 3;
            }
            else
            {
                Console.WriteLine("Infelizmente você está fora do torneio");
                break;
            }
        }
    }
    else
    {
        Console.WriteLine("Você ja esta nas 4º");
    }
   
}