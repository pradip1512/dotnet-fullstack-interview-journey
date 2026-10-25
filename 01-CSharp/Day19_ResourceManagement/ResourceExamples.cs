using System;
using System.Collections.Generic;
using System.Text;

namespace Day19_ResourceManagement;

public sealed class DemoResource : IDisposable
{
    private bool _disposed;

    public void DoWork()
    {
        ObjectDisposedException.ThrowIf(_disposed, this);
        Console.WriteLine("Resource is working.");
    }

    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        _disposed = true;
        Console.WriteLine("Resource is disposed.");
    }
}
public static class ResourceExamples
{
    public static void Run()
    {
        Console.WriteLine("==== Using Statement ====");

        using (DemoResource resource = new())
        {
            resource.DoWork();
        }
        Console.WriteLine();

        Console.WriteLine("==== Using Declartion");

        using DemoResource anotherResource = new();
        anotherResource.DoWork();

        Console.WriteLine("The using-declaration resource is still in scope.");
    }
}
