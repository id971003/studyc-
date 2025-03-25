using System;
using System.Collections.Generic;
using System.Text;

// [ref / out]
namespace projectstudy
{
    /* 요약
     매개 변수 전달시 전달하는 변수를 복사해 넣는다
     ref 키워드 : 참조 형식으로 변수를 전달한다
     out 키워드 : c#에서 out은 매개변수로 입력 할 때 초기화 되지 않아도 된다 
                그러나 반드시 메서드 안에서 초기화가 되어야 한다. 그리고 메서드가 
                완료될 때 out 매개변수가 반환된다
     */
    class ReferenceVariable
    {
        public static void ReferenceVariableTestClass(string[] arg)
        {
            int x = 3;
            int y = 4;
            int result = Calculator.Add(x, y); //이때 x,y 를 add 의 a,b 에 전달할때 x,y 랑 a,b 는 서로 다른 메모리를 할당받는다

            Console.WriteLine(result); //x=3, y 4


            Calculator.Swap(x, y); //call by value 메서드를 호출할때 데이터를 복사해서 매개 변수로 넘기는것 

            Console.WriteLine("X : {0} Y :{1}", x, y); // x,y 는 변하지 않는다 


            Calculator.Swapref(ref x, ref y);

            Console.WriteLine("X : {0} Y :{1}", x, y);//x=4, y=3 으로 변한다


            int a = 4;
            int b = 2;
            int qut, rem;

            Calculator.Divice(a, b, out qut, out rem);  // qut , rem 두개의 값을 업데이트 함

            Console.WriteLine("Qutient :{0}  remainder : {1}", qut, rem);

            object return_Divide = Calculator.Divide_retuen(a, b);
            (int quotient, int remainder) result_t = Calculator.Divide_retuen(a, b);
            Console.WriteLine($"Quotient: {result_t.quotient}, Remainder: {result_t.remainder}");


        }
    }
    class Calculator
    {
        public static int Add(int a, int b)
        {

            return a + b;
        }
        public static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;


        }
        public static void Swapref(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;


        }
        public static void Divice(int x, int y, out int qut, out int rem)
        {
            qut = x / y;
            rem = x % y;

        }
        // 반환값이 두개인 것은 다음과 같이 구현 할 수 있다 
        // 튜플 구조로 반환 값을 받을 수 있다. 
        public static (int quotient, int remainder) Divide_retuen(int x, int y)
        {
            int quotient = x / y;
            int remainder = x % y;
            return (quotient, remainder);
        }

    }
}
