# .NET Action Callback Demo

This is a simple .NET demo showing how to use `Action` delegates as callback functions in C#.

## 💡 What It Shows

- How to define a method that accepts an `Action` as a parameter
- How to pass a callback function using `Action`

## 📄 Example

```csharp
using System;

class Program
{
    static void Main()
    {
        RunWithCallback(() => Console.WriteLine("Callback executed!"));
    }

    static void RunWithCallback(Action callback)
    {
        Console.WriteLine("Doing some work...");
        callback?.Invoke();
    }
}
