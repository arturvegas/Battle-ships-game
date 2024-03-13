using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleshipsgame
{
    internal class PlayerBoard : Menu
    {
        public string[] place = new string[100];
        public string[] place2 = new string[100];
        public string[] boardForShotting1 = new string[100];
        public string[] boardForShotting2 = new string[100];
        public void createBoard()
        {
            string iString;
            for (int i = 0; i < 100; i++)
            {
                if (i < 10)
                {
                    iString = " " + i.ToString() + " ";
                }
                else
                {
                    iString = " " + i.ToString();
                }
                place[i] = iString;
                place2[i] = iString;
                boardForShotting1[i] = iString;
                boardForShotting2[i] = iString;
            }
        }

        public void ShowBoard(string[] board)
        {
            Console.WriteLine("-----------------------------------------------------------");
            int a = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" " + board[0 + a] + " | " + board[1 + a] + " | " + board[2 + a] + " | " + board[3 + a] + " | " + board[4 + a] + " | " + board[5 + a] + " | " + board[6 + a] + " | " + board[7 + a] + " | " + board[8 + a] + " | " + board[9 + a] + " ");
                Console.WriteLine("-----------------------------------------------------------");
                a = a + 10;
            }
        }
    }
}
