using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Memo
/// -1 % 2 = -1
/// </summary>

namespace Csharp_Project.Programmers.Lv1
{
    internal class TestClass
    {
        public static void Main(string[] args)
        {
            int[,] answer = new int[,] { { } };

            string str = "123";
            int[] arr = new int[5] {1,2,3,4,1};
            List<int> list = new(arr);

            list.Remove(1);

            StringBuilder sb = new StringBuilder(str);

            int n = 45;
            int answer2 = 0;
            Stack<int> stack = new Stack<int>();

            Dictionary<int, string> dict = new Dictionary<int, string>()
        {
            {0, "zero"}, {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"},
            {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}
        };

            Console.WriteLine(dict[1]);

            // Console.WriteLine(solution("3141592", "271"));

            // for (int i = 0; i < list.Count; i++) 
            //     Console.Write(list[i]);

            // Console.WriteLine(Solution(6));
        }

        
        public static int Solution(int num)
        {
            int answer = num;

            if (answer == 1)
                return 0;

            for (int i = 0; i < 500; i++)
            {
                
                

                Console.WriteLine(answer);
                if (answer % 2 == 0) // 짝수
                    answer /= 2;
                else // 홀수
                    answer = (answer * 3) + 1;

                if (answer == 1)
                    return 1;
            }

            return -1;
        }

    }
}
