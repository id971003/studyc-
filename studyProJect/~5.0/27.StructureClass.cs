using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /* 
    Struct(구조체)  vs Class
    Struct : 값형식(깊은복사 , 가비지 컬렉터가 수거 해갈 필요가없음 ?메모리관리유용) / 선언만으로 생성 / 매개 변수는 생성자로 선언 불가능 / System.ValueType 상속받음
    Class: 참조형식(얇은복사) / new 연산자와 생성자 필요 / 매개 변수 없이 생성가능 
     */

    struct NumberZipStruct
    {
        public int a;
        public int b;
        public NumberZipStruct(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
    }
    class NumberZipClass
    {
        public int a;
        public int b;
    }

    class Structure
    {
        public static void StructureTestClass()
        {
            NumberZipStruct MyStruct1; //선언 만으로 인스턴스 생성 //NumberzipStruct MyStruct1 = new NumberZipStruct(10,20) 처럼 생성자로 인스턴스 생성가능
            NumberZipStruct MyStruct2;

            MyStruct1.a = 10;
            MyStruct1.b = 20;

            MyStruct2 = MyStruct1;   //값 형식 이기때문에 깊은 복사 됨
            MyStruct2.b = 30;

            Console.WriteLine("Mystruct1 {0} : {1}", MyStruct1.a, MyStruct1.b); //MyStruct1 a:10 b:20
            Console.WriteLine("Mystruct2 {0} : {1}", MyStruct2.a, MyStruct2.b); //MyStruct1 a:10 b:30


            NumberZipClass MyClass1 = new NumberZipClass();
            NumberZipClass MyClass2 = MyClass1; //참조 형식이기때문에  얇은복사됨

            MyClass1.a = 10;
            MyClass1.b = 20;
            MyClass2.b = 30;

            Console.WriteLine("MyClass1 {0} : {1} ", MyClass1.a, MyClass1.b); //MyClass1 a:10 b:30
            Console.WriteLine("MyClass2 {0} : {1} ", MyClass2.a, MyClass2.b); //MyClass2 a:10 b:30
        }
    }
}


