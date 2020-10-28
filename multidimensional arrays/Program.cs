using System;
using System.Linq;

namespace multidimensional_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a number matrix");
            Console.Write("Insert number of columns:");
            int col = int.Parse(Console.ReadLine());
            Console.Write("Insert number of rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert now your number matrix. Just separate the numbers with a comma and a space");

            int[,] array = new int[rows, col];

            string[] lines = new string[rows];


            for (int i = 0; i < rows; i++)
            {
                lines[i] = Console.ReadLine();
            }

            for (int i = 0; i < rows; i++)
            {
                string[] num = lines[i].Split(", ");
                for (int j = 0; j < col; j++)
                {
                    int z = Convert.ToInt32(num[j]);
                    array[i, j] = z;
                }
            }
            
            Console.WriteLine();
            Console.WriteLine("To confirm, the matrix you inserted is the following:");
            
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < col; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();

            //count of rows and columns
            int rowNumber = array.GetLength(0);
            int colNumber = array.GetLength(1);

            //sum of all values
            int sum = array.Cast<int>().Sum();

            Console.WriteLine("The number of rows in this array is: " + rowNumber);
            Console.WriteLine("The number of columns in this array is: " + colNumber);
            Console.WriteLine("The sum of all elements in this array is: " + sum);

            Console.ReadLine();
        }
    }
}
