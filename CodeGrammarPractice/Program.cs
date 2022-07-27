using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGrammarPractice
{
    class Program
    {
        // 일반화 클래스, 제네릭 클래스
        //class MyList<T> where T : Monster >> 조건 달기
        class MyList<T>
        {
            //object[] arr = new object[10];
            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return arr[i];
            }
        }
        class Monster
        {

        }

        static void Test<T>(T input)
        {

        }

        static void Main(string[] args)
        {
            MyList<int> myIntList = new MyList<int>();
            int item = myIntList.GetItem(0);

            MyList<short> myShortList = new MyList<short>();
            MyList<Monster> myMonsterList = new MyList<Monster>();
        }
    }
}
