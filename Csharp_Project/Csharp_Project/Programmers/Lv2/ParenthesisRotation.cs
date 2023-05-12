using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project.Programmers.Lv2
{
    internal class ParenthesisRotation
    {
        /* 괄호 회전하기
        https://school.programmers.co.kr/learn/courses/30/lessons/76502
        
        다음 규칙을 지키는 문자열을 올바른 괄호 문자열이라고 정의합니다.

        (), [], {} 는 모두 올바른 괄호 문자열입니다.
        만약 A가 올바른 괄호 문자열이라면, (A), [A], {A} 도 올바른 괄호 문자열입니다. 
        예를 들어, [] 가 올바른 괄호 문자열이므로, ([]) 도 올바른 괄호 문자열입니다.

        만약 A, B가 올바른 괄호 문자열이라면, AB 도 올바른 괄호 문자열입니다. 
        예를 들어, {} 와 ([]) 가 올바른 괄호 문자열이므로, {}([]) 도 올바른 괄호 문자열입니다.

        대괄호, 중괄호, 그리고 소괄호로 이루어진 문자열 s가 매개변수로 주어집니다. 
        이 s를 왼쪽으로 x (0 ≤ x < (s의 길이)) 칸만큼 회전시켰을 때 
        s가 올바른 괄호 문자열이 되게 하는 x의 개수를 return 하도록 solution 함수를 완성해주세요.

        제한사항
        s의 길이는 1 이상 1,000 이하입니다.
       */

        public static void Main_ParenthesisRotation(string[] args)
        {
            Console.WriteLine($"기댓값 : 3 / 결과 : {Solution("[](){}")}");
            Console.WriteLine($"기댓값 : 2 / 결과 : {Solution("}]()[{")}");
            Console.WriteLine($"기댓값 : 0 / 결과 : {Solution("[)(]")}");
            Console.WriteLine($"기댓값 : 0 / 결과 : {Solution("}}}")}");
            Console.WriteLine($"기댓값 : 0 / 결과 : {Solution("{(})")}"); // Add
        }

        // 회전 - 맨 앞에 인덱스의 문자를 맨 뒤로 보내는 것
        // 회전 수 : 문자열의 길이만큼

        // 풀이시도1.
        // int형 isS, isM, isL을 선언해서 괄호열기 ++, 괄호닫기 --, 로 문자 판단 시마다 -1이 생기면 X처리하고,
        // 모든 문자를 체크한 후에 각 변수의 값이 0이라면, 옳은 괄호라고 판단하는 것.
        // 예외 상황으로 { ( } ) 이런 경우에도 잘못된 괄호인데, 맞는 괄호처럼 인식해버림.
        
        // 풀이시도2.
        // 스택을 떠올리면 바로 해결
       
        public static int Solution(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            int answer = 0;

            for(int i = 0; i < sb.Length; i++)
            {
                if (IsCorrectParentheses(sb.ToString()))
                    answer++;

                // 문자열 회전
                sb.Append(sb[0]); // 맨 앞의 인덱스를 뒤에 추가
                sb.Remove(0, 1); // 맨 앞의 인덱스 삭제
            }

            return answer;
        }

        // 올바른 괄호 판단
        public static bool IsCorrectParentheses(string s)
        {
            Stack<Char> stack = new Stack<char>();

            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                    stack.Push(s[i]);
                else if (stack.Count == 0)
                    return false;

                switch (s[i])
                {
                    case ')':
                        if (stack.Pop() != '(')
                            return false;
                        break;
                    case '}':
                        if (stack.Pop() != '{')
                            return false;
                        break;
                    case ']':
                        if (stack.Pop() != '[')
                            return false;
                        break;
                }
            }

            return stack.Count == 0;
        }
    }
}
