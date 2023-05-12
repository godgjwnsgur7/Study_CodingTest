using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project.Programmers.Lv2
{
    internal class MaximumValue_MinimumValue
    {
        /* 최댓값과 최솟값
        https://school.programmers.co.kr/learn/courses/30/lessons/12939
        문자열 s에는 공백으로 구분된 숫자들이 저장되어 있습니다. 
        str에 나타나는 숫자 중 최소값과 최대값을 찾아 이를 
        "(최소값) (최대값)"형태의 문자열을 반환하는 함수, Solution을 완성하세요.
        예를들어 s가 "1 2 3 4"라면 "1 4"를 리턴하고, "-1 -2 -3 -4"라면 "-4 -1"을 리턴하면 됩니다.

        제한 조건
        s에는 둘 이상의 정수가 공백으로 구분되어 있습니다.
        */

        public static void Main_MaximumValue_MinimumValue(string[] args)
        {
            Console.WriteLine($"기댓값 : 1 4  / 결과 : {Solution("1 2 3 4")}");
            Console.WriteLine($"기댓값 : -4 -1  / 결과 : {Solution("-1 -2 -3 -4")}");
            Console.WriteLine($"기댓값 : -1 -1  / 결과 : {Solution("-1 -1")}");
        }

        // 풀이시도1.
        // 1. Split(' ')로 공백을 기준으로 string 배열로 변환해서 담음
        // 2. 변환한 string 배열의 크기만큼 List<int>에 Parse해서 담음
        // 3. 담은 List의 Min(), Max() 함수로 양식에 맞춰 추출하고 리턴

        public static string Solution(string s)
        {
            string answer;

            string[] words = s.Split(' ');

            List<int> values = new List<int>();

            for (int i = 0; i < words.Length; i++)
                values.Add(int.Parse(words[i]));

            answer = $"{values.Min()} {values.Max()}";
           
            return answer;
        }
    }
}
