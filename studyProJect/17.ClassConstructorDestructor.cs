using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /* 
    생성자 : 객체 (클래스) 를 생성함 (명시적으로 구현하지 않아도 컴파일러가 생성자를 만들어줌 ) 생성자 구현시 필드 를 원하는값으로 초기화가능 

    소멸자 : 매개변수와 한정자 사용불가능 클래스 이름앞에 "~" 표시 , clr 의 gc 가 객체를 소멸시키는 판단에 소멸자 호출
     */
     class ClassConstructorDestructor
    {
        public static void ClassConstructorDestructorTestClass()
        {
            Preson Me = new Preson("김동호",25);
            Preson Brother = new Preson("김갑순",19);
            
            Me.appear();
            Brother.appear();
        }

    }
    class Preson
    {
        public Preson(string Name, int Age)
        {
            this.Name=Name;
            this.Age=Age;
        }
        public string Name;
        public int Age;

        public void appear()
        {
            Console.WriteLine("{0}{1} : 등장",Name,Age);
        }
        
        ~Preson()
        {
            Console.WriteLine("{0}{1} : 퇴장",Name,Age);
        }
    }
}