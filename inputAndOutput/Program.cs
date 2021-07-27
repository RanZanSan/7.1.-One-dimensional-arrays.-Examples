using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inputAndOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()); // сколько чисел будут вводиться на следующей строке
            string s = Console.ReadLine(); // сохранить всю введенную строку
            string[] ss = s.Split(' '); // разделить введенную строку по пробелам и сохранить в массив строкового типа
        }
    }
}