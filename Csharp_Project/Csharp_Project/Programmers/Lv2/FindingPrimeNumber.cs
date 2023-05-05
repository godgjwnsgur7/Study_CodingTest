using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project.Programmers.Lv2
{
    internal class FindingPrimeNumber
    {
        /* 소수 찾기
        https://school.programmers.co.kr/learn/courses/30/lessons/42839?language=csharp

        한자리 숫자가 적힌 종이 조각이 흩어져있습니다. 
        흩어진 종이 조각을 붙여 소수를 몇 개 만들 수 있는지 알아내려 합니다.

        각 종이 조각에 적힌 숫자가 적힌 문자열 numbers가 주어졌을 때, 
        종이 조각으로 만들 수 있는 소수가 몇 개인지 return 하도록 solution 함수를 완성해주세요.

        제한사항
        numbers는 길이 1 이상 7 이하인 문자열입니다.
        numbers는 0~9까지 숫자만으로 이루어져 있습니다.
        "013"은 0, 1, 3 숫자가 적힌 종이 조각이 흩어져있다는 의미입니다.
       */

        public static void Main_FindingPrimeNumber(string[] args)
        {
            Console.WriteLine($"기댓값 : 3 / 결과 : {Solution("17")}");
            Console.WriteLine($"기댓값 : 2 / 결과 : {Solution("011")}");
        }

        // 소수 : 1과 자신으로만 딱 나누어 떨어지는 수

        // 풀이시도1.
        // 소수 판독기 함수를 만듦 ( 스트링 인덱스 기준 처음부터 끝까지 보냄 )
        // 매개변수로 받은 문자열로 가능한 모든 숫자를 만들고
        // HashSet(중복방지)에 넣고, 그 길이만큰 소수판독기 돌려서 카운트

        // 가능한 모든 숫자를 만드는 것이 포인트
        // 시도1.
        // 첫 번째 인덱스를 끝으로 한칸씩 저장하며 보내는 것을 한 사이클로 문자열 길이만큼 수행함
        // 맨 끝 인덱스를 하나씩 삭제하면서 모두 set에 담음
        // -> 문제 : 최대 자릿수로 모든 경우의 수를 뽑을 때, 예외상황이 많음 / 부분실패

        // 완전탐색 알고리즘에 대한 이해 등이 필요할 거 같은데, 일단 미룸....

        public static int Solution(string numbers)
        {
            int answer = 0;
            StringBuilder sb = new StringBuilder(numbers);
            HashSet<int> set = new HashSet<int>();



            // 소수 판독기에 넣어서 카운트
            foreach(int num in set)
                if (IsPrimeNumber(num))
                    answer++;

            return answer;
        }

        // 소수 판독기
        public static bool IsPrimeNumber(int _num)
        {
            if (_num <= 1)
                return false;

            for(int i = 2; i < _num; i++)
            {
                if(_num % i == 0)
                    return false;
            }

            return true;
        }
    }
}
