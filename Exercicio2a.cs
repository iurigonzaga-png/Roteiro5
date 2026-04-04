using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase com espaços sobrando no início e no fim, separando as palavras por vírgula.");
        string fraseOriginal = Console.ReadLine();
        string fraseLimpa = fraseOriginal.Trim();
        Console.WriteLine($"Frase limpa: '{fraseLimpa}'");
        string[] palavras = fraseLimpa.Split(',');
        Console.WriteLine("Frase dividida em palavras (Split()):");
        for (int i = 0; i < palavras.Length; i++)
        {
            Console.WriteLine($" Item {i + 1}: {palavras[i].Trim()}");
        }

        Console.WriteLine("\nQual palavra ou letra da frase você quer substituir?");
        string palavraAntiga = Console.ReadLine();

        Console.WriteLine($"Por qual palavra você quer trocar '{palavraAntiga}'?");
        string palavraNova = Console.ReadLine();

        string fraseNova= fraseLimpa.Replace(palavraAntiga, palavraNova);
        Console.WriteLine($"Frase após o Replace(): '{fraseNova}'");

        Console.WriteLine("\nQual palavra você quer verificar se a frase COMEÇA?");
        string palavraInicio = Console.ReadLine();
        bool comecaCom = fraseLimpa.StartsWith(palavraInicio);
        Console.WriteLine($"A frase começa com '{palavraInicio}'? {comecaCom}");

        Console.WriteLine("\nQual palavra você quer verificar se a frase TERMINA?");
        string palavraFim = Console.ReadLine();

     
        bool terminaCom = fraseLimpa.EndsWith(palavraFim);
        Console.WriteLine($"A frase termina com '{palavraFim}'? {terminaCom}");
    }
}
