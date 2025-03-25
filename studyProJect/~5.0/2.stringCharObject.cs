using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /*요약 string, char  ,bool
     * char 는 '' 로 string 은 ""로 감싸줘야함 
     * bool 형식은 true 랑 false 뿐
     * obejct  모든 형식
     */

    public class StringCharObject
    {
        public static void StringCharObjectTestClass()
        {
            char a = '공';
            char b = '부';
            string c = "공부";
            bool g = true;
            bool f = false;
            object q = "1";
            object k = 5;
            object m = 5.45342532453425;

            Console.Write(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(g);
            Console.WriteLine(f);
            Console.WriteLine(q);
            Console.WriteLine(k);
            Console.WriteLine(m);
        }
    }
}
