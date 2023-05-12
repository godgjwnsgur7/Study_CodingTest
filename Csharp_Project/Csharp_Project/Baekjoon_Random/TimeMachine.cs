using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 타임머신
/// https://www.acmicpc.net/problem/1440
/// </summary>

namespace Csharp_Project.Baekjoon_Random
{
    internal class TimeMachine
    {
        public static void Main_TimeMachine(string[] args)
        {
            string[] s = Console.ReadLine().Split(':');

            int[] times = new int[3] { int.Parse(s[0]), int.Parse(s[1]), int.Parse(s[2]) };

            Console.WriteLine(Solution(times));
        }

        public static int Solution(int[] times)
        {
            int count = 0;

            for (int h = 0; h < times.Length; h++)
            {
                for (int m = 0; m < times.Length; m++)
                {
                    for (int s = 0; s < times.Length; s++)
                    {
                        if (h != m && m != s && s != h) // 서로 다른 인덱스인지?
                        {
                            if (1 <= times[h] && times[h] <= 12 &&
                               0 <= times[m] && times[m] <= 59 &&
                               0 <= times[s] && times[s] <= 59)
                                count += 1;
                        }
                    }
                }
            }

            return count;
        }
    }
}