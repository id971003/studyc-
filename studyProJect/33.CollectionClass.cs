using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace projectstudy
{

    /*
    .NET  프레임 워크가 제공하는 컬랙션 클래스 
    ArrayList  : 용량을 지정할 필요없는 배열  Add(),Insert() 는 Object 를 매개변수를 받아 박싱함
    Queue : FristIn FirstOut
    Stack : LastIn LastOut
    Hashtable : 키 로 데이터를 찾는다 :타배열보다 탐색 속도가 빠름 (거의 없다)  
    Indexer : 클레스의 프로퍼티를 배열처럼 다루게해준다 (?)

    */
        class IndexClass
    {
        private int[] IndexArray;
        public IndexClass()
        {
            IndexArray=new int[3];
        }
        public int this[int index]
        {
            get
            {
                return IndexArray[index];
            }
            set
            {
                if(index >= IndexArray.Length)
                {
                    Array.Resize<int>(ref IndexArray,index+1);
                    Console.WriteLine("Array Resize");
                }
                IndexArray[index]=value;
            }
        }
    }
    class CollectionClass 
    {
        public static void CollectionClassTestClass()
        {
            ArrayList list = new ArrayList(); //ArrayList
            list.Add(1); //Add 가장마지막요소뒤에 새요솔를추가삼 
            list.RemoveAt(0); //해당번호 요소를 삭제
            list.Add(1);
            list.Add(2);
            list.Insert(1,"sr"); // 해당번호에 요소를 추가 

            foreach(object Var in list)
            Console.WriteLine(Var+" : " +Var.GetType());


            Queue Que = new Queue(); //Queue
            Que.Enqueue(1);
            Que.Enqueue(2);
            Que.Enqueue(3);

            Console.WriteLine(Que.Count); //3
            for(int i=0;i<3;i++)
            Console.WriteLine(Que.Dequeue()); //1,2,3 순으로 출력 후 뺌
            Console.WriteLine(Que.Count); //  0


            Stack Sta = new Stack(); //stack
            Sta.Push(1);
            Sta.Push(2);
            Sta.Push(3);

            Console.WriteLine(Sta.Count);
            for(int i=0;i<3;i++)
            Console.WriteLine(Sta.Pop()); //3,2,1순으로 출록후 뺌
            Console.WriteLine(Sta.Count); //  0


            Hashtable Ht = new Hashtable(); //Hashtable
            Ht["Unity"] ="C#";
            Ht["Unreal"] = "C++";

            Console.WriteLine(Ht["Unity"]);
            Console.WriteLine(Ht["Unreal"]);
            

            IndexClass IC = new IndexClass(); // Indexer 

            for(int i=0;i<4;i++)
            IC[i]=i;

            for(int i=0;i<4;i++)
            Console.WriteLine(IC[i]);

        }
    }



}
