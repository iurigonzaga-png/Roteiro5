using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        Console.Write("Digite a data e hora do compromisso (Ex: 12/04/2025 15:00): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime dataCompromisso))
        { int diasFaltantes = (dataCompromisso.Date - DateTime.Today).Days;
            string diaDaSemana = dataCompromisso.ToString("dddd");
            string mensagem = string.Format(
                "\nOlá, {0}!\nSeu compromisso será em {1} dias, na {2}.\nData marcada: {3:dd/MM/yyyy} às {3:HH:mm}",
                nome, diasFaltantes, diaDaSemana, dataCompromisso
            );

            Console.WriteLine(mensagem);
        }
        else
        {
            Console.WriteLine("\n formato de data inválido. Tente novamente.");
        }
    }
}
