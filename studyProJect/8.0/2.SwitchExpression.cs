using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using studyProJect;
using static studyProJect.UsingStatic;

namespace projectstudy
{

    /// <summary>
    /// switch 문 간단하게 표현가능함
    /// </summary>
    public class SwitchExpression
    {
        public void TA()
        {
            List<object> targegtList = new List<object>()
        {
            new Circle(5),
            new Square(6),
        };
            foreach (var a in targegtList)
            {
                int Length = a switch
                {
                    Circle r => r.Radius,
                    Square s => s.x,
                    _ => 0
                };
                Console.WriteLine(Length);
            }


            //이렇게 속성 비교도 할수있음
            User user = new User(true,true);

            int fee = user switch
            {
                {IsChild : true} => 15,
                {IsChild : false , IsMan : true } => 20,
                {IsChild : false, IsMan : false} => 18,
                _ => 20
            };
            Console.WriteLine(fee);

        }

    }
    public class User
    {
        public bool IsMan;
        public bool IsChild;
        public User(bool isMan, bool IsChild)
        {
            this.IsMan=isMan;
            this.IsChild=IsChild;
        }
    }
}