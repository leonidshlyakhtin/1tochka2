using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение радиуса: ");
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine("Длина окружности = {0}", 2 * Math.PI * R);
            Console.WriteLine("Площадь круга = {0}", Math.PI * Math.Pow(R, 2));
            Console.ReadKey();
        }
    }
}
