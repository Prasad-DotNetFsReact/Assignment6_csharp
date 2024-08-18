using System;

public class Pizza
{
    // Private instance variables
    private string pizzaSize;
    private int cheeseToppings;
    private int pepperoniToppings;
    private int hamToppings;

    // Constructor that sets all instance variables
    public Pizza(string size, int cheese, int pepperoni, int ham)
    {
        pizzaSize = size;
        cheeseToppings = cheese;
        pepperoniToppings = pepperoni;
        hamToppings = ham;
    }

    public string PizzaSize
    {
        get { return pizzaSize; }
        set { pizzaSize = value; }
    }

    public int CheeseToppings
    {
        get { return cheeseToppings; }
        set { cheeseToppings = value; }
    }

    public int PepperoniToppings
    {
        get { return pepperoniToppings; }
        set { pepperoniToppings = value; }
    }

    public int HamToppings
    {
        get { return hamToppings; }
        set { hamToppings = value; }
    }

    // Method to calculate the cost of the pizza
    public double CalcCost()
    {
        double baseCost = 0;

        switch (pizzaSize.ToLower())
        {
            case "small":
                baseCost = 10;
                break;
            case "medium":
                baseCost = 12;
                break;
            case "large":
                baseCost = 14;
                break;
            default:
                throw new ArgumentException("Invalid pizza size");
        }

        // Calculate total cost
        double totalCost = baseCost + 2 * (cheeseToppings + pepperoniToppings + hamToppings);
        return totalCost;
    }

    // Method to get the description of the pizza
    public string GetDescription()
    {
        return $"Size: {pizzaSize}, Cheese Toppings: {cheeseToppings}, Pepperoni Toppings: {pepperoniToppings}, Ham Toppings: {hamToppings}, Cost: ${CalcCost()}";
    }
}



