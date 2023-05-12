using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project.Programmers.Lv2
{
    internal class ConvertingNumbers
    {
        /* 숫자 변환하기
        https://school.programmers.co.kr/learn/courses/30/lessons/154538
        자연수 x를 y로 변환하려고 합니다. 사용할 수 있는 연산은 다음과 같습니다.
        x에 n을 더합니다, x에 2를 곱합니다, x에 3을 곱합니다.
        자연수 x, y, n이 매개변수로 주어질 때, x를 y로 변환하기 위해 필요한 최소 연산 횟수를 return하도록 solution 함수를 완성해주세요.
        이때 x를 y로 만들 수 없다면 -1을 return 해주세요

        제한사항
        1 ≤ x ≤ y ≤ 1,000,000
        1 ≤ n < y
        */

        public static void Main_ConvertingNumbers(string[] args)
        {
            Console.WriteLine($"기댓값 : 2  / 결과 : {Solution(10, 40, 5)}");
            Console.WriteLine($"기댓값 : 1  / 결과 : {Solution(10, 40, 30)}");
            Console.WriteLine($"기댓값 : -1 / 결과 : {Solution(2, 5, 4)}");
        }

        // 풀이시도1. 세 가지 연산 중에 목표 값과 가장 가까워지는 수를 찾아 연산하는 방식을 채택
        // -> 가장 가까워진다고 해서 빠르게 도달할 수 있는 것이 아님

        // 풀이시도2. (힌트. HashSet)
        // 모든 경우의 수를 찾아야 하므로 2개의 자료구조를 사용하는 방식 채택
        // - 중복된 값이 있을 경우 같은 연산이 되므로 HashSet을 사용하여 중복 방지
        // -> currSet(값 체크) <-> nextSet(연산하여 저장)

        public static int Solution(int x, int y, int n)
        {
            int answer = 0;

            if (x == y)
                return 0;

            HashSet<int> currSet, nextSet;
            currSet = new HashSet<int>();

            currSet.Add(x);

            while(currSet.Count != 0)
            {
                if (currSet.Contains(y))
                    return answer;

                nextSet = new HashSet<int>();
                
                foreach (int set in currSet)
                {
                    int case1 = set + n;
                    int case2 = set * 2;
                    int case3 = set * 3;

                    if (case1 <= y) nextSet.Add(case1);
                    if (case2 <= y) nextSet.Add(case2);
                    if (case3 <= y) nextSet.Add(case3);
                }
                
                currSet = nextSet;
                answer++;
            }

            return -1;
        }
    }
}
