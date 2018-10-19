using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevBuild.Assessment2_Question4
{ 
    class Program
    {
        public enum DiagonalDirection { Forwards, Backwards }

        static int[,] matrixArray = new int[4, 4] { {5, -4, 3, 0 } ,
                                                    {5, 1, -2, -1 },
                                                    {8, 6, -7, 4 },
                                                    {-2, 1,-5, 2 } };

        static void Main(string[] args)
        {
            PrintArray();
            Console.WriteLine($"Sum of the diagonal is {CalculateSumOfDiagonal()} . ");
            Console.WriteLine($"Sum of all values in the matrix is {CalculateSumOfAllValues()} . ");
            GetDiagonalIndices();
            Console.WriteLine($"The Determinant is {CalculateSumOfDiagonal(DiagonalDirection.Forwards) - CalculateSumOfDiagonal(DiagonalDirection.Backwards)} . ");
            while (true) ;
        }

        public static void PrintArray()
        {
            Console.WriteLine("");
            for (int i = 0; i < matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrixArray.GetLength(1); j++)
                {
                    Console.Write(matrixArray[i, j].ToString().PadLeft(2) + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        public static int CalculateSumOfAllValues()
        {
            int sumOfValues = 0;
            for (int i = 0; i < matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrixArray.GetLength(1); j++)
                {
                    sumOfValues += matrixArray[i,j];
                }
            }
            return sumOfValues;
        }

        public static int CalculateSumOfDiagonal()
        {
            int sumOfDiagonal = 0;
            if (matrixArray.GetLength(0) == matrixArray.GetLength(1))
            {
                //if these dimensions are equal, we know the matrix is square. Proceed with finding the sum of the diagonal
                //we can also use either dimenstion to loop through the array diagonal
                for (int i = 0; i < matrixArray.GetLength(0); i++)
                {
                    sumOfDiagonal += matrixArray[i, i];
                }

            }
            else { Console.WriteLine("Matrix not square, you're on your own. "); }
            return sumOfDiagonal;
        }

        public static int CalculateSumOfDiagonal(DiagonalDirection direction)
        {
            int sumOfDiagonal = 0;
            if (matrixArray.GetLength(0) == matrixArray.GetLength(1))
            {
                switch (direction)
                {
                    case DiagonalDirection.Forwards:
                        {
                            //if these dimensions are equal, we know the matrix is square. Proceed with finding the sum of the diagonal
                            //we can also use either dimenstion to loop through the array diagonal
                            for (int i = 0; i < matrixArray.GetLength(0); i++)
                            {
                                sumOfDiagonal += matrixArray[i, i];
                            }
                            break;
                        }
                    case DiagonalDirection.Backwards:
                        {
                            //if these dimensions are equal, we know the matrix is square. Proceed with finding the sum of the diagonal
                            //we can also use either dimenstion to loop through the array diagonal
                            for (int i = matrixArray.GetLength(0) - 1; i >= 0; i--)
                            { 
                                sumOfDiagonal += matrixArray[i, i];
                            }
                            break;
                        }
                }

            }
            else { Console.WriteLine("Matrix not square, you're on your own. "); }
            return sumOfDiagonal;
        }

        public static void GetDiagonalIndices()
        {
            List<string> indices = new List<string>();

            for (int i = 0; i < matrixArray.GetLength(0); i++)
            {
                for (int j = 0; j < matrixArray.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        indices.Add($"Value at diagonal position [{i},{j}] is {matrixArray[i,j]}");
                    }
                }
            }

            foreach (string s in indices)
            {
                Console.WriteLine(s);
            }
            return;
        }

        public static int CalculateDeterminant()
        {
            return 0;
        }
    }
}
