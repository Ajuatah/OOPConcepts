using System;

public class constructor
{
    public int Value { get; set; }

    // Default Constructor
    public constructor()
    {
        Value = 0;
    }

    // Parameterized Constructor
    public constructor(int value)
    {
        Value = value;
    }

    // Copy Constructor
    public constructor(constructor other)
    {
        Value = other.Value;
    }

    // Static Constructor
    static constructor()
    {
        Console.WriteLine("Static constructor called");
    }

    // Private Constructor
    private constructor(string message)
    {
        Console.WriteLine(message);
    }
}