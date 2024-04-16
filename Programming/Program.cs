

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
            double TF = 0;
            double COnst = 0.55555;
            Console.WriteLine("Программа переводу Фаренгейтів в Градуси Цельсію");
            Console.WriteLine("введіть будь ласка значення в Фаренгейтах, котре Ви хочете конвертувати в Градуси Цельсію");
            string Fahrenheit = Console.ReadLine();
            TF = Convert.ToDouble(Fahrenheit);
            Console.WriteLine(TF - 32);
            Console.WriteLine("Результат: " + TF * COnst + "градусів Цельсію");
        }
    }
}