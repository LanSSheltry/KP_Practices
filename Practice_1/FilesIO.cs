using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice_1
{
    static class FilesIO
    {

        private const string InputFilePath = "Input.txt";

        private const string OutputFilePath = "Output.txt";

        private const string TaskFilePath = "Task.txt";

        private static string[] Input { get; set; }

        public static string[] GetAllLinesFromInput() //Return all lines from input file separately
        {
            Input = File.ReadAllLines(InputFilePath);
            return Input;
        }

        public static string GetTaskText() //Return text from task
        {
            return File.ReadAllText(TaskFilePath);
        }

        public static void RegisterDelegates()
        {

        }

        public static void WriteFormattedOutput(string[] answers) //Write answers into output file and call delegate to print answer into console
        {
            File.Delete(OutputFilePath);
            string outputText="No.\tInput\tOutput\n";
            for (int i = 0; i < Input.Length; i++)
            {
                outputText += $"{i + 1}\t{Input[i]}\t{answers[i]}\n";
            }
            Console.WriteLine(outputText); //Im too lazy to create a delegate)))
            File.AppendAllText(OutputFilePath, outputText);
        }
    }
}
