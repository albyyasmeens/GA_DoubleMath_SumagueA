static void Main(string[] args)
{
    Console.WriteLine("\n--- Understanding double ---");
}
            double myDouble = 123.456;
            Console.WriteLine($"Value of myDouble: {myDouble}");
    {
        Console.WriteLine("Exploring C# Double and Floating-Point Operations");
        double sum = 3.5 + 4.7; // Addition
        Console.WriteLine($"3.5 + 4.7={sum}");
        double difference = 3.5 - 4.7; // Subtraction
        Console.WriteLine($"3.5 - 4.7={difference}");
        double product = 3.5 * 4.7; // Multiplication
        Console.WriteLine($"3.5 * 4.7={product}");
        double quotient = 3.5 / 4.7; // Division
        Console.WriteLine($"3.5 / 4.7={quotient}");
    }
        Console.WriteLine("\n--- Math Operations with int and double ---");
            int wholeNumber = 12;
            double floatingNumber = 6;
            double mixedSum = wholeNumber + floatingNumber; 
            Console.WriteLine($"12 + 6 = {mixedSum}");

 Console.WriteLine("\n--- Complex Floating-Point Operations ---");
    double complexOperation = 3.5 + 4.7 * 2.2 / 0.5;
    Console.WriteLine($"3.5 + 4.7 * 2.2 / 0.5 = {complexOperation}");

Console.WriteLine("\n--- Handling Floating-Point Precision ---");
double a = 0.3;
double b = 0.6;
double preciseSum = a + b;
Console.WriteLine($"0.3 + 0.6 = {preciseSum}");
