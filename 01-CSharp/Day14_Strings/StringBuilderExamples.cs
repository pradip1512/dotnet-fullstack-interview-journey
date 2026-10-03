using System;
using System.Collections.Generic;
using System.Text;


namespace Day14_Strings;

public static class StringBuilderExamples
{
    public static void Run()
    {
        StringBuilder builder = new();

        builder.AppendLine("====== WorkSphere Employee Report ======");

        builder.AppendLine("Employee: Pradip");

        builder.AppendLine("Department: IT");

        builder.AppendLine("Employee: Rahul");

        builder.AppendLine("Department: HR");

        Console.WriteLine(builder.ToString());
    }
}
