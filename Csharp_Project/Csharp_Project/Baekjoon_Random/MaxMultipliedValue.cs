using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 최대 곱
/// https://www.acmicpc.net/problem/1500
/// </summary>

namespace Csharp_Project.Baekjoon_Random
{
    internal class MaxMultipliedValue
    {
        public static void Main_MaxMultipliedValue(string[] args)
        {
            string[] s = Console.ReadLine().Split();

            Console.WriteLine(Solution(int.Parse(s[0]), int.Parse(s[1])));
        }

        public static long Solution(int addValue, int count)
        {
            long maxMult = 1;

            List<int> list = new List<int>();

            int divide = addValue / count;
            int theRast = addValue % count;
            
            for(int i = 0; i < count; i++)
                list.Add(divide);

            for (int i = 0; i < theRast; i++)
                list[i] += 1;

            for(int i = 0; i < list.Count; i++)
            {
                maxMult *= list[i];
            }

            return maxMult;
        }
    }
}
