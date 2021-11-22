using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /* 
     :를통해 상속이 이루어짐 (EX A : B  A에게 B 를 상속 A=파생클래스 B=기반클래스 )
     파생클래스의 고유한 필드와 메서드를 기반 클래스에 넘겨줌

     */
    class BaceDerivedClass
    {
        public static void BaceDerivedClassTestClass()
        {
            BaseClass Base = new BaseClass("김");

            Base.BaseMethod();

            Derived Derived = new Derived("동");

            Derived.BaseMethod();
            Derived.DerivedMethod();
        }

    }
    class BaseClass
    {
        public string Name;
        public BaseClass(string Name)
        {
            this.Name = Name;
            Console.WriteLine("{0} : Base()", this.Name);
        }
        ~BaseClass()
        {
            Console.WriteLine("{0} : ~Base()", Name);
        }
        public void BaseMethod()
        {
            Console.WriteLine("{0}.BaseMethod()", Name);
        }
    }
    class Derived : BaseClass
    {
        /*BaseClass(Nmae) 호출*/
        public Derived(string Name) : base(Name)
        {
            Console.WriteLine("{0}.Drived()", this.Name);
        }
        ~Derived()
        {
            Console.WriteLine("{0}.~Drived()", this.Name);
        }
        public void DerivedMethod()
        {
            Console.WriteLine("{0}.DerivedMethod()", Name);
        }
    }
}