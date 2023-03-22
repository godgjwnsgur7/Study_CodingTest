using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project.Programmers.Lv2
{
    internal class LongJump
    {
        /* 멀리 뛰기
        효진이는 멀리 뛰기를 연습하고 있습니다. 효진이는 한번에 1칸, 또는 2칸을 뛸 수 있습니다. 
        칸이 총 4개 있을 때, 효진이는
        (1칸, 1칸, 1칸, 1칸)
        (1칸, 2칸, 1칸)
        (1칸, 1칸, 2칸)
        (2칸, 1칸, 1칸)
        (2칸, 2칸)
        의 5가지 방법으로 맨 끝 칸에 도달할 수 있습니다. '
        멀리뛰기에 사용될 칸의 수 n이 주어질 때, 효진이가 끝에 도달하는 방법이 몇 가지인지 알아내, 
        여기에 1234567를 나눈 나머지를 리턴하는 함수, solution을 완성하세요.
        예를 들어 4가 입력된다면, 5를 return하면 됩니다.

        제한 사항
        n은 1 이상, 2000 이하인 정수입니다.
        */

        public static void Main(string[] args)
        {
            Console.WriteLine($"기댓값 : 1 / 결과 : {Solution(1)}");
            Console.WriteLine($"기댓값 : 1 / 결과 : {Solution(2)}");
            Console.WriteLine($"기댓값 : 3 / 결과 : {Solution(3)}");
            Console.WriteLine($"기댓값 : 5 / 결과 : {Solution(4)}");

        }

        // Memo
        // F(n) = F(n-1) + F(n-2) 가 된다는 걸 유추할 수 있다면 정답
        // 피보나치 수

        public static long Solution(int n)
        {
            // 제한조건 : F(1)부터 시작 가능
            int count = 1;
            int tempNum;

            // F(1)에서의 F(n-2), F(n-1) 값 세팅하고 시작
            int firstNum = 1; // F(0) = F(n-2)
            int secondNum = 1; // F(1) = F(n-1)

            while(count < n)
            {
                tempNum = (firstNum + secondNum) % 1234567;
                firstNum = secondNum;
                secondNum = tempNum;

                count++;
            }

            long answer = secondNum;
            return answer;
        }
    }
}
