using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /* 요약
     * 매개 변수 전달시 전달하는 변수를 복사해 넣는다
     * 
     * ref 키워드 : 참조 형식으로 변수를 전달한다
     * out 키워드 : return 값이 2개 이상일때 넣는다
     */
    class ReferenceVariable
    {
        static void Main(string[] arg)
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

            Calculator.Divice(a, b, out qut, out rem);
            Console.WriteLine("Qutient :{0}  remainder : {1}", qut, rem);
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
    }
}
