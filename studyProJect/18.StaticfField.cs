using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /* 
    StaticField 의 경우 인스턴스에 속하지 않고 클래스에 소속됨 (프로그램 전체에서 유일하다)
    StaticField 가 아닐경우 자동으로 인스턴스에 소속됨
     */
    class StaticfField
    {
        public static void StaticfFieldTestClass()
        {
            Person Me = new Person();
            Me.Age = 25;
            Person.Name = "5";

            Console.WriteLine(Me.Age);
            Console.WriteLine(Person.Name);
        }
    }
    public class Person
    {
        //  Person.Name 가능
        //  Person.Age 불가능

        public int Age;
        public static string Name;
    }
}
