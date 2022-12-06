using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Practice_3
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

    }
}
