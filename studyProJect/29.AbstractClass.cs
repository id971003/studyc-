using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /*
    추상 클래스 : 구현 은 가능하지만 인스턴스는 불가능한 클래스  (구현이 가능한 인터페이스 ? )
    추상 메서드 : 추상 클레스중 구현을 하지 못하는 메서드 ,인터페이스처럼 파생클래스(부모클래스) 에서 구현을 강제 
    추상 클레스를 상속 받는 추상 클레스는 부모의 추상 메소드를 구현할 필요없다 

    오버라이딩을 강제한다 ? 추상메소드의 구현부를 강제한다.
    */

    abstract class AbstractBaseClass // 추상클래스
    {
        public  void DoSomething()
        {
            Console.WriteLine("Something");
        }
        public abstract void SayHi();  //추상 클래스안에 추상 메소드
    }
    abstract class AbstrctDerivedClass :AbstractBaseClass //추상클래스를 상속 받는 추상클래스 , Sayhi 구현 안해도됨 
    {
        public void DSomethingPlusAlpa()
        {
            Console.WriteLine("SomethingPlusAlpa");
        }
    }
    class DerivedClass :AbstrctDerivedClass //추상 클래스를 상속받는 메소드
    {
        public override void SayHi() //추상클래스 안에 추상 메소드를 구현 강제 
        {
            Console.WriteLine("Say Hi!");
        }
    }
    class AbstractClass 
    {
        public static void AbstractClassTstClass()
        {
            DerivedClass Der = new DerivedClass();
            Der.SayHi();
            Der.DoSomething();
            Der.DSomethingPlusAlpa();
        }
    }

}
