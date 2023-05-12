using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project.Programmers.Lv2
{
    internal class FibonacciNumber
    {
        /* 피보나치 수
         피보나치 수는 F(0) = 0, F(1) = 1일 때, 1 이상의 n에 대하여 F(n) = F(n-1) + F(n-2) 가 적용되는 수 입니다.

        예를들어
        F(2) = F(0) + F(1) = 0 + 1 = 1
        F(3) = F(1) + F(2) = 1 + 1 = 2
        F(4) = F(2) + F(3) = 1 + 2 = 3
        F(5) = F(3) + F(4) = 2 + 3 = 5
        와 같이 이어집니다.

        2 이상의 n이 입력되었을 때, n번째 피보나치 수를 1234567으로 나눈 나머지를 리턴하는 함수, solution을 완성해 주세요.

        제한 사항
        n은 2 이상 100,000 이하인 자연수입니다.
        */
        
        public static void Main_FibonacciNumber(string[] args)
        {
            Console.WriteLine($"기댓값 : 2 / 결과 : {Solution(3)}");
            Console.WriteLine($"기댓값 : 5 / 결과 : {Solution(5)}");
        }

        // 풀이시도 1 - 내용 참조
        // 로직 상의 문제는 없었지만,
        // int로 표현 가능한 범위를 넘어가는 상황에 대해 고려하지 않았었다.

        // Memo
        // Queue를 사용해서 불필요한 삭제, 추가를 발생시키는 것이 아니라
        // List, 등의 다른 자료형을 이용해서 인덱스를 통해 할당된 범위 내에서 연산을 했다면,
        // 더 좋은 코드가 될 수 있었을지도 모르겠다는 생각이 듦

        public static int Solution(int n)
        {
            int count = 2; // 2부터 시작
            Queue<int> q = new Queue<int>();

            int first, second;

            // 초기 값을 넣어놓는다.
            q.Enqueue(0);
            q.Enqueue(1);

            while (count != n)
            {
                // F(n-2), F(n-1)
                first = q.Dequeue();
                second = q.Dequeue();

                // int의 범위를 벗어나지 않게 예외처리
                second %= 1234567;

                // F(n-1), F(n)
                q.Enqueue(second);
                q.Enqueue(first + second);

                count++;
            }

            // F(n-2), F(n-1)
            first = q.Dequeue();
            second = q.Dequeue();

            // F(n)
            int answer = (first + second) % 1234567;
            return answer;
        }
    }
}
