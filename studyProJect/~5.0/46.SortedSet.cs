using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace projectstudy
{
    //SortedSetClass

    // 중복이 되지않는다는 특징이있다
    // Add 시킨 값들이 순서대로 정렬되지않는다
    // Add 메서드가 bool 타입을 리턴한다 안에 add 시킬 값이 들어있지 않으면 true 이미 들어가있으면 false 를 리턴한다

    class SortedSetClass
    {

        public static void SortedSetTextClass()
        {
            HashSet<int> HashSetList = new HashSet<int>();
            SortedSet<int> SortedSetList = new SortedSet<int>();
            List<int> A = new List<int>();

            A.Add(5);
            A.Add(5);
            A.Add(5);
            A.Add(5);
            A.Add(5);
            A.Add(5);
            Console.WriteLine(A.Capacity);
            A.Capacity=5;
            Console.WriteLine(A.Capacity);

            for(int i=0;i<100;i++)
            SortedSetList.Add(i);

            foreach(int a in SortedSetList)
            Console.WriteLine(a);

            if(SortedSetList.Add(5))
            {
                Console.WriteLine("5가들어갔어");
            }   
            else
            {
                Console.WriteLine("5는이미들어있어");
            }
        }
    }
}