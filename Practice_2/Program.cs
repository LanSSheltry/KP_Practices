using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("IPZ-41 Vladimir Aldokhin Lab 2");
            WriteLine("Menu:\n" +
                "1 - Print and open input file\n" +
                "2 - Print answer\n" +
                "3 - Print and open output file");
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

                    WriteLine(new Algorithm().GetSolution());
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
    }
}
