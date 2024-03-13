using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battleshipsgame
{
    internal class ShootingShips : SettingShips
    {
        int howManyShipsShotDown1 = 0;
        int howManyShipsShotDown2 = 0;
        Boolean AllShipSunk = false;
        Boolean ShotDown = true;
        int whichPlayer = 1;
        int shot;
        public void Shooting()
        {
            while (!AllShipSunk)
            {
                if (whichPlayer == 1)
                {
                    NextPlayer();
                    Console.WriteLine("Plansza do strzelania:");
                    ShowBoard(boardForShotting2);
                    Console.WriteLine("Twoja plansza:");
                    ShowBoard(place);
                    Boolean ShotDown = true;
                    while (ShotDown)
                    {
                        Console.WriteLine("Gracz " + PlayerName1 + " Wybierz gdzie strzelić (0-99)");
                        for (int i = 0; i < 1;)
                        {
                            for (int k = 0; k < 1;)
                            {
                                shot = Convert.ToInt32(Console.ReadLine());
                                if (shot < 0 || shot > 99)
                                {
                                    Console.WriteLine("Strzał poza planszą!");
                                }
                                else
                                {
                                    k++;
                                }
                            }
                            if (boardForShotting2[shot] != "-X-" && boardForShotting2[shot] != "O" + shot.ToString() && boardForShotting2[shot] != "OO" + shot.ToString())
                            {
                                i++;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Nie strzelaj w to samo miejsce!");
                                Console.WriteLine("Plansza do strzelania:");
                                ShowBoard(boardForShotting2);
                                Console.WriteLine("Twoja plansza:");
                                ShowBoard(place);
                                Console.WriteLine("Gracz " + PlayerName1 + " Wybierz gdzie strzelić (0-99)");
                            }
                        }
                        if (place2[shot] == "---")
                        {
                            Console.Clear();
                            Console.WriteLine("Hit!");
                            boardForShotting2[shot] = "-X-";
                            place2[shot] = "-X-";
                            int IsSunk = positionValidation2(shot, place2);
                            if (IsSunk == 1)
                            {
                                Console.WriteLine("Zatopiony!");
                            }
                            Console.WriteLine("Plansza do strzelania:");
                            ShowBoard(boardForShotting2);
                            Console.WriteLine("Twoja plansza:");
                            ShowBoard(place);
                            howManyShipsShotDown1++;
                            if (howManyShipsShotDown1 == 20)
                            {
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.WriteLine("Gracz " + PlayerName1 + " wygrywa HOORAYYYY!!!!");
                                AllShipSunk = true;
                                break;
                            }
                        }
                        else
                        {
                            if (shot < 10)
                            {
                                boardForShotting2[shot] = "-" + shot + "-";
                            }
                            else
                            {
                                boardForShotting2[shot] = "-" + shot;
                            }
                            Console.Clear();
                            Console.WriteLine("Nie trafiłeś!");
                            Console.WriteLine("Plansza do strzelania:");
                            ShowBoard(boardForShotting2);
                            Console.WriteLine("Twoja plansza:");
                            ShowBoard(place);
                            Thread.Sleep(1000);
                            Console.Clear();
                            ShotDown = false;
                            if (whichPlayer == 1)
                            {
                                whichPlayer = 2;
                            }
                            else
                            {
                                whichPlayer = 1;
                            }
                        }
                    }
                }
                else
                {
                    NextPlayer();
                    Console.WriteLine("Plansza do strzelania:");
                    ShowBoard(boardForShotting1);
                    Console.WriteLine("Twoja plansza:");
                    ShowBoard(place2);
                    Boolean ShotDown = true;
                    while (ShotDown)
                    {
                        Console.WriteLine("Gracz " + PlayerName2 + " Wybierz gdzie strzelić (0-99)");
                        for (int i = 0; i < 1;)
                        {
                            for (int k = 0; k < 1;)
                            {
                                shot = Convert.ToInt32(Console.ReadLine());
                                if (shot < 0 || shot > 99)
                                {
                                    Console.WriteLine("Strzał poza planszą!");
                                }
                                else
                                {
                                    k++;
                                }
                            }
                            if (boardForShotting1[shot] != "-X-" && boardForShotting1[shot] != "O" + shot.ToString() && boardForShotting1[shot] != "OO" + shot.ToString())
                            {
                                i++;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Nie strzelaj w to samo miejsce!");
                                Console.WriteLine("Plansza do strzelania:");
                                ShowBoard(boardForShotting1);
                                Console.WriteLine("Twoja plansza:");
                                ShowBoard(place2);
                                Console.WriteLine("Gracz " + PlayerName2 + " Wybierz gdzie strzelić (0-99)");
                            }
                        }
                        if (place[shot] == "---")
                        {
                            Console.Clear();
                            Console.WriteLine("Hit!");
                            boardForShotting1[shot] = "-X-";
                            place[shot] = "-X-";
                            int IsSunk = positionValidation2(shot, place);
                            if (IsSunk == 1)
                            {
                                Console.WriteLine("Zatopiony!");
                            }
                            Console.WriteLine("Plansza do strzelania:");
                            ShowBoard(boardForShotting1);
                            Console.WriteLine("Twoja plansza:");
                            ShowBoard(place2);
                            howManyShipsShotDown2++;
                            if (howManyShipsShotDown2 == 20)
                            {
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.WriteLine("Gracz " + PlayerName2 + " wygrywa HOORAYYYY!!!!");
                                AllShipSunk = true;
                                break;
                            }
                        }
                        else
                        {
                            if (shot < 10)
                            {
                                boardForShotting1[shot] = "-" + shot + "-";
                            }
                            else
                            {
                                boardForShotting1[shot] = "-" + shot;
                            }
                            Console.Clear();
                            Console.WriteLine("Nie trafiłeś!");
                            Console.WriteLine("Plansza do strzelania:");
                            ShowBoard(boardForShotting1);
                            Console.WriteLine("Twoja plansza:");
                            ShowBoard(place2);
                            Thread.Sleep(1000);
                            Console.Clear();
                            ShotDown = false;
                            if (whichPlayer == 1)
                            {
                                whichPlayer = 2;
                            }
                            else
                            {
                                whichPlayer = 1;
                            }
                        }
                    }
                }
            }
        }
    }
}
