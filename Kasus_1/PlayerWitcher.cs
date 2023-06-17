using System;
using System.Collections.Generic;
using System.Text;

namespace Kasus_1
{
    class PlayerWitcher: Player
    {
        public void ReaksiElemental()
        {
            Console.WriteLine("Player mengeluarkan Reaksi Elemental");
        }

        public void ReaksiElemental(string specialAttack)
        {
            Console.WriteLine("kemudian " + specialAttack);
        }
    }
}
