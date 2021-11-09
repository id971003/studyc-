using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /* 
     람다식 : 익명 메소드를 만들기 위해 사용함  
     익명메소드랑 비슷한결과  (?) 
     익명메소드는 c# 2.0 람다식은 3.0 도입됨 익명메소드보다 람다식을 사용하자 (?)

     Func ,Action keyworld : .NET 프레임워크에서 미리선언해논 delegate
     Func : 반환형식이있는 델리게이트
     Action : 반환형식이없는 델리게이트 
     */
    class LambdaClass
    {
        delegate int LamdaCalculate(int a, int b);
        delegate void LamdaDoSoumthing();
        public static void LambdaClassTestClass()
        {
            LamdaCalculate Calc = (int a, int b) => a + b; //람다식
            //LamdaCalculate Calc =(a, b) => a+b 이렇게 int 삭제가능 (형식유추)

            Console.WriteLine(Calc(1, 5));


            LamdaDoSoumthing Dosomething = () =>
            {//문형의 람다식 
                Console.WriteLine("1");
                Console.WriteLine("2");
                Console.WriteLine("3");
            };

            Dosomething();

            Func<int, int> Func1 = (x) => x * x; //Func   이때 가장 마지막 매개변수의 형식이 Func 의 반환 형식이다

            Console.WriteLine(Func1(5));


            int Result = 0;
            Action<int> Act1 = (x) => Result = x * x; //action

            Act1(5);
            Console.WriteLine(Result);
        }
    }
}