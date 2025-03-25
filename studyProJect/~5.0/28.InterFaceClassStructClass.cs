using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{
    /* 
    InterFace  :  인터페이스로부터 파생될 클래스는 반드시 인터페이스 내부 메소드를 강제 구현 해야한다.
    (따라서 모든 메소드를 public , protected , internal , protected internal 중하나로  으로 선언해야함 ?)
    메소드, 이벤트 인덱서 프로퍼티 만 가질수 있다.
    구현부가 따로 없다 , 인스턴스 생성 불가능  (클레스에상속해 인스턴스 생성가능  [규칙 메소드 들을 public 한정자로 수식해야함])
    
    인터페이스는 인터페이스 / 구조체 / 클레스 에 상속 시킬수있다,

    class 는 다중상속을 할수 없지만 interface 는 가능하다
     */

    interface IDebugLog
    {
        void WriteLog(string message);
        //private void WriteLog(string message) 불가능  인터페이스는 구현 이 불가능 함으로 상속을 이용해야 하기 때문에 
    }

    interface IDebugLogSayBye
    {
        void SayBye(string name);
    }


    interface IDebugLogPlus : IDebugLog //인터페이스를 상속하는 인터페이스  인스턴스가 인스턴스를 상속할때는 부모 인스턴스의 메소드를 구현할필요없음 
    {
        void WriteLogPluse(string message);
    }

    struct InterfaceDerivedStrut : IDebugLog, IDebugLogSayBye //인터페이스를 상속하는 구조체
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
        public void WriteLogPluse(string message)
        {
            Console.WriteLine("메시지! :" + message);
        }
        public void SayBye(string name)
        {
            Console.WriteLine(name + " Bye");
        }
    }



    class InterfaceDerivedClass : IDebugLogPlus, IDebugLogSayBye//인터페이스를 상속하는 클레스
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
        public void WriteLogPluse(string message)
        {
            Console.WriteLine("메시지! :" + message);
        }
        public void SayBye(string name)
        {
            Console.WriteLine(name + " Bye");
        }
    }

    class InterFaceClassStruct
    {
        public static void InterFaceClassTestClass()
        {
            InterfaceDerivedClass InterfaceClass = new InterfaceDerivedClass();
            InterfaceClass.WriteLog("안녕");
            InterfaceClass.WriteLogPluse("안녕");
            InterfaceClass.SayBye("나");

            InterfaceDerivedStrut InterfaceStruct;
            InterfaceStruct.WriteLog("안녕");
            InterfaceStruct.WriteLogPluse("안녕");
            InterfaceStruct.SayBye("나");
        }
    }
}
