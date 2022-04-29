
public class showCharacter
{    
	public static void showChar(String[] args)
	{
		System.Console.WriteLine("Give me a city");
		string str = Console.ReadLine();
		
		System.Console.WriteLine("Now give me a position");
		int num = Convert.ToInt32(Console.ReadLine());
	}

    public static void showChar(String place, int index) 
	{
		System.Console.WriteLine("The character at position " + index + " of the string " + place + " is " + place[2]);
        
	}
}