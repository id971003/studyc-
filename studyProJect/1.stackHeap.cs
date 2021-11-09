using System;

namespace projectstudy
{
    //데이터
    //스택vs 힙 
    //스택 에 있는 값은 {} 를 만나며 바로 지워지지만 힙에 있는 값은 바로 지워지지않는다 
    //정수 계열 형식
    public class StackHeap
    {
        public static void StackHeapTestClass()
        {
            {
                int A = 100;
                int B = 200;
                int C = 300;

                Console.WriteLine(A + " " + B + " " + C);
                //a>b>c순으로 스택에 쌓임
            } //} 만나며 c>b>a 순으로 제거


            //힙
            {
                object A = 20;
                object B = "Study";

                Console.WriteLine(A + " " + B);
            } // 스택에서는 a  ,b 둘다제거  but 힙에는 20,study 값 남아있음 (이후 가비지컬렉터가 수거)



            //정수계열 형식 

            byte d = 10; //0~255
            sbyte e = -10; // -128~127
            short f = -30000; // -32768 ~ 32767
            ushort g = 60000;// 0~ 4294967295
            long h = -500000000000; //0~18446744073709551615
            ulong i = 2000000000000000000; // 0~18446744073709551615

            Console.WriteLine("byte : {0} \nsbyte : {1}\nshort : {2}\nushort : {3}\nlong : {4}\nulong : {5}", d, e, f, g, h, i);

        }
    }
}