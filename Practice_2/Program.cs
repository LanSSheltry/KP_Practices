using System;

using static System.Console;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("IPZ-41 Vladimir Aldokhin Lab 2");
            WriteLine("Menu:\n" +
                "1 - Print input data\n" +
                "2 - Open input file\n" +
                "3 - Print answer to console\n" +
                "4 - Print to console and output file");
            while (true)
            {
                WriteLine("Enter the variant: ");
                var variant = ReadLine();
                if (Int32.TryParse(variant, out int b))
                {
                    Menu(b);
                    b = 0;
                }
            }
        }

        static void Menu(int variant)
        {
            switch (variant)
            {
                case 1:
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
                    WriteLine(text);
                    break;
                case 2:
                    System.Diagnostics.Process.Start("Input.txt");
                    break;
                case 3:
                    var a = new Algorithm().GetSolution();
                    WriteLine($"Hamsters: {a.Item1}\nRabbits: {a.Item2}");
                    break;
                case 4:
                    var b = new Algorithm().GetSolution();
                    WriteLine($"Hamsters: {b.Item1}\nRabbits: {b.Item2}");
                    new IOFiles().WriteToOutputFile($"{b.Item2} {b.Item1}");
                    break;
            }
        }
    }
}
