using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 5; // записать в первый элемент массива 5
            numbers[1] = 2;
            numbers[4] = 3;
            //numbers[5] = 2; // ошибка, индекс вне границ массива
            Console.WriteLine(numbers[0]); // вывести первый элемент массива
            Console.ReadKey();
        }
    }
}