public class retailPrice{

double calculatedRetail;

int retail()
{
    double retailPrice;
    System.Console.WriteLine("This program calculates and displays the retail price of an item");
    retailPrice = calculatedRetail;
    System.Console.WriteLine("The retail price of the item is $" + retailPrice);
    return 0; 
}

double calculateRetail()
{
	double Cost,
		   Markup;

	do
	{
		System.Console.WriteLine("What is the item's wholesale cost? ");
		Cost = Convert.ToInt32(Console.ReadLine());

		if (Cost < 0)
		{
			System.Console.Write("Error! Wholesale cost must be a positive number.");
		}
	} while (!(Cost > 0));
	do
	{
		System.Console.WriteLine("What is the item's markup percentage? ");
		Markup = Convert.ToInt32(Console.ReadLine());
		if (Markup < 0)
		{
			System.Console.WriteLine("Error! The markup percentage must be a positive number.");	
		}
	} while (!(Markup > 0));

	Markup /= 100;
	return Cost * (1 + Markup);
}
}