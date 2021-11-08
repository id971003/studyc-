using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace projectstudy
{

    /*
    foreach 를 사용하려면 IEnumerator 와 Ienumerable 을 상속하는 형식 만 지원한다 

    Ienumerable :  GetEnumerator 
    GetEnumerator :IEnumerator 형식의 객체를 반환한다

    IEnumerator : MoveNext ,Reset ,Current
    boolean MoveNext : 다음요소로 이동한다 (끝나면 flase 이동성공시 True 반환)
    void Reset : 컬렉션의 가장첫위치 -1로 이동한다
    Obejct Current : 컬렉션의 현재요소 반환 
    */

    //https://docs.microsoft.com/ko-kr/dotnet/csharp/language-reference/keywords/yield
    

    class ForeachIenumeratorTestClass :  IEnumerable
    {
        int Position=-1;   // foreach 문 실행시 MoveNext 를 실행해 다음 요소를 가져옴으로 시작값은 -1 (1을 더하고 가져오기때문)
        private int[] ForeachIenumeratorTestClassArray;
        public ForeachIenumeratorTestClass()
        {
            ForeachIenumeratorTestClassArray=new int[3];
        }
        public int this[int index]
        {
            get
            {
                return ForeachIenumeratorTestClassArray[index];
            }
            set
            {
                if(index >= ForeachIenumeratorTestClassArray.Length)
                {
                    Array.Resize<int>(ref ForeachIenumeratorTestClassArray,index+1);
                    Console.WriteLine("Array Resize");
                }
                ForeachIenumeratorTestClassArray[index]=value;
            }
        }


        public IEnumerator GetEnumerator() //IEnumerable 메소드
        {
            for(int i=0;i<ForeachIenumeratorTestClassArray.Length;i++) 
            {
                yield return (ForeachIenumeratorTestClassArray[i]); // 배열값을 반환한다
            }
        }

        /*
        public object Current // IEnumerator 메소드1
        {
            get
            {
                return ForeachIenumeratorTestClassArray[Position]; //현재 데이터 반환
            }
        }
        public void Reset() // IEnumerator 메소드2 
        {
            Position=-1; //시작값은 -1
        }
        public bool MoveNext() // IEnumerator 메소드3
        {
            if(Position== ForeachIenumeratorTestClassArray.Length-1) //지금위치가 배열의 크기 -1 과 같다면  (시작값이 -1 이기때문에) 
            {
                Reset(); // 지금위치를 초기화 시키고 
                return false; // false 를 반환한다
            }
            Position++; //지금위치를 1더한다
            return (Position< ForeachIenumeratorTestClassArray.Length); //더해진 위치가 배결보다 작으면(배열안에있으면 ) True 반환 
        }
        */

    }
    class ForeachIEnumerator 
    {
        public static void ForeachIEnumeratorTestClass()
        {
            ForeachIenumeratorTestClass list = new ForeachIenumeratorTestClass();
            for(int i=0;i<3;i++)
            list[i]=i;

            foreach(int val in list)
            Console.WriteLine(val);
        }
    }



}
