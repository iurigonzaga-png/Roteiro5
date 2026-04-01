using System;
    class Program
{
    static void Main()
    {
        double[] numeros = new double[5];
        for (int i = 0; i < 5; i++) {
            Console.WriteLine($"digite o {i + 1}º numero decimal");
            string entrada = Console.ReadLine();
            numeros[i] = Convert.ToDouble(entrada);
        }

        foreach (double numero in numeros)
        {
            Console.WriteLine($"> Numero original: {numero}");
            Console.WriteLine($"Arredondamento padrão: {Math.Round(numero)}");
            Console.WriteLine($"Arredondamento para baixo: {Math.Floor(numero)}");
            Console.WriteLine($"Arredondamento para cima: {Math.Ceiling(numero)}");
            Console.WriteLine($"Truncamento: {Math.Truncate(numero)}");

        }
    } }
