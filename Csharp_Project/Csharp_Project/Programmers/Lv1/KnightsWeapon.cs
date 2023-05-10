using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project.Programmers.Lv1
{
    internal class KnightsWeapon
    {
        /* 기사단원의 무기
        https://school.programmers.co.kr/learn/courses/30/lessons/136798

        약수를 구하는 과정의 연산 수를 줄이는 것이 관건
        하나하나 약수의 갯수를 구하면 시간초과.
        약수가 자신의 배수에게 카운트하는 방식으로 변경.
        */

        public static void Main_KnightsWeapon(string[] args)
        {
            Console.WriteLine($"기댓값 : 10 / 결과 : {Solution(5, 3, 2)}");
            Console.WriteLine($"기댓값 : 21 / 결과 : {Solution(10, 3, 2)}");
        }

        /// <summary>
        /// 자신의 기사 번호의 약수 개수에 해당하는 공격력을 가진 무기를 구매
        /// 공격력 제한수치보다 큰 공격력을 가질 경우 power로 구매
        /// 모든 기사의 무기 공격력의 합을 구하시오.
        /// </summary>
        /// <param name="number"></param> 기사단원의 수
        /// <param name="limit"></param> 공격력 제한수치
        /// <param name="power"></param> 제한수치 초과 무기 공격력
        /// <returns></returns>
        public static int Solution(int number, int limit, int power)
        {
            int answer = 0;
            int[] counts = new int[number + 1];

            for(int i = 1; i <= number; i++)
            {
                int tempNum = i;

                while(tempNum <= number)
                {
                    counts[tempNum - 1]++;
                    tempNum += i;
                }
            }

            for(int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > limit)
                    answer += power;
                else
                    answer += counts[i];
            }

            return answer;
        }
    }
}
