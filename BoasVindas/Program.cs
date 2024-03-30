// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ola, qual é o seu nome?");

string nome = Console.ReadLine();

if (!string.IsNullOrEmpty(nome))
{
    Console.WriteLine($"Olá, {nome}! Seja bem-vindo!");
}
else
{
    Console.WriteLine($"Uma pena, você não digitou o seu nome, tente novamente!");
}

