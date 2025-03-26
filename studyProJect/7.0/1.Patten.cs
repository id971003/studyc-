using System;
using System.Collections.Generic;

namespace projectstudy
{
    public class Patten
    {
        /// <summary>
        /// Is 통해서 타입 비교가 가능함 기존 꺼에비에 좀 더 추가됨
        /// 클레스 객체 비교가능
        /// </summary>
        public void TA()
        {
            List<object> ta = new List<object>()
            {
                new Circle(5),
                new Square(1)
            };


            //before 
            foreach (var a in ta)
            {
                if (a is Circle)
                {
                    Circle cr = (Circle)a;
                    Console.WriteLine($"반지름{cr.Radius}짜리원임");
                }
                if (a is Circle)
                {
                    Square sq = (Square)a;
                    Console.WriteLine($"길이{sq.x}짜리사각형임");
                }
            }

            foreach (var a in ta)
            {
                if (a is Circle cr)
                {
                    //원이면 cr 에 객체를 반환 받음
                    Console.WriteLine($"반지름{cr.Radius}짜리원임");
                }
                else if (a is Square sq)
                {
                    //사각형이면 sq 에 반환받음
                    Console.WriteLine($"길이{sq.x}짜리사각형임");
                }
            }
            foreach (var a in ta)
            {
                //switch 도 원래 기본형 [int string bool ]만 쓸수있었는데 클레스 객체에서쓸수있음
                switch (a)
                {
                    case null:
                        break;
                    case Circle c:
                        Console.WriteLine($"반지름{c.Radius}짜리원임");
                        break;
                    case Square s:
                        Console.WriteLine($"길이{s.x}짜리사각형임");
                        break;
                }
            }
        }
    }

    public class Circle
    {
        public int Radius;
        public Circle(int radius)
        {
            this.Radius = radius;
        }
    }
    public class Square
    {
        public int x;
        public Square(int x)
        {
            this.x = x;
        }
    }


}


