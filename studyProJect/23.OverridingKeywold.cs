using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /* 
    오버라이딩 : 상속 과정에서 기반 클레스의 메서드에 변화를 주고 싶을 때 이용한다.
    기반클레스에서 변화를 주고싶은 메서드를 virtual 로 한정하고 파생클레스에선 override 로 한정해이용한다
        + private 선언시 상속 자체가 불가능함으로 오버라이딩은 불가능하다 
    new : new 한정자로 메서드를 한정하면 Base 클레스에서의 메서드를 감추고 Derived 클레스의 메서드만 노출한다

    오버라이딩vs new 를 이용한 메서드 숨기기 : 메서드 숨기기는 오버라이딩과 다르게 BaseClass 의 메서드도 실행가능하다 

    sealed : 오버라이딩이 불가능하다 막는다  virtual 선언된 가상메소드를 오버라이딩 한 버전의 메소드만 가능 
     */

     
    class OverridingKeywold
    {
        public static void OverridingKeywoldTestClass()
        {
            OverringDerivedClass OverD=new OverringDerivedClass();

            OverD.Number(); //파생클래스의 number 메서드 


            OverringBaceClass OverD2 = new OverringDerivedClass();

            OverD2.Number2(); //기반클래스의 number 메서드 
        }
    }

    class OverringBaceClass
    {
        public virtual void Number() // 상속시 변화를 주고싶은 메서드 
        {
            Console.WriteLine("1,2");
        }
        public virtual void Number2() // 상속시 변화를 주고싶은 메서드 
        {
            Console.WriteLine("5,6");
        }
    }
    class OverringDerivedClass : OverringBaceClass
    {
        public sealed override void Number() //상속받은 메서드중에 변화를 줄 메서드  //sealed했기때문에 더이상 상속 불가능 
        {
            base.Number();
            Console.WriteLine(",3,4,5");
        }
        public  new void Number2() // 상속시 변화를 주고싶은 메서드 
        {
            Console.WriteLine("7,8");
        }
    }
}