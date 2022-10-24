using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boubleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 300, 1, 60, 94, 61219, 41, 16, 7 };

            int temporaryNumber = 0;

            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 0; j < number.Length - 1; j++)
                {
                    if (number[j] > number[j + 1])
                    {
                        temporaryNumber = number[j + 1];
                        number[j + 1] = number[j];
                        number[j] = temporaryNumber;
                    }
                }
            }
            Console.WriteLine("Lista po posortowaniu:");
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write($"{number[i]} {" "}");
            }

            Console.ReadKey();
        }
    }
}
