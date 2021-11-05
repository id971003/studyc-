using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /* 
    StaticField 의 경우 인스턴스에 속하지 않고 클래스에 소속됨 (프로그램 전체에서 유일하다)
    StaticField 가 아닐경우 자동으로 인스턴스에 소속됨
     */
    class DeepCopyClass
    {
        public static void DeepCopyTestClass()
        {
            MyClass Source = new MyClass();  //Source 인스턴스를 만들고 각각 10,20 을할당한후
            Source.MyField1=10;
            Source.MyField2=20;

            MyClass Target = Source; // Source 인스턴스를 Target 에 할당한후 Target 에 myfield2 를 30 으로 바꾸면
            Target.MyField2=30; // Source 와 target 의 MyField2 가 모두 30 으로 바뀐다  클래스는 참조 형식 이기 때문에 Source 와 Target 이 같은 참조를 복사했기때문이다 (얇은 복사)

            Console.WriteLine("{0} : {1}",Source.MyField1,Source.MyField2); //10,30
            Console.WriteLine("{0} : {1}",Target.MyField1,Target.MyField2); //10,30


            MyClass Source2 =new MyClass(); //Source2 인스턴스를 만들고 각각 10,20 을할당한후
            Source2.MyField1=10;
            Source2.MyField2=20;

            MyClass Target2 = Source2.DeepCopy(); // Source에 DeepCopy 메서드를 통해 객체를 힙이 새로 할당해 그곳에 Source2 의멤버를 할당하고 Target2 에 복사해넣는다
            Target2.MyField2=30;

            Console.WriteLine("{0} : {1}",Source2.MyField1,Source2.MyField2); //10,30
            Console.WriteLine("{0} : {1}",Target2.MyField1,Target2.MyField2); //10,30


        }

    }
    class MyClass 
    {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;
            return newCopy;
        }
    }
}