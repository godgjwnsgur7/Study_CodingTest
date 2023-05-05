using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project.Programmers.Lv2
{
    internal class CalculatingParkingFee
    {
        /* 주차 요금 계산 : 2020 KAKAO BLIND RECRUITMENT
        https://school.programmers.co.kr/learn/courses/30/lessons/92341
        */

        public static void Main_CalculatingParkingFee(string[] args)
        {
            string[] testRecords1 = new string[] { 
                "05:34 5961 IN", "06:00 0000 IN", "06:34 0000 OUT", "07:59 5961 OUT", "07:59 0148 IN", 
                "18:59 0000 IN", "19:09 0148 OUT", "22:59 5961 IN", "23:00 5961 OUT" };
            int[] testFees1 = new int[] { 180, 5000, 10, 600 };

            string[] testRecords2 = new string[] {
                "16:00 3961 IN", "16:00 0202 IN", "18:00 3961 OUT", "18:00 0202 OUT", "23:58 3961 IN" };
            int[] testFees2 = new int[] { 120, 0, 60, 591 };

            string[] testRecords3 = new string[] { "00:00 1234 IN" };
            int[] testFees3 = new int[] { 1, 461, 1, 10 };

            int[] answer1 = Solution(testFees1, testRecords1);
            int[] answer2 = Solution(testFees2, testRecords2);
            int[] answer3 = Solution(testFees3, testRecords3);

            Console.Write($"기댓값 : [14600, 34400, 5000] / 결과 : [{answer1[0]}");
            for (int i = 1; i < answer1.Length; i++)
                Console.Write($", {answer1[i]}");
            Console.WriteLine("]");

            Console.Write($"기댓값 : [0, 591] / 결과 : [{answer2[0]}");
            for (int i = 1; i < answer2.Length; i++)
                Console.Write($", {answer2[i]}");
            Console.WriteLine("]");

            Console.Write($"기댓값 : [14841] / 결과 : [{answer3[0]}");
            for (int i = 1; i < answer3.Length; i++)
                Console.Write($", {answer3[i]}");
            Console.WriteLine("]");
        }


        public static int[] Solution(int[] fees, string[] records)
        {
            int[] answer = new int[] { };



            return answer;
        }
    }
}
