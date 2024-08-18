using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // list to store pizza records
        List<Pizza> pizzas = new List<Pizza>();

        // Add some pizza records
        pizzas.Add(new Pizza("small", 1, 1, 0));
        pizzas.Add(new Pizza("medium", 2, 0, 1));
        pizzas.Add(new Pizza("large", 3, 2, 1));

        // Display the records
        foreach (Pizza pizza in pizzas)
        {
            Console.WriteLine(pizza.GetDescription());
        }
    }
}
