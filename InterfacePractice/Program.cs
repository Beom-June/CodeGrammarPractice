using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    class Program
    {
        // 추상 클래스
        abstract class Monster
        {
            // 개념적으로만 존재
            public abstract void Shout();
            //public virtual void Shout() { }

        }

        //abstract class Flyable
        interface IFlyable
        {
            //public abstract void Fly();
            void Fly();
        }

        class Orc : Monster
        {
            public override void Shout()
            {
                Console.WriteLine("Shout Orc");
            }
        }

        class FlyableOrc : Orc, IFlyable
        {
            // 인터페이스 구현해야 오류가 안뜸
            public void Fly()
            {

            }
        }

        class Skeleton : Monster
        {
            // 상속 없으면 에러
            public override void Shout()
            {
                Console.WriteLine("Shout Skeleton");
            }
        }

        static void DoFly(IFlyable flyable)
        {
            flyable.Fly();
        }

        static void Main(string[] args)
        {
            FlyableOrc orc = new FlyableOrc();
            DoFly(orc);
        }
    }
}
