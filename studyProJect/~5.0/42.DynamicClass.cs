using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace projectstudy
{
    /*
    dynamic :컴파일 타임에서 타입오류를 검사하지 않고 런타임에서 검사하는 방법 ? > 컴파일 타임에 오류검사를 건너 뛰는 방법 ? 

    interface 를 사용해도 되지만 (interface 는 너무 어렵기때문에 ? ) dynamic 도씀

    (?)
    dynamic vs Object
    dynamic 대신 obejct 를 사용할경우 
    1. 사용하려할때 형변환을한번
    2. 타입이 다를경우 사용할수없다 
    결론 dynamic 도 필요하다 


    동적언어 vs 정적언어

    정적언어 : 컴파일 타임에서 타입을 검사하는 언어 (C/ C++ / C# / Java)
    동적언어 : 런타임에서 변수의 타입을 검사하는 언어 (Python /PHP / JavajScript)

    코드작성속도는 동적언어가 더빠르다 (코드작성시 변수 타입을 고려할 필요가 없기떄문)
    변수 타입에 대한 안정성은 정적언어가 더 좋다 (컴파일시 변수 타입을 채크 함으로 사소한 버그 쉽게 체크가능)

    dynamic 은 정적언어인 C# 을 동적언어와의 상호 운용성을 위한 키워드이다 

    */



    class Duck //오리 = Walk(),Swim(),Quak() 를 가지고있다 > Walk(),Swim(),Quak() 를가지고있다
    {
        public void Walk()
        {
            Console.WriteLine(this.GetType() + "walk");
        }
        public void Swim()
        {
            Console.WriteLine(this.GetType() + "Swim");
        }
        public void Quak()
        {
            Console.WriteLine(this.GetType() + "Quack");
        }
    }
    class Mallard : Duck //오리를 상속 받았으니 얘는 오리다 
    {
    }
    class Robot // 얘는 오리를 상속 받지 않았기때문에 일반적으론 오리가 아니다 하지만 Walk(),와 Swim(), Quak()를 가지고있으니 오리다 
    {
        public void Walk()
        {
            Console.WriteLine(this.GetType() + "walk");
        }
        public void Swim()
        {
            Console.WriteLine(this.GetType() + "Swim");
        }
        public void Quak()
        {
            Console.WriteLine(this.GetType() + "Quack");
        }
    }
    class DynamicClass
    {
        public static void DynamicClassTestClass()
        {
            dynamic[] DuckArray = new dynamic[]
            { new Duck(),
              new Mallard(),
              new Robot()  //Robot 는 오리가 아니기 때문에 넣을수없지만 Dynamic 형식에선 오리일수도 있기때문에 일단 넣는다 
            };

            foreach (dynamic duck in DuckArray)
            {
                Console.WriteLine(duck.GetType());
                duck.Walk();
                duck.Swim();
                duck.Quak();
            }

            Console.WriteLine();
            object[] DuckArray2 = new dynamic[]
            {
                new Duck(),
                new Mallard(),
                new Robot()
            };

            foreach (object duck in DuckArray) //dynamic vs Object
            {

                Duck D = duck as Duck;
                if (D != null)
                {
                    Console.WriteLine(duck.GetType());
                    D.Walk();
                    D.Swim();
                    D.Quak();
                }
                else
                {
                    Console.WriteLine(duck.GetType() + "오리가아니다");
                }
            }
        }
    }
}
