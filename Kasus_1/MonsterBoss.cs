using System;
using System.Collections.Generic;
using System.Text;

namespace Kasus_1
{
    class MonsterBoss: Monster
    {
        public void LimaBarNyawa()
        {
            Console.WriteLine("monster memiliki 5x Bar nyawa");
        }

        public void KillPlayer(string specialAttack)
        {
            Console.WriteLine("membunuh player dengan " + specialAttack);
        }
    }
}
