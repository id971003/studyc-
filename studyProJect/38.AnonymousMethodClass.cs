using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace projectstudy
{
    /*
    익명메소드 : 선언한 델리게이트의 인스턴스를 만들때 인스턴스에 메소드의 구현이 담겨있는 코드블록 (이름이없다)
    다시는 사용할 일이없을때 사용
    */

    
    delegate int CalCulater(int a, int b);
    class AnonymousMethodClass 
    {
        
        public static void AnonymousMethodClassTestClass()
        {
            CalCulater Calc;
            Calc = delegate (int a, int b)
                {
                    return a+b;
                };
            Console.WriteLine(Calc(3,4));
            
        }
    }
}

    




