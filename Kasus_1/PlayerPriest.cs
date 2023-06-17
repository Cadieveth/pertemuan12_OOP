using System;
using System.Collections.Generic;
using System.Text;

namespace Kasus_1
{
    class PlayerPriest: Player
    {
        public void Bertahan()
        {
            Console.WriteLine("Player bertahan");
        }

        public void Bertahan(string specialAttack)
        {
            Console.WriteLine("Bertahan dengan " + specialAttack);
        }

        public void Healer()
        {
            Console.WriteLine("Player healing");
        }

        public void Healer(string specialAttack)
        {
            Console.WriteLine("Healing dengan " + specialAttack);
        }
    }
}
