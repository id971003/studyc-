using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace projectstudy
{
    /*
    하나의 델리게이트는 여러개의 메소드를 동시 참조 가능하다
    += < 키워드로 추가한다
    -= < 키워드로 뺀다.

    */

    delegate void Notifi(string message);

    class Notifier
    {
        public Notifi eventOccured;
    }
    class EventListener
    {
        private string name;
        public EventListener(string name)
        {
            this.name=name;
        }
        public void SomethingHappend(string message)
        {
            Console.WriteLine("{0}.somethingHappend : {1}",name,message);
        }
    }

    class DelegateChainClass
    {

        public static void DelegateChainClassTestClass()
        {
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("listen1");
            EventListener listener2 = new EventListener("listen2");
            EventListener listener3 = new EventListener("listen3");


            notifier.eventOccured += listener1.SomethingHappend;
            notifier.eventOccured += listener2.SomethingHappend;
            notifier.eventOccured += listener3.SomethingHappend;

            notifier.eventOccured("Hi"); //listener1 , 2 3 순서로 실행


            notifier.eventOccured -= listener3.SomethingHappend;

            notifier.eventOccured("Hi"); //listener 1 ,2 순서로 실행 
        }
    }
}

    




