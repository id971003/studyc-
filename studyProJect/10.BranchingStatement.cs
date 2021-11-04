using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /*분기문
         * if / elseif / switch 
         * 
         * 반복문
         * for/ while / do while / foreach
         */
    class BranchingStatement
    {
        static void MaBranchingStatementTestClass(string[] args)
        {
            //if 와 else if

            int a = 1;

            if (a < 0)
            {
                Console.WriteLine("0보다작다");
            }
            else if (a > 100)
            {
                Console.WriteLine("100보다크다");
            }
            else
            {
                Console.WriteLine("0과 100 사이다 ");
            }

            //switch
            switch (a)
            {
                case 1:
                    Console.WriteLine("1이다");
                    break;
                default:
                    Console.WriteLine("1이아니다");
                    break;
            }


            //for
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();


            //while
            int j = 10;

            while (j > 0)
            {

                Console.Write(j);
                j--;
            }
            Console.WriteLine();


            //do while
            int q = 10;

            do
            {
                Console.Write(q); //10보다 크지만 한번은 실행 
            }
            while (q > 10); // while 이랑다르게 ; 필요
            Console.WriteLine();


            //foreach
            char[] o = { 's', 't', 'u', 'd', 'y' };
            foreach (char n in o)
                Console.Write(n);
        }
    }
}
