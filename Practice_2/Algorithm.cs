using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    class Algorithm
    {

        List<List<int>> input;

        public (int, int) GetSolution()
        {
            var filesIO = new IOFiles();
            input = filesIO.GetInputMatrix();

            var N = input[0][0];
            var M = input[0][1];

            int carrotsCollectedByRabbit = 0;
            int carrotsCollectedByHamsters = 0;

            while (!isMatrixEmpty())
            {
                RabbitTurn(ref carrotsCollectedByRabbit);
                HamsterTurn(ref carrotsCollectedByHamsters);
            }

            return (
                carrotsCollectedByHamsters,
                carrotsCollectedByRabbit);
        }

        private bool isMatrixEmpty()
        {
            int sum = 0;
            for (int i = 1; i < input.Count; i++)
            {
                for (int j = 0; j < input[i].Count; j++)
                {
                    sum += input[i][j];
                }
            }

            return sum == 0 ? true : false;
        }

        private void RabbitTurn(ref int rabbitCarrots)
        {
            int startIndex = 0;
            int endIndex = input[0][1] - 1;
            int maxValueIndex = 0;

            for (int i = 1; i < input.Count; i++)
            {
                int maxValue = 0;

                if (i > 1)
                {
                    startIndex = (maxValueIndex - 1) < 0 ? 0 : (maxValueIndex - 1);
                    endIndex = (maxValueIndex + 1) >= input[i].Count ? (input[i].Count - 1) : (maxValueIndex + 1);
                }

                for (int j = startIndex; j <= endIndex; j++)
                {
                    if (maxValue <= input[i][j])
                    {
                        maxValue = input[i][j];
                        maxValueIndex = j;
                    }
                }

                rabbitCarrots += input[i][maxValueIndex];
                input[i][maxValueIndex] = 0;

            }
        }

        private void HamsterTurn(ref int hamsterCarrots)
        {

            int startIndex = 0;
            int endIndex = input[0][1] - 1;
            int maxValueIndex = 0;

            for (int i = 1; i < input.Count; i++)
            {
                int maxValue = -1;

                if (i > 1)
                {
                    startIndex = (maxValueIndex - 1) < 0 ? 0 : (maxValueIndex - 1);
                    endIndex = (maxValueIndex + 1) >= input[i].Count ? (input[i].Count - 1) : (maxValueIndex + 1);
                }

                for (int j = endIndex; j >= startIndex; j--)
                {
                    if (maxValue <= input[i][j])
                    {
                        maxValue = input[i][j];
                        maxValueIndex = j;
                    }
                }

                hamsterCarrots += input[i][maxValueIndex];
                input[i][maxValueIndex] = 0;

            }
        }
    }
}
