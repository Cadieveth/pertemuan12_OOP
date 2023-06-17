using System;
using System.Collections.Generic;
using System.Text;

namespace Kasus_1
{
    class PlayerFighter: Player
    {
        public void Menebas()
        {
            Console.WriteLine("Player menebas");
        }

        public void Menebas(string specialAttack)
        {
            Console.WriteLine("menebas dengan " + specialAttack);
        }

        public void Memukul()
        {
            Console.WriteLine("Player memukul");
        }

        public void Memukul(string specialAttack)
        {
            Console.WriteLine("memukul dengan " + specialAttack);
        }
    }
}
