using System;
using System.Collections;
using System.Collections.Generic;

namespace BasicExercise60_Matrix
{
    class Program
    {
        // Write a C# program to calculate the sum of all the intgers of a rectangular matrix except those integers which are located below an intger of value 0.

        static int[][] sampleMatrixForQuestion = 
        { 
            new int[] {0,2,3,2},
            new int[] {0,6,0,1},
            new int[] {4,0,3,0}
        };

        static List<int> numbersForSum = new List<int>();
        static int answer;

        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            collectSelectValues(sampleMatrixForQuestion);
            calcSums(numbersForSum);
        }

        private static void collectSelectValues(int [][] matrix)
        {
            for(int x = 0; x<matrix.Length;x++)
            {
                for (int y = 0; y < matrix[x].Length; y++)
                {
                    if (x == 0)
                    {
                        if (y > 0)
                        {
                            numbersForSum.Add(matrix[x][y]);
                        }
                    }
                    if (x > 0)
                    {
                        if ((matrix[x][y] > 0)&&(matrix[x-1][y])> 0)
                        {
                            numbersForSum.Add(matrix[x][y]);
                        }
                    }
                }
            }
        }

        private static void calcSums(List<int>sum)
        {
            for (int i = 0; i < sum.Count; i++)
            {
                answer = answer + sum[i];

                /*if (i != numbersForSum.Count)
                {
                    answer = numbersForSum[i] + numbersForSum[i + 1];
                }*/
            }

            Console.WriteLine("The answer is: " + answer);
        }
    }
}
