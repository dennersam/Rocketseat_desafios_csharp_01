// See https://aka.ms/new-console-template for more information
Console.WriteLine("Olá, digite algo...");

var texto = Console.ReadLine();

int count = 0;

for (int i = 0; i < texto.Length; i++)
{
    if (texto[i] != ' ')
    {
        count++;
    }
}

Console.WriteLine($"Seu texto tem {count} letras.");
