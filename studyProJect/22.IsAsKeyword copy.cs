using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /* 
    파생클래스는 기반 클래스의 인스턴스로 이용가능하다 
    is : 객체가 해당형식에 해당하면 true 아니면 false 반환
    as : 형식 변환 자와같은 역할을 하지만 형식변환자는 형변환에 실패시 > 예외를 던지고 as 키워드는 실패시  > 객체 참조를 null 로 만듬 
        + as 연산자는 참조 형식에만 가능하므로 형식변환자보다 as 연산자의 이용이 권장되지만 값형식일경우 형식 변환 연산자를 이용해야한다 
     */
    class IsAsKeyword
    {
        public static void IsAsKeywordTestClass()
        {
            Animal animal =new Dog(); //파생클래스를 기반클래스의 인스턴스로 이용
            Dog dog;

            if(animal is Dog) //개가 동물이냐 ?  맞으니 true 
            {
                dog = (Dog)animal; //animal 이 Dog 형식이니 형변환한다
                dog.Bark();
            }


            Animal animal2 = new Cat(); //
            Cat cat1 = animal2 as Cat;  //고양이가 동물이냐 ? 맞으니 cat1 을 Cat 로 형변환
            Cat cat2 = animal as Cat; //고양이가 개냐?  틀리니 cat2  을 null 로만든다

            if(cat1 !=null)
            {
                cat1.Meow();
            }
            else
            {
                Console.WriteLine("cat1 is not Cat");
            }
            
            if(cat2 !=null)
            {
                cat2.Meow();
            }
            else
            {
                Console.WriteLine("cat2 is not Cat");
            }
        }

    }
    class Animal
    {
        public void Walk()
        {
            Console.WriteLine("Walk");
        }
    }
    class Dog:Animal
    {
        public void Bark()
        {
            Console.WriteLine("Bark");
        }
    }
    class Cat:Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meow");
        }
    }

}