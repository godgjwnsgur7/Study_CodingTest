using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project.Programmers.Lv1
{
    internal class TheRestOne
    {
        /* 나머지가 1이 되는 수 찾기
        https://school.programmers.co.kr/learn/courses/30/lessons/87389 
        */

        public static void Main_TheRestOne(string[] args)
        {
            Console.WriteLine($"기댓값 : 3 / 결과 : {Solution(10)}");
            Console.WriteLine($"기댓값 : 11 / 결과 : {Solution(12)}");
        }

        public static int Solution(int n)
        {
            int answer = 0;

            for (int i = 1; i < n; i++)
                if (n % i == 1)
                {
                    answer = i;
                    break;
                }

            return answer;
        }
    }
}
