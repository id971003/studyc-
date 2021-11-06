using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /* 
    InterFace  :  인터페이스로부터 파생될 클래스는 반드시 인터페이스 내부 메소드를 강제 구현 해야한다.
    메소드, 이벤트 인덱서 프로퍼티 만 가질수 있다.
    구현부가 따로 없다 , 인스턴스 생성 불가능  (클레스에상속해 인스턴스 생성가능  [규칙 메소드 들을 public 한정자로 수식해야함])

     */

    interface IDebugLog
    {
        void WriteLog(string message);
    }
    class InterfaceDerivedClass : IDebugLog
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }
    class InterFaceClass 
    {
        public static void InterFaceClassTestClass()
        {
            InterfaceDerivedClass InterfaceClass = new InterfaceDerivedClass();
            InterfaceClass.WriteLog("안녕");
        }


    }
}
