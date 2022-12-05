using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice_2
{
    class IOFiles
    {

        private const string InputFileName = "Input.txt";
        private const string OutputFileName = "Output.txt";

        private List<List<int>> parsedData { get; set; }

        public List<List<int>> GetInputMatrix() //Change format according to task
        {
            if (!File.Exists(InputFileName)) return null;
            var text = File.ReadAllLines(InputFileName);
            parsedData = new List<List<int>>();

            for (int i = 0; i < text.Length; i++)
            {
                List<string> tmp = text[i].Split(' ').ToList();
                parsedData.Add(new List<int>());

                for (int j = 0; j < tmp.Count; j++)
                {
                    parsedData[i].Add(Convert.ToInt32(tmp[j]));
                }
            }

            return parsedData;
        }

        public void WriteToOutputFile(string text) //Write formatting
        {
            if (!File.Exists(OutputFileName))
                File.Create(OutputFileName);

            File.WriteAllText(OutputFileName, text);
            System.Diagnostics.Process.Start(OutputFileName);
        }
    }
}
