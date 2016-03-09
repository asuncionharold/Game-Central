using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Midterm
{
    class Program
    {
        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< Bingo
        public static bool boom = true;
        public static string key;
        public static int[,] content1 = new int[100, 2];
        public static int[,] content2 = new int[100, 2];
        public static string[,] bingo1 = new string[5, 5];
        public static string[,] bingo2 = new string[5, 5];
        public static Random rand = new Random();
        public static Random rand1 = new Random();

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< Memory Game
        static int[,] content = new int[100, 2];
        static string[,] board = new string[4, 4];
        static string[,] copy = new string[4, 4];
        static Random rmemory = new Random();
        static int row = 0, col = 0, ctr = 0;
        static int fRow, fCol, sRow, sCol;

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< Millionaire
        static int count, q;
        static string ques1, ques2, ans1, ans2, ans3, ans4;

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< Wheel of Fortune
        public static bool playerAturn = true, playerBturn = false, loop = true;
        public static int TotalA = 0;
        public static int TotalB = 0;
        public static bool opt2 = true;
        public static string[] arr1 = { "S", "I", "T", "C", "H" };
        public static string[] correctAns = { "S", "T", "I", "T", "C", "H", "E", "S" };
        public static string[] alpha = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public static string[] solve = { "_", "T", "_", "_", "_", "_", "E", "S" };
        public static string PlayerA, PlayerB, Try;

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< Battleship
        static string[,] board1 = new String[8, 8];
        static string[,] board2 = new String[8, 8];
        static string[, ,] checkBoard = new String[8, 8, 1];
        static Random row1 = new Random();
        static Random col1 = new Random();
        static Random number = new Random();
        static int a = 0, b = 0, c = 0, score1 = 0, score2 = 0, ctr1 = 0;
        static bool finish = false, ps1 = false, ps2 = false;


        public static void Main()
        {
        BEGIN:
            Console.Clear();
            Game();

            CHOICE:
            Console.Clear();
            Console.Write("\n\n\t\t@@@@@@@@@@@@@@@ GAME CENTRAL @@@@@@@@@@@@@@@\n\n");
            Console.Write("\n\t\tWELCOME");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\n\t\t\t Game Central offers console ");
            Console.Write("\n\t\tapplication games, which you can enjoy with ");
            Console.Write("\n\t\tyour friends and family. Its main goal is ");
            Console.Write("\n\t\tfor enjoyment, stress reliever and a bit of ");
            Console.Write("\n\t\tchallenge for our brains. Have Fun!\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\t\t\t1. Wheel of Fortune ");
            Console.Write("\n\t\t\t2. Who Wants to be Millionaire ");
            Console.Write("\n\t\t\t3. Memory Game ");
            Console.Write("\n\t\t\t4. Bingo Card ");
            Console.Write("\n\t\t\t5. Battleship Game ");
            Console.Write("\n\n\t\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n\n");
            Console.Write("\t\t  Please enter the number of your choice: ");
                char choice = char.Parse(Console.ReadLine());

                if (choice == '1') 
                {
                    //Wheel of Fortune
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\t\t    +++++++ WHEEL OF FORTUNE +++++++");
                    Console.WriteLine("\n\t --------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n\tEnter Player 1 Name: ");
                    PlayerA = Console.ReadLine().ToUpper();
                    Console.Write("\n\tEnter Player 2 Name: ");
                    PlayerB = Console.ReadLine().ToUpper();
                    Console.Clear();

                    while (loop == true)
                    {

                        while (playerAturn == true)
                        {
                            opt2 = true;
                            header();

                            Console.WriteLine("\t\t\t\t{0}'s turn", PlayerA);

                            Console.Write("\n\n\tChoose your option 1) Spin/Guess 2)Vowel 3)Solve : ");
                            int Option = Convert.ToInt32(Console.ReadLine());

                            if (Option == 1)
                            {
                                SpinGuess();
                            }
                            else if (Option == 2)
                            {
                                BuyVowel();
                            }
                            else if (Option == 3)
                            {
                                Solve();
                            }

                            else
                            {
                                Console.WriteLine("\t**Please enter a correct option!**");
                            }

                        }

                        while (playerBturn == true)
                        {
                            opt2 = true;
                            header();

                            Console.WriteLine("\t\t\t\t{0}'s turn", PlayerB);

                            Console.Write("\n\n\tChoose your option 1) Spin/Guess 2)Vowel 3)Solve : ");
                            int Option = Convert.ToInt32(Console.ReadLine());

                            if (Option == 1)
                            {
                                SpinGuess1();
                            }
                            else if (Option == 2)
                            {
                                BuyVowel1();
                            }
                            else if (Option == 3)
                            {
                                Solve1();
                            }

                            else
                            {
                                Console.WriteLine("\t**Please enter a correct option!**");
                            }

                        }

                    }
                    Console.WriteLine("\tCongratulations!");
                    Console.WriteLine("\tPress any key to exit. . . . ");
                    Console.ReadLine();
                    //Wheel of Fortune END
                }
                else if (choice == '2') 
                {
                    //Who Wants to be Millionaire
                    bool cover = true;

                    do
                    {
                        Console.Clear();
                        Random r = new Random();
                        int[] questions = new int[6];
                        int prize = 0, a = 0, quesnumber, point = 0, money = 0;
                        const int maxNumbers = 7;
                        bool easy = true, medium = false, hard = false, checkans = false, EndGame = false, yesno = true;

                        do
                        {
                            List<int> numbers = new List<int>(maxNumbers);
                            for (int i = 1; i < maxNumbers; i++)
                            {
                                numbers.Add(i);
                            }

                            while (numbers.Count > 0)
                            {
                                int index = r.Next(numbers.Count);
                                questions[a] = numbers[index];
                                Console.Write("{0} ", numbers[index]);
                                numbers.RemoveAt(index);
                                a++;
                            }

                            /*
                             * Start of easy questions 
                             */

                            a = 0;
                            for (count = 1; count <= 6; count++)
                            {
                                Console.Clear();
                                quesnumber = questions[a];
                                switch (count)
                                {
                                    case 1: prize = 100; break;
                                    case 2: prize = 200; break;
                                    case 3: prize = 300; break;
                                    case 4: prize = 400; break;
                                    case 5: prize = 500; break;
                                    case 6: prize = 1000; break;
                                }
                                int qnumber = questions[a];

                                EasyQuestions(ref quesnumber, ref checkans); //start of questions

                                if (count == 6)
                                {
                                    Console.Write("\n\n\t\t\tCongratulations!");
                                    Console.Write("\n\t\t\tYou meet the first safe haven. You now have Php {0}", prize);
                                    Console.Write("\n\t\t\tYou will now move on to the next round...");
                                    Thread.Sleep(3000); //delay
                                    easy = false;
                                    medium = true;
                                }

                                if (checkans == true)
                                {
                                    point++;
                                }
                                else
                                {
                                    EndGame = true;
                                    easy = false;
                                    count = 7;
                                }
                                a++;
                            }

                        } while (easy == true);//end of easy while loop

                        while (medium == true)
                        {
                            a = 0;
                            List<int> numbers = new List<int>(maxNumbers);
                            for (int i = 1; i < maxNumbers; i++)
                            {
                                numbers.Add(i);
                            }
                            while (numbers.Count > 0)
                            {
                                int index = r.Next(numbers.Count);
                                questions[a] = numbers[index];
                                Console.Write("{0} ", numbers[index]);
                                numbers.RemoveAt(index);
                                a++;
                            }

                            a = 0;
                            for (count = 1; count <= 5; count++)
                            {
                                Console.Clear();
                                quesnumber = questions[a];
                                switch (count)
                                {
                                    case 1: prize = 2000; q = 7; break;
                                    case 2: prize = 5000; q = 8; break;
                                    case 3: prize = 8000; q = 9; break;
                                    case 4: prize = 16000; q = 10; break;
                                    case 5: prize = 32000; q = 11; break;
                                }
                                int qnumber = questions[a];

                                MediumQuestions(ref quesnumber, ref checkans);

                                if (count == 5)
                                {
                                    Console.Write("\n\n\t\t\tCongratulations!");
                                    Console.Write("\n\t\t\tYou meet the second safe haven. You now have Php {0}", prize);
                                    Console.Write("\n\t\t\tYou will now move on to the next round...");
                                    Thread.Sleep(3000); //delay
                                    easy = false;
                                    hard = true;
                                }
                                if (count > 1)
                                {
                                    while (yesno == true)
                                    {

                                        Console.Write("\n\t\t\tDo you want to continue or walk away with Php {0}? Y/N: ", prize);
                                        string yn = Console.ReadLine().ToLower();
                                        switch (yn)
                                        {
                                            case "y":
                                                yesno = false;

                                                break;
                                            case "n":
                                                medium = false;
                                                yesno = false;
                                                break;
                                            default:
                                                Console.WriteLine("\n\t\t\tMake sure you are entering Y or N");
                                                yesno = true;
                                                Thread.Sleep(1500); //delay
                                                break;
                                        }
                                    }
                                }

                                if (checkans == true)
                                {
                                    point++;
                                }
                                else
                                {
                                    EndGame = true;
                                    easy = false;
                                    count = 6;
                                }
                                a++;
                            }
                        } //end of medium while loop

                        while (hard == true)
                        {
                            a = 0;
                            List<int> numbers = new List<int>(maxNumbers);
                            for (int i = 1; i < maxNumbers; i++)
                            {
                                numbers.Add(i);
                            }
                            while (numbers.Count > 0)
                            {
                                int index = r.Next(numbers.Count);
                                questions[a] = numbers[index];
                                Console.Write("{0} ", numbers[index]);
                                numbers.RemoveAt(index);
                                a++;
                            }

                            a = 0;
                            for (count = 1; count <= 4; count++)
                            {
                                Console.Clear();
                                quesnumber = questions[a];
                                switch (count)
                                {
                                    case 1: prize = 64000; q = 12; break;
                                    case 2: prize = 250000; q = 13; break;
                                    case 3: prize = 500000; q = 14; break;
                                    case 4: prize = 1000000; q = 15; break;
                                }
                                int qnumber = questions[a];

                                HardQuestions(ref quesnumber, ref checkans);

                                if (count == 4)
                                {
                                    Console.Write("\n\n\t\t\tCongratulations!");
                                    Console.Write("\n\t\t\tYou meet the third safe haven.");
                                    Console.Write("\n\t\t\tYou will take home Php {0}", prize);
                                    easy = false;
                                    hard = true;
                                }
                                if (count > 1)
                                {
                                    while (yesno == true)
                                    {

                                        Console.Write("\n\t\t\tDo you want to continue or walk away with Php {0}? Y/N: ", prize);
                                        string yn = Console.ReadLine().ToLower();
                                        switch (yn)
                                        {
                                            case "y":
                                                yesno = false;
                                                break;
                                            case "n":
                                                medium = false;
                                                yesno = false;
                                                break;
                                            default:
                                                Console.WriteLine("\n\t\t\tMake sure you are entering Y or N");
                                                Thread.Sleep(1500); //delay
                                                yesno = true;
                                                break;
                                        }
                                    }
                                }

                                if (checkans == true)
                                {
                                    point++;
                                }
                                else
                                {
                                    EndGame = true;
                                    easy = false;
                                    count = 6;
                                }
                                a++;
                            }
                        } //end of hard while loop

                        do
                        {
                            switch (point)
                            {
                                case 1: money = 0; break;
                                case 2: money = 0; break;
                                case 3: money = 0; break;
                                case 4: money = 0; break;
                                case 5: money = 0; break;
                                case 6: money = 1000; break;
                                case 7: money = 2000; break;
                                case 8: money = 5000; break;
                                case 9: money = 8000; break;
                                case 10: money = 16000; break;
                                case 11: money = 32000; break;
                                case 12: money = 64000; break;
                                case 13: money = 250000; break;
                                case 14: money = 500000; break;
                                case 15: money = 1000000; break;
                            }

                            Console.Write("\n\t\t\tNice Try");
                            Console.Write("\n\t\t\tYou are walking away with: Php {0}", money);

                            Console.Write("\n\n\t\t\tDo you want to play again? Y/N: ");
                            string playagain = Console.ReadLine().ToLower();

                            switch (playagain)
                            {
                                case "y":
                                    EndGame = false;
                                    cover = true;
                                    break;
                                case "n":
                                    EndGame = false;
                                    cover = false;
                                    break;
                                default:
                                    Console.WriteLine("\n\t\t\tMake sure you are entering Y or N");
                                    break;
                            }
                        } while (EndGame == true);
                    } while (cover == true);

                    goto BEGIN;
                    //Who Wants to be Millionaire END
                }
                else if (choice == '3')
                {
                    //Memory Game
                    for (int a = 0; a < 100; a++)
                    {
                        int b = rmemory.Next(0, 4);
                        int c = rmemory.Next(0, 4);
                        content[a, 0] = b;
                        content[a, 1] = c;
                    }
                        BoardSet();
                        Board();
                        Flip();
                    //Memory Game END
                }
                else if (choice == '4')
                {
                    //Bingo Card
                    for (int a = 0; a < 100; a++)
                    {
                        int b = rand.Next(0, 5);
                        int c = rand.Next(0, 5);
                        int d = rand.Next(0, 5);
                        int e = rand.Next(0, 5);

                        string bee = b.ToString();
                        string cee = c.ToString();
                        content1[a, 0] = b;
                        content1[a, 1] = c;
                        content2[a, 0] = d;
                        content2[a, 1] = e;
                    }

                    while (boom)
                    {
                        int randnum = rand1.Next(1, 25);
                        string randomnum = randnum.ToString();

                        Console.Write("\n\n\t\t\t\tRANDOM NUMBER IS: {0}", randnum);
                        Console.Write("\n\t\t    *Press Enter to generate next random number");
                        Console.WriteLine("");

                        Console.WriteLine("");
                        bingocard1();
                        Console.WriteLine("");
                        bingocard2();

                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (bingo1[i, j] == randomnum)
                                {
                                    bingo1[i, j] = "X";
                                    Check();
                                }

                                if (bingo2[i, j] == randomnum)
                                {
                                    bingo2[i, j] = "X";
                                    Check();
                                }
                            }
                        }


                        key = Console.ReadKey().Key.ToString();
                        if (key == "")
                        {
                            boom = true;
                        }
                        Console.Clear();
                    }
                    //Bingo Card END
                }
                else if (choice == '5')
                {
                    //Battleship Game

                    Console.Clear();
                    if (finish == false)
                    {

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("\t     >>>>>>>>>>>>>>>>>>>> BATTLESHIP <<<<<<<<<<<<<<<<<<<<");
                        Console.WriteLine();
                        Console.WriteLine();
                        setBoard();
                        show();
                        play();
                    }
                    else if (finish == true)
                    {

                    }
                    Console.ReadKey(true);
                    //Bingo Card END
                }
                else
                {
                    Console.Write("\n\t\t Error!");
                    Console.Write("\n\t\t Please try again! Choose from numbers 1 to 5 only.");
                    Thread.Sleep(1500); //delay
                    goto CHOICE;
                }
            
        }

        public static void Game() 
        { 
            Console.Write("\n\n\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n\t\t  @@@@@@       @@@      @@@    @@@   @@@@@@@@@");
            Console.Write("\n\t\t @@           @@  @     @@ @  @ @@   @@");
            Console.Write("\n\t\t @@          @@    @    @@  @@  @@   @@@@@@");
            Console.Write("\n\t\t @@   @@@   @@@@@@@@@   @@  @@  @@   @@");
            Console.Write("\n\t\t @@    @@   @@     @@   @@      @@   @@");
            Console.Write("\n\t\t  @@@@@@    @@     @@   @@      @@   @@@@@@@@@\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\t\t@@@@@  @@@@@  @@   @  @@@@@@  @@@@@    @@@   @@");
            Console.Write("\n\t\t@@     @@     @@@  @    @@    @@   @  @@  @  @@");
            Console.Write("\n\t\t@@     @@@@   @@ @ @    @@    @@@@@   @@@@@  @@");
            Console.Write("\n\t\t@@     @@     @@  @@    @@    @@ @@   @@  @  @@");
            Console.Write("\n\t\t@@@@@  @@@@@  @@   @    @@    @@  @@  @@  @  @@@@@");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n\n");
            Console.Write("\t\t\t   Press enter to continue: ");
            Console.ReadLine();
        }

        /*==============================
         *==============================
         * MEMORY GAME
         * =============================
         * =============================*/

        public static void BoardSet()
        {
            //setting values for the board
            for (int a = 0; a < 8; a++)
            {
                for (int b = 0; b < 100; b++)
                {
                    if (board[content[b, 0], content[b, 1]] == null)
                    {
                        board[content[b, 0], content[b, 1]] = (a + 1).ToString();
                        break;
                    }
                    else
                        Console.Write("");
                }
            }

            for (int a = 0; a < 8; a++)
            {
                for (int b = 0; b < 100; b++)
                {
                    if (board[content[b, 0], content[b, 1]] == null)
                    {
                        board[content[b, 0], content[b, 1]] = (a + 1).ToString();
                        break;
                    }
                    else
                        Console.Write("");
                }
            }

            for (row = 0; row < 4; row++)
            {
                for (col = 0; col < 4; col++)
                {
                    copy[row, col] = "*";
                }
                Console.WriteLine();
            }
        }

        public static void Board()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                             1     2     3     4");
            Console.WriteLine("                           _____ _____ _____ _____");
            Console.WriteLine("                          |     |     |     |     |");
            Console.WriteLine("                        1 |  {0}  |  {1}  |  {2}  |  {3}  |", copy[0, 0], copy[1, 0], copy[2, 0], copy[3, 0]);
            Console.WriteLine("                          |_____|_____|_____|_____|");
            Console.WriteLine("                          |     |     |     |     |");
            Console.WriteLine("                        2 |  {0}  |  {1}  |  {2}  |  {3}  |", copy[0, 1], copy[1, 1], copy[2, 1], copy[3, 1]);
            Console.WriteLine("                          |_____|_____|_____|_____|");
            Console.WriteLine("                          |     |     |     |     |");
            Console.WriteLine("                        3 |  {0}  |  {1}  |  {2}  |  {3}  |", copy[0, 2], copy[1, 2], copy[2, 2], copy[3, 2]);
            Console.WriteLine("                          |_____|_____|_____|_____|");
            Console.WriteLine("                          |     |     |     |     |");
            Console.WriteLine("                        4 |  {0}  |  {1}  |  {2}  |  {3}  |", copy[0, 3], copy[1, 3], copy[2, 3], copy[3, 3]);
            Console.WriteLine("                          |_____|_____|_____|_____|");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void FlipComplete()
        {
            Console.Clear();
            Console.Write("\n\n\t\t@@@@@@@@@@@@@@@ MEMORY GAME @@@@@@@@@@@@@@@\n\n");
            Board();
            Console.Write("\n\t\t\t  Congratulations! ");
            Console.Write("\n\t\t\t  Puzzle completed! ");
            Console.ReadKey(true);
        }

        public static void Flip()
        {
        START:
            if (ctr == 16)
            {
                goto END;
            }

            /*
            * COLUMNS
            */

            GOBACK1:
            Console.Clear();
            Console.Write("\n\n\t\t@@@@@@@@@@@@@@@ MEMORY GAME @@@@@@@@@@@@@@@\n\n");
            Board();
            
            try
            {
                Console.Write("\n\t\t First Choice\n");
                Console.Write("\t\t Enter the row of your first card: ");
                fRow = int.Parse(Console.ReadLine());
                Console.Write("\t\t Enter the column of your first card: ");
                fCol = int.Parse(Console.ReadLine());

                if (copy[fRow - 1, fCol - 1] != "*")
                {
                    Console.Write("\n\t\t The tile is already flipped open.");
                    Console.Write("\n\t\t Please try again!");
                    Thread.Sleep(1500); //delay
                    goto GOBACK1;
                }

            }
            catch (Exception)
            {
               // Console.Write("\n\t\t Error occurred!");
               // Console.Write("\n\t\t Please try again!");
               // goto GOBACK1;

                if ((fRow > 4) || (fRow < 0))
                {
                    Console.Write("\n\t\t The row choosen is not of the given scope.");
                    Console.Write("\n\t\t Please try again!");
                    Thread.Sleep(1500); //delay
                    goto GOBACK1;
                }
                else if ((fCol > 4) || (fRow < 0))
                {
                    Console.Write("\n\t\t The column choosen is not of the given scope.");
                    Console.Write("\n\t\t Please try again!");
                    Thread.Sleep(1500); //delay
                    goto GOBACK1;
                }
                else 
                {
                    Console.Write("\n\t\t Invalid Input!");
                    Console.Write("\n\t\t Please try again!");
                    Thread.Sleep(1500); //delay
                    goto GOBACK1;
                }

            }

            copy[fRow - 1, fCol - 1] = board[fRow - 1, fCol - 1];
            Console.WriteLine("Card ({0},{1}) is: {2} ", fRow, fCol, copy[fRow - 1, fCol - 1]);

            /*
             * ROWS
             */

            GOBACK2:
            Console.Clear();
            Console.Write("\n\n\t\t@@@@@@@@@@@@@@@ MEMORY GAME @@@@@@@@@@@@@@@\n\n");
            Board();
        
            try
            {
                Console.Write("\n\t\t Second Choice\n");
                Console.Write("\t\t Enter the row of your second card: ");
                sRow = int.Parse(Console.ReadLine());
                Console.Write("\t\t Enter the column of your second card: ");
                sCol = int.Parse(Console.ReadLine());

                if (copy[sRow - 1, sCol - 1] != "*")
                {
                    Console.Write("\n\t\t The tile is already flipped open.");
                    Console.Write("\n\t\t Please try again!");
                    Thread.Sleep(1500); //delay
                    goto GOBACK2;
                }

                if ((sRow == fRow) && (sCol == fCol))
                {
                    Console.Write("\n\t\t The coordinates for the second card cannot be equal to the first.");
                    Console.Write("\n\t\t Please try again!");
                    Thread.Sleep(1500); //delay
                    goto GOBACK2;
                }

                
            }
            catch (Exception)
            {
                //Console.Write("\n\t\t Error occurred!");
                //Console.Write("\n\t\t Please try again!");
                //goto GOBACK2;

                if ((sRow > 4) || (sRow < 0))
                {
                    Console.Write("\n\t\t The row choosen is not of the given scope.");
                    Console.Write("\n\t\t Please try again!");
                    Thread.Sleep(1500); //delay
                    goto GOBACK2;
                }
                else if ((sCol > 4) || (sRow < 0))
                {
                    Console.Write("\n\t\t The column choosen is not of the given scope.");
                    Console.Write("\n\t\t Please try again!");
                    Thread.Sleep(1500); //delay
                    goto GOBACK2;
                }
                else
                {
                    Console.Write("\n\t\t Invalid Input!");
                    Console.Write("\n\t\t Please try again!");
                    Thread.Sleep(1500); //delay
                    goto GOBACK2;
                }
                
            }

            copy[sRow - 1, sCol - 1] = board[sRow - 1, sCol - 1];
            Console.WriteLine("Card ({0},{1}) is: {2}", fRow, fCol, copy[fRow - 1, fCol - 1]);

            Console.Clear();
            Console.Write("\n\n\t\t@@@@@@@@@@@@@@@ MEMORY GAME @@@@@@@@@@@@@@@\n\n");
            Board();

           
            if (copy[fRow - 1, fCol - 1] != copy[sRow - 1, sCol - 1])
            {
                Console.Write("\n\t\t\t Mismatch.");
                copy[fRow - 1, fCol - 1] = "*";
                copy[sRow - 1, sCol - 1] = "*";
                Thread.Sleep(2000);
                Console.Clear();
                Console.Write("\n\n\t\t@@@@@@@@@@@@@@@ MEMORY GAME @@@@@@@@@@@@@@@\n\n");
                Board();
            }
            else if (copy[fRow - 1, fCol - 1] == copy[sRow - 1, sCol - 1])
            {
                Console.Write("\n\t\t\t Correct Match.");
                ctr = ctr + 2;
                Thread.Sleep(2000);
                goto START;
            }
            goto START;
        END:

            FlipComplete();
        }

        /*==============================
         *==============================
         * WHO WANTS TO BE A MILLIONAIRE
         * =============================
         * =============================*/

        public static void BoardEasy()
        {
            Console.Clear();

            if (count == 1)
            {
                Console.Write("\n\n\t@@@@@@@@@@@@@@@ WHO WANTS TO BE A MILLIONAIRE @@@@@@@@@@@@@@@\n\n");
                Console.Write("\n\tEASY      |\t" + "Question #{0}", count);
                Console.Write("\n\tPrize     |\t");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\tPhp: 100  ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|\t" + ques1);
                Console.Write("\n\tPhp: 200  |\t" + ques2);
                Console.Write("\n\tPhp: 300  |\t\t" + ans1);
                Console.Write("\n\tPhp: 400  |\t\t" + ans2);
                Console.Write("\n\tPhp: 500  |\t\t" + ans3);
                Console.Write("\n\tPhp: 1000 |\t\t" + ans4 + "\n");
                Console.Write("\n\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
            }
            else if (count == 2)
            {
                Console.Write("\n\n\t@@@@@@@@@@@@@@@ WHO WANTS TO BE A MILLIONAIRE @@@@@@@@@@@@@@@\n\n");
                Console.Write("\n\tEASY      |\t" + "Question #{0}", count);
                Console.Write("\n\tPrize     |\t");
                Console.Write("\n\tPhp: 100  |\t" + ques1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\tPhp: 200  ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|\t" + ques2);
                Console.Write("\n\tPhp: 300  |\t\t" + ans1);
                Console.Write("\n\tPhp: 400  |\t\t" + ans2);
                Console.Write("\n\tPhp: 500  |\t\t" + ans3);
                Console.Write("\n\tPhp: 1000 |\t\t" + ans4 + "\n");
                Console.Write("\n\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
            }
            else if (count == 3)
            {
                Console.Write("\n\n\t@@@@@@@@@@@@@@@ WHO WANTS TO BE A MILLIONAIRE @@@@@@@@@@@@@@@\n\n");
                Console.Write("\n\tEASY      |\t" + "Question #{0}", count);
                Console.Write("\n\tPrize     |\t");
                Console.Write("\n\tPhp: 100  |\t" + ques1);
                Console.Write("\n\tPhp: 200  |\t" + ques2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\tPhp: 300  ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|\t\t" + ans1);
                Console.Write("\n\tPhp: 400  |\t\t" + ans2);
                Console.Write("\n\tPhp: 500  |\t\t" + ans3);
                Console.Write("\n\tPhp: 1000 |\t\t" + ans4 + "\n");
                Console.Write("\n\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
            }
            else if (count == 4)
            {
                Console.Write("\n\n\t@@@@@@@@@@@@@@@ WHO WANTS TO BE A MILLIONAIRE @@@@@@@@@@@@@@@\n\n");
                Console.Write("\n\tEASY      |\t" + "Question #{0}", count);
                Console.Write("\n\tPrize     |\t");
                Console.Write("\n\tPhp: 100  |\t" + ques1);
                Console.Write("\n\tPhp: 200  |\t" + ques2);
                Console.Write("\n\tPhp: 300  |\t\t" + ans1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\tPhp: 400  ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|\t\t" + ans2);
                Console.Write("\n\tPhp: 500  |\t\t" + ans3);
                Console.Write("\n\tPhp: 1000 |\t\t" + ans4 + "\n");
                Console.Write("\n\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
            }
            else if (count == 5)
            {
                Console.Write("\n\n\t@@@@@@@@@@@@@@@ WHO WANTS TO BE A MILLIONAIRE @@@@@@@@@@@@@@@\n\n");
                Console.Write("\n\tEASY      |\t" + "Question #{0}", count);
                Console.Write("\n\tPrize     |\t");
                Console.Write("\n\tPhp: 100  |\t" + ques1);
                Console.Write("\n\tPhp: 200  |\t" + ques2);
                Console.Write("\n\tPhp: 300  |\t\t" + ans1);
                Console.Write("\n\tPhp: 400  |\t\t" + ans2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\tPhp: 500  ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|\t\t" + ans3);
                Console.Write("\n\tPhp: 1000 |\t\t" + ans4 + "\n");
                Console.Write("\n\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
            }
            else
            {
                Console.Write("\n\n\t@@@@@@@@@@@@@@@ WHO WANTS TO BE A MILLIONAIRE @@@@@@@@@@@@@@@\n\n");
                Console.Write("\n\tEASY      |\t" + "Question #{0}", count);
                Console.Write("\n\tPrize     |\t");
                Console.Write("\n\tPhp: 100  |\t" + ques1);
                Console.Write("\n\tPhp: 200  |\t" + ques2);
                Console.Write("\n\tPhp: 300  |\t\t" + ans1);
                Console.Write("\n\tPhp: 400  |\t\t" + ans2);
                Console.Write("\n\tPhp: 500  |\t\t" + ans3);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\tPhp: 1000  ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|\t\t" + ans4 + "\n");
                Console.Write("\n\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
            }
        }

        public static void BoardMedium()
        {
            if (count == 1)
            {
                Console.Write("\n\n\t@@@@@@@@@@@@@@@ WHO WANTS TO BE A MILLIONAIRE @@@@@@@@@@@@@@@\n\n");
                Console.Write("\n\tMEDIUM    |\t" + "Question #{0}", q);
                Console.Write("\n\tPrize     |\t");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\tPhp: 2000 ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|\t" + ques1);
                Console.Write("\n\tPhp: 5000 |\t" + ques2);
                Console.Write("\n\tPhp: 8000 |\t\t" + ans1);
                Console.Write("\n\tPhp: 16000|\t\t" + ans2);
                Console.Write("\n\tPhp: 32000|\t\t" + ans3);
                Console.Write("\n\t          |\t\t" + ans4 + "\n");
                Console.Write("\n\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
            }
            else if (count == 2)
            {
                Console.Write("\n\n\t@@@@@@@@@@@@@@@ WHO WANTS TO BE A MILLIONAIRE @@@@@@@@@@@@@@@\n\n");
                Console.Write("\n\tMEDIUM    |\t" + "Question #{0}", q);
                Console.Write("\n\tPrize     |\t");
                Console.Write("\n\tPhp: 2000 |\t" + ques1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\tPhp: 5000 ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|\t" + ques2);
                Console.Write("\n\tPhp: 8000 |\t\t" + ans1);
                Console.Write("\n\tPhp: 16000|\t\t" + ans2);
                Console.Write("\n\tPhp: 32000|\t\t" + ans3);
                Console.Write("\n\t          |\t\t" + ans4 + "\n");
                Console.Write("\n\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
            }
            else if (count == 3)
            {
                Console.Write("\n\n\t@@@@@@@@@@@@@@@ WHO WANTS TO BE A MILLIONAIRE @@@@@@@@@@@@@@@\n\n");
                Console.Write("\n\tMEDIUM    |\t" + "Question #{0}", q);
                Console.Write("\n\tPrize     |\t");
                Console.Write("\n\tPhp: 2000 |\t" + ques1);
                Console.Write("\n\tPhp: 5000 |\t" + ques2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\tPhp: 8000 ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|\t\t" + ans1);
                Console.Write("\n\tPhp: 16000|\t\t" + ans2);
                Console.Write("\n\tPhp: 32000|\t\t" + ans3);
                Console.Write("\n\t          |\t\t" + ans4 + "\n");
                Console.Write("\n\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
            }
            else if (count == 4)
            {
                Console.Write("\n\n\t@@@@@@@@@@@@@@@ WHO WANTS TO BE A MILLIONAIRE @@@@@@@@@@@@@@@\n\n");
                Console.Write("\n\tMEDIUM    |\t" + "Question #{0}", q);
                Console.Write("\n\tPrize     |\t");
                Console.Write("\n\tPhp: 2000 |\t" + ques1);
                Console.Write("\n\tPhp: 5000 |\t" + ques2);
                Console.Write("\n\tPhp: 8000 |\t\t" + ans1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\tPhp: 16000");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|\t\t" + ans2);
                Console.Write("\n\tPhp: 32000|\t\t" + ans3);
                Console.Write("\n\t          |\t\t" + ans4 + "\n");
                Console.Write("\n\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
            }
            else
            {
                Console.Write("\n\n\t@@@@@@@@@@@@@@@ WHO WANTS TO BE A MILLIONAIRE @@@@@@@@@@@@@@@\n\n");
                Console.Write("\n\tMEDIUM    |\t" + "Question #{0}", q);
                Console.Write("\n\tPrize     |\t");
                Console.Write("\n\tPhp: 2000 |\t" + ques1);
                Console.Write("\n\tPhp: 5000 |\t" + ques2);
                Console.Write("\n\tPhp: 8000 |\t\t" + ans1);
                Console.Write("\n\tPhp: 16000|\t\t" + ans2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\tPhp: 32000");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|\t\t" + ans3);
                Console.Write("\n\t          |\t\t" + ans4 + "\n");
                Console.Write("\n\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
            }
        }

        public static void BoardHard()
        {
            if (count == 1)
            {
                Console.Write("\n\n\t@@@@@@@@@@@@@@@ WHO WANTS TO BE A MILLIONAIRE @@@@@@@@@@@@@@@\n\n");
                Console.Write("\n\tHARD      |\t" + "Question #{0}", q);
                Console.Write("\n\tPrize     |\t");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\tPhp: 64000");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|\t" + ques1);
                Console.Write("\n\tPhp:250000|\t" + ques2);
                Console.Write("\n\tPhp:500000|\t\t" + ans1);
                Console.Write("\n\tPhp:      |\t\t" + ans2);
                Console.Write("\n\t 1,000,000|\t\t" + ans3);
                Console.Write("\n\t          |\t\t" + ans4 + "\n");
                Console.Write("\n\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
            }
            else if (count == 2)
            {
                Console.Write("\n\n\t@@@@@@@@@@@@@@@ WHO WANTS TO BE A MILLIONAIRE @@@@@@@@@@@@@@@\n\n");
                Console.Write("\n\tHARD      |\t" + "Question #{0}", q);
                Console.Write("\n\tPrize     |\t");
                Console.Write("\n\tPhp: 64000|\t" + ques1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\tPhp:250000");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|\t" + ques2);
                Console.Write("\n\tPhp:500000|\t\t" + ans1);
                Console.Write("\n\tPhp:      |\t\t" + ans2);
                Console.Write("\n\t 1,000,000|\t\t" + ans3);
                Console.Write("\n\t          |\t\t" + ans4 + "\n");
                Console.Write("\n\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
            }
            else if (count == 3)
            {
                Console.Write("\n\n\t@@@@@@@@@@@@@@@ WHO WANTS TO BE A MILLIONAIRE @@@@@@@@@@@@@@@\n\n");
                Console.Write("\n\tHARD      |\t" + "Question #{0}", q);
                Console.Write("\n\tPrize     |\t");
                Console.Write("\n\tPhp: 64000|\t" + ques1);
                Console.Write("\n\tPhp:250000|\t" + ques2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\tPhp:500000");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|\t\t" + ans1);
                Console.Write("\n\tPhp:      |\t\t" + ans2);
                Console.Write("\n\t 1,000,000|\t\t" + ans3);
                Console.Write("\n\t          |\t\t" + ans4 + "\n");
                Console.Write("\n\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
            }
            else
            {
                Console.Write("\n\n\t@@@@@@@@@@@@@@@ WHO WANTS TO BE A MILLIONAIRE @@@@@@@@@@@@@@@\n\n");
                Console.Write("\n\tHARD      |\t" + "Question #{0}", q);
                Console.Write("\n\tPrize     |\t");
                Console.Write("\n\tPhp: 64000|\t" + ques1);
                Console.Write("\n\tPhp:250000|\t" + ques2);
                Console.Write("\n\tPhp:500000|\t\t" + ans1);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\tPhp:      ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|\t\t" + ans2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\n\t 1,000,000");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("|\t\t" + ans3);
                Console.Write("\n\t          |\t\t" + ans4 + "\n");
                Console.Write("\n\t@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@\n");
            }
        }

        public static void EasyQuestions(ref int x, ref bool checkans)
        {
            bool q1 = true, q2 = true, q3 = true, q4 = true, q5 = true, q6 = true;
            switch (x)
            {
                case 1:
                    {
                        while (q1 == true)
                        {
                        ENTER:
                            ques1 = "In the 'Road Runner and Coyote' cartoons, what";
                            ques2 = "what famous sound does the Road Runner make?";
                            ans1 = "a: Ping! Ping!";
                            ans2 = "b: Beep! Beep!";
                            ans3 = "c: Aoooga! Aoooga!";
                            ans4 = "d: Vroom! Vroom!";
                            BoardEasy();
                            Console.Write("\n\t\t\tEnter the letter of your choice: ");
                            string inptY = Console.ReadLine();
                            switch (inptY)
                            {
                                case "a":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q1 = false;
                                    checkans = false;
                                    break;
                                case "b":
                                    Console.WriteLine("\n\t\t\tCorrect");
                                    q1 = false;
                                    checkans = true;
                                    break;
                                case "c":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q1 = false;
                                    checkans = false;
                                    break;
                                case "d":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q1 = false;
                                    checkans = false;
                                    break;
                                default:
                                    Console.WriteLine("\n\t\t\tChoose the letter of the correct answer");
                                    Thread.Sleep(1500); //delay
                                    q1 = true;
                                    goto ENTER;
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        while (q2 == true)
                        {
                        ENTER:
                            ques1 = "Where should choking victims place their hands";
                            ques2 = "to indicate to others that they need help?";
                            ans1 = "a: Over the Eyes";
                            ans2 = "b: On the Knees";
                            ans3 = "c: Around the Throat";
                            ans4 = "d: On the Hips";
                            BoardEasy();
                            Console.Write("\n\t\t\tEnter the letter of your choice: ");
                            string inptY = Console.ReadLine();
                            switch (inptY)
                            {
                                case "a":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q2 = false;
                                    checkans = false;
                                    break;
                                case "b":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q2 = false;
                                    checkans = false;
                                    break;
                                case "c":
                                    Console.WriteLine("\n\t\t\tCorrect");
                                    q2 = false;
                                    checkans = true;
                                    break;
                                case "d":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q2 = false;
                                    checkans = false;
                                    break;
                                default:
                                    Console.WriteLine("\n\t\t\tChoose the letter of the correct answer");
                                    Thread.Sleep(1500); //delay
                                    q2 = true;
                                    goto ENTER;
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        while (q3 == true)
                        {
                        ENTER:
                            ques1 = "Which of these dance names is used to describe";
                            ques2 = "a fashionable dot?";
                            ans1 = "a: Hora";
                            ans2 = "b: Swing";
                            ans3 = "c: Lambada";
                            ans4 = "d: Polka";
                            BoardEasy();
                            Console.Write("\n\t\t\tEnter the letter of your choice: ");
                            string inptY = Console.ReadLine();
                            switch (inptY)
                            {
                                case "a":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q3 = false;
                                    checkans = false;
                                    break;
                                case "b":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q3 = false;
                                    checkans = false;
                                    break;
                                case "c":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q3 = false;
                                    checkans = false;
                                    break;
                                case "d":
                                    Console.WriteLine("\n\t\t\tCorrect");
                                    q3 = false;
                                    checkans = true;
                                    break;
                                default:
                                    Console.WriteLine("\n\t\t\tChoose the letter of the correct answer");
                                    Thread.Sleep(1500); //delay
                                    q3 = true;
                                    goto ENTER;
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        while (q4 == true)
                        {
                        ENTER:
                            ques1 = "In what language would you say 'ello-hay' to";
                            ques2 = "greet your friends?";
                            ans1 = "a: Bull Latin";
                            ans2 = "b: Dog Latin";
                            ans3 = "c: Duck Latin";
                            ans4 = "d: Pig Latin";
                            BoardEasy();
                            Console.Write("\n\t\t\tEnter the letter of your choice: ");
                            string inptY = Console.ReadLine();
                            switch (inptY)
                            {
                                case "a":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q4 = false;
                                    checkans = false;
                                    break;
                                case "b":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q4 = false;
                                    checkans = false;
                                    break;
                                case "c":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q4 = false;
                                    checkans = false;
                                    break;
                                case "d":
                                    Console.WriteLine("\n\t\t\tCorrect");
                                    q4 = false;
                                    checkans = true;
                                    break;
                                default:
                                    Console.WriteLine("\n\t\t\tChoose the letter of the correct answer");
                                    Thread.Sleep(1500); //delay
                                    q4 = true;
                                    goto ENTER;
                            }
                        }
                        break;
                    }
                case 5:
                    {
                        while (q5 == true)
                        {
                        ENTER:
                            ques1 = "What part of chicken is commonly called the";
                            ques2 = "'drumstick'?";
                            ans1 = "a: Breast";
                            ans2 = "b: Wing";
                            ans3 = "c: Leg";
                            ans4 = "d: Gizzard";
                            BoardEasy();
                            Console.Write("\n\t\t\tEnter the letter of your choice: ");
                            string inptY = Console.ReadLine();
                            switch (inptY)
                            {
                                case "a":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q5 = false;
                                    checkans = false;
                                    break;
                                case "b":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q5 = false;
                                    checkans = false;
                                    break;
                                case "c":
                                    Console.WriteLine("\n\t\t\tCorrect");
                                    q5 = false;
                                    checkans = true;
                                    break;
                                case "d":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q5 = false;
                                    checkans = false;
                                    break;
                                default:
                                    Console.WriteLine("\n\t\t\tChoose the letter of the correct answer");
                                    Thread.Sleep(1500); //delay
                                    q5 = true;
                                    goto ENTER;
                            }
                        }
                        break;
                    }
                case 6:
                    {
                        while (q6 == true)
                        {
                        ENTER:
                            ques1 = "What is the only position on a football team";
                            ques2 = "that can be 'sacked'?";
                            ans1 = "a: Center";
                            ans2 = "b: Wide Receiver";
                            ans3 = "c: Tight End";
                            ans4 = "d: Quarter Back";
                            BoardEasy();
                            Console.Write("\n\t\t\tEnter the letter of your choice: ");
                            string inptY = Console.ReadLine();
                            switch (inptY)
                            {
                                case "a":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q6 = false;
                                    checkans = false;
                                    break;
                                case "b":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q6 = false;
                                    checkans = false;
                                    break;
                                case "c":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q6 = false;
                                    checkans = false;
                                    break;
                                case "d":
                                    Console.WriteLine("\n\t\t\tCorrect");
                                    q6 = false;
                                    checkans = true;
                                    break;
                                default:
                                    Console.WriteLine("\n\t\t\tChoose the letter of the correct answer");
                                    Thread.Sleep(1500); //delay
                                    q6 = true;
                                    goto ENTER;
                            }
                        }
                        break;
                    }
            }
        }

        public static void MediumQuestions(ref int x, ref bool checkans)
        {
            bool q1 = true, q2 = true, q3 = true, q4 = true, q5 = true;
            switch (x)
            {
                case 1:
                    {
                        while (q1 == true)
                        {
                        ENTER:
                            ques1 = "Canada's most densely populated province is:";
                            ques2 = "";
                            ans1 = "a: Ontario";
                            ans2 = "b: Quebec";
                            ans3 = "c: Saskatchewan";
                            ans4 = "d: Prince Edward Island";
                            BoardMedium();
                            Console.Write("\n\t\t\tEnter the letter of your choice: ");
                            string inptY = Console.ReadLine();
                            switch (inptY)
                            {
                                case "a":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q1 = false;
                                    checkans = false;
                                    break;
                                case "b":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q1 = false;
                                    checkans = true;
                                    break;
                                case "c":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q1 = false;
                                    checkans = false;
                                    break;
                                case "d":
                                    Console.WriteLine("\n\t\t\tCorrect");
                                    q1 = false;
                                    checkans = false;
                                    break;
                                default:
                                    Console.WriteLine("\n\t\t\tChoose the letter of the correct answer");
                                    Thread.Sleep(1500); //delay
                                    q1 = true;
                                    goto ENTER;
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        while (q2 == true)
                        {
                        ENTER:
                            ques1 = "Whom does the governor general of Canada";
                            ques2 = "represent at the federal level";
                            ans1 = "a: The Prime Minister";
                            ans2 = "b: The Queen of Canada";
                            ans3 = "c: The Chief of Staff";
                            ans4 = "d: The Deputy Minister";
                            BoardMedium();
                            Console.Write("\n\t\t\tEnter the letter of your choice: ");
                            string inptY = Console.ReadLine();
                            switch (inptY)
                            {
                                case "a":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q2 = false;
                                    checkans = false;
                                    break;
                                case "b":
                                    Console.WriteLine("\n\t\t\tCorrect");
                                    q2 = false;
                                    checkans = false;
                                    break;
                                case "c":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q2 = false;
                                    checkans = true;
                                    break;
                                case "d":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q2 = false;
                                    checkans = false;
                                    break;
                                default:
                                    Console.WriteLine("\n\t\t\tChoose the letter of the correct answer");
                                    Thread.Sleep(1500); //delay
                                    q2 = true;
                                    goto ENTER;
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        while (q3 == true)
                        {
                        ENTER:
                            ques1 = "Where are the highest tides in the world?";
                            ques2 = "";
                            ans1 = "a: Hudson's Bay";
                            ans2 = "b: The Bay of Fundy";
                            ans3 = "c: James Bay";
                            ans4 = "d: Cowichan Bay";
                            BoardMedium();
                            Console.Write("\n\t\t\tEnter the letter of your choice: ");
                            string inptY = Console.ReadLine();
                            switch (inptY)
                            {
                                case "a":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q3 = false;
                                    checkans = false;
                                    break;
                                case "b":
                                    Console.WriteLine("\n\t\t\tCorrect");
                                    q3 = false;
                                    checkans = false;
                                    break;
                                case "c":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q3 = false;
                                    checkans = false;
                                    break;
                                case "d":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q3 = false;
                                    checkans = true;
                                    break;
                                default:
                                    Console.WriteLine("\n\t\t\tChoose the letter of the correct answer");
                                    Thread.Sleep(1500); //delay
                                    q3 = true;
                                    goto ENTER;
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        while (q4 == true)
                        {
                        ENTER:
                            ques1 = "What is the only officially bilingual province";
                            ques2 = "in Canada?";
                            ans1 = "a: Ontario";
                            ans2 = "b: Quebec";
                            ans3 = "c: Alberta";
                            ans4 = "d: New Brunswick";
                            BoardMedium();
                            Console.Write("\n\t\t\tEnter the letter of your choice: ");
                            string inptY = Console.ReadLine();
                            switch (inptY)
                            {
                                case "a":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q4 = false;
                                    checkans = false;
                                    break;
                                case "b":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q4 = false;
                                    checkans = false;
                                    break;
                                case "c":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q4 = false;
                                    checkans = false;
                                    break;
                                case "d":
                                    Console.WriteLine("\n\t\t\tCorrect");
                                    q4 = false;
                                    checkans = true;
                                    break;
                                default:
                                    Console.WriteLine("\n\t\t\tChoose the letter of the correct answer");
                                    Thread.Sleep(1500); //delay
                                    q4 = true;
                                    goto ENTER;
                            }
                        }
                        break;
                    }
                case 5:
                    {
                        while (q5 == true)
                        {
                        ENTER:
                            ques1 = "What famous sea creature in the Okanagan Lake";
                            ques2 = "of British Columbia was called";
                            ans1 = "a: Manopogo";
                            ans2 = "b: Okanaganaka";
                            ans3 = "c: Ogopogo";
                            ans4 = "d: Champ";
                            BoardMedium();
                            Console.Write("\n\t\t\tEnter the letter of your choice: ");
                            string inptY = Console.ReadLine();
                            switch (inptY)
                            {
                                case "a":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q5 = false;
                                    checkans = false;
                                    break;
                                case "b":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q5 = false;
                                    checkans = false;
                                    break;
                                case "c":
                                    Console.WriteLine("\n\t\t\tCorrect");
                                    q5 = false;
                                    checkans = true;
                                    break;
                                case "d":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q5 = false;
                                    checkans = false;
                                    break;
                                default:
                                    Console.WriteLine("\n\t\t\tChoose the letter of the correct answer");
                                    Thread.Sleep(1500); //delay
                                    q5 = true;
                                    goto ENTER;
                            }
                        }
                        break;
                    }

            }
        }
        public static void HardQuestions(ref int x, ref bool checkans)
        {
            bool q1 = true, q2 = true, q3 = true, q4 = true;
            switch (x)
            {
                case 1:
                    {
                        while (q1 == true)
                        {
                        ENTER:
                            ques1 = "Canada's most densely populated province is:";
                            ques2 = "";
                            ans1 = "a: Ontario";
                            ans2 = "b: Quebec";
                            ans3 = "c: Saskatchewan";
                            ans4 = "d: Prince Edward Island";
                            BoardHard();
                            Console.Write("\n\t\t\tEnter the letter of your choice: ");
                            string inptY = Console.ReadLine();
                            switch (inptY)
                            {

                                case "a":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q1 = false;
                                    checkans = false;
                                    break;
                                case "b":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q1 = false;
                                    checkans = true;
                                    break;
                                case "c":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q1 = false;
                                    checkans = false;
                                    break;
                                case "d":
                                    Console.WriteLine("\n\t\t\tCorrect");
                                    q1 = false;
                                    checkans = false;
                                    break;
                                default:
                                    Console.WriteLine("\n\t\t\tChoose the letter of the correct answer");
                                    Thread.Sleep(1500); //delay
                                    q1 = true;
                                    goto ENTER;
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        while (q2 == true)
                        {
                        ENTER:
                            ques1 = "Whom does the governor general of Canada";
                            ques2 = "represent at the federal level";
                            ans1 = "a: The Prime Minister";
                            ans2 = "b: The Queen of Canada";
                            ans3 = "c: The Chief of Staff";
                            ans4 = "d: The Deputy Minister";
                            BoardHard();
                            Console.Write("\n\t\t\tEnter the letter of your choice: ");
                            string inptY = Console.ReadLine();
                            switch (inptY)
                            {
                                case "a":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q2 = false;
                                    checkans = false;
                                    break;
                                case "b":
                                    Console.WriteLine("\n\t\t\tCorrect");
                                    q2 = false;
                                    checkans = false;
                                    break;
                                case "c":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q2 = false;
                                    checkans = true;
                                    break;
                                case "d":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q2 = false;
                                    checkans = false;
                                    break;
                                default:
                                    Console.WriteLine("\n\t\t\tChoose the letter of the correct answer");
                                    Thread.Sleep(1500); //delay
                                    q2 = true;
                                    goto ENTER;
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        while (q3 == true)
                        {
                        ENTER:
                            ques1 = "Where are the highest tides in the world?";
                            ques2 = "";
                            ans1 = "a: Hudson's Bay";
                            ans2 = "b: The Bay of Fundy";
                            ans3 = "c: James Bay";
                            ans4 = "d: Cowichan Bay";
                            BoardHard();
                            Console.Write("\n\t\t\tEnter the letter of your choice: ");
                            string inptY = Console.ReadLine();
                            switch (inptY)
                            {
                                case "a":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q3 = false;
                                    checkans = false;
                                    break;
                                case "b":
                                    Console.WriteLine("\n\t\t\tCorrect");
                                    q3 = false;
                                    checkans = false;
                                    break;
                                case "c":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q3 = false;
                                    checkans = false;
                                    break;
                                case "d":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q3 = false;
                                    checkans = true;
                                    break;
                                default:
                                    Console.WriteLine("\n\t\t\tChoose the letter of the correct answer");
                                    Thread.Sleep(1500); //delay
                                    q3 = true;
                                    goto ENTER;
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        while (q4 == true)
                        {
                        ENTER:
                            ques1 = "Canada's most densely populated province is:";
                            ques2 = "";
                            ans1 = "a: Ontario";
                            ans2 = "b: Quebec";
                            ans3 = "c: Saskatchewan";
                            ans4 = "d: Prince Edward Island";
                            BoardHard();
                            Console.Write("\n\t\t\tEnter the letter of your choice: ");
                            string inptY = Console.ReadLine();
                            switch (inptY)
                            {
                                case "a":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q4 = false;
                                    checkans = false;
                                    break;
                                case "b":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q4 = false;
                                    checkans = false;
                                    break;
                                case "c":
                                    Console.WriteLine("\n\t\t\tWrong");
                                    q4 = false;
                                    checkans = false;
                                    break;
                                case "d":
                                    Console.WriteLine("\n\t\t\tCorrect");
                                    q4 = false;
                                    checkans = true;
                                    break;
                                default:
                                    Console.WriteLine("\n\t\t\tChoose the letter of the correct answer");
                                    Thread.Sleep(1500); //delay
                                    q4 = true;
                                    goto ENTER;
                            }
                        }
                        break;
                    }
            }
        }

        /*==============================
        *==============================
        * WHEEL OF FORTUNE
        * =============================
        * =============================*/

        public static void SpinGuess()
        {
            int[] arrWheel = new int[] { 300, 400, 500, 600, 700, 800, 900, 5000, 1, 2 };
            Random ran = new Random();
            int Rndom = arrWheel[ran.Next(0, arrWheel.Length)];

            if (Rndom == 1)
            {
                Console.WriteLine("\tWheel space contains: BANKRUPT! ");
                Console.WriteLine("\t{0}'s total money will become zero", PlayerA);
                TotalA = 0;
                playerAturn = false;
                playerBturn = true;
                Console.WriteLine("\tPlease wait 3 seconds, screen is loading again.....");
                Thread.Sleep(3000);
                Console.Clear();

            }
            else if (Rndom == 2)
            {
                Console.WriteLine("\tWheel space contains: LOSE A TURN");
                Console.WriteLine("\t{0}'S TURN", PlayerB);
                playerAturn = false;
                playerBturn = true;
                Console.WriteLine("\tPlease wait.......");
                Thread.Sleep(3000);
                Console.Clear();
            }
            else
            {
                Console.Write("\tWheel space contains: ${0}", Rndom);
                Console.WriteLine("\n\t****************************");
                Console.Write("\tGuess a letter: ");
                Try = Console.ReadLine().ToUpper();
                if (Try == "S")
                {
                    if (solve[0] != correctAns[0])
                    {
                        TotalA += Rndom;
                        Console.WriteLine("\tLETTER FOUND! YOU WON ${0}", Rndom);
                        Console.WriteLine("\tPlease wait.......");
                        Thread.Sleep(3000);
                        Console.Clear();
                        solve[0] = Try;
                        alpha[18] = "-";
                        if ((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7]))
                        {
                            header();

                            Console.WriteLine("");
                            Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerA, TotalA);
                            playerAturn = false;
                            loop = false;
                        }
                        else
                        {
                            playerAturn = true;
                        }
                    }

                    else
                    {
                        Console.WriteLine("\tLETTER AlREADY GIVEN!");
                        Console.WriteLine("\tPlease wait.......");
                        Thread.Sleep(3000);
                        Console.Clear();
                        playerAturn = true;
                    }

                }
                else if (Try == "I")
                {
                    if (solve[2] != correctAns[2])
                    {
                        TotalA += Rndom;
                        Console.WriteLine("\tLETTER FOUND! YOU WON ${0}", Rndom);
                        Console.WriteLine("\tPlease wait.......");
                        Thread.Sleep(3000);
                        Console.Clear();
                        solve[2] = Try;
                        alpha[8] = "-";
                        if ((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7]))
                        {
                            header();

                            Console.WriteLine("");
                            Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerA, TotalA);
                            playerAturn = false;
                            loop = false;
                        }
                        else
                        {
                            playerAturn = true;
                        }
                    }

                    else
                    {
                        Console.WriteLine("\tLETTER AlREADY GIVEN!");
                        Console.WriteLine("\tPlease wait.......");
                        Thread.Sleep(3000);
                        Console.Clear();
                        playerAturn = true;
                    }
                }
                else if (Try == "T")
                {
                    if (solve[3] != correctAns[3])
                    {
                        TotalA += Rndom;
                        Console.WriteLine("\tLETTER FOUND! YOU WON ${0}", Rndom);
                        Console.WriteLine("\tPlease wait.......");
                        Thread.Sleep(3000);
                        Console.Clear();
                        solve[3] = Try;
                        alpha[19] = "-";
                        if ((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7]))
                        {
                            header();

                            Console.WriteLine("");
                            Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerA, TotalA);
                            playerAturn = false;
                            loop = false;
                        }
                        else
                        {
                            playerAturn = true;
                        }
                    }

                    else
                    {
                        Console.WriteLine("\tLETTER AlREADY GIVEN!");
                        Console.WriteLine("\tPlease wait.......");
                        Thread.Sleep(3000);
                        Console.Clear();
                        playerAturn = true;
                    }
                }
                else if (Try == "C")
                {
                    if (solve[4] != correctAns[4])
                    {
                        TotalA += Rndom;
                        Console.WriteLine("\tLETTER FOUND! YOU WON ${0}", Rndom);
                        Console.WriteLine("\tPlease wait.......");
                        Thread.Sleep(3000);
                        Console.Clear();
                        solve[4] = Try;
                        alpha[2] = "-";
                        if ((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7]))
                        {
                            header();

                            Console.WriteLine("");
                            Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerA, TotalA);
                            playerAturn = false;
                            loop = false;
                        }
                        else
                        {
                            playerAturn = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\tLETTER AlREADY GIVEN!");
                        Console.WriteLine("\tPlease wait.......");
                        Thread.Sleep(3000);
                        Console.Clear();
                        playerAturn = true;
                    }
                }
                else if (Try == "H")
                {
                    if (solve[5] != correctAns[5])
                    {
                        TotalA += Rndom;
                        Console.WriteLine("\tLETTER FOUND! YOU WON ${0}", Rndom);
                        Console.WriteLine("\tPlease wait.......");
                        Thread.Sleep(3000);
                        Console.Clear();
                        solve[5] = Try;
                        alpha[7] = "-";
                        if ((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7]))
                        {
                            header();

                            Console.WriteLine("");
                            Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerA, TotalA);
                            playerAturn = false;
                            loop = false;
                        }
                        else
                        {
                            playerAturn = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\tLETTER AlREADY GIVEN!");
                        Console.WriteLine("\tPlease wait.......");
                        Thread.Sleep(3000);
                        Console.Clear();
                        playerAturn = true;
                    }
                }

                else if ((Try == "A") || (Try == "B") || (Try == "D") || (Try == "E") || (Try == "F") || (Try == "G") || (Try == "J") || (Try == "K") || (Try == "L") || (Try == "M") || (Try == "N") || (Try == "O") || (Try == "P") || (Try == "Q") || (Try == "R") || (Try == "U") || (Try == "V") || (Try == "W") || (Try == "X") || (Try == "Y") || (Try == "Z"))
                {
                    alphacheck();
                    Console.WriteLine("\tNo Letter Found");
                    Console.WriteLine("\t{0}'S TURN", PlayerB);
                    playerAturn = false;
                    playerBturn = true;
                    Console.WriteLine("\tPlease wait.......");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\tInvalid!/No Letter Found");
                    Console.WriteLine("\t{0}'S TURN", PlayerB);
                    playerAturn = false;
                    playerBturn = true;
                    Console.WriteLine("\tPlease wait.......");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
        }

        public static void BuyVowel()
        {
            while (opt2 == true)
            {
                if (!((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7])))
                {
                    Console.WriteLine("\tPurchase a vowel? (COSTS $250)");
                    Console.Write("\tY/N:");
                    string Purchase = Console.ReadLine().ToUpper();
                    if (Purchase == "Y")
                    {
                        if (TotalA < 250)
                        {
                            Console.WriteLine("\tYou have insufficient amount of money!");
                            Console.WriteLine("\tPlease wait.......");
                            Thread.Sleep(3000);
                            Console.Clear();
                            playerAturn = true;
                            opt2 = false;
                        }

                        else
                        {
                            TotalA -= 250;
                            Console.WriteLine("\tTotal Amount will be reduced by $250");
                            Console.WriteLine("\tPlease wait.......");
                            Thread.Sleep(3000);
                            Console.Clear();

                            if (solve[0] != correctAns[0])
                            {

                                solve[0] = "S";
                                alpha[18] = "-";

                                if ((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7]))
                                {
                                    header();
                                    Console.WriteLine("");
                                    Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerA, TotalA);
                                    opt2 = false;
                                    playerAturn = false;
                                    loop = false;
                                }
                                else
                                {
                                    playerAturn = true;
                                    opt2 = false;
                                }
                            }
                            else if (solve[2] != correctAns[2])
                            {

                                solve[2] = "I";
                                alpha[8] = "-";

                                if ((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7]))
                                {
                                    header();
                                    Console.WriteLine("");
                                    Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerA, TotalA);
                                    opt2 = false;
                                    playerAturn = false;
                                    loop = false;
                                }
                                else
                                {
                                    playerAturn = true;
                                    opt2 = false;
                                }
                            }
                            else if (solve[3] != correctAns[3])
                            {

                                solve[3] = "T";
                                alpha[19] = "-";

                                if ((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7]))
                                {
                                    header();
                                    Console.WriteLine("");
                                    Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerA, TotalA);
                                    opt2 = false;
                                    playerAturn = false;
                                    loop = false;
                                }
                                else
                                {
                                    playerAturn = true;
                                    opt2 = false;
                                }
                            }
                            else if (solve[4] != correctAns[4])
                            {

                                solve[4] = "C";
                                alpha[2] = "-";

                                if ((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7]))
                                {
                                    header();
                                    Console.WriteLine("");
                                    Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerA, TotalA);
                                    opt2 = false;
                                    playerAturn = false;
                                    loop = false;
                                }
                                else
                                {
                                    playerAturn = true;
                                    opt2 = false;
                                }
                            }
                            else if (solve[5] != correctAns[5])
                            {

                                solve[5] = "H";
                                alpha[7] = "-";

                                if ((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7]))
                                {
                                    header();
                                    Console.WriteLine("");
                                    Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerA, TotalA);
                                    opt2 = false;
                                    playerAturn = false;
                                    loop = false;
                                }
                                else
                                {
                                    playerAturn = true;
                                    opt2 = false;
                                }
                            }
                        }
                    }
                    else if (Purchase == "N")
                    {
                        Console.Clear();
                        playerAturn = true;
                        opt2 = false;
                    }
                    else
                    {
                        Console.WriteLine("\tInvalid Input.");
                        opt2 = true;
                    }
                }
                else
                {
                    Console.WriteLine("\tAll vowels are shown.");
                    opt2 = false;
                    playerAturn = true;
                }
            }
        }
        public static void Solve()
        {

            Console.Write("\tSolve the puzzle:");
            string Solve = Console.ReadLine().ToUpper();
            if ((Solve == "STITCHES") || (Solve == "Stitches") || (Solve == "stitches"))
            {
                if (TotalA == 0)
                {
                    TotalA = 100000;
                    Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerA, TotalA);
                    playerBturn = false;
                    loop = false;
                    playerAturn = false;
                    loop = false;
                }
                else
                {
                    Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerA, TotalA);
                    playerBturn = false;
                    loop = false;
                    playerAturn = false;
                    loop = false;
                }
            }
            else
            {
                Console.WriteLine("\tWRONG! BETTER LUCK NEXT TIME!");
                Console.WriteLine("\tRestarting game in 5 seconds");
                Thread.Sleep(5000);
                Console.Clear();
                Main();
            }
        }

        public static void SpinGuess1()
        {
            int[] arrWheel = new int[] { 300, 400, 500, 600, 700, 800, 900, 5000, 1, 2 };
            Random ran = new Random();
            int Rndom = arrWheel[ran.Next(0, arrWheel.Length)];

            if (Rndom == 1)
            {
                Console.WriteLine("\tWheel space contains: BANKRUPT! ");
                Console.WriteLine("\t{0}'s total money will become zero", PlayerB);
                TotalB = 0;
                playerBturn = false;
                playerAturn = true;
                Console.WriteLine("\tPlease wait.......");
                Thread.Sleep(3000);
                Console.Clear();

            }
            else if (Rndom == 2)
            {
                Console.WriteLine("\tWheel space contains: LOSE A TURN");
                Console.WriteLine("\t{0}'S TURN", PlayerA);
                playerBturn = false;
                playerAturn = true;
                Console.WriteLine("\tPlease wait.......");
                Thread.Sleep(3000);
                Console.Clear();


            }
            else
            {
                Console.Write("\tWheel space contains: ${0}", Rndom);
                Console.WriteLine("\n\t****************************");
                Console.Write("\tGuess a letter: ");
                Try = Console.ReadLine().ToUpper();

                if (Try == "S")
                {
                    if (solve[0] != correctAns[0])
                    {
                        TotalB += Rndom;
                        Console.WriteLine("\tLETTER FOUND! YOU WON ${0}", Rndom);
                        Console.WriteLine("\tPlease wait.......");
                        Thread.Sleep(3000);
                        Console.Clear();
                        solve[0] = Try;
                        alpha[18] = "-";
                        if ((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7]))
                        {
                            header();

                            Console.WriteLine("");
                            Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerB, TotalB);
                            playerBturn = false;
                            loop = false;
                        }
                        else
                        {
                            playerBturn = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\tLETTER AlREADY GIVEN!");
                        Console.WriteLine("\tPlease wait.......");
                        Thread.Sleep(3000);
                        Console.Clear();
                        playerBturn = true;
                    }
                }
                else if (Try == "I")
                {
                    if (solve[2] != correctAns[2])
                    {
                        TotalB += Rndom;
                        Console.WriteLine("\tLETTER FOUND! YOU WON ${0}", Rndom);
                        Console.WriteLine("\tPlease wait.......");
                        Thread.Sleep(3000);
                        Console.Clear();
                        solve[2] = Try;
                        alpha[8] = "-";
                        if ((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7]))
                        {
                            header();

                            Console.WriteLine("");
                            Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerB, TotalB);
                            playerBturn = false;
                            loop = false;
                        }
                        else
                        {
                            playerBturn = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\tLETTER AlREADY GIVEN!");
                        Console.WriteLine("\tPlease wait.......");
                        Thread.Sleep(3000);
                        Console.Clear();
                        playerBturn = true;
                    }
                }
                else if (Try == "T")
                {
                    if (solve[3] != correctAns[3])
                    {
                        TotalB += Rndom;
                        Console.WriteLine("\tLETTER FOUND! YOU WON ${0}", Rndom);
                        Console.WriteLine("\tPlease wait.......");
                        Thread.Sleep(3000);
                        Console.Clear();
                        solve[3] = Try;
                        alpha[19] = "-";
                        if ((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7]))
                        {
                            header();

                            Console.WriteLine("");
                            Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerB, TotalB);
                            playerBturn = false;
                            loop = false;
                        }
                        else
                        {
                            playerBturn = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\tLETTER AlREADY GIVEN!");
                        Console.WriteLine("\tPlease wait.......");
                        Thread.Sleep(3000);
                        Console.Clear();
                        playerBturn = true;
                    }
                }
                else if (Try == "C")
                {
                    if (solve[4] != correctAns[4])
                    {
                        TotalB += Rndom;
                        Console.WriteLine("\tLETTER FOUND! YOU WON ${0}", Rndom);
                        Console.WriteLine("\tPlease wait.......");
                        Thread.Sleep(3000);
                        Console.Clear();
                        solve[4] = Try;
                        alpha[2] = "-";
                        if ((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7]))
                        {
                            header();

                            Console.WriteLine("");
                            Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerB, TotalB);
                            playerBturn = false;
                            loop = false;
                        }
                        else
                        {
                            playerBturn = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\tLETTER AlREADY GIVEN!");
                        Console.WriteLine("\tPlease wait.......");
                        Thread.Sleep(3000);
                        Console.Clear();
                        playerBturn = true;
                    }
                }
                else if (Try == "H")
                {
                    if (solve[5] != correctAns[5])
                    {
                        TotalB += Rndom;
                        Console.WriteLine("\tLETTER FOUND! YOU WON ${0}", Rndom);
                        Console.WriteLine("\tPlease wait.......");
                        Thread.Sleep(3000);
                        Console.Clear();
                        solve[5] = Try;
                        alpha[7] = "-";
                        if ((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7]))
                        {
                            header();

                            Console.WriteLine("");
                            Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerB, TotalB);
                            playerBturn = false;
                            loop = false;
                        }
                        else
                        {
                            playerBturn = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\tLETTER AlREADY GIVEN!");
                        Console.WriteLine("\tPlease wait.......");
                        Thread.Sleep(3000);
                        Console.Clear();
                        playerBturn = true;
                    }
                }

                else if ((Try == "A") || (Try == "B") || (Try == "D") || (Try == "E") || (Try == "F") || (Try == "G") || (Try == "J") || (Try == "K") || (Try == "L") || (Try == "M") || (Try == "N") || (Try == "O") || (Try == "P") || (Try == "Q") || (Try == "R") || (Try == "U") || (Try == "V") || (Try == "W") || (Try == "X") || (Try == "Y") || (Try == "Z"))
                {
                    alphacheck();
                    Console.WriteLine("\tNo Letter Found");
                    Console.WriteLine("\t{0}'S TURN", PlayerA);
                    playerBturn = false;
                    playerAturn = true;
                    Console.WriteLine("\tPlease wait.......");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\tInvalid!/No Letter Found");
                    Console.WriteLine("\t{0}'S TURN", PlayerA);
                    playerBturn = false;
                    playerAturn = true;
                    Console.WriteLine("\tPlease wait.......");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }
        }
        public static void BuyVowel1()
        {
            while (opt2 == true)
            {
                if (!((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7])))
                {
                    Console.WriteLine("\tPurchase a vowel? (COSTS $250)");
                    Console.Write("\tY/N:");
                    string Purchase = Console.ReadLine().ToUpper();
                    if (Purchase == "Y")
                    {
                        if (TotalB < 250)
                        {
                            Console.WriteLine("\tYou have insufficient amount of money");
                            Console.WriteLine("\tPlease wait.......");
                            Thread.Sleep(3000);
                            Console.Clear();
                            playerAturn = true;
                            opt2 = false;
                        }
                        else
                        {
                            TotalB -= 250;
                            Console.WriteLine("\tTotal Amount will be reduced by $250");
                            Console.WriteLine("\tPlease wait.......");
                            Thread.Sleep(3000);
                            Console.Clear();

                            if (solve[0] != correctAns[0])
                            {

                                solve[0] = "S";
                                alpha[18] = "-";

                                if ((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7]))
                                {
                                    header();
                                    Console.WriteLine("");
                                    Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerB, TotalB);
                                    opt2 = false;
                                    playerBturn = false;
                                    loop = false;
                                }
                                else
                                {
                                    playerBturn = true;
                                    opt2 = false;
                                }
                            }
                            else if (solve[2] != correctAns[2])
                            {
                                solve[2] = "I";
                                alpha[8] = "-";

                                if ((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7]))
                                {
                                    header();
                                    Console.WriteLine("");
                                    Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerB, TotalB);
                                    opt2 = false;
                                    playerBturn = false;
                                    loop = false;
                                }
                                else
                                {
                                    playerBturn = true;
                                    opt2 = false;
                                }
                            }
                            else if (solve[3] != correctAns[3])
                            {

                                solve[3] = "T";
                                alpha[19] = "-";

                                if ((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7]))
                                {
                                    header();
                                    Console.WriteLine("");
                                    Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerB, TotalB);
                                    opt2 = false;
                                    playerBturn = false;
                                    loop = false;
                                }
                                else
                                {
                                    playerBturn = true;
                                    opt2 = false;
                                }
                            }
                            else if (solve[4] != correctAns[4])
                            {
                                solve[4] = "C";
                                alpha[2] = "-";

                                if ((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7]))
                                {
                                    header();
                                    Console.WriteLine("");
                                    Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerB, TotalB);
                                    opt2 = false;
                                    playerBturn = false;
                                    loop = false;
                                }
                                else
                                {
                                    playerBturn = true;
                                    opt2 = false;
                                }
                            }
                            else if (solve[5] != correctAns[5])
                            {
                                solve[5] = "H";
                                alpha[7] = "-";

                                if ((solve[0] == correctAns[0]) && (solve[1] == correctAns[1]) && (solve[2] == correctAns[2]) && (solve[3] == correctAns[3]) && (solve[4] == correctAns[4]) && (solve[5] == correctAns[5]) && (solve[6] == correctAns[6]) && (solve[7] == correctAns[7]))
                                {
                                    header();
                                    Console.WriteLine("");
                                    Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerB, TotalB);
                                    opt2 = false;
                                    playerBturn = false;
                                    loop = false;
                                }
                                else
                                {
                                    playerBturn = true;
                                    opt2 = false;
                                }
                            }
                        }
                    }
                    else if (Purchase == "N")
                    {
                        Console.Clear();
                        playerBturn = true;
                        opt2 = false;
                    }
                    else
                    {
                        Console.WriteLine("\tInvalid Input.");
                        opt2 = true;
                    }
                }
                else
                {
                    Console.WriteLine("\tAll vowels are shown.");
                    opt2 = false;
                    playerBturn = true;
                }
            }
        }
        public static void Solve1()
        {
            Console.Write("\tSolve the puzzle:");
            string Solve = Console.ReadLine();
            if ((Solve == "STITCHES") || (Solve == "Stitches") || (Solve == "stitches"))
            {
                if (TotalB == 0)
                {
                    TotalB = 100000;
                    Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerB, TotalB);
                    playerBturn = false;
                    loop = false;
                }
                else
                {
                    Console.WriteLine("\t{0}, YOU WON! ${1}", PlayerB, TotalB);
                    playerBturn = false;
                    loop = false;
                }
            }
            else
            {
                Console.WriteLine("\tWRONG! BETTER LUCK NEXT TIME!");
                Console.WriteLine("\tRestarting game in 5 seconds");
                Thread.Sleep(5000);
                Console.Clear();
                Main();
            }
        }

        public static void header()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\t\t    +++++++ WHEEL OF FORTUNE +++++++");
            Console.WriteLine("\n\t --------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\n");
            Console.Write("        \t\t\t");
            for (int i = 0; i < solve.Length; i++)
            {
                Console.Write("{0} ", solve[i]);
            }
            Console.Write("\n\n");
            Console.Write("          \t\t");
            for (int i = 0; i < alpha.Length; i++)
            {
                Console.Write("{0}", alpha[i]);
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\t --------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n");
            Console.WriteLine("\n\t Contestant\t\t\t\tTotal $");
            Console.WriteLine("\t ===========\t\t\t\t===========");
            Console.Write("\t{0}\t\t\t\t\t${1}", PlayerA, TotalA);
            Console.Write("\n\t{0}\t\t\t\t\t${1}", PlayerB, TotalB);
            Console.Write("\n\n");

        }

        public static void alphacheck()
        {
            for (int i = 0; i < alpha.Length; i++)
            {
                if (alpha[i] == Try)
                {
                    alpha[i] = "-";
                }
            }
        }


        /*==============================
        *==============================
        * BINGO
        * =============================
        * =============================*/

        private static void bingocard1()
        {
            for (int a = 0; a < 25; a++)
            {
                for (int b = 0; b < 100; b++)
                {
                    if (bingo1[content1[b, 0], content1[b, 1]] == null)
                    {
                        bingo1[content1[b, 0], content1[b, 1]] = (a + 1).ToString();
                        break;
                    }
                    else
                        Console.Write("");
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Player 1\n");
            Console.WriteLine(" \tB\t|\tI\t|\tN\t|\tG\t|\tO");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" \t--\t|\t--\t|\t--\t|\t--\t|\t--");
            Console.WriteLine(" \t{0}\t|\t{1}\t|\t{2}\t|\t{3}\t|\t{4}", bingo1[0, 0], bingo1[0, 1], bingo1[0, 2], bingo1[0, 3], bingo1[0, 4]);
            Console.WriteLine(" \t{0}\t|\t{1}\t|\t{2}\t|\t{3}\t|\t{4}", bingo1[1, 0], bingo1[1, 1], bingo1[1, 2], bingo1[1, 3], bingo1[1, 4]);
            Console.WriteLine(" \t{0}\t|\t{1}\t|\t{2}\t|\t{3}\t|\t{4}", bingo1[2, 0], bingo1[2, 1], bingo1[2, 2], bingo1[2, 3], bingo1[2, 4]);
            Console.WriteLine(" \t{0}\t|\t{1}\t|\t{2}\t|\t{3}\t|\t{4}", bingo1[3, 0], bingo1[3, 1], bingo1[3, 2], bingo1[3, 3], bingo1[3, 4]);
            Console.WriteLine(" \t{0}\t|\t{1}\t|\t{2}\t|\t{3}\t|\t{4}", bingo1[4, 0], bingo1[4, 1], bingo1[4, 2], bingo1[4, 3], bingo1[4, 4]);
        }

        private static void bingocard2()
        {
            for (int a = 0; a < 25; a++)
            {
                for (int b = 0; b < 100; b++)
                {
                    if (bingo2[content2[b, 0], content2[b, 1]] == null)
                    {
                        bingo2[content2[b, 0], content2[b, 1]] = (a + 1).ToString();
                        break;
                    }
                    else
                        Console.Write("");
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Player 2");
            Console.WriteLine(" \tB\t|\tI\t|\tN\t|\tG\t|\tO");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" \t--\t|\t--\t|\t--\t|\t--\t|\t--");
            Console.WriteLine("\t{0}\t|\t{1}\t|\t{2}\t|\t{3}\t|\t{4}", bingo2[0, 0], bingo2[0, 1], bingo2[0, 2], bingo2[0, 3], bingo2[0, 4]);
            Console.WriteLine("\t{0}\t|\t{1}\t|\t{2}\t|\t{3}\t|\t{4}", bingo2[1, 0], bingo2[1, 1], bingo2[1, 2], bingo2[1, 3], bingo2[1, 4]);
            Console.WriteLine("\t{0}\t|\t{1}\t|\t{2}\t|\t{3}\t|\t{4}", bingo2[2, 0], bingo2[2, 1], bingo2[2, 2], bingo2[2, 3], bingo2[2, 4]);
            Console.WriteLine("\t{0}\t|\t{1}\t|\t{2}\t|\t{3}\t|\t{4}", bingo2[3, 0], bingo2[3, 1], bingo2[3, 2], bingo2[3, 3], bingo2[3, 4]);
            Console.WriteLine("\t{0}\t|\t{1}\t|\t{2}\t|\t{3}\t|\t{4}", bingo2[4, 0], bingo2[4, 1], bingo2[4, 2], bingo2[4, 3], bingo2[4, 4]);
        }

        private static void Check()
        {
            for (int i = 0; i < 5; i++)
            {
                if (bingo1[i, 0] == "X" && bingo1[i, 1] == "X" && bingo1[i, 2] == "X" && bingo1[i, 3] == "X" && bingo1[i, 4] == "X")
                {
                    Console.Clear();
                    Console.WriteLine("BINGO! Player 1 Won!");
                    bingocard1();
                    Console.WriteLine("Press Any Key To Exit. . .");
                    boom = false;
                }

                else if (bingo1[0, i] == "X" && bingo1[1, i] == "X" && bingo1[2, i] == "X" && bingo1[3, i] == "X" && bingo1[4, i] == "X")
                {
                    Console.Clear();
                    Console.WriteLine("BINGO! Player 1 Won!");
                    bingocard1();
                    Console.WriteLine("Press Any Key To Exit. . .");
                    boom = false;
                }

                else if (bingo2[i, 0] == "X" && bingo2[i, 1] == "X" && bingo2[i, 2] == "X" && bingo2[i, 3] == "X" && bingo2[i, 4] == "X")
                {
                    Console.Clear();
                    Console.WriteLine("BINGO! Player 2 Won!");
                    bingocard2();
                    Console.WriteLine("Press Any Key To Exit. . .");
                    boom = false;
                }

                else if (bingo2[0, i] == "X" && bingo2[1, i] == "X" && bingo2[2, i] == "X" && bingo2[3, i] == "X" && bingo2[4, i] == "X")
                {
                    Console.Clear();
                    Console.WriteLine("BINGO! Player 2 Won!");
                    bingocard2();
                    Console.WriteLine("Press Any Key To Exit. . .");
                    boom = false;
                }
            }
        }

        /*==============================
        *==============================
        * BATTLESHIP
        * =============================
        * =============================*/

        public static void setBoard()
        {
            for (c = 0; c < 8; c++)
            {
                for (a = 0; a < 8; a++)
                {
                    board1[a, col1.Next(0, 8)] = " x";
                }
            }
            for (c = 0; c < 3; c++)
            {
                for (a = 0; a < 8; a++)
                {
                    board1[a, col1.Next(0, 8)] = " .";
                }
            }
            for (a = 0; a < 8; a++)
            {
                for (b = 0; b < 8; b++)
                {
                    if (board1[a, b] == null)
                    {
                        board1[a, b] = " *";
                    }
                    else if ((board1[a, b] == " x") || (board1[a, b] == " ."))
                    {
                        goto skip;
                    }
                skip:
                    Console.Write("");
                }
            }
            for (a = 0; a < 8; a++)
            {
                for (b = 0; b < 8; b++)
                {
                    board2[a, b] = " ?";
                }
            }
        }

        public static void show()
        {

            for (a = 0; a < 8; a++)
            {
                Console.Write("\t\t\t   ");
                for (b = 0; b < 8; b++)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("{0} ", board2[a, b]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write("\n");
                Console.Write("\n");
            }
        }

        public static void play()
        {
        go:
            
            Console.WriteLine("\t\t\t\t== Player 1 ==");
        again:
            Console.Write("\t\t\t       Choose row   : ");
            a = int.Parse(Console.ReadLine()) - 1;
            Console.Write("\t\t\t       Choose column: ");
            b = int.Parse(Console.ReadLine()) - 1;

            if ((a > 8) || (a < 0) || (b > 8) || (b < 0))
            {
                Console.WriteLine();
                Console.WriteLine("Row and column do not exist.");
                Console.WriteLine();
                goto again;
            }
            else if (checkBoard[a, b, 0] == "1")
            {
                Console.WriteLine();
                Console.WriteLine("Row and column has already been selected.");
                Console.WriteLine();
                goto again;
            }
            ps1 = true;
            check(a, b);
            show();
            Console.WriteLine("\t\t\t\t== Player 2 ==");
        again2:
            
            Console.Write("\t\t\t       Choose row   : ");
            a = int.Parse(Console.ReadLine()) - 1;
            Console.Write("\t\t\t       Choose column: ");
            b = int.Parse(Console.ReadLine()) - 1;


            if ((a > 8) || (a < 0) || (b > 8) || (b < 0))
            {
                Console.WriteLine();
                Console.WriteLine("Row and column not existing.");
                Console.WriteLine();
                goto again2;
            }
            else if (checkBoard[a, b, 0] == "1")
            {
                Console.WriteLine();
                Console.WriteLine("Row and column has already been selected.");
                Console.WriteLine();
                goto again2;
            }
            ps2 = true;
            check(a, b);

            ctr1 = ctr1 + 2;

            if (ctr1 == 64)
            {
                goto end;
            }
            else
            {
                show();
                goto go;
            }


        end:
            finish = true;
            Main();

        }

        public static void check(int rw, int cl)
        {
            if (board1[rw, cl] == " .")
            {
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t                  ***OWWW! That's a MISS!***");
                Console.ForegroundColor = ConsoleColor.White;
                if (ps1 == true)
                {
                    //player1
                    ps1 = false;
                }
                if (ps2 == true)
                {
                    //player2
                    ps2 = false;
                }
                Console.WriteLine("\t      Player 1 >>>>>>>>>>>> SCORE <<<<<<<<<<<<< Player 2 ");
                Console.WriteLine("\t      Score: {0}                                Score: {1}     ", score1, score2);
                board2[rw, cl] = board1[rw, cl];
                checkBoard[rw, cl, 0] = "1";
            }
            else if (board1[rw, cl] == " x")
            {
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t        ***BANG! You've HIT a battleship! +1 point***");
                Console.ForegroundColor = ConsoleColor.White;
                if (ps1 == true)
                {
                    //player1
                    ps1 = false;
                    score1 = score1 + 1;
                }
                if (ps2 == true)
                {
                    //player2
                    ps2 = false;
                    score2 = score2 + 1;
                }
                Console.WriteLine("\t      Player 1 >>>>>>>>>>>> SCORE <<<<<<<<<<<<< Player 2 ");
                Console.WriteLine("\t      Score: {0}                                Score: {1}     ", score1, score2);
                board2[rw, cl] = board1[rw, cl];
                checkBoard[rw, cl, 0] = "1";
            }
            else //(board1[rw, cl] == " *")
            {
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t             ***BOOM! That's a BOMB! -1 point***");
                Console.ForegroundColor = ConsoleColor.White;
                if (ps1 == true)
                {
                    //player1
                    ps1 = false;
                    score1 = score1 - 1;
                }
                if (ps2 == true)
                {
                    //player2
                    ps2 = false;
                    score2 = score2 - 1;
                }
                Console.WriteLine("\t      Player 1 >>>>>>>>>>>> SCORE <<<<<<<<<<<<< Player 2 ");
                Console.WriteLine("\t      Score: {0}                                Score: {1}     ", score1, score2);
                board2[rw, cl] = board1[rw, cl];
                checkBoard[rw, cl, 0] = "1";
            }
        }
    }
}

