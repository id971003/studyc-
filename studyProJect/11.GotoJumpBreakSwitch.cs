using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /* 요약 
     * break,continue.switch , goto 문
     * break : 반복을 탈출 
     * continue :반복 건너뛰기
     * switch : 한변수 값에 따라 분기 나눔
     * goto : 레이블로강제 이동 (자주사용되지는 않는다고함)
     */
    class GotoJumpBreakSwitch
    {
        static void Main(string[] args)
        {
            //break 문 
            int a = 0;

            while (true)
            {
                Console.WriteLine(a++);
                if (a > 10)
                    break;
            }//12345678910


            //continue문 
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                if (i == 1)     //1일때 건너뜀 
                    continue;
                Console.Write(i);
            }//02


            Console.WriteLine();

            //goto 문 & switch 문 
            string fg = "a";

            switch (fg)
            {
                case "a":
                    Console.Write("a");
                    goto case "b";
                case "b":
                    Console.Write("b");
                    goto case "c";
                case "c":
                    Console.Write("c :end");
                    goto default;
                case "d":
                    Console.Write("d");
                    break;
                default:
                    goto gotob;
            }
            gotob: Console.WriteLine("끝");//abc:end끝
            }
    }
}
