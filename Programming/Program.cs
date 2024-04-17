

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Сonsole
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.OutputEncoding = Encoding.Unicode;

            int number1 = 0, number2 = 0, number3 = 0, number4 = 0, number5 = 0;
            int result_1 = 0, result_2 = 0, result_3 = 0, result_4 = 0, result_5 = 0;

            int Option1(int x, int y)// Number 1 Plus Number 2
            {
                int result1 = number1 + number2;
                return result1;
            }

            int Option2(int x, int y, int z)// Number 3 Minus Number 1 Plus Number 2
            {
                int result2 = number3 - number1 + number2;
                return result2;
            }

            int Option3(int x, int y) //Number 3 Multiplied By Number 2 Minus Number 3
            {
                int result3 = number3 * number2 - number3;
                return result3;
            }

            int Option4(int x, int y) //Number 1 Divided By Number 3 Minus Number 1
            {
                int result4 = number1 / number3 - number1;
                return result4;
            }

            int Option5(int x, int y, int z)//Number 3 Plus Number 3 Minus Number 2 Multiplied By Number 5 
            {
                int result5 = number3 + number3 - number2 * number5;
                return result5;
            }





            while (true)
            {
                int Choice = 0;

                Console.WriteLine("\nChoose you action:\n1.Number 1 Plus Number 2\n2.Number 3 Minus Number 1 Plus Number 2\n3.Number 3 Multiplied By Number 2 Minus Number 3\n4.Number 1 Divided By Number 3 Minus Number 1\n5.Number 3 Plus Number 3 Minus Number 2 Multiplied By Number 5\n6.Exit from program ");
                Choice = int.Parse(Console.ReadLine());

                if (Choice == 1)
                {
                    try
                    {
                        Console.Write("Enter number 1: ");
                        number1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter number 2: ");
                        number2 = int.Parse(Console.ReadLine());
                        result_1 = Option1(number1, number2);
                        Console.Write($"it will equal {result_1}\n");

                    }
                    catch
                    {
                        Console.Write("\nUuuuuups something going wrong! Try again!");
                        continue;
                    }
                }
                if (Choice == 2)
                {//Number 3 Minus Number 1 Plus Number 2
                    try
                    {
                        Console.Write("Enter number 3: ");
                        number3 = int.Parse(Console.ReadLine());
                        Console.Write("Enter number 1: ");
                        number1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter number 2: ");
                        number2 = int.Parse(Console.ReadLine());
                        result_2 = Option2(number3, number1, number2);
                        Console.Write($"it will equal {result_2}\n");

                    }
                    catch
                    {
                        Console.Write("\nUuuuuups something going wrong! Try again!");
                        continue;
                    }
                }

                if (Choice == 3)
                {
                    try
                    {
                        Console.Write("Enter number 3: ");
                        number3 = int.Parse(Console.ReadLine());
                        Console.Write("Enter number 2: ");
                        number2 = int.Parse(Console.ReadLine());
                        result_3 = Option3(number3, number2);
                        Console.Write($"it will equal {result_3}\n");

                    }
                    catch
                    {
                        Console.Write("\nUuuuuups something going wrong! Try again!");
                        continue;
                    }
                }

                if (Choice == 4)
                {
                    try
                    {
                        Console.Write("Enter number 1: ");
                        number1 = int.Parse(Console.ReadLine());
                        Console.Write("Enter number 3: ");
                        number3 = int.Parse(Console.ReadLine());
                        result_4 = Option4(number1, number3);
                        Console.Write($"it will equal {result_4}\n");

                    }
                    catch
                    {
                        Console.Write("\nUuuuuups something going wrong! Try again!");
                        continue;
                    }
                }

                if (Choice == 5)
                {//Number 3 Plus Number 3 Minus Number 2 Multiplied By Number 5 
                    try
                    {
                        Console.Write("Enter number 3: ");
                        number3 = int.Parse(Console.ReadLine());
                        Console.Write("Enter number 2: ");
                        number2 = int.Parse(Console.ReadLine());
                        Console.Write("Enter number 5: ");
                        number5 = int.Parse(Console.ReadLine());
                        result_5 = Option5(number3, number2, number5);
                        Console.Write($"it will equal {result_5}\n");

                    }
                    catch
                    {
                        Console.Write("\nUuuuuups something going wrong! Try again!");
                        continue;
                    }
                }

                if (Choice == 6)
                {
                    Console.Write("\nThank you for using our App for high level dificult calculations!\n");
                    Console.Write($"Results: \n{result_1} {result_2} {result_3} {result_4} {result_5} ");
                    break;
                }
            }

            int Q1 = 0, Q2 = 0, Q3 = 0, Q4 = 0, Q5 = 0, Q6 = 0, Q8 = 0;

            Console.Write("\nEnter number Q1: ");
            Q1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number Q2: ");
            Q2 = int.Parse(Console.ReadLine());
            Console.Write("Enter number Q3: ");
            Q3 = int.Parse(Console.ReadLine());
            Console.Write("Enter number Q4: ");
            Q4 = int.Parse(Console.ReadLine());
            Console.Write("Enter number Q5: ");
            Q5 = int.Parse(Console.ReadLine());
            Console.Write("Enter number Q6: ");
            Q6 = int.Parse(Console.ReadLine());
            Console.Write("Enter number Q8: ");
            Q8 = int.Parse(Console.ReadLine());

            Console.Write($"\nQ1 Multiplied by Q3 {Q3 * Q1}");
            Console.Write($"\nQ2 Divided by Q4 { Q2 * Q4}");
            Console.Write($"\nQ5 Plus Q1 Plus Number 2 {Q5 + Q1 + result_1}");
            Console.Write($"\nQ3 Minus Q6 Plus Number 1 Multiplied by Q4 { Q3 - Q6 + result_1 * Q4}");
            Console.Write($"\nQ3 Multiplied by Q2 Plus Q4 Plus Number 2 Minus Q6 Divided By Q8{ Q3* Q2 +Q4 + result_2 - Q6 / Q8}");
        }
    }
}