using System;

class Program
{
    static void Main()
    {
        // create an instance of MathOperations.
        MathOperations mathOps = new MathOperations();

        // call PerformOperation method with parameters.
        mathOps.PerformOperation(5, 20);

        // call PerformOperation method with named parameters.
        mathOps.PerformOperation(number1: 7, number2: 30);

        // keep console window open to review output.
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

