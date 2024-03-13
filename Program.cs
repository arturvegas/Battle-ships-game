using battleshipsgame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleshipsgame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.ShowMenu();
            ShootingShips game = new ShootingShips();
            Player player1 = new Player();
            game.PlayerName1 = game.getName();
            Console.Clear();
            game.createBoard();
            game.Move();
            Thread.Sleep(1000);
            Console.Clear();
            menu.NextPlayer();
            game.player = 2;
            Player player2 = new Player();
            menu.ShowMenu();
            game.PlayerName2 = game.getName();
            Console.Clear();
            game.Move();
            Thread.Sleep(1000);
            Console.Clear();
            game.Shooting();
        }
    }
}