using OperacaoMatematica.Model;

Console.WriteLine("Vamos realizar algumas operações matemáticas!");

double Numero1 = 0;
double Numero2 = 0;

string input;

do
{
    Console.Write("Digite o primeiro numero: ");
    input = Console.ReadLine();
    if(string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Parece que vc não digitou nenhum valor, vamos tentar denovo?");
    }
    else
    {
        Numero1 = Double.Parse(input);
    }
} while (string.IsNullOrEmpty(input));

input = null;

do
{
    Console.Write("Digite o segundo numero: ");
    input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Parece que vc não digitou nenhum valor, vamos tentar denovo?");
    }
    else
    {
        Numero2 = Double.Parse(input);
    }
} while (string.IsNullOrEmpty(input));

Calculo calc = new Calculo();

var soma = calc.Soma(Numero1, Numero2);

var subtracao = calc.Subtracao(Numero1, Numero2);

var multiplicacao = calc.Multiplicacao(Numero1, Numero2);

var divisao = calc.Divisao(Numero1, Numero2);

var media = calc.Media(Numero1, Numero2);

Console.WriteLine($"\tSoma: {soma}");
Console.WriteLine($"\tSubtracao: {subtracao}");
Console.WriteLine($"\tMultiplicacao: {multiplicacao}");
Console.WriteLine($"\tDivisao: {divisao}");
Console.WriteLine($"\tMédia: {media}");