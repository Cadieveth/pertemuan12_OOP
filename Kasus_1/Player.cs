using System;
using System.Collections.Generic;
using System.Text;

namespace Kasus_1
{
    class Player
    {
        private int _level;
        private int _nyawa;

        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public int Nyawa
        {
            get { return _nyawa; }
            set { _nyawa = value; }
        }

        public void Menyerang()
        {
            Console.WriteLine("Player menyerang");
        }

        public void Berlari()
        {
            Console.WriteLine("Player berlari");
        }

        public void Berjalan()
        {
            Console.WriteLine("Player berjalan");
        }
        
        public void Berenang()
        {
            Console.WriteLine("Player berenang");
        }

        public void Gugur()
        {
            Console.WriteLine("Player gugur");
        }
    }
}
