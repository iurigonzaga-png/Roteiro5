using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Data do evento (Ex: 10/08/2026): ");
        DateTime.TryParse(Console.ReadLine(), out DateTime dataEvento);
        Console.Write("Valor do ingresso: ");
        double.TryParse(Console.ReadLine(), out double valorIngresso);
        Console.Write("Categoria (VIP ou Comum): ");
        string categoriaInput = Console.ReadLine();
        string categoria = categoriaInput.ToUpper();
        double valorFinal = valorIngresso;
        if (categoria.Contains("VIP"))
        { double valorComDesconto = valorIngresso * 0.85;
            valorFinal = Math.Round(valorComDesconto, 2);
        }
        int diasRestantes = (dataEvento.Date - DateTime.Today).Days;
        string ingressoFormatado = string.Format(
            "{0,-15} {1}\n{2,-15} {3:dd/MM/yyyy}\n{4,-15} {5}\n{6,-15} {7} dias\n{8,-15} {9:C}",
            "NOME: ", nome,
            "DATA: ", dataEvento,
            "CATEGORIA: ", categoria,
            "Faltam: ", diasRestantes,
            "VALOR: ", valorFinal);

        Console.WriteLine(ingressoFormatado);
    }
}
