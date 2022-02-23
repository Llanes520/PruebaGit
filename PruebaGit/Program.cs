using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Algoritmo4();
        }

        static void Algoritmo4()
        {
            int num1, num2;

            List<int> list = new List<int>();

            Console.WriteLine("Ingrese dos numeros enteros");
            Console.WriteLine("El primero menor y el siguiente mayor: ");

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            for (int i = num1; i < num2; i++)
            {
                if (i == num1)
                {
                    i++;
                }
                num1++;
                list.Add(num1);
                Console.WriteLine(num1);
            }
        }
}
