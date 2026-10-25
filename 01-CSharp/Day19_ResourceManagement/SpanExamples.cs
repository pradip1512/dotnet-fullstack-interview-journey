using System;
using System.Collections.Generic;
using System.Text;


namespace Day19_ResourceManagement;

public static class SpanExamples
{
    public static void Run()
    {
        Console.WriteLine("\n==== Span Example ====");
        int[] scores = [10, 20, 30, 40, 50];

        Span<int> selectedScores = scores.AsSpan(1, 3);

        Console.WriteLine("Original array:");
        Console.WriteLine(string.Join(", ", scores));

        selectedScores[0] = 99;

        Console.WriteLine("After modifying the span:");
        Console.WriteLine(string.Join(", ", scores));

        ReadOnlySpan<int> readOnlyScores = scores.AsSpan(0, 2);

        Console.WriteLine($"First score: {readOnlyScores[0]}");
        Console.WriteLine($"Second score: {readOnlyScores[1]}");
    }
}

