using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace projectstudy
{
    /*
    EventKeyWord:  델리게이트를 event 한정자로 수식한다
    delegate vs event : 이벤트는 외부에서 직접 사용할수 없다 자신이 선언되어있는 클래스 외부에서 호출 불가능 / delegate 는 외부 호출가능
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

    




