using System;

namespace NewCours
{
    class Program
    {
        static void Main(string[] args)
        {

            //****************************************************Arithmetic mean of two numbers

            Console.WriteLine("Нахождение среднего арифметического\n");
           
            Console.WriteLine("Введите первое значение: ");
            string FirstValue = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Введите второе значение: ");
            string SecondValue = Console.ReadLine();
            Console.WriteLine();

            double a = Convert.ToDouble(FirstValue);
            double b = Convert.ToDouble(SecondValue);
            double result = (a + b) / 2;
            Console.WriteLine("Среднее арифметическое введенных значений = "+ result);
            Console.WriteLine("Для продолжения нажмите \"Enter\"\n");
            Console.ReadLine();
            Console.Clear();

            //****************************************************Sum and multiplication of numbers

            Console.WriteLine("Нахождение суммы и произведения значений\n");
            Console.WriteLine("Введите первое значение\n");
            string FirstNumberD = Console.ReadLine();
            Console.WriteLine();
           
            Console.WriteLine("Введите второе значение\n");
            string SecondNumberE = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Введите второе значение\n");
            string ThirdNumberF = Console.ReadLine();
            Console.WriteLine();
            double d = Convert.ToDouble(FirstNumberD);
            double e = Convert.ToDouble(SecondNumberE);
            double f = Convert.ToDouble(ThirdNumberF);
           
            double ResultSum = (d + e + f);
            double ResultMultiplication = (d * e * f);
            Console.WriteLine("Сумма введенных значений= " + ResultSum + "\n ");
            Console.WriteLine("Произведение введенных значений= " + ResultMultiplication + "\n ");
            Console.WriteLine("Для продолжения нажмите \"Enter\"\n");
            Console.ReadLine();
            Console.Clear();

            //**************************************************************** Currency Converter

            double UsdToRub = 2.31;
            Console.WriteLine("Конвертер валют: курс $/руб =2,31 \n");
            
            Console.WriteLine("Введите сумму в $");
            double SumUsd = double.Parse(Console.ReadLine());
           
            Console.WriteLine(SumUsd+"$ ="+(UsdToRub* SumUsd)+" руб.");
            Console.ReadLine();



        }
    }
}
