using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    public class ConstReadonly
    {
        /*요약
        * const : 컴파일상수 (선언시초기화) , 정수,실수,enum,string 타입만 사용 가능 , stack 메모리할당 (static 선언시 heap 메모리 저장가능  , stack 메모리에 할당해 속도가 빠름
        * readonly  : 런타임상수 (선언시 초기화 필요없음) ,생성자 단계에서 초기화가능 , 모든 자료형 이용가능 , heap메모리 할당 
        */
        public static void ConstReadonlyTestClass()
        {
            //constReadonlyValue.constValue = 5; const 값은 런타임시 바꿀수없음
            Console.WriteLine(constReadonlyValue.constValue);


            constReadonlyValue k = new constReadonlyValue(5);
            Console.WriteLine(k.readonlyValue);




        }
    }
    public class constReadonlyValue
    {
        public const int constValue = 2;
        public readonly int readonlyValue;
        public constReadonlyValue(int k)
        {
            readonlyValue = k;
        }
    }
}
