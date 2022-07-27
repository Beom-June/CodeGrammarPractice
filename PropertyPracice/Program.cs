using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPracice
{
    class Program
    {
        // 객체지향 -> 은닉성 : 불필요한 정보를 외부로 노출 X
        class Knight
        {
            //protected int hp;
            //public int Hp
            //{
            //    get { return hp; }
            //    set { hp = value; }
            //}

            public int HP { get; set; }
            private int hp;
            // Getter Get 함수
            public int GetHp() { return hp; }
            // Setter Set 함수
            public void SetHp(int hp) { this.hp = hp; }
        }


        static void Main(string[] args)
        {
            // 프로퍼티
            Knight knight = new Knight();
            //knight.SetHp(100);
            knight.Hp = 100;

            int hp = knight.Hp;
        }
    }
}
