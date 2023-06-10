using System;

public class MyClass
{
    public int publicField;
    private int privateField;
    protected int protectedField;
    internal int internalField;
    protected internal int protectedInternalField;

    public void PublicMethod()
    {
        Console.WriteLine("Public method");
    }

    private void PrivateMethod()
    {
        Console.WriteLine("Private method");
    }

    protected void ProtectedMethod()
    {
        Console.WriteLine("Protected method");
    }

    internal void InternalMethod()
    {
        Console.WriteLine("Internal method");
    }

    protected internal void ProtectedInternalMethod()
    {
        Console.WriteLine("Protected Internal method");
    }
}

public class DerivedClass : MyClass
{
    public void AccessBaseClassMembers()
    {
        publicField = 1;                 // Accessible
        // privateField = 2;             // Not accessible (private)
        protectedField = 3;              // Accessible (inherited)
        internalField = 4;               // Accessible (inherited)
        protectedInternalField = 5;      // Accessible (inherited)

        PublicMethod();                  // Accessible
        // PrivateMethod();              // Not accessible (private)
        ProtectedMethod();               // Accessible (inherited)
        InternalMethod();                // Accessible (inherited)
        ProtectedInternalMethod();       // Accessible (inherited)
    }
}
