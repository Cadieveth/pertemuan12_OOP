using System;
using System.Collections.Generic;
using System.Text;

namespace Kasus_1
{
    class Monster
    {
        private int _nyawa;

        public int Nyawa
        {
            get { return _nyawa; }
            set { _nyawa = value; }
        }

        public void Menyerang()
        {
            Console.WriteLine("Monster menyerang");
        }

        public void Terbang()
        {
            Console.WriteLine("Monster terbang");
        }

        public void Berjalan()
        {
            Console.WriteLine("Monster berjalan");
        }

        public void KillPlayer()
        {
            Console.WriteLine("Monster membunuh player");
        }

        public void Gugur()
        {
            Console.WriteLine("Monster gugur");
        }
    }
}
