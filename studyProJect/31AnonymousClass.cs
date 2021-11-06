using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{

    /*
    무명형식 : 형식 선언과 동시에 인스턴스할당 ( 인스턴스를 만들고 다시는 사용하지 않을때 이용)

    */
    class AnonymousClass 
    {
        public static void AnonymousClassTestClass()
        {
            var a = new{Name = "김동호 ",Age =123};
            Console.WriteLine(a.Name +a.Age);
        }
    }


}
