using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using static projectstudy.UsingStatic;

namespace projectstudy
{
    /// <summary>
    /// 구조체를 참조,읽기전용으로 전달가능하다 
    /// 성능도빠르고 값바꿀수없어 안전하다
    /// </summary>
    public class RealOnlyStruct
    {
        public void TA()
        {
            Triangle Ta = new Triangle(1, 2, 3);
            Triangle Ta2= Check(Ta);
            Ta2.a=5;
            Check(Ta2);
            Check(Ta); // 이렇게해도 Ta 의 a 는 1이다 
            //why ? 참조를 복사해서 전달하기때문이지
        }
        public struct Triangle
        {
            public int a, b, c;

            public Triangle(int a, int b, int c)
            { 
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public int Perimeter => a + b + c;
            public bool IsEquilateral => a == b && b == c;
        }
        private Triangle Check(in Triangle tri)
        {
            int perim = tri.Perimeter;
            bool equi = tri.IsEquilateral;
            //tri.a=6;  //읽기전용 참조 변수라 수정불가

            Console.WriteLine($"{perim}, {equi}");
            return tri;
        }

    }
}