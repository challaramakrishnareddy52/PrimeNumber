namespace PrimeNumber
{
    class Program
    {
        static bool isPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i < Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;

            return true;
        }
        static void Main()
        {
            if (isPrime(11))
                Console.Write("it is a prime number:");

            else
                Console.Write("it is not a prime number:");
        }
    }
}
