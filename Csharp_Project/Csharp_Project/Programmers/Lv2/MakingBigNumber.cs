using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project.Programmers.Lv2
{
    internal class MakingBigNumber
    {
        /* 큰 수 만들기
        https://school.programmers.co.kr/learn/courses/30/lessons/42883
        
        어떤 숫자에서 k개의 수를 제거했을 때 얻을 수 있는 가장 큰 숫자를 구하려 합니다.
        예를 들어, 숫자 1924에서 수 두 개를 제거하면 [19, 12, 14, 92, 94, 24] 를 만들 수 있습니다.
        이 중 가장 큰 숫자는 94 입니다.
        문자열 형식으로 숫자 number와 제거할 수의 개수 k가 solution 함수의 매개변수로 주어집니다. 
        number에서 k 개의 수를 제거했을 때 만들 수 있는 수 중 가장 큰 숫자를 
        문자열 형태로 return 하도록 solution 함수를 완성하세요.

        제한 조건
        number는 2자리 이상, 1,000,000자리 이하인 숫자입니다.
        k는 1 이상 number의 자릿수 미만인 자연수입니다.
        */

        public static void Main_MakingBigNumber(string[] args)
        {
            Console.WriteLine($"기댓값 : 94 / 결과 : {Solution("1924", 2)}");
            Console.WriteLine($"기댓값 : 3234 / 결과 : {Solution("1231234", 3)}");
            Console.WriteLine($"기댓값 : 775841 / 결과 : {Solution("4177252841", 4)}");
        }

        // 풀이시도 1
        // 한 자릿수 제외 : 모든 자리 수를 하나씩 빼는 경우의 수를 전부 비교해 가장 큰 수를 다음 대상으로 함
        // -> 문제 : 2개 외에 다 실패 + 시간복잡도가 k*n^2 가 되어 시간초과 

        // 알고리즘 풀이
        // 맨 앞의 인덱스부터 비교해서 한칸 뒤의 수보다 작으면 앞의 인덱스를 지웠을 때 가장 큰 수가 나옴

        public static string Solution(string number, int k)
        {
            number = "9" + number;
            StringBuilder sb = new StringBuilder(number);

            int index = 0;

            for(int i = 0; i < k; i++)
            {
                while(true)
                {
                    if(index + 1 == sb.Length)
                    {
                        sb.Remove(index, 1);
                        index--;
                        break;
                    }
                    
                    if(sb[index] < sb[index+1])
                    {
                        sb.Remove(index, 1);
                        index--;
                        break;
                    }

                    index++;
                }
            }

            return sb.Remove(0, 1).ToString();
        }
    }
}
