using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            CMyClass tmpMC1 = new CMyClass();
            Console.WriteLine(tmpMC1.GetName());


            Console.WriteLine(new CMyClass(1).GetName());
            Console.WriteLine(new CMyClass(3, "AAA").GetName());

            int a = 5;
            int b = 5; //초기화 해줘야해.
            tmpMC1.Increase(a);
            tmpMC1.Increase(ref b);

            Console.WriteLine(a);
            Console.WriteLine(b);

            int c; //out은 초기화 안해줘도 돼! 함수에서 줄거니까 근데 함수에서 안 주면 에러나용~
            tmpMC1.MakeValue(out c);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
