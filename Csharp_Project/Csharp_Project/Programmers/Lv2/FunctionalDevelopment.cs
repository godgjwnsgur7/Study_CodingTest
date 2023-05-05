using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project.Programmers.Lv2
{
    internal class FunctionalDevelopment
    {
        /* 기능개발
        프로그래머스 팀에서는 기능 개선 작업을 수행 중입니다. 각 기능은 진도가 100%일 때 서비스에 반영할 수 있습니다.
        또, 각 기능의 개발속도는 모두 다르기 때문에 뒤에 있는 기능이 앞에 있는 기능보다 먼저 개발될 수 있고, 
        이때 뒤에 있는 기능은 앞에 있는 기능이 배포될 때 함께 배포됩니다.
        먼저 배포되어야 하는 순서대로 작업의 진도가 적힌 정수 배열 progresses와 각 작업의 개발 속도가 적힌 정수 배열 speeds가 주어질 때 
        각 배포마다 몇 개의 기능이 배포되는지를 return 하도록 solution 함수를 완성하세요.

        제한 사항
        작업의 개수(progresses, speeds배열의 길이)는 100개 이하입니다.
        작업 진도는 100 미만의 자연수입니다.
        작업 속도는 100 이하의 자연수입니다.
        배포는 하루에 한 번만 할 수 있으며, 하루의 끝에 이루어진다고 가정합니다.
        예를 들어 진도율이 95%인 작업의 개발 속도가 하루에 4%라면 배포는 2일 뒤에 이루어집니다.
        */

        public static void Main_FunctionalDevelopment(string[] args)
        {
            int[] testProgresses1 = { 93, 30, 55 };
            int[] testSpeeds1 = { 1, 30, 5 };
            int[] answer1 = Solution(testProgresses1, testSpeeds1);

            int[] testProgresses2 = { 95, 90, 99, 99, 80, 99 };
            int[] testSpeeds2 = { 1, 1, 1, 1, 1, 1 };
            int[] answer2 = Solution(testProgresses2, testSpeeds2);

            Console.Write($"기댓값 : [2, 1] / 결과 : [{answer1[0]}");
            for(int i = 1; i < answer1.Length; i++)
                Console.Write($", {answer1[i]}");
            Console.WriteLine("]");

            Console.Write($"기댓값 : [1, 3, 2] / 결과 : [{answer2[0]}");
            for (int i = 1; i < answer2.Length; i++)
                Console.Write($", {answer2[i]}");
            Console.WriteLine("]");
        }

        public static int[] Solution(int[] progresses, int[] speeds)
        {
            List<int> answerList = new List<int>();
            Queue<int> progressesQueue = new Queue<int>(progresses);
            Queue<int> speedsQueue = new Queue<int>(speeds);

            int completeCount = 0;

            while (progressesQueue.Count > 0)
            {
                // 작업 진행
                for(int i = 0; i < progressesQueue.Count; i++)
                {
                    int tempNum = progressesQueue.Dequeue();
                    tempNum += speedsQueue.ElementAt(i);
                    progressesQueue.Enqueue(tempNum);
                }

                // 배포가능 체크
                if(progressesQueue.Count > 0)
                {
                    while (progressesQueue.Peek() >= 100)
                    {
                        completeCount++;
                        progressesQueue.Dequeue();
                        speedsQueue.Dequeue();

                        if (progressesQueue.Count == 0)
                            break;
                    }
                }

                // 배포가능 갯수 추가
                if (completeCount > 0)
                {
                    answerList.Add(completeCount);
                    completeCount = 0;
                }
            }

            return answerList.ToArray();
        }
    }
}
