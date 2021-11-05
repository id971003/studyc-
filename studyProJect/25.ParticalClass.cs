using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /* 

     */

     
    class ParticalClassExtensionMethod
    {
        public static void ParticalClassExtensionMethodTestClass()
        {
            ParticalClass ParticalC = new ParticalClass();
            
            ParticalC.Num1();
            ParticalC.Num2();
            ParticalC.Num3();
            ParticalC.Num4();
            
        }
    }
    partial class ParticalClass
    {
        public void Num1()
        {
            Console.WriteLine("1");
        }
        public void Num2()
        {
            Console.WriteLine("2");
        }
    }
    partial class ParticalClass
    {
        public void Num3()
        {
            Console.WriteLine("3");
        }
        public void Num4()
        {
            Console.WriteLine("4");
        }
    }
}