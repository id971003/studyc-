
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace projectstudy
{

    public static class AutoPropertyInit
    {
        public static class User
        {
            //프로퍼티 init 하면서 자동으로 기본값 설정가능
            public static string Name{get;set;} ="KIM";

            //일기전용 프로퍼티

            public static int Age{get;} =5;

            
        }
    }
}
