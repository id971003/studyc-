using System;
namespace projectstudy
{
    /// <summary>
    /// ??= 로 만약 null 이면 뒤에꺼 넣어라 가됨
    /// </summary>
    public class NullCoalescingAssignment
    {
        public void TA()
        {
            int? a = null;

            // (1) 널 병합 연산자
            int b = a ?? 1;

            // 위 문장 실행후: a = null, b = 1


            // (2) 널 병합 할당 연산자
            a ??= 100;

            // 위 문장 실행후: a = 100
        }
    }
}
