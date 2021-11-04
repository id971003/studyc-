using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /* 요약
     * object 형식과같이 참조 형식은 힙에 데이터를 할당한다
     * 이때 이 object 에 int 와 float 과 같은 스택 형식의 객체를 담았을때 이 스택형식의 값들이 힙에 할당 될수있도록 하는것 
     */
    class boxing
    {
        static void Main(string[] args)
        {
            object a = 20;//박싱

            Console.WriteLine(a.GetType());


            int b = (int)a; //언박싱

            Console.WriteLine(b + ": " + b.GetType());


            object c = (object)/*이거왜쓰지?*/ b;  //박싱

            Console.WriteLine(c + ":" + c.GetType());


            int d = (int)c; //언박싱

            Console.WriteLine(d + ": " + d.GetType());
        }
    }
}
