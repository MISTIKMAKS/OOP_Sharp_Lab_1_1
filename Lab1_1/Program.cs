using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0; // вхідний параметр
            double y = 0; // результат обчислення виразу
            double A = 0; // проміжний результат - функціонально стала частина виразу
            double B = 0; // проміжний результат - функціонально змінна частина виразу
            Console.Write("x = ");
            x = Convert.ToDouble(Console.ReadLine());
            A = (2 + x) / (x * x) + 1;
            // спосіб 1: розгалуження в скороченій формі
            if (x < 0){
                B = Math.Pow(x, 3) - 2 * Math.Pow(x, 4);
            }
            if (x <= 0 && x >= 2) {
                B = Math.Pow(Math.Abs(x) + Math.Exp(x), 3);
            }
            if (x > 2) {
                B = 4 * Math.Cos((x * x) - 2);
            }
            y = A + B;
            Console.WriteLine("");
            Console.WriteLine($"1) y = {Math.Round(y, 2)}");
            // спосіб 2: розгалуження в повній формі
            if (x < 0) {
                B = Math.Pow(x, 3) - 2 * Math.Pow(x, 4);
            }
            else if (x > 2) {
                B = 4 * Math.Cos((x * x) - 2);
            }
            else {
                B = Math.Pow(Math.Abs(x) + Math.Exp(x), 3);
            }
            y = A - B;
            Console.WriteLine($"2) y = {Math.Round(y, 2)}");
            Console.ReadKey();
        }
    }
}
