using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{

    /*
    프로퍼티 : get set 메소드를 이용하여  은닉성을위해 pirvate 으로선언한 클래스 내의 필드에 값변환 혹은 값을 읽을 때 사용 
    자동구현 프로퍼티 : 필드를 따로 선언할 필요도없이  자동으로 get;set; 만 해도 구현해준다 (? 누가 : k_BackingField ,? 다른기능 추가불가능 )

    인터페이스와 추상클레스 모두 프로퍼티를 가질수 있다.
    */


    class PropertyPerson 
    {
        private string name; //프로퍼티 (대소문자?)
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                Console.WriteLine("이름설정 !"+value); //(자동구현프로퍼티에선 이런거못함 ?)
                name=value;
            }
        }
        public int Age //자동구현 프로퍼티
        {
            get;set;
        }
    }

    interface IDog  //인터페이스 프로퍼티
    {
        string Name
        {
            get;set;
        }
    }
    class DogClass : IDog 
    {
        private string name;
        public string Name
        {
            get{return name;}
            set{name=value;}
        }
    }

    abstract class AbstractCatClass  //추상클레스 프로퍼티
    {
        public string catname;
        
        public string CatName
        {
            get { return catname;}
            set {catname=value;}
        }
    }

    class CatClass : AbstractCatClass
    {
    }

    class PropertyClass 
    {
        public static void PropertyTestClass()
        {
            PropertyPerson DongHo = new PropertyPerson();
            DongHo.Name="동호";
            DongHo.Age=25;

            Console.WriteLine(DongHo.Name + DongHo.Age);


            PropertyPerson NaMi = new PropertyPerson() //프로퍼티를 이용해 객체 생성과 초기화 
            {
                Name="나미",
                Age=25
            };

            Console.WriteLine(NaMi.Name + NaMi.Age); 


            DogClass Dog = new DogClass() //인터페이스 프로퍼티
            {Name="까미"};
            
            Console.WriteLine(Dog.Name);


            CatClass Cat = new CatClass();
            Cat.CatName="꾸미";

            Console.WriteLine(Cat.CatName);


        }
    }


}
