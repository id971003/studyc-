using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /* 
        this : 객체 자신을 지칭, 클래스 지역 객제 (매개변수와 필드의 이름이 같을때 구별해준다 )
        this() : 자기자신의 생성자를 지칭 , 생성자에서만 사용 , 생성자의 코드블록의 앞쪽에서만 사용가능 (생성자 오버로딩시 사용 ?)
     */
    class ThisKeyword
    {
        public static void ThisKeywordTestClass()
        {
            ThisKeyWordClass1 MyClass = new ThisKeyWordClass1();
            MyClass.SetName("김동호");

            Console.WriteLine(MyClass.GetName());


            ThisKeyWordClass2 Myclass2 = new ThisKeyWordClass2(456, 789);

            Console.WriteLine("{0} : {1} : {2}", Myclass2.a, Myclass2.b, Myclass2.c);

        }

    }
    class ThisKeyWordClass1
    {
        private string Name;

        public void SetName(string Name) // 
        {
            this.Name = Name;
        }
        public string GetName()
        {
            return this.Name;
        }
    }
    class ThisKeyWordClass2
    {
        public int a, b, c;
        /*
        public ThisKeyWordClass2() //생성자
        {
            this.a=123;
        }
        public ThisKeyWordClass2(int b) //생성자 오버로딩
        {
            
            this.a=123;
            this.b=b;
        }
        public ThisKeyWordClass2(int b,int c) //생성자 오버로딩
        {
            
            this.a=123;
            this.b=b;
            this.c=c;
        }
        */

        public ThisKeyWordClass2()
        {
            this.a = 123;
        }
        public ThisKeyWordClass2(int b) : this()
        {
            this.b = b;
        }
        public ThisKeyWordClass2(int b, int c) : this(b)
        {

            this.c = c;
        }

    }
}