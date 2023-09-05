using System.Globalization;//formata conformo a moeda definida no windows
char resp = 'S';
int opcao = 0;

while(resp == 'S')
{
    Console.Clear();
    Console.WriteLine("\t\t\t\t\t\t\t ***** Menu *****");//cada \t e um tab do teclado
    Console.WriteLine("1 - Criar uma Lista");
    Console.WriteLine("2 - Criar um Vetor");
    Console.WriteLine("3 - Criar uma Matriz");
    Console.WriteLine("4 - Formatar um valor monetario");
    Console.WriteLine("5 - Entrada de dados sem try...catch");
    Console.WriteLine("6 - Entrada de dados com try...catch");
    Console.WriteLine("7 - Entrada de dados com try...catch em looping");
    Console.Write("Entre com a sua opção: ");
    opcao = int.Parse(Console.ReadLine());
    switch(opcao) //switch e usado para testar
    {
        case 1:    
            CriarLista();
            break;
        case 2:
            CriarVetor();
            break;
        case 3:
            //CriarMatriz();
            break;
        case 4:
            FormatarDinheiro();
            break;
        case 5:
            Entresemtrycatch();
            break;
        case 6:
            Entrecomtrycatch();
            break;
        case 7:
            Entrecomtrycatchlooping();
            break;
        default:
            Console.WriteLine("Opção Inválida! Tente Novamente");
            break;
    }
    resp = verificaResp(resp); //metedo pode ou não retornar um valor para quem chamou ele
}

void CriarLista()
{
     //cria uma lista de números inteiros

     List<int> numeros = new List<int>();

    //Adicionar numero a lista
    numeros.Add(10);
    numeros.Add(5);
    numeros.Add(20);

    //exibe os numeros da lista
    Console.WriteLine("\n\n Numeros da Lista"); //o \n\n, pula uma linha
    foreach(int num in numeros)
    {
        Console.WriteLine(num);
    }

    Console.ReadKey();

    //remova um numero da lista
    numeros.Remove(5);

    //exibir os numeros atualizados da lista
    Console.WriteLine("\nNumero das lista atualizados");
    foreach(int num in numeros)
        {
        Console.WriteLine(num);
    }
    Console.ReadKey();
}

void CriarVetor()
{
    int tamanho = 5;
    int[] vetor = new int[ tamanho ];   

    Console.WriteLine("Digite" + tamanho + "Numeros");

    for(int i=0; i<tamanho; i++)
    {
        Console.Write("Numeros" + (i + 1) + "; ");
        vetor[i] = i;
    }

    Console.WriteLine("Numeros Digitados");
    for (int i=0; i<tamanho; i++)
    {
        Console.Write("\nNumeros" + (i + 1)+ ": " + vetor[i]);
    }

    Console.ReadKey();
}

void FormatarDinheiro()
{
    double valor1 = 0, valor2 = 0, soma = 0;
    Console.Write("\n Entre com um valor monetario: ");
    valor1 = double.Parse(Console.ReadLine());

    Console.Write("\n Entre com um valor monetario: ");
    valor2 = double.Parse(Console.ReadLine());

    soma = valor1 + valor2;

    Console.Write("\n Soma dos valores = "+soma.ToString("C2", CultureInfo.CurrentCulture));
    Console.ReadKey();
                               
}
