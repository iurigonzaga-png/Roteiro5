using System;
    class Program
{
    static void Main()
    {
        Console.WriteLine("informe seu capital inicial");
       string cinicial = Console.ReadLine();
        Console.WriteLine("informe o juros mensal");
       string jmensal = Console.ReadLine();
        Console.WriteLine("informe quantos meses ficara investido");
       string minv = Console.ReadLine();
        double capitalInicial = Convert.ToDouble(cinicial);
        double juros = Convert.ToDouble(jmensal);
        double meses = Convert.ToDouble(minv);

        double montante = capitalInicial * Math.Pow(1 + juros, meses);
        double lucro = montante - capitalInicial;
        double lucroArredondado = Math.Round(lucro, 2);

    } }
