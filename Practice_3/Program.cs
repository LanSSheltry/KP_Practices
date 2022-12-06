using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("IPZ-41 Aldokhin Volodymyr Practice 3");
            var matrix = new IOFiles().GetInputMatrix();
            string text = "";
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    text += " " + matrix[i][j];
                }
                text += "\n";
            }
            WriteLine($"Input matrix: \n" + text);

            foreach (string answer in GetAnswer(matrix))
            {
                WriteLine(answer);
            }
            ReadKey();

        }

        static List<string> GetAnswer(List<List<int>> input)
        {
            List<List<List<int>>> inputMatrices = new List<List<List<int>>>();

            List<int> comps = new List<int>();
            List<int> msgs = new List<int>();

            List<List<int>> matrix1 = new List<List<int>>();

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i].Count == 2)
                {
                    comps.Add(input[i][0]);
                    msgs.Add(input[i][1]);
                    List<List<int>> cache = new List<List<int>>();
                    cache = matrix1;
                    if (cache.Count > 0)
                        inputMatrices.Add(cache);
                    matrix1 = new List<List<int>>();
                    continue;
                }

                List<int> row = new List<int>();

                for (int j = 1; j < input[i].Count; j++)
                {
                    row.Add(input[i][j]);
                }
                matrix1.Add(row);
                if (i == input.Count - 1) inputMatrices.Add(matrix1);
            }

            List<string> matricesResult = new List<string>();

            for (int i = 0; i < inputMatrices.Count; i++)
            {
                matricesResult.Add(checkLog(inputMatrices[i], msgs[i]));
            }

            return matricesResult;
        }

        private static string checkLog(List<List<int>> matrix, int msg)
        {
            int col1 = 0;
            int col2 = 1;
            while (!isEmpty(matrix))
            {
                for (int i = 0; i < matrix.Count; i++)
                {
                    for (int j = 0; j < matrix.Count; j++)
                    {
                        if (matrix[i].Count > col1 && matrix[j].Count > col2)
                        {
                            if (Math.Abs(matrix[i][col1]) == Math.Abs(matrix[j][col2])
                                && matrix[i][col1] != 0)
                            {
                                if (matrix[i][col1] < 0)
                                    return "NO";
                                matrix[i][col1] = 0;
                                matrix[j][col2] = 0;
                                break;
                            }
                        }
                    }
                }
                col1 = col2;
                col2++;
            }

            return "YES";

        }

        private static bool isEmpty(List<List<int>> matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    sum += Math.Abs(matrix[i][j]);
                }
            }

            if (sum > 0) return false;
            else return true;
        }
    }
}
