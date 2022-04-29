public class primeNumbers
{
    public primeNumbers(String[] args) 
    {
    // TODO
    System.Console.WriteLine(isPrime(19));
    }

    static bool isPrime(int number)
    {
        for(int i = 2; i < number; i++)
    {
        if(number % i == 0)
        {
            return false;
        }
    }
    
    return true;
}
}