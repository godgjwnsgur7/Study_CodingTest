using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project.Programmers.Lv2
{
    internal class Carpet
    {
        /* 숫자 변환하기
        https://school.programmers.co.kr/learn/courses/30/lessons/42842

        Leo는 카펫을 사러 갔다가 아래 그림(링크)과 같이 중앙에는 노란색으로 칠해져 있고 
        테두리 1줄은 갈색으로 칠해져 있는 격자 모양 카펫을 봤습니다.
        https://grepp-programmers.s3.ap-northeast-2.amazonaws.com/files/production/b1ebb809-f333-4df2-bc81-02682900dc2d/carpet.png

        Leo는 집으로 돌아와서 아까 본 카펫의 노란색과 갈색으로 색칠된 격자의 개수는 기억했지만,
        전체 카펫의 크기는 기억하지 못했습니다.

        Leo가 본 카펫에서 갈색 격자의 수 brown, 노란색 격자의 수 yellow가 매개변수로 주어질 때 
        카펫의 가로, 세로 크기를 순서대로 배열에 담아 return 하도록 solution 함수를 작성해주세요.

        제한사항
        갈색 격자의 수 brown은 8 이상 5,000 이하인 자연수입니다.
        노란색 격자의 수 yellow는 1 이상 2,000,000 이하인 자연수입니다.
        카펫의 가로 길이는 세로 길이와 같거나, 세로 길이보다 깁니다.
        */

        public static void Main_Carpet(string[] args)
        {
            Console.WriteLine($"기댓값 : [4, 3] / 결과 : [{Solution(10, 2)[0]}, {Solution(10, 2)[1]}]");
            Console.WriteLine($"기댓값 : [3, 3] / 결과 : [{Solution(8, 1)[0]}, {Solution(8, 1)[1]}]");
            Console.WriteLine($"기댓값 : [8, 6] / 결과 : [{Solution(24, 24)[0]}, {Solution(24, 24)[1]}]");
        }

        // 풀이시도1.
        // 노랑 a, 갈색 b, 가로 x, 세로 y 로 놨을 때
        // 노랑 : a = xy - b, 갈색 : 2x + 2y - 4
        // 즉, xy = a + b, x + y = (b / 2) + 2
        // 더한 식의 조건을 대입한 후 곱한 식의 조건에 부합하는지 찾는 방식

        public static int[] Solution(int brown, int yellow)
        {
            int[] answer = new int[2]; // 가로, 세로

            int addValue = (brown / 2) + 2; // 가로 + 세로
            int xy = brown + yellow; // 가로 * 세로

            int x, y;

            for(int i = 1; i < addValue - 1; i++)
            {
                // 더한 식의 조건을 적용
                x = i;
                y = addValue - x;

                // 곱한 식의 조건을 만족하는 지 확인
                if (xy == x * y)
                {
                    // 최적 값을 찾음
                    answer[0] = x;
                    answer[1] = y;
                    break;
                }
            }

            if(answer[0] < answer[1])
            {
                int tempNum = answer[1];
                answer[1] = answer[0];
                answer[0] = tempNum;
            }

            return answer;
        }
    }
}
