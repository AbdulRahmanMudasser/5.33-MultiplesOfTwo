using System.Diagnostics.Metrics;

class MultiplesOfTwo
{
    static void Main(string[] args)
    {
        // declaring variables
        long number = 1;
        int counter = 0;

        while (counter != 40)
        {
            Console.Write((number *= 2) + " ");

            counter++;
        }
    }
}