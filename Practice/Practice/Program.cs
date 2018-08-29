using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //One();
            //Two();
            //Three();
            Four();

        }

        public static void One()
        {
            Console.Write("give me a letter. ");
            string letter = Console.ReadLine();
            if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u") Console.WriteLine($"{letter} is a vowel.");
            else Console.WriteLine($"{letter} is a consonant.");
            Console.WriteLine("your welcome");
            Console.ReadKey();
        }

        public static void Two()
        {
            Console.Write("what is your weight in Kg? ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("what is your height in Meters? ");
            double height = double.Parse(Console.ReadLine());
            double bmi = weight / (height * height);
            Console.WriteLine($"your BMI is {bmi: 0.00}");
            Console.WriteLine("your welcome");
            Console.ReadKey();
        }

        public static void Three()
        {
            double sum = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.Write("give me a number. ");
                double input = double.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine($"the sum of 20 numbers are {sum}");
            Console.WriteLine("your welcome");
            Console.ReadKey();
        }

        public static void Four()
        {
            Console.Write("give me a number. ");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= number; i++) factorial *= i;
            Console.WriteLine($"the factorial of {number} is {factorial}");
            Console.WriteLine("your welcome");
            Console.ReadKey();
        }

}
