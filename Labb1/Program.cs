using System;

namespace Labb1
{
    class MainClass
    {
        private static void Calculate(Func <double> method, Calculator calculator)
        {
            Console.WriteLine("Insert first number:");
            calculator.FirstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert second number:");
            calculator.SecondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"{method()}");
            Console.ReadKey();
        }

        private static void AddNumberToMemory(Calculator calculator)
        {
            Console.WriteLine("Insert number");
            calculator.NumberInMemory = int.Parse(Console.ReadLine());
            Console.WriteLine("Number successfully added to memory");
        }

        private static Calculator ClearNumberInMemory()
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Number in memory cleared");
            return calculator;
        }

        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            while (true)
            {
                Console.WriteLine("1. Add two numbers\n2. Multiply two numbers\n3." +
                    " Sum the numbers between two numbers\n4. Add number to memory\n5. " +
                    "Clear memory\n6. Print calculator contents\n7. Quit");             

                int menuInput = int.Parse(Console.ReadLine());

                switch (menuInput)
                {
                    case 1:
                        Calculate(calculator.SumNumbers, calculator);                
                        break;
                    case 2:
                        Calculate(calculator.MuliplyNumbers, calculator);
                        break;
                    case 3:
                        Calculate(calculator.SumInBetween, calculator);
                        break;
                    case 4:
                        AddNumberToMemory(calculator);
                        break;
                    case 5:
                        calculator = ClearNumberInMemory();
                        break;
                    case 6:
                        Console.WriteLine(calculator);
                        break;
                    case 7:
                        Console.WriteLine("Goodbye");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Must be a number between 1-7");
                        break;
                }
            } 
        }
    }
}
