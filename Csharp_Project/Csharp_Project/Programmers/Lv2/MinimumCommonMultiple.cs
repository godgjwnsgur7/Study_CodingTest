using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project.Programmers.Lv2
{
    internal class MinimumCommonMultiple
    {
        /* 최소 공배수
        두 수의 최소공배수(Least Common Multiple)란 입력된 두 수의 배수 중 공통이 되는 가장 작은 숫자를 의미합니다. 
        예를 들어 2와 7의 최소공배수는 14가 됩니다. 
        정의를 확장해서, n개의 수의 최소공배수는 n 개의 수들의 배수 중 공통이 되는 가장 작은 숫자가 됩니다. 
        n개의 숫자를 담은 배열 arr이 입력되었을 때 이 수들의 최소공배수를 반환하는 함수, solution을 완성해 주세요.

        제한 사항
        arr은 길이 1이상, 15이하인 배열입니다.
        arr의 원소는 100 이하인 자연수입니다.
        */

        public static void Main_MinimumCommonMultiple(string[] args)
        {
            int[] test1 = new int[] { 2, 6, 8, 14 };
            int[] test2 = new int[] { 1, 2, 3 };

            Console.WriteLine($"기댓값 : 168 / 결과 : {Solution(test1)}");
            Console.WriteLine($"기댓값 : 6 / 결과 : {Solution(test2)}");
        }

        // 풀이시도 1.
        // 인덱스 0번을 기준으로 1번부터 순차적으로 최소공배수를 구해서
        // 마지막 인덱스까지 최소공배수를 구하면 배열 전체의 최소공배수가 될 것

        public static int Solution(int[] arr)
        {
            int answer = arr[0];
            int answerNum;
            int arrNum;

            // 0번은 기준 숫자로 answer에 들어가있으므로 1부터 시작
            for (int i = 1; i < arr.Length; i++)
            {
                arrNum = arr[i];
                answerNum = answer;

                // 현재 숫자와 해당 인덱스의 최소 공배수 구하기 ( 현재 숫자 갱신 )
                while (answer != arr[i])
                {
                    if(answer > arr[i])
                        arr[i] += arrNum;
                    else
                        answer += answerNum;
                }
            }

            return answer;
        }
    }
}
