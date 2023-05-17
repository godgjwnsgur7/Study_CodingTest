using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project.Programmers.Lv2
{
    internal class Z_Memo_Lv2
    {
        /// <summary>
        /// 올바른 괄호
        /// https://school.programmers.co.kr/learn/courses/30/lessons/12909
        /// - 스택을 사용하지 않아도 풀 수 있는 문제라 스택을 사용하면 효율성 검사에서 떨어짐
        /// </summary>
        public static bool CorrectParentheses(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    count++;
                else if (count == 0)
                    return false;
                else
                    count--;
            }
            return count == 0;
        }
    }
}
