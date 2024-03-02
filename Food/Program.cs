using System;
using Food;
using static Food.Factories;

internal class Program
{
    private static void Main(string[] args)
    {

        var orderProcessor = new OrderProcessor();
        orderProcessor.ProcessOrder();

    }
}