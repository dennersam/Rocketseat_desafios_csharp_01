using Usuario.Model;

var usuario = new Pessoa();

do
{
    Console.WriteLine("Olá, qual o seu primeiro nome?");
    usuario.Nome = Console.ReadLine();
    if (string.IsNullOrEmpty(usuario.Nome))
    {
        Console.WriteLine("Parece que vc não digitou nenhum valor, vamos tentar denovo?");
        
    }
} while (string.IsNullOrEmpty(usuario.Nome));

do
{
    Console.WriteLine("Olá, qual o seu segundo nome?");
    usuario.SobreNome = Console.ReadLine();
    if (string.IsNullOrEmpty(usuario.SobreNome))
    {
        Console.WriteLine("Parece que vc não digitou nenhum valor, vamos tentar denovo?");

    }
} while (string.IsNullOrEmpty(usuario.SobreNome));


Console.WriteLine($"Seu nome completo é {usuario}");

