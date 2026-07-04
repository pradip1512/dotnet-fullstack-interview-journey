public class Program
{
    static void Main()
    {
        Console.WriteLine("Numbers from 1 to 100: ");
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Print only even numbers: ");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("Print only odd numbers: ");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }


}
