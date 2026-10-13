using System;
using System.Collections.Generic;
using System.Text;

namespace Day17_EnumerableQueryable;

public static class EnumeratorExamples
{
    public static void Run()
    {
        Console.WriteLine("==== Enumerator Examples: ====");

        List<int> numbers =
            [
                10, 20, 30
            ];
        
        using IEnumerator<int> enumerator = numbers.GetEnumerator();

        while (enumerator.MoveNext())
        {
            Console.WriteLine($"Current: {enumerator.Current}");
        }
    }
}
