using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//매개변수 갯수 다른거 오버로딩
namespace Chapter02_01
{
    class CMyClass
    {
        public int theStudentCount;
        public string theName;
        public int theGrade;
         
        public CMyClass()
        {
            theStudentCount = 20;
            theName = "NoName";
            theGrade = 0;
        }

        public CMyClass(int aGrade)
        {
            theStudentCount = 20;
            theName = "NoName";
            theGrade = aGrade;
        }

        public CMyClass(int aGrade, string aName) : this() //:this() -> 이게 생성자 잖아 생성자를 마치 상속받은 것 처럼 ....갱신되는 내용만 적으면 돼
            //매개변수 없는 생성자를 상속받는 것 처럼 this()를 쓰고 갱신된 내용만..
        {
            theName = aName;
            theGrade = aGrade;
        }

        public string GetName()
        {
            string res = string.Format("{0}학년 {1}, {2}명", theGrade, theName, theStudentCount);
            return (res);
        }
        public void Increase(int aValue) //5
        {
            aValue++;
        }
        public void Increase(ref int aValue) //5가 있는 주소를 넘겨서 그 값을 증가시키기 때문에 6이 되는고양 (마치 포인터와 같은...) ref가 없다면 5 5출력
        {
            aValue++;
        }

        public void MakeValue(out int aValue) //여기서 바꿨는데 main에서 19라고 출력된당. 교환할 때 쓰인대..
        {//out은 return 값과 비슷하다고 생각하면돼. 함수 안에서 19지만 main에서도 출력가능쓰 out에 관한 설명들이얌!
            aValue = 19;
        }

    }
}
