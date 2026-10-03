using System;
using System.Collections.Generic;
using System.Text;

namespace Day13_Generics;

public class Box<T>
{
    public T Value { get; set; }

    public Box(T value)
    {
        Value = value;
    }

    public void Display()
    {
        Console.WriteLine($"Value: {Value}");

        Console.WriteLine($"Type: {typeof(T)}");
    }
}

public static class GenericHelper
{
    public static void Display<T>(T value)
    {
        Console.WriteLine($"Value: {value}");
        Console.WriteLine($"Type: {typeof(T)}");
    } 

    public static T GetFirst<T>(T first, T second)
    {
        return first;
    }
}
