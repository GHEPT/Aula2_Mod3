using System;
using System.Linq;

// EX1. Algoritmo para calcular fatorial de um número informado pelo usuário.

//Console.Write("Digite um número para descobrir o fatorial (!): ");
//int num = Convert.ToInt32(Console.ReadLine());
//int fatorial = 1;

//Console.Clear();

//for (int i = 1; i <= num; i++)
//{
//    fatorial *= i;
//    Console.WriteLine(fatorial);
//}

//Console.WriteLine($"O fatorial de {num} é {fatorial}.");




// EX2. Algoritmo para encontrar o maior valor de uma lista de números com tamanho e valores definidos por usuário.

//Console.Write("Digite um número de valores para uma lista: ");
//int quant = Convert.ToInt32(Console.ReadLine());
//int[] values = new int[quant];

//for (int i = 0; i < quant; i++) // meu for inicia em zero (i) e enquanto for menor que o número digitado ele vai executar.
// Depois que executar ele acrescenta 1 ao for e fazer de novo.
//{
//    Console.WriteLine($"Adicione o {i + 1}º número à lista: "); // Se quero gerar repetições de interações eu faço um for.
//    values[i] = Convert.ToInt32(Console.ReadLine()); // O primeiro (1º) valor perguntado ao usuário é o values[0] e assim sucessivamente.
//}

//int n = values.Max(); // variável n recebe o maior valor da lista.
//Console.WriteLine($"O maior valor digitado foi o {n}."); // Aqui mostramos o valor
//Console.WriteLine("[{0}]", string.Join(", ", values));



// EX3. Algoritmo para definir um array de números com tamanho e valores definidos pelo usuário e apresentá-lo em tela ordenado de forma crescente.

//Console.WriteLine("Quantos valores você deseja adicionar ao array? ");
//int quant = Convert.ToInt32(Console.ReadLine());
//int[] values = new int[quant];

//for (int i = 0; i < quant; i++)
//{
//    Console.WriteLine($"Adicione o {i + 1}º valor: ");
//    values[i] = Convert.ToInt32(Console.ReadLine());
//}

//Array.Sort(values);
//Console.WriteLine("{0} [{1}]","Esta é a lista ordenada:", string.Join(", ", values));




//4. Altere o algoritmo anterior para que os números sejam inseridos no array aleatoriamente:

//Console.WriteLine("Quantos valores você deseja adicionar ao array? ");
//int quant = Convert.ToInt32(Console.ReadLine());
//int[] values = new int[quant];
//Random rnd = new Random();

//for (int i = 0; i < quant; i++)
//{
//    int aleat = rnd.Next(1, 99);
//    Console.WriteLine($"{i + 1}º valor: {aleat}");
//    values[i] = aleat;
//}

//Array.Sort(values);
//Console.WriteLine("{0} [{1}]","Esta é a lista ordenada:", string.Join(", ", values));



// SalaDeAula

Console.Write("Informe o nome da turma: ");
string nome = Console.ReadLine();
Console.Write("Informe o tamanho da turma: ");
int tamanho = Convert.ToInt32(Console.ReadLine());
int[] turma = new int[1];
Console.WriteLine($"Turma {nome}, máximo de {tamanho} alunos, foi criada com sucesso!");

// PROFESSOR, MINHA SEMANA TÁ MUITO CORRIDA, SÓ AGORA NO FINAL DE SEMANA QUE CONSEGUI REVISAR SO CONTEÚDOS
// PARA ASSIMILAR. NÃO CONSEGUI TEMPO PARA FAZER OS CODELABS AVANÇADOS. DESCULPE. 