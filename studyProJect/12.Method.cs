using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    class Method
    {
        /* 요약
         * 일련의 기능을 하나로 묶은 코드 
         * 
         */
        static void Main(string[] args)
        {

            Console.WriteLine(Clock.NowTime());
            Console.WriteLine(Clock.DeltaTime(5));
        }
    }
    class Clock
    {
        public static string NowTime()
        {
            return DateTime.Now.ToString();
        }
        public static string DeltaTime(int minit)
        {
            return (DateTime.Now.AddMinutes(5)).ToString();
        }
    }
}