using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project.Programmers.Lv2
{
    internal class PickTangerines
    {
        /* 귤 고르기
        경화는 과수원에서 귤을 수확했습니다.
        경화는 수확한 귤 중 'k'개를 골라 상자 하나에 담아 판매하려고 합니다. 
        그런데 수확한 귤의 크기가 일정하지 않아 보기에 좋지 않다고 생각한 경화는 귤을 크기별로 분류했을 때 
        서로 다른 종류의 수를 최소화하고 싶습니다.

        예를 들어, 경화가 수확한 귤 8개의 크기가 [1, 3, 2, 5, 4, 5, 2, 3] 이라고 합시다. 
        경화가 귤 6개를 판매하고 싶다면, 크기가 1, 4인 귤을 제외한 여섯 개의 귤을 상자에 담으면, 
        귤의 크기의 종류가 2, 3, 5로 총 3가지가 되며 이때가 서로 다른 종류가 최소일 때입니다.

        경화가 한 상자에 담으려는 귤의 개수 k와 귤의 크기를 담은 배열 tangerine이 매개변수로 주어집니다. 
        경화가 귤 k개를 고를 때 크기가 서로 다른 종류의 수의 최솟값을 return 하도록 solution 함수를 작성해주세요.

        제한사항
        1 ≤ k ≤ tangerine의 길이 ≤ 100,000
        1 ≤ tangerine의 원소 ≤ 10,000,000
        */

        public static void Main_PickTangerines(string[] args)
        {
            int[] test1 = new int[] { 1, 3, 2, 5, 4, 5, 2, 3 };
            int[] test2 = new int[] { 1, 3, 2, 5, 4, 5, 2, 3 };
            int[] test3 = new int[] { 1, 1, 1, 1, 2, 2, 2, 3 };

            Console.WriteLine($"기댓값 : 3  / 결과 : {Solution(6, test1)}");
            Console.WriteLine($"기댓값 : 2  / 결과 : {Solution(4, test2)}");
            Console.WriteLine($"기댓값 : 1  / 결과 : {Solution(2, test3)}");
        }

        // 풀이시도 1.
        // 귤의 크기 종류별로 배열에 담아서 갯수가 많은 것부터 정렬한 뒤
        // 많은 갯수부터 k에서 빼나가는 문제
        // 딕셔너리 -> 리스트

        public static int Solution(int k, int[] tangerine)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            int answer = 0;

            // 귤 크기에 따라 딕셔너리에 담아 갯수파악
            for(int i = 0; i < tangerine.Length; i++)
            {
                if(!dict.ContainsKey(tangerine[i]))
                    dict.Add(tangerine[i], 1);
                else
                    dict[tangerine[i]]++;
            }

            // 딕셔너리의 값을 내림차순 정렬해서 List로 담음
            var sortList = dict.OrderByDescending(x => x.Value).ToList();
            int sum = 0;

            for (int i = 0; i < sortList.Count; i++)
            {
                answer++;
                sum += sortList[i].Value;
                if (sum >= k)
                    break;
            }

            return answer;
        }
    }
}
