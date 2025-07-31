using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problem15
{
    internal class SparseMatrixCompression
    {
        public static void Run()
        {
            //4x4 
            int[,] matrix = new int[,]
            {
                {0,0,1,0},
                {0,5,0,0},
                {0,0,0,0},
                {0,0,0,7}
            };
            int rowCont = matrix.GetLength(0);
            int colCont = matrix.GetLength(1);
       
                Console.WriteLine("Matrix:\n");
                printMatrix(matrix);
            // The algorith works for not square matrix
                Dictionary<(int, int), int> compressed = compressMatrix(matrix);
                Console.WriteLine("\nMatrix after compressed to Dichionary:\n");
                foreach (var row in compressed)
                {
                    Console.Write($"{row} ");
                }

          
                Console.WriteLine("\n\nDichionary after decompressed:\n");
                int[,] decompressed = decompressDictionary(compressed, rowCont, colCont);
                printMatrix(decompressed);
            }

            

            static Dictionary<(int, int), int> compressMatrix(int[,] array)
            {
                Dictionary<(int, int), int> result = new Dictionary<(int, int), int>();
                int rowCount = array.GetLength(0);
                int columnCount = array.GetLength(1);
                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        if (array[i, j] != 0)
                            result[(i, j)] = array[i, j];
                    }
                }
                return result;
            }//end of function

            static int[,] decompressDictionary(Dictionary<(int, int), int> Compress, int row, int column)
            {
                int[,] decompressed = new int[row, column];

                foreach (var record in Compress)
                {
                    var (i, j) = record.Key;
                    decompressed[i, j] = record.Value;
                }
                return decompressed;

            }//end of function
            static void printMatrix(int[,] arr)
            {
                int rowCount = arr.GetLength(0);
                int columnCount = arr.GetLength(1);


                for (int i = 0; i < rowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        Console.Write($"{arr[i, j]} ");
                    }
                    Console.WriteLine("\n");
                }
            }
        }
    }

