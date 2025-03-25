using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace projectstudy
{
    //linkedlist vs list
    //list : 인덱스의 엑세스는 빠르지만 요소를 삽입하거나 제거 할때 속도가 느림 > 목록끝에 추가하거나 끝을 제거하는게 합리적임.
    //linkedlist  : 인덱스의 엑세스가 느리다 , 요소를 추가하거나 삽입이 빠름 (이유: 참조를 위한 저장공간을 가지고있기때문)
    //linkedlist 가 list 보다 더많은 메모리를 사용한다 (이유 : 다음/이전 참조를 위한 공간이 필요하기 때문)

    //결론 : 인덱스의 엑세스가 중요하면 list 를 요소를 추가하거나 삽입이 많으면 linkedlist 를 이용하자 
    class LinkedListClass
    {

        public static void LinkedListClassTextClass()
        {
            string[] list ={"김","김","동"};
            LinkedList<string> LinkedList = new LinkedList<string>(list);

            LinkedList.AddLast("호");
            LinkedList.AddLast("건");

            foreach(string a in LinkedList)
            Console.WriteLine(a);

            LinkedList.Remove("김");

            
            foreach(string a in LinkedList)
            Console.WriteLine(a);

            List<int> b = new List<int>();

            b.Add(1);
            b.Add(2);
            b.Add(3);
            b.Add(4);
            b.Add(5);

        

            
            
        }
    }
}