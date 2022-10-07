using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Math;

namespace Practice_1
{
    static class Combinatorics
    {
        public static string[] GetPermutationAnswers(string[] Input) //Calculate all input values and return all answers
        {
            string[] answers = new string[Input.Length];
            for (int i = 0; i < Input.Length; i++)
            {
                string[] InputNums = Input[i].Split(' ');

                uint n = Convert.ToUInt32(InputNums[0]);
                uint k = Convert.ToUInt32(InputNums[1]);

                if (InputNums.Length > 2)
                    return new string[] { "Input error", "" };

                if (n < 1 || n > 9 || k < 0 || k > n)
                    return new string[] { "Input error", "" };

                answers[i] = GetPermutationsAmount(n, k).ToString();
            }
            return answers;
        }

        private static uint GetPermutationsAmount(uint n, uint m) //Get current answer
        {
            if (n - m == 1) 
                return 0;

            return dnm(n, m);
        }

        static uint dnm(uint n, uint m) //Dnm statistics formula
        {
            return cnm(n, m) * an(n - m);
        }

        static uint an(uint n) //An statistics forumla
        {
            uint a = 0, b = 1;
            for (uint i = 2; i < n; i++)
                if (i % 2 != 0)
                    b = i * (a + b);
                else
                    a = i * (a + b);
            return n % 2 != 0 ? a : b;
        }

        static uint cnm(uint n, uint m) //Cnm statistics formula
        {
            uint k = n - m;
            if (m > k)
                m = k;
            if (m == 0)
                return 1;
            uint akk = k = n - m + 1;
            k++;
            for (uint i = 2; i <= m; i++, k++)
                akk = akk / i * k + akk % i * k / i;
            return akk;
        }
    }
}
