using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace projectstudy
{
    /*
    EventKeyWord:  델리게이트를 event 한정자로 수식한다
    delegate vs event : 이벤트는 외부에서 직접 사용할수 없다 자신이 선언되어있는 클래스 외부에서 호출 불가능 / delegate 는 외부 호출가능

    “Event는 Delegate를 캡슐화 시킨 것이다.”
    https://blog.naver.com/silent1002/10086120655

    "통지 구조를 인터페이스에 드러내거나 publish 동작을 클래스 내부에 감추는 목적으로 이벤트와 델리게이트를 구분해서 쓰면 될 것 같다."
    https://okminseok.blogspot.com/2019/09/c-event-vs-delegate.html

    "Evnet 는 프로퍼티 라고 생각하자"
    https://freeprog.tistory.com/261
    */
    delegate void EventClassEventhandler(string message); //델리게이트

    class EventNotifier
    {
        public event EventClassEventhandler SomethingHappend; //이벤트핸들러
        public void DoSomething(int number)
        {
            if(number<10)
            {
                SomethingHappend(number.ToString()+"은 10보다 작다");
            }
        }    
    }

    class EventCLass 
    {
        static public void MyHandler(String message)
        {
            Console.WriteLine(message);
        }
        public static void EventCLassTestClass()
        {
            EventNotifier notifier = new EventNotifier();
            notifier.SomethingHappend+=new EventClassEventhandler(MyHandler); //MyHnadler 를 notifier 의 이벤트핸들러 SomethingHappend 에 넣어서 사용 
            //notifier.SomethingHappend("123"); 외부 객체에서 사용 불가능
            for(int i=0;i<20; i++)
            {
                notifier.DoSomething(i);
            }
            
            
        }
    }
}

    




