using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace battleshipsgame
{
    internal class SettingShips : Player
    {
        public int top = 0;
        public int left = 0;
        public int right = 0;
        public int bottom = 0;
        public int positionValidation(int choosenPlace, int WhichBattleShip, string[] board)
        {
            int i = 0;
            int closeShip2 = 2;
            int closeShip3 = 0;
            int closeShip4 = 0;
            if (choosenPlace > 9)
            {
                closeShip2 = positionValidation2(choosenPlace - 10, board);
            }
            if (WhichBattleShip >= 3)
            {
                if (choosenPlace > 19)
                {
                    closeShip3 = positionValidation2(choosenPlace - 20, board);
                }
            }
            if (WhichBattleShip == 4)
            {
                if (choosenPlace > 29)
                {
                    closeShip4 = positionValidation2(choosenPlace - 30, board);
                }
            }
            if (choosenPlace != 2 && choosenPlace != 3 && choosenPlace != 4 && choosenPlace != 5 && choosenPlace != 6 && choosenPlace != 7 &&
                    choosenPlace != 8 && choosenPlace != 1 && choosenPlace != 0 && choosenPlace != 9 && board[choosenPlace - 10] != "---" && (closeShip2 == 1 || closeShip2 == 0))
            {
                if (WhichBattleShip == 2)
                {
                    Console.WriteLine("[1] góra");
                    top = 1;
                    i++;
                }
                if (choosenPlace != 12 && choosenPlace != 13 && choosenPlace != 14 && choosenPlace != 15 && choosenPlace != 16 && choosenPlace != 17 &&
                           choosenPlace != 18 && choosenPlace != 11 && choosenPlace != 10 && choosenPlace != 19 && board[choosenPlace - 20] != "---" && (closeShip2 == 1 || closeShip2 == 0)
                           && (closeShip3 == 1 || closeShip3 == 0))
                {
                    if (WhichBattleShip == 3)
                    {
                        Console.WriteLine("[1] góra");
                        top = 1;
                        i++;
                    }
                    if (WhichBattleShip == 4)
                    {
                        if (choosenPlace != 22 && choosenPlace != 23 && choosenPlace != 24 && choosenPlace != 25 && choosenPlace != 26 && choosenPlace != 27 &&
                                choosenPlace != 28 && choosenPlace != 21 && choosenPlace != 20 && choosenPlace != 29 && board[choosenPlace - 30] != "---" && (closeShip2 == 1 || closeShip2 == 0)
                                && (closeShip3 == 1 || closeShip3 == 0) && (closeShip4 == 1 || closeShip4 == 0))
                        {
                            Console.WriteLine("[1] góra");
                            top = 1;
                            i++;
                        }
                    }
                }
            }
            if (choosenPlace != 0 && choosenPlace != 90)
            {
                closeShip2 = positionValidation2(choosenPlace - 1, board);
            }
            if (WhichBattleShip >= 3)
            {
                if (choosenPlace != 0 && choosenPlace != 90 && choosenPlace != 91 && choosenPlace != 1)
                {
                    closeShip3 = positionValidation2(choosenPlace - 2, board);
                }
            }
            if (WhichBattleShip == 4)
            {
                if (choosenPlace != 0 && choosenPlace != 90 && choosenPlace != 91 && choosenPlace != 1 && choosenPlace != 93 && choosenPlace != 2)
                {
                    closeShip4 = positionValidation2(choosenPlace - 3, board);
                }
            }
            if (choosenPlace != 10 && choosenPlace != 20 && choosenPlace != 30 && choosenPlace != 40 && choosenPlace != 50 && choosenPlace != 60 &&
                    choosenPlace != 70 && choosenPlace != 80 && choosenPlace != 90 && choosenPlace != 0 && board[choosenPlace - 1] != "---" && (closeShip2 == 1 || closeShip2 == 0))
            {
                if (WhichBattleShip == 2)
                {
                    Console.WriteLine("[2] lewo");
                    left = 1;
                    i++;
                }
                if (choosenPlace != 11 && choosenPlace != 21 && choosenPlace != 31 && choosenPlace != 41 && choosenPlace != 51 && choosenPlace != 61 &&
                           choosenPlace != 71 && choosenPlace != 81 && choosenPlace != 91 && choosenPlace != 1 && board[choosenPlace - 2] != "---" && (closeShip2 == 1 || closeShip2 == 0)
                           && (closeShip3 == 1 || closeShip3 == 0))
                {
                    if (WhichBattleShip == 3)
                    {
                        Console.WriteLine("[2] lewo");
                        left = 1;
                        i++;
                    }
                    if (WhichBattleShip == 4)
                    {
                        if (choosenPlace != 12 && choosenPlace != 22 && choosenPlace != 32 && choosenPlace != 42 && choosenPlace != 52 && choosenPlace != 62 &&
                                choosenPlace != 72 && choosenPlace != 82 && choosenPlace != 92 && choosenPlace != 3 && board[choosenPlace - 3] != "---" && (closeShip2 == 1 || closeShip2 == 0)
                                && (closeShip3 == 1 || closeShip3 == 0) && (closeShip4 == 1 || closeShip4 == 0))
                        {
                            Console.WriteLine("[2] lewo");
                            left = 1;
                            i++;
                        }
                    }
                }
            }
            if (choosenPlace != 99 && choosenPlace != 9)
            {
                closeShip2 = positionValidation2(choosenPlace + 1, board);
            }
            if (WhichBattleShip >= 3)
            {
                if (choosenPlace != 99 && choosenPlace != 9 && choosenPlace != 8 && choosenPlace != 98)
                {
                    closeShip3 = positionValidation2(choosenPlace + 2, board);
                }
            }
            if (WhichBattleShip == 4)
            {
                if (choosenPlace != 99 && choosenPlace != 9 && choosenPlace != 8 && choosenPlace != 98 && choosenPlace != 7 && choosenPlace != 97)
                {
                    closeShip4 = positionValidation2(choosenPlace + 3, board);
                }
            }
            if (choosenPlace != 9 && choosenPlace != 19 && choosenPlace != 29 && choosenPlace != 39 && choosenPlace != 49 && choosenPlace != 59 &&
                    choosenPlace != 69 && choosenPlace != 79 && choosenPlace != 89 && choosenPlace != 99 && board[choosenPlace + 1] != "---" && (closeShip2 == 1 || closeShip2 == 0))
            {
                if (WhichBattleShip == 2)
                {
                    Console.WriteLine("[3] prawo");
                    right = 1;
                    i++;
                }
                if (choosenPlace != 8 && choosenPlace != 18 && choosenPlace != 28 && choosenPlace != 38 && choosenPlace != 48 && choosenPlace != 58 &&
                            choosenPlace != 68 && choosenPlace != 78 && choosenPlace != 88 && choosenPlace != 98 && board[choosenPlace + 2] != "---" && (closeShip2 == 1 || closeShip2 == 0)
                            && (closeShip3 == 1 || closeShip3 == 0))
                {
                    if (WhichBattleShip == 3)
                    {
                        Console.WriteLine("[3] prawo");
                        right = 1;
                        i++;
                    }
                    if (WhichBattleShip == 4)
                    {
                        if (choosenPlace != 7 && choosenPlace != 17 && choosenPlace != 27 && choosenPlace != 37 && choosenPlace != 47 && choosenPlace != 57 &&
                                choosenPlace != 67 && choosenPlace != 77 && choosenPlace != 87 && choosenPlace != 97 && board[choosenPlace + 3] != "---" && (closeShip2 == 1 || closeShip2 == 0)
                                && (closeShip3 == 1 || closeShip3 == 0) && (closeShip4 == 1 || closeShip4 == 0))
                        {
                            Console.WriteLine("[3] prawo");
                            right = 1;
                            i++;
                        }
                    }
                }
            }
            if (choosenPlace < 90)
            {
                closeShip2 = positionValidation2(choosenPlace + 10, board);
            }
            if (WhichBattleShip >= 3)
            {
                if (choosenPlace < 80)
                {
                    closeShip3 = positionValidation2(choosenPlace + 20, board);
                }
            }
            if (WhichBattleShip == 4)
            {
                if (choosenPlace < 70)
                {
                    closeShip4 = positionValidation2(choosenPlace + 30, board);
                }
            }
            if (choosenPlace != 90 && choosenPlace != 91 && choosenPlace != 92 && choosenPlace != 93 && choosenPlace != 94 && choosenPlace != 95 &&
                    choosenPlace != 96 && choosenPlace != 97 && choosenPlace != 98 && choosenPlace != 99 && board[choosenPlace + 10] != "---" && (closeShip2 == 1 || closeShip2 == 0))
            {
                if (WhichBattleShip == 2)
                {
                    Console.WriteLine("[4] dół");
                    bottom = 1;
                    i++;
                }
                if (choosenPlace != 80 && choosenPlace != 81 && choosenPlace != 82 && choosenPlace != 83 && choosenPlace != 84 && choosenPlace != 85 &&
                            choosenPlace != 86 && choosenPlace != 87 && choosenPlace != 88 && choosenPlace != 89 && board[choosenPlace + 20] != "---" && (closeShip2 == 1 || closeShip2 == 0)
                            && (closeShip3 == 1 || closeShip3 == 0))
                {
                    if (WhichBattleShip == 3)
                    {
                        Console.WriteLine("[4] dół");
                        bottom = 1;
                        i++;
                    }
                    if (WhichBattleShip == 4)
                    {
                        if (choosenPlace != 70 && choosenPlace != 71 && choosenPlace != 72 && choosenPlace != 73 && choosenPlace != 74 && choosenPlace != 75 &&
                                choosenPlace != 76 && choosenPlace != 77 && choosenPlace != 78 && choosenPlace != 79 && board[choosenPlace + 30] != "---" && (closeShip2 == 1 || closeShip2 == 0)
                                && (closeShip3 == 1 || closeShip3 == 0) && (closeShip4 == 1 || closeShip4 == 0))
                        {
                            Console.WriteLine("[4] dół");
                            bottom = 1;
                            i++;
                        }
                    }
                }
            }
            if (i == 0)
            {
                return 0;
            }
            return 1;
        }

        public int positionValidation2(int choosenPlace, string[] board)
        {
            if (board[choosenPlace] == "---")
            {
                return 2;
            }
            else
            {
                if (choosenPlace == 0)
                {
                    if ((board[choosenPlace + 1] != "---" && board[choosenPlace + 10] != "---" && board[choosenPlace + 11] != "---"))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                if (choosenPlace == 9)
                {
                    if ((board[choosenPlace - 1] != "---" && board[choosenPlace + 10] != "---" && board[choosenPlace - 9] != "---"))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                if (choosenPlace == 90)
                {
                    if ((board[choosenPlace + 1] != "---" && board[choosenPlace - 10] != "---" && board[choosenPlace - 9] != "---"))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                if (choosenPlace == 99)
                {
                    if ((board[choosenPlace - 1] != "---" && board[choosenPlace - 10] != "---" && board[choosenPlace - 11] != "---"))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                if (choosenPlace != 99 && choosenPlace != 90 && choosenPlace != 9 && choosenPlace != 0)
                {
                    if (choosenPlace != 10 && choosenPlace != 20 && choosenPlace != 30 && choosenPlace != 40 && choosenPlace != 50 && choosenPlace != 60 &&
                        choosenPlace != 70 && choosenPlace != 80 && choosenPlace != 90 && choosenPlace != 0)
                    {
                        if (choosenPlace != 9 && choosenPlace != 19 && choosenPlace != 29 && choosenPlace != 39 && choosenPlace != 49 && choosenPlace != 59 &&
                            choosenPlace != 69 && choosenPlace != 79 && choosenPlace != 89 && choosenPlace != 99)
                        {
                            if (choosenPlace != 90 && choosenPlace != 91 && choosenPlace != 92 && choosenPlace != 93 && choosenPlace != 94 && choosenPlace != 95 &&
                                choosenPlace != 96 && choosenPlace != 97 && choosenPlace != 98 && choosenPlace != 99)
                            {
                                if (choosenPlace != 2 && choosenPlace != 3 && choosenPlace != 4 && choosenPlace != 5 && choosenPlace != 6 && choosenPlace != 7 &&
                                    choosenPlace != 8 && choosenPlace != 1 && choosenPlace != 0 && choosenPlace != 9)
                                {
                                    if ((board[choosenPlace - 1] != "---" && board[choosenPlace - 10] != "---" && board[choosenPlace - 11] != "---" && board[choosenPlace - 9] != "---" &&
                                        board[choosenPlace + 1] != "---" && board[choosenPlace + 10] != "---" && board[choosenPlace + 11] != "---" && board[choosenPlace + 9] != "---"))
                                    {
                                        return 1;
                                    }
                                    else
                                    {
                                        return 2;
                                    }
                                }
                                else
                                {
                                    if ((board[choosenPlace + 10] != "---" && board[choosenPlace + 9] != "---" &&
                                    board[choosenPlace + 11] != "---" && board[choosenPlace + 1] != "---" && board[choosenPlace - 1] != "---"))
                                    {
                                        return 1;
                                    }
                                    else
                                    {
                                        return 2;
                                    }
                                }
                            }
                            else
                            {
                                if ((board[choosenPlace - 10] != "---" && board[choosenPlace - 9] != "---" &&
                                board[choosenPlace - 11] != "---" && board[choosenPlace + 1] != "---" && board[choosenPlace - 1] != "---"))
                                {
                                    return 1;
                                }
                                else
                                {
                                    return 2;
                                }
                            }
                        }
                        else
                        {
                            if ((board[choosenPlace - 10] != "---" && board[choosenPlace + 9] != "---" &&
                            board[choosenPlace - 1] != "---" && board[choosenPlace + 10] != "---" && board[choosenPlace - 11] != "---"))
                            {
                                return 1;
                            }
                            else
                            {
                                return 2;
                            }
                        }
                    }
                    else
                    {
                        if ((board[choosenPlace - 10] != "---" && board[choosenPlace - 9] != "---" &&
                            board[choosenPlace + 1] != "---" && board[choosenPlace + 10] != "---" && board[choosenPlace + 11] != "---"))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
                else
                {
                    return 0;
                }
            }
        }

        public void whichBoardShow()
        {
            if (player == 1)
            {
                ShowBoard(place);
            }
            else
            {
                ShowBoard(place2);
            }
        }

        public string[] whichBoard()
        {
            if (player == 1)
            {
                return place;
            }
            else
            {
                return place2;
            }
        }
        public string whichName()
        {
            if (player == 1)
            {
                return PlayerName1;
            }
            else
            {
                return PlayerName2;
            }
        }
        public void Move()
        {
            int closeShip = 0;
            int validPosition = 0;
            string[] board = whichBoard();
            string Name = whichName();
            //1 -----------------------------------------------------------------------------------
            for (int i = 0; i < 4;)
            {
                whichBoardShow();
                int choosenPlace = 0;
                Console.WriteLine("1-masztowce");
                Console.WriteLine("Gracz " + Name + " wybierz pole na którym chcesz postawić 1 masztowiec (0-99) " + i + "/4");
                for (int k = 0; k < 1;)
                {
                    choosenPlace = Convert.ToInt32(Console.ReadLine());
                    if (choosenPlace < 0 || choosenPlace > 99)
                    {
                        Console.WriteLine("Statek poza planszą!");
                    }
                    else
                    {
                        k++;
                    }
                }
                Console.Clear();
                closeShip = positionValidation2(choosenPlace, board);
                if (closeShip == 1 || closeShip == 0)
                {
                    Console.Clear();
                    board[choosenPlace] = "---";
                    i++;
                }
                else
                {
                    Console.WriteLine(" !! Podane miejsce jest niepoprawne !! ");
                }
            }
            //2 -----------------------------------------------------------------------------------
            whichBoardShow();
            for (int i = 0; i < 3;)
            {
                int choosenPlace = 0;
                Console.WriteLine("2-masztowce");
                Console.WriteLine("Gracz " + Name + " wybierz pole na którym chcesz postawić 2 masztowiec (0-99) " + i + "/3");
                for (int k = 0; k < 1;)
                {
                    choosenPlace = Convert.ToInt32(Console.ReadLine());
                    if (choosenPlace < 0 || choosenPlace > 99)
                    {
                        Console.WriteLine("Statek poza planszą!");
                    }
                    else
                    {
                        k++;
                    }
                }
                Console.Clear();
                closeShip = positionValidation2(choosenPlace, board);
                validPosition = positionValidation(choosenPlace, 2, board);
                if (validPosition != 0)
                {
                    if (closeShip == 1 || closeShip == 0)
                    {
                        board[choosenPlace] = "-0-";
                        whichBoardShow();
                        Console.WriteLine("Wybierz gdzie postawić drugą część statku: ");
                        for (int j = 0; j < 1;)
                        {
                            {
                                int choosenPlace2 = Convert.ToInt32(Console.ReadLine());
                                switch (choosenPlace2)
                                {
                                    case 1:
                                        if (top == 1)
                                        {
                                            Console.Clear();
                                            board[choosenPlace - 10] = "---";
                                            board[choosenPlace] = "---";
                                            whichBoardShow();
                                            i++;
                                            j++;
                                            top = 0; bottom = 0; right = 0; left = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wybierz poprawną opcję!");
                                            positionValidation(choosenPlace, 2, board);
                                            whichBoardShow();
                                            break;
                                        }
                                    case 2:
                                        if (left == 1)
                                        {
                                            Console.Clear();
                                            board[choosenPlace - 1] = "---";
                                            board[choosenPlace] = "---";
                                            whichBoardShow();
                                            i++;
                                            j++;
                                            top = 0; bottom = 0; right = 0; left = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wybierz poprawną opcję!");
                                            positionValidation(choosenPlace, 2, board);
                                            whichBoardShow();
                                            break;
                                        }
                                    case 3:
                                        if (right == 1)
                                        {
                                            Console.Clear();
                                            board[choosenPlace + 1] = "---";
                                            board[choosenPlace] = "---";
                                            whichBoardShow();
                                            i++;
                                            j++;
                                            top = 0; bottom = 0; right = 0; left = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wybierz poprawną opcję!");
                                            positionValidation(choosenPlace, 2, board);
                                            whichBoardShow();
                                            break;
                                        }
                                    case 4:
                                        if (bottom == 1)
                                        {
                                            Console.Clear();
                                            board[choosenPlace + 10] = "---";
                                            board[choosenPlace] = "---";
                                            whichBoardShow();
                                            i++;
                                            j++;
                                            top = 0; bottom = 0; right = 0; left = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wybierz poprawną opcję!");
                                            positionValidation(choosenPlace, 2, board);
                                            whichBoardShow();
                                            break;
                                        }
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("Wybierz poprawną opcję!");
                                        positionValidation(choosenPlace, 2, board);
                                        whichBoardShow();
                                        break;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(" !! Podane miejsce jest niepoprawne !! ");
                        whichBoardShow();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" !! Podane miejsce jest niepoprawne !! ");
                    whichBoardShow();
                    top = 0; bottom = 0; right = 0; left = 0;
                }
            }
            //3 -----------------------------------------------------------------------------------
            for (int i = 0; i < 2;)
            {
                int choosenPlace = 0;
                Console.WriteLine("3-masztowce");
                Console.WriteLine("Gracz " + Name + " wybierz pole na którym chcesz postawić 3 masztowiec (0-99) " + i + "/2");
                for (int k = 0; k < 1;)
                {
                    choosenPlace = Convert.ToInt32(Console.ReadLine());
                    if (choosenPlace < 0 || choosenPlace > 99)
                    {
                        Console.WriteLine("Statek poza planszą!");
                    }
                    else
                    {
                        k++;
                    }
                }
                Console.Clear();
                closeShip = positionValidation2(choosenPlace, board);
                validPosition = positionValidation(choosenPlace, 3, board);
                if (validPosition != 0)
                {
                    if (closeShip == 1 || closeShip == 0)
                    {
                        board[choosenPlace] = "-0-";
                        whichBoardShow();
                        Console.WriteLine("Wybierz gdzie postawić drugą część statku: ");
                        for (int j = 0; j < 1;)
                        {
                            {
                                int choosenPlace2 = Convert.ToInt32(Console.ReadLine());
                                switch (choosenPlace2)
                                {
                                    case 1:
                                        if (top == 1)
                                        {
                                            Console.Clear();
                                            board[choosenPlace - 10] = "---";
                                            board[choosenPlace - 20] = "---";
                                            board[choosenPlace] = "---";
                                            whichBoardShow();
                                            i++;
                                            j++;
                                            top = 0; bottom = 0; right = 0; left = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wybierz poprawną opcję!");
                                            positionValidation(choosenPlace, 3, board);
                                            whichBoardShow();
                                            break;
                                        }
                                    case 2:
                                        if (left == 1)
                                        {
                                            Console.Clear();
                                            board[choosenPlace - 1] = "---";
                                            board[choosenPlace - 2] = "---";
                                            board[choosenPlace] = "---";
                                            whichBoardShow();
                                            i++;
                                            j++;
                                            top = 0; bottom = 0; right = 0; left = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wybierz poprawną opcję!");
                                            positionValidation(choosenPlace, 3, board);
                                            whichBoardShow();
                                            break;
                                        }
                                    case 3:
                                        if (right == 1)
                                        {
                                            Console.Clear();
                                            board[choosenPlace + 1] = "---";
                                            board[choosenPlace + 2] = "---";
                                            board[choosenPlace] = "---";
                                            whichBoardShow();
                                            i++;
                                            j++;
                                            top = 0; bottom = 0; right = 0; left = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wybierz poprawną opcję!");
                                            positionValidation(choosenPlace, 3, board);
                                            whichBoardShow();
                                            break;
                                        }
                                    case 4:
                                        if (bottom == 1)
                                        {
                                            Console.Clear();
                                            board[choosenPlace + 10] = "---";
                                            board[choosenPlace + 20] = "---";
                                            board[choosenPlace] = "---";
                                            whichBoardShow();
                                            i++;
                                            j++;
                                            top = 0; bottom = 0; right = 0; left = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wybierz poprawną opcję!");
                                            positionValidation(choosenPlace, 3, board);
                                            whichBoardShow();
                                            break;
                                        }
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("Wybierz poprawną opcję!");
                                        positionValidation(choosenPlace, 3, board);
                                        whichBoardShow();
                                        break;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(" !! Podane miejsce jest niepoprawne !! ");
                        whichBoardShow();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" !! Podane miejsce jest niepoprawne !! ");
                    whichBoardShow();
                    top = 0; bottom = 0; right = 0; left = 0;
                }
            }
            //4 -----------------------------------------------------------------------------------
            for (int i = 0; i < 1;)
            {
                int choosenPlace = 0;
                Console.WriteLine("4-masztowce");
                Console.WriteLine("Gracz " + Name + " wybierz pole na którym chcesz postawić 4 masztowiec (0-99) " + i + "/1");
                for (int k = 0; k < 1;)
                {
                    choosenPlace = Convert.ToInt32(Console.ReadLine());
                    if (choosenPlace < 0 || choosenPlace > 99)
                    {
                        Console.WriteLine("Statek poza planszą!");
                    }
                    else
                    {
                        k++;
                    }
                }
                Console.Clear();
                closeShip = positionValidation2(choosenPlace, board);
                validPosition = positionValidation(choosenPlace, 4, board);
                if (validPosition != 0)
                {
                    if (closeShip == 1 || closeShip == 0)
                    {
                        board[choosenPlace] = "-0-";
                        whichBoardShow();
                        Console.WriteLine("Wybierz gdzie postawić drugą część statku: ");
                        for (int j = 0; j < 1;)
                        {
                            {
                                int choosenPlace2 = Convert.ToInt32(Console.ReadLine());
                                switch (choosenPlace2)
                                {
                                    case 1:
                                        if (top == 1)
                                        {
                                            Console.Clear();
                                            board[choosenPlace - 10] = "---";
                                            board[choosenPlace - 20] = "---";
                                            board[choosenPlace - 30] = "---";
                                            board[choosenPlace] = "---";
                                            whichBoardShow();
                                            i++;
                                            j++;
                                            top = 0; bottom = 0; right = 0; left = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wybierz poprawną opcję!");
                                            positionValidation(choosenPlace, 4, board);
                                            whichBoardShow();
                                            break;
                                        }
                                    case 2:
                                        if (left == 1)
                                        {
                                            Console.Clear();
                                            board[choosenPlace - 1] = "---";
                                            board[choosenPlace - 2] = "---";
                                            board[choosenPlace - 3] = "---";
                                            board[choosenPlace] = "---";
                                            whichBoardShow();
                                            i++;
                                            j++;
                                            top = 0; bottom = 0; right = 0; left = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wybierz poprawną opcję!");
                                            positionValidation(choosenPlace, 4, board);
                                            whichBoardShow();
                                            break;
                                        }
                                    case 3:
                                        if (right == 1)
                                        {
                                            Console.Clear();
                                            board[choosenPlace + 1] = "---";
                                            board[choosenPlace + 2] = "---";
                                            board[choosenPlace + 3] = "---";
                                            board[choosenPlace] = "---";
                                            whichBoardShow();
                                            i++;
                                            j++;
                                            top = 0; bottom = 0; right = 0; left = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wybierz poprawną opcję!");
                                            positionValidation(choosenPlace, 4, board);
                                            whichBoardShow();
                                            break;
                                        }
                                    case 4:
                                        if (bottom == 1)
                                        {
                                            Console.Clear();
                                            board[choosenPlace + 10] = "---";
                                            board[choosenPlace + 20] = "---";
                                            board[choosenPlace + 30] = "---";
                                            board[choosenPlace] = "---";
                                            whichBoardShow();
                                            i++;
                                            j++;
                                            top = 0; bottom = 0; right = 0; left = 0;
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Wybierz poprawną opcję!");
                                            positionValidation(choosenPlace, 4, board);
                                            whichBoardShow();
                                            break;
                                        }
                                    default:
                                        Console.Clear();
                                        Console.WriteLine("Wybierz poprawną opcję!");
                                        positionValidation(choosenPlace, 4, board);
                                        whichBoardShow();
                                        break;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(" !! Podane miejsce jest niepoprawne !! ");
                        whichBoardShow();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" !! Podane miejsce jest niepoprawne !! ");
                    whichBoardShow();
                    top = 0; bottom = 0; right = 0; left = 0;
                }
            }
        }
    }
}
