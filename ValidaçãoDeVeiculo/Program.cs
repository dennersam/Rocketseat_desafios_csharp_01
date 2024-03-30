// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Olá, bem vindo ao validador de placa!");
Console.Write("Digite a placa sem traço: ");
var placa = Console.ReadLine();

if(placa.Length == 7)
{
    var letras = placa.Substring(0, 3);

    var numeros = placa.Substring(3, 4);

    Console.WriteLine($"Os tres primeiros digitos são {letras}");
    Console.WriteLine($"Os quatro ultimos digitos são {numeros}");

    var validarLetras = false;
    var validarNumeros = false;

    if(Regex.IsMatch(letras, $@"^[a-z]*$") )
    {
        validarLetras = true;
    }

    if(Regex.IsMatch(numeros, $@"^[0-9]*$"))
    {
        validarNumeros = true;
    }

    if(validarLetras && validarNumeros)
    {
        Console.WriteLine("A placa foi validada com sucesso!");
    }
    else
    {
        Console.WriteLine("Placa inválida!");
    }
}
else
{
    Console.WriteLine("É obrigatório ter 7 digitos, tente novamente.");
}


         