using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project.Programmers.Lv1
{
    internal class WalkPark
    {
        /* 공원 산책
        https://school.programmers.co.kr/learn/courses/30/lessons/172928
        
        런타임 에러가 부분적으로 뜨는 데 이유를 모르겠음
        이유는 진짜 없었음 사이트 오류였나봄ㅠㅠ
        */

        public static void Main_WalkPark(string[] args)
        {
            string[] test1 = new string[] { "SOO", "OOO", "OOO" };
            string[] test01 = new string[] { "E 2", "S 2", "W 1" };
            string[] test2 = new string[] { "SOO", "OXX", "OOO" };
            string[] test02 = new string[] { "E 2", "S 2", "W 1" };
            string[] test3 = new string[] { "OSO", "OOO", "OXO", "OOO" };
            string[] test03 = new string[] { "E 2", "S 3", "W 1" };

            Console.WriteLine($"기댓값 : [2, 1] / 결과 : [{Solution(test1, test01)[0]}, {Solution(test1, test01)[1]}]");
            Console.WriteLine($"기댓값 : [0, 1] / 결과 : [{Solution(test2, test02)[0]}, {Solution(test2, test02)[1]}]");
            Console.WriteLine($"기댓값 : [0, 0] / 결과 : [{Solution(test3, test03)[0]}, {Solution(test3, test03)[1]}]");
        }

        public static int[] Solution(string[] park, string[] routes)
        {
            int[] currPosition = new int[2] { -1, -1 };

            // 출발 위치 찾기
            for(int i = 0; i < park.Length; i++)
            {
                for(int j = 0; j < park[i].Length; j++)
                {
                    if(park[i][j] == 'S')
                    {
                        currPosition[0] = i;
                        currPosition[1] = j;
                        break;
                    }
                }
                if (currPosition[0] != -1 && currPosition[1] != -1)
                    break;
            }

            // 길 찾기
            for (int i = 0; i < routes.Length; i++)
            {
                int moveToY, moveToX;
                moveToY = currPosition[0];
                moveToX = currPosition[1];
                bool isMove = true;

                for (int j = 0; j < (int)routes[i][2] - (int)'0'; ++j)
                {
                    if (routes[i][0] == 'N') moveToY--;
                    else if (routes[i][0] == 'S') moveToY++;
                    else if (routes[i][0] == 'E') moveToX++;
                    else if (routes[i][0] == 'W') moveToX--;
                    else Console.WriteLine("범위 벗어남");

                    if (moveToY < 0 || moveToY >= park.Length ||
                        moveToX < 0 || moveToX >= park[0].Length ||
                        park[moveToY][moveToX] == 'X')
                    {
                        isMove = false;
                        break;
                    }
                }

                if(isMove)
                    currPosition = new int[2] { moveToY, moveToX };
            }
            
            return currPosition;
        }
    }
}