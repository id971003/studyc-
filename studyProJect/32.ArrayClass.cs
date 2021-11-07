using System;
using System.Collections.Generic;
using System.Text;

namespace projectstudy
{

    /*
    배열 같은타입의 변수가 많을때 한번만 선언하게해준다
    다차배열 ( 2차가 넘는) 은 사용을 지양한다.
    가변배열 : 가변배열의 요소는 배열 이기 때문에 가변길이의 길이가 같을 필요없다 
    */
    class ArrayClass 
    {
        public static void ArrayClassTestClass()
        {
            
            int[] ArrayInt = new int[4]; //배열

            for(int i=0;i<ArrayInt.Length;i++)
            ArrayInt[i]=i;
            
            foreach(int Value in ArrayInt)
            {
            Console.WriteLine(Value);
            }


            int[,] ArrayInt2 = new int[4,2]{{1,2},{3,4},{5,6},{7,8}}; //2 차배열 

            for(int i=0;i<4;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.WriteLine(ArrayInt2[i,j]);
                }
            }
            

            int[][] ArrayInt3 = new int[3][]; // 가변배열 

            ArrayInt3[0]=new int[5]{1,2,3,4,5}; //5
            ArrayInt3[1]=new int[] {10,20,30}; //3 
            ArrayInt3[2] = new int[]{100,200}; //2 

            for(int i=0;i<ArrayInt3.Length;i++)
            {
                for(int j=0; j<ArrayInt3[i].Length;j++)
                Console.Write(ArrayInt3[i][j]);

                Console.WriteLine();

            }


            
        }
    }


}
