using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace projectstudy
{
    /*요악
     * 산술 증가/감소 할당 연산자
     * +,-,/,% 를 알아본다
     * ++,--,+=,-=,/=,%= 를 알아본다
     * 
     * 논리 관계 연산자
     *&&,||, ! ,> ,< ,== 를알아본다
     * 
     * 조건 연산자
     * ?, : 를알아본다
     * etc (if 문을 간단하게하는게 끝?)
     * 
     * 
     * 연산자 순위
     * 증/감연산자  > 산술 연산자 > 관계연산자 > 논리 연산자 > 할당 연산자 
     */
    class Operator
    {
        static void OperatorTestClass(string[] args)
        {
            //산술 증/감소
            int a = 7;
            int b = 3;

            Console.WriteLine(a + b); //10
            Console.WriteLine(a - b); //4
            Console.WriteLine(a / b); //2
            Console.WriteLine(a % b); //1
            Console.WriteLine(++a); //8
            Console.WriteLine(a--); //8 
            Console.WriteLine(a); //7 


            int c = 0;
            c += a;

            Console.WriteLine(c); // 0+7=7

            c /= a;

            Console.WriteLine(c);//7/7=1;

            c = 7;
            c %= a;

            Console.WriteLine(c); //7%7 =0;
            Console.WriteLine();
            //논리관계

            bool q = true;
            bool r = false;

            Console.WriteLine(q && r); //q와 r 둘다 true 냐 
            Console.WriteLine(q || r); //q 랑 r 중 하나라도 true 냐 
            Console.WriteLine(!q); //q 의 반대는 ?

            int w = 1;
            int e = 2;

            Console.WriteLine(w < e); // w 가 e 보다작냐
            Console.WriteLine(w == e); //w랑 e 가같냐 
            Console.WriteLine();
            //조건연산자

            int p = 30;

            string result = p == 30 ? "삼십" : "삼십아님";
            Console.WriteLine(result);
        }
    }
}
