using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePractice
{
    class Program
    {
        // delegate >> 형식은 형신인데, 함수 자체를 인자로 넘겨줌
        // 반환 : int, 입력 : void
        // OnClicked 이 delegate 형식의 이름
        delegate int OnClikced();

        static void ButtonPressed(OnClikced clickedFunction/*함수 자체를 인자로 넘겨주고*/)
        {
            // 함수 호출
            clickedFunction();
        }

        static int TestDelegate()
        {
            Console.WriteLine("");
            return 0;
        }

        static void Main(string[] args)
        {
            // delegate (대리자)
            Console.WriteLine();
        }
    }
}
