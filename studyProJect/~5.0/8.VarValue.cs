using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /*요약: var 은뭘까?
     * 1. 형식을 자기가 찾아서 변환한다.
     * 2. 지역변수에서만 사용가능하다
     * 3. 반드시 초기화 해줘야한다 (안하면 찾아줄수가없다)
     */
    class VarValue
    {
        static void VarValueTestClass(string[] args)
        {
            var a = 20;
            var b = 'b';
            var c = "c";
            var d = "dd";
            var f = 3.14f;

            Console.WriteLine(a + ":" + a.GetType());
            Console.WriteLine(b + ":" + b.GetType());
            Console.WriteLine(c + ":" + c.GetType());
            Console.WriteLine(d + ":" + d.GetType());
            Console.WriteLine(f + ": " + f.GetType());
        }
    }
}
