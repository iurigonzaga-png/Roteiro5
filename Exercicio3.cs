using System;
class Program
{
    static void Main()
    {
        string[] nomes = { "Magic Plate Armor", "Boots of Haste (BoH)", "Demon Shield" };
        double[] precos = { 250.00, 45.50, 120.90 };
        int[] quantidades = { 1, 2, 1 };
        Console.WriteLine($"{"ITENS",-25} | {"PREÇO (F2)",10} | {"QTD (N0)",8} | {"TOTAL (C)",15}");

        double subtotal = 0;
        for (int i = 0; i < 3; i++)
        {
            double totalItem = precos[i] * quantidades[i];
            subtotal += totalItem;
            Console.WriteLine($"{nomes[i],-25} | {precos[i],10:F2} | {quantidades[i],8:N0} | {totalItem,15:C}");
        }

        double percentualDesconto = 0.10;
        double valorDesconto = subtotal * percentualDesconto;
        double totalFinal = subtotal - valorDesconto;

        Console.WriteLine($"{"Subtotal:",-49} {subtotal,15:C}");
        Console.WriteLine($"{"Desconto:(" + percentualDesconto.ToString("P0") + "):",-49} {-valorDesconto,15:C}");
        Console.WriteLine($"{"Total:",-49} {totalFinal,15:C}");
    } 
}
