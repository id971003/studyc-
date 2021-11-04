using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /*요약
      * enum 은 변수를 만든다?
      * enum convert to string 
      */
    class enumValue
    {
        enum language
        {
            c, java, python, english = 10, go
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine((int)language.c);
            Console.WriteLine(language.c.ToString() == "c"); //tostring() 으로 enum > string 값을 변환 가능 

            

            foreach(language b in Enum.GetValues(typeof(language))) // 열거형 상수의 배열 검색 후 string 전환 
            {
                string value = b.ToString();
                Console.WriteLine(value);
            }
        }
    }
}