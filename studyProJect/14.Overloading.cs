using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /*overloading : 같은기능을 하는 서로다른 변수 가지는 메서드
     * 
     * param 키워드 :  매개변수의 '갯수' 만 다를때 오버로딩 하는 방식
     */
    class Overloading
    {
        static void OverloadingTestClass(string[] arg)
        {
            int x = 1;
            int y = 1;
            double z = 1;
            double a = 1;
            Console.WriteLine(Add(x, y));
            Console.WriteLine(Add(x, z));
            Console.WriteLine(Add(a, z));
            Console.WriteLine(Add(x, y, x)); //        static int Add(params int[] arg) 사용
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static double Add(double a, double b)
        {
            return a + b;
        }
        static int Add(params int[] arg)
        {
            int sum = 0;
            foreach (int a in arg)
                sum += a;
            return sum;
        }
    }

}

