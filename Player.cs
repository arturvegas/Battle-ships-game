using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleshipsgame
{
    internal class Player : PlayerBoard
    {
        public int player = 1;
        public String PlayerName1, PlayerName2;
        Program makeMove = new Program();
        public String getName()
        {
            Console.WriteLine("Gracz " + player + " podaj swoje imię: ");
            return Console.ReadLine();
        }
    }
}
