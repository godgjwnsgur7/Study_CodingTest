using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project.Programmers.Lv1
{
    internal class Z_Memo_Lv1
    {
        /// <summary>
        /// 문자열 내 마음대로 정렬하기
        /// https://school.programmers.co.kr/learn/courses/30/lessons/12915
        /// - string, CompareTo, OrderBy
        /// </summary>
        public static string[] SortStrings_HoweverYouWant(string[] strings, int n)
        {
            bool isChange = true;
            while (isChange)
            {
                isChange = false;
                for (int i = 0; i < strings.Length - 1; i++)
                {
                    if (strings[i][n] > strings[i + 1][n])
                    {
                        isChange = true;
                        string str = strings[i];
                        strings[i] = strings[i + 1];
                        strings[i + 1] = str;
                    }
                    else if (strings[i][n] == strings[i + 1][n])
                    {
                        if (strings[i].CompareTo(strings[i + 1]) > 0)
                        {
                            isChange = true;
                            string str = strings[i];
                            strings[i] = strings[i + 1];
                            strings[i + 1] = str;
                        }
                    }
                }
            }
            // return strings;

            // 한줄요약
            string[] strAnswer = strings.OrderBy(c => c[n]).ThenBy(c => c).ToArray();
            return strAnswer;
        }
    }
}
