using System;

namespace NewCours
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arithmetic mean of two numbers

            Console.WriteLine("Введите первое значение\n");
            string FirstNumber = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Введите второе значение\n");
            string SecondNumber = Console.ReadLine();
            Console.WriteLine();

            double a = Convert.ToDouble(FirstNumber);
            double b = Convert.ToDouble(SecondNumber);
            double result = (a + b) / 2;
            Console.WriteLine("Среднее арифметическое " + a + " и " + b + " = " + result);

        }
    }
}
