using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project.Programmers.Lv2
{
    /* 디펜스 게임
    준호는 요즘 디펜스 게임에 푹 빠져 있습니다.
    디펜스 게임은 준호가 보유한 병사 n명으로 연속되는 적의 공격을 순서대로 막는 게임입니다.
    디펜스 게임은 다음과 같은 규칙으로 진행됩니다.
    
    준호는 처음에 병사 n명을 가지고 있습니다.
    매 라운드마다 enemy[i]마리의 적이 등장합니다.
    남은 병사 중 enemy[i]명 만큼 소모하여 enemy[i]마리의 적을 막을 수 있습니다.
    예를 들어 남은 병사가 7명이고, 적의 수가 2마리인 경우, 현재 라운드를 막으면 7 - 2 = 5명의 병사가 남습니다.
    남은 병사의 수보다 현재 라운드의 적의 수가 더 많으면 게임이 종료됩니다.
    게임에는 무적권이라는 스킬이 있으며, 무적권을 사용하면 병사의 소모없이 한 라운드의 공격을 막을 수 있습니다.
    무적권은 최대 k번 사용할 수 있습니다.
    준호는 무적권을 적절한 시기에 사용하여 최대한 많은 라운드를 진행하고 싶습니다.

    준호가 처음 가지고 있는 병사의 수 n, 사용 가능한 무적권의 횟수 k, 
    매 라운드마다 공격해오는 적의 수가 순서대로 담긴 정수 배열 enemy가 매개변수로 주어집니다.
    준호가 몇 라운드까지 막을 수 있는지 return 하도록 solution 함수를 완성해주세요.

    제한사항
    1 ≤ n ≤ 1,000,000,000
    1 ≤ k ≤ 500,000
    1 ≤ enemy의 길이 ≤ 1,000,000
    1 ≤ enemy[i] ≤ 1,000,000
    enemy[i]에는 i + 1 라운드에서 공격해오는 적의 수가 담겨있습니다.
    모든 라운드를 막을 수 있는 경우에는 enemy[i]의 길이를 return 해주세요.
    */

    internal class DefenseGame
    {
        public static void Main(string[] args)
        {
            int[] testIndex = { 4, 2, 4, 5, 3, 3, 1 };
            int[] testIndex2 = { 3, 3, 3, 3 };
            Console.WriteLine($"기댓값 : 5  / 결과 : {Solution(7, 3, testIndex)}");
            Console.WriteLine($"기댓값 : 4  / 결과 : {Solution(2, 4, testIndex2)}");
        }

        // 풀이시도1.
        // 1. n만을 이용해서 클리어 가능한만큼을 배열에 담으며 진행
        // 2. 클리어 불가능한 라운드에 도달 시에 k가 남아있다면,
        // - 현재 라운드까지 중에 가장 큰 수에 무적권을 사용하여 0으로 만듦 (현재 라운드가 아니라면, 더하고 현재 라운드 수행)
        // 3. 반복하다가, 2번에서 k가 0이라면, 해당하는 라운드가 최대 도달할 수 있는 라운드가 될 것.
        // -> 시간초과 2개

        // 풀이시도2.
        // 시간초과를 해결하기 위해 큰 수와 인덱스를 뽑아내던 for문을 사용하면 안된다고 판단.
        // ㅋㅋ 일단, 킵... 시간초과 그 상태 그대로

        public static int Solution(int n, int k, int[] enemy)
        {
            int currSoldier = n;
            int currIncibilityCount = k;
            int currRoundIndex;


            for(currRoundIndex = 0; currRoundIndex < enemy.Length; currRoundIndex++)
            {
                if (currSoldier < enemy[currRoundIndex])
                {
                    if (currIncibilityCount <= 0)
                        break;

                    // 현재 라운드까지 중에 가장 큰 수와 가장 큰 수의 인덱스를 추출
                    int maxValue = 0;
                    int maxValueIndex = 0;
                    for (int i = 0; i <= currRoundIndex; i++)
                    {
                        if(maxValue < enemy[i])
                        {
                            maxValue = enemy[i];
                            maxValueIndex = i;
                        }
                    }

                    // 만약 현재 라운드에 사용한다면, 상쇄시키기 위해 더해줌
                    if (maxValueIndex != currRoundIndex)
                    {
                        currSoldier += enemy[maxValueIndex];
                    }

                    // 무적권 사용
                    enemy[maxValueIndex] = 0;
                    currIncibilityCount--;
                }
                
                currSoldier -= enemy[currRoundIndex];
            }

            return currRoundIndex;
        }
    }
}
