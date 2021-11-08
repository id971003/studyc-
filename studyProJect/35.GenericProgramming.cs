using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace projectstudy
{

    /*
    Generic : 데이터 형식을 일반화한다.
    where : Generic 의 형식을 제안할수있다
    where T: struct 값형식 이여야한다.
    where T: class 참조형식이여야한다.
    where T: new() 매개변수가없는 생성자가 있어야한다.
    where T: "BaseClaseName" 기반클레스의 파생클레스여야한다.
    where T: "InterfaceName" 명시한 인터페이스를 구현해야한다.
    where T: U 
    */    
        class PrintArrayClass<T>  //일반화 클레스 
        {
            public void PrintArray (T[] Val)
            {
                for(int i =0;i<Val.Length;i++)
                {
                    Console.WriteLine(Val[i]);
                }
            }
        }
    class GenericProgrammingClass 
    {
        static void CopyArray<T> (T[] Source , T[] Target) //일반화 메소드
        {
            for(int i=0;i<Source.Length;i++)
            Target[i]=Source[i];
        }



        class StructArray<T> where T:struct //where
        {
            public T[] Array
            {
                get;set;
            }
            public StructArray(int size)
            {
                Array=new T[size];
            }
        }


        public static void GenericProgrammingClassTestClass()
        {
            int[] IntArray = new int[5];
            StructArray<int> IntArray2  = new StructArray<int>(5);

            string[] StringArray = new string[5];

        for(int i=0;i<IntArray.Length;i++)
            {
                IntArray[i]=i;
                StringArray[i]=i+"입니다";
            }

            CopyArray<int>(IntArray,IntArray2.Array);

      


            PrintArrayClass<int> PrintIntArray = new PrintArrayClass<int>();
            PrintIntArray.PrintArray(IntArray2.Array);
            
            PrintArrayClass<string> PrintStringArray = new PrintArrayClass<string>();
            PrintStringArray.PrintArray(StringArray);

                        
        }
    }
    



}
