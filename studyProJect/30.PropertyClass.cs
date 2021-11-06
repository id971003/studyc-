using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{

    /*
    프로퍼티 : get set 메소드를 이용하여  은닉성을위해 pirvate 으로선언한 클래스 내의 필드에 값변환 혹은 값을 읽을 때 사용 
    자동구현 프로퍼티 : 필드를 따로 선언할 필요도없이  자동으로 get;set; 만 해도 구현해준다 (? 누가 : k_BackingField ,? 다른기능 추가불가능 )
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
    class Property 
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
        }
    }


}
