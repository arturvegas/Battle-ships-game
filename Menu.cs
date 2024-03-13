using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleshipsgame
{
    internal class Menu
    {
        public void ShowMenu()
        {
            Console.WriteLine("============");
            Console.WriteLine("   STATKI   ");
            Console.WriteLine("============");
        }

        public void NextPlayer()
        {
            Console.WriteLine("Kliknij losowy przycisk jeżeli gracz się zmienił");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
