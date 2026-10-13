using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Day17_EnumerableQueryable;

public static class ExpressionExamples
{
    public static void Run()
    {
        Console.WriteLine("==== Expression Tree ====");

        Expression<Func<int, bool>> expression =
            number => number > 10;

        Console.WriteLine($"Expression: {expression}");

        Func<int, bool> compiled = expression.Compile();

        Console.WriteLine($"5 > 10: {compiled(5)}");

        Console.WriteLine($"20 > 10: {compiled(20)}");
    }
}
