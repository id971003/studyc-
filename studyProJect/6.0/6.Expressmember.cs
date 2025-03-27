
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace projectstudy
{
    //속성이나 메서드 간단하게 표현가능
    public static class ExpressMember
    {
        public static string FirstName;
        public static string LastName;
        

        public static string BeforeName()
        {
            return FirstName+""+LastName;
        }
        public static string NewName=>FirstName+""+LastName;
    }
}