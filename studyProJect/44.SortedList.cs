using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace projectstudy
{
    //Arraylist 와 hashtable 과 혼합 key 로 저장한 값을 불러옴
    //중복키 허옹하지않음 
    //입력된 순서와 상관없이 key 값으로 정렬됨
    class SortedListClass
    {

        public static void SortedListTextClass()
        {
            SortedList<int,string> list1 = new SortedList<int, string>();

            list1.Add(4, "Four"); 
            list1.Add(1, "One"); 
            list1.Add(2, "Two");
            list1.Add(3,"three");
            for(int i=0;i<list1.Count;i++)
            Console.WriteLine(list1.Values[i]);
        }
    }
}