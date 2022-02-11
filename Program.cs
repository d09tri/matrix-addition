using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max;
            Matrix mt1 = new Matrix();
            Matrix mt2 = new Matrix();

            Console.WriteLine("Step 1. Range value for matrix");
            Console.Write("Min value to create random matrix: ");
            min = int.Parse(Console.ReadLine());
            Console.Write("Max value to create random matrix: ");
            max = int.Parse(Console.ReadLine());

            Console.WriteLine("\nStep 2. Init and display two matrix");
            Console.WriteLine("=====         Matrix 1         =====");

            mt1.CreatRandomMatrix(min, max);
            mt1.PrintMatrix();

            Console.WriteLine("=====         Matrix 2         =====");
            mt2.CreatRandomMatrix(min, max);
            mt2.PrintMatrix();

            Console.WriteLine("Step 3. Add two matrix");
            Matrix mt3 = new Matrix();

            mt3.AddTwoMatrix(mt1, mt2);
            mt3.PrintMatrix();

            Console.ReadLine();
        }
    }
}
