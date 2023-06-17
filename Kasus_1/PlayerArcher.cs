using System;
using System.Collections.Generic;
using System.Text;

namespace Kasus_1
{
    class PlayerArcher: Player
    {
        public void Memanah()
        {
            Console.WriteLine("Player memanah");
        }

        public void Membidik()
        {
            Console.WriteLine("Player membidik");
        }

        public void Membidik(string specialAttack)
        {
            Console.WriteLine("membidik kemudian " + specialAttack);
        }
    }
}
