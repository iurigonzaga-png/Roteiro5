using System;
class Program
{
    static void Main()
    {
        Console.Write("Digite o seu CPF (pode conter pontos, traços ou espaços): ");
        string cpfOriginal = Console.ReadLine();
        string cpfLimpo = cpfOriginal.Trim().Replace(".", "").Replace("-", "").Replace(" ", "");
        if (cpfLimpo.Length == 11)
        {
            bool comecaComDigitoValido = false;
            for (int i = 0; i <= 9; i++)
            {
                if (cpfLimpo.StartsWith(i.ToString()))
                {
                    comecaComDigitoValido = true;
                    break;
                }
            }

            if (comecaComDigitoValido)
            {
                string parte1 = cpfLimpo.Substring(0, 3);
                string parte2 = cpfLimpo.Substring(3, 3);
                string parte3 = cpfLimpo.Substring(6, 3);
                string parte4 = cpfLimpo.Substring(9, 2);

                string cpfFormatado = $"{parte1}.{parte2}.{parte3}-{parte4}";

                Console.WriteLine($"\nCPF formatado: {cpfFormatado}");
            }
            else
            {
                Console.WriteLine("\nErro: O CPF não começa com um número válido.");
            }
        }
        else
        {
            Console.WriteLine("\nErro: O CPF deve conter exatamente 11 dígitos.");
        }
    }
}
