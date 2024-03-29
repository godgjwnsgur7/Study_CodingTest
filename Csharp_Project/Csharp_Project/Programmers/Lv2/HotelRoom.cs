﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Project.Programmers.Lv2
{
    internal class HotelRoom
    {
        /* 호텥 대실
        https://school.programmers.co.kr/learn/courses/30/lessons/155651
        호텔을 운영 중인 코니는 최소한의 객실만을 사용하여 예약 손님들을 받으려고 합니다.
        한 번 사용한 객실은 퇴실 시간을 기준으로 10분간 청소를 하고 다음 손님들이 사용할 수 있습니다.
        
        예약 시각이 문자열 형태로 담긴 2차원 배열 book_time이 매개변수로 주어질 때,
        코니에게 필요한 최소 객실의 수를 return 하는 solution 함수를 완성해주세요.

        제한사항
        1 ≤ book_time의 길이 ≤ 1,000
        book_time[i]는 ["HH:MM", "HH:MM"]의 형태로 이루어진 배열입니다
        [대실 시작 시각, 대실 종료 시각] 형태입니다.
        시각은 HH:MM 형태로 24시간 표기법을 따르며, "00:00" 부터 "23:59" 까지로 주어집니다.
        예약 시각이 자정을 넘어가는 경우는 없습니다.
        시작 시각은 항상 종료 시각보다 빠릅니다.
        */

        public static void Main_HotelRoom(string[] args)
        {
            string[,] test1 = { { "15:00", "17:00" }, { "16:40", "18:20" }, { "14:20", "15:20" }, { "14:10", "19:20" }, { "18:20", "21:20" } };
            string[,] test2 = { { "09:10", "10:10" }, { "10:20", "12:20" } };
            string[,] test3 = { { "10:20", "12:30" }, { "10:20", "12:30" }, { "10:20", "12:30" } };

            Console.WriteLine($"기댓값 : 3 / 결과 : {Solution(test1)}");
            Console.WriteLine($"기댓값 : 1 / 결과 : {Solution(test2)}");
            Console.WriteLine($"기댓값 : 3 / 결과 : {Solution(test3)}");
        }

        // 풀이시도 1
        // 1. 퇴실 시간을 기준으로 10분 후부터 사용이 가능하므로, 모든 경우의 퇴실시간에 10분을 더함.
        // 2. 00시부터 23시 59분까지의 1분 단위의 모든 시간을 체크함 ( x = 체크할 시간 )
        // 체크 내용 - 입실시간 < x < 퇴실시간 ( 조건 만족 갯수 파악 )

        public static int Solution(string[,] book_time)
        {
            int answer = 0;
            int[] useRoomTimeCount = new int[1450];

            int startTime, endTime;
            string[] startTimeStr, endTimeStr;

            for(int i = 0; i < book_time.GetLength(0); i++)
            {
                startTimeStr = book_time[i, 0].Split(":");
                endTimeStr = book_time[i, 1].Split(":");

                startTime = int.Parse(startTimeStr[0]) * 60 + int.Parse(startTimeStr[1]);
                endTime = int.Parse(endTimeStr[0]) * 60 + int.Parse(endTimeStr[1]) + 10;

                for (int j = startTime; j < endTime; j++)
                    useRoomTimeCount[j]++;
            }

            for(int i = 0; i < useRoomTimeCount.Length; i++)
            {
                if(answer < useRoomTimeCount[i])
                    answer = useRoomTimeCount[i];
            }    

            return answer;
        }
    }
}
