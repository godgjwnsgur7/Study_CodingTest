using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project.Programmers.Lv2
{
    internal class JadenCaseCreateString
    {
        /* JadenCase 문자열 만들기
        JadenCase란 모든 단어의 첫 문자가 대문자이고, 그 외의 알파벳은 소문자인 문자열입니다. 
        단, 첫 문자가 알파벳이 아닐 때에는 이어지는 알파벳은 소문자로 쓰면 됩니다. (첫 번째 입출력 예 참고)
        문자열 s가 주어졌을 때, s를 JadenCase로 바꾼 문자열을 리턴하는 함수, solution을 완성해주세요.

        제한 조건
        s는 길이 1 이상 200 이하인 문자열입니다.
        s는 알파벳과 숫자, 공백문자(" ")로 이루어져 있습니다.
        숫자는 단어의 첫 문자로만 나옵니다.
        숫자로만 이루어진 단어는 없습니다.
        공백문자가 연속해서 나올 수 있습니다.
        */

        public static void Main_JadenCaseCreateString(string[] args)
        {
            Console.WriteLine($"기댓값 : 3people Unfollowed Me / 결과 : {Solution("3people unFollowed me")}");
            Console.WriteLine($"기댓값 : For The Last Week  / 결과 : {Solution("for the last week")}");
        }

        // 풀이시도1.
        // 숫자일 때, 공백일 때, 문자일 때로 나눠서
        // 숫자 : 패스, 공백 : 다음에 오는 문자 대문자로, 문자 : 공백 이후 첫 문자면 대문자로

        // 개선사항1.
        // StringBuilder로 인덱스 접근이 가능해졌을 때,
        // [0]이거나 [i-1]위치의 문자가 공백인지 확인해서 수행했다면 로직이 더 간단했을 것
        
        // 개선사항2.
        // 굳이 StringBuilder를 쓰지 않고 foreach(char c in s)으로 처리했다면 로직이 더 간단했을 것
        // foreach문을 사용하면, 굳이 인덱스로 접근하지 않고 조건확인만으로, 해결 가능

        public static string Solution(string s)
        {
            StringBuilder sb =  new(s);
            bool isBlank = false; // 공백확인

            // 첫 글자 판단해서 공백이거나 숫자가 아니라면 대문자로 변환
            if (sb[0] != ' ' && !char.IsNumber(sb[0]))
            {
                sb[0] = Char.ToUpper(sb[0]);
            }

            for(int i = 1; i < sb.Length; i++)
            {
                if(char.IsNumber(sb[i])) // 숫자라면
                {
                    isBlank = false;
                }
                else if(sb[i] == ' ') // 공백이라면
                {
                    isBlank = true;
                }
                else // 문자라면
                {
                    if(isBlank)
                    {
                        sb[i] = Char.ToUpper(sb[i]);
                        isBlank = false;
                    }
                    else
                    {
                        sb[i] = Char.ToLower(sb[i]);
                    }
                }
            }

            return sb.ToString();
        }
    }
}
