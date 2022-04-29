public class temperatureTable{
public static void temperature(String[] Strings) {

        System.Console.WriteLine("Input a degree in Fahrenheit: ");
        double fahrenheit = Convert.ToInt32(Console.ReadLine());

        double  celsius =(( 5 *(fahrenheit - 32.0)) / 9.0);
        System.Console.WriteLine(fahrenheit + " degree Fahrenheit is equal to " + celsius + " in Celsius");
    }
}
