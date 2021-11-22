using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace projectstudy
{
    /*
    값이아닌 코드 자체를 매개 변수로 넘기고 싶을때 이용 
    델리게이트 메소드를 int 나 string 같은 형식으로 이용할수있게해준다 ( 델리게이트는 메소드의 참조다)
    */
    delegate int MyDelegate(int a, int b);

    class CalculatorDelegateClass
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
    class DelegateClass
    {

        public static void DelegateClassTestClass()
        {
            CalculatorDelegateClass del = new CalculatorDelegateClass();
            MyDelegate CallBack = new MyDelegate(del.Plus);

            Console.WriteLine(CallBack(5, 4));


            CallBack = new MyDelegate(del.Minus);
            Console.WriteLine(CallBack(5, 4));
        }
    }
}






