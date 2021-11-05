using System;
using System.Collections.Generic;
using System.Text;
using ExtensionSt;

namespace projectstudy
{
    /* 
    메서드를 확장시킨다, 상속받아 기능을 추가하거나 제거하는 상속과 다른기능
    선언할 메서드와 클래스를 static 한정자로 수식 , 첫매개변수를 this 한정자로 수식
     */

     
    class ExtensionMethod
    {
        public static void ExtensionMethodTestClass()
        {
            string Name = "동호";
            Console.WriteLine(Name.AddHi());
            
        }
    }
}
namespace ExtensionSt
{
    public static class StringExtension
    {
        public static string AddHi(this string Name)
        {
            string hi = "안녕";
            return Name+hi;
        }
    }
}