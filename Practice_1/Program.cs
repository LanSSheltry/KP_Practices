using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace Practice_1
{
    class Program
    {

        public delegate void UI(string OutputText);

        static void Main(string[] args)
        {
            string task = FilesIO.GetTaskText(); //Task text

            //Task output

            WriteLine("Practice no.1\tVariant 67\nVolodymyr Aldokhin\nIPZ-41\n\n");
            WriteLine(task);

            string[] answer = Combinatorics.GetPermutationAnswers(
                    FilesIO.GetAllLinesFromInput());

            FilesIO.WriteFormattedOutput(answer);

            ReadKey();
        }
    }
}
