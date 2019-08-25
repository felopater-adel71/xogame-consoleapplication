using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XO_game
{
    class XOgame
    {
        
        static int x_Player = 0;
        static int o_player = 0;


///////////////////////////////////////////////////////////////////

       
//////////////////////////////////////////////////////////////////

        public XOgame()
        {
            
        }

        public void play()
        {
            print_game();
          
        }

        static void print_game()
        {
            for (int i = 3; i <= 12; i++)
            {
                for (int j = 3; j <= 12; j++)
                {
                    if (i % 4 == 0 && j % 4 == 0)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.WriteLine("{ }");
                    }
                }
            }
            start_game();
        }

        static void start_game()
        {
            bool flag = false;
            char[] xo_arr = new char[9];
            char plying;
            ConsoleKeyInfo cki;
            for (int i = 0; i < 9; i++)
            {
                cki = Console.ReadKey();
                if (i % 2 == 0)
                {
                    plying = 'X';

                }
                else
                { plying = 'O'; }
                switch (cki.Key)
                {
                    case ConsoleKey.NumPad1:
                        Console.SetCursorPosition(5, 12);
                        Console.WriteLine(plying);
                        xo_arr[0] = plying;
                        flag = winer(xo_arr);
                        break;
                    case ConsoleKey.NumPad2:
                        Console.SetCursorPosition(9, 12);
                        Console.WriteLine(plying);
                        xo_arr[1] = plying;
                        flag = winer(xo_arr);
                        break;
                    case ConsoleKey.NumPad3:
                        Console.SetCursorPosition(13, 12);
                        Console.WriteLine(plying);
                        xo_arr[2] = plying;
                        flag = winer(xo_arr);
                        break;
                    case ConsoleKey.NumPad4:
                        Console.SetCursorPosition(5, 8);
                        Console.WriteLine(plying);
                        xo_arr[3] = plying;
                        flag = winer(xo_arr);
                        break;
                    case ConsoleKey.NumPad5:
                        Console.SetCursorPosition(9, 8);
                        Console.WriteLine(plying);
                        xo_arr[4] = plying;
                        flag = winer(xo_arr);
                        break;
                    case ConsoleKey.NumPad6:
                        Console.SetCursorPosition(13, 8);
                        Console.WriteLine(plying);
                        xo_arr[5] = plying;
                        flag = winer(xo_arr);
                        break;
                    case ConsoleKey.NumPad7:
                        Console.SetCursorPosition(5, 4);
                        Console.WriteLine(plying);
                        xo_arr[6] = plying;
                        flag = winer(xo_arr);
                        break;
                    case ConsoleKey.NumPad8:
                        Console.SetCursorPosition(9, 4);
                        Console.WriteLine(plying);
                        xo_arr[7] = plying;
                        flag = winer(xo_arr);
                        break;
                    case ConsoleKey.NumPad9:
                        Console.SetCursorPosition(13, 4);
                        Console.WriteLine(plying);
                        xo_arr[8] = plying;
                        flag = winer(xo_arr);
                        break;
                }
                if (flag == true)
                {
                    break;
                }
            }

            Console.SetCursorPosition(20, 4);
            Console.Write("X Player = {0}",x_Player);
            Console.SetCursorPosition(40, 4);
            Console.Write("O Player = {0}",o_player);
            chosing();

        }

        static bool winer(char[] xo_arr)
        {
            //////////////////////////////////////////////////////////////////////////
            if (xo_arr[0] == 'X' && xo_arr[1] == 'X' && xo_arr[2] == 'X')
            {
                x_Player++;      
                Console.SetCursorPosition(17, 8);
                Console.WriteLine("winer is X player");
                return true;
            }
            else if (xo_arr[0] == 'O' && xo_arr[1] == 'O' && xo_arr[2] == 'O')
            {
                o_player++;
                Console.SetCursorPosition(17, 8);
                Console.WriteLine("winer is o player");
                return true;
            }
            ///////////////////////////////////////////////////////////////////////////////
            else if (xo_arr[3] == 'X' && xo_arr[4] == 'X' && xo_arr[5] == 'X')
            {
                x_Player++;
                Console.SetCursorPosition(17, 8);
                Console.WriteLine("winer is X player");
                return true;
            }
            else if (xo_arr[3] == 'O' && xo_arr[4] == 'O' && xo_arr[5] == 'O')
            {
                o_player++;
                Console.SetCursorPosition(17, 8);
                Console.WriteLine("winer is o player");
                return true;
            }
            /////////////////////////////////////////////////////////////////////////////////
            else if (xo_arr[6] == 'X' && xo_arr[7] == 'X' && xo_arr[8] == 'X')
            {
                x_Player++;
                Console.SetCursorPosition(17, 8);
                Console.WriteLine("winer is X player");
                return true;
            }
            else if (xo_arr[6] == 'O' && xo_arr[7] == 'O' && xo_arr[8] == 'O')
            {
                o_player++;
                Console.SetCursorPosition(17, 8);
                Console.WriteLine("winer is o player");
                return true;
            }
            /////////////////////////////////////////////////////////////////////////
            else if (xo_arr[6] == 'X' && xo_arr[4] == 'X' && xo_arr[2] == 'X')
            {
                x_Player++;
                Console.SetCursorPosition(17, 8);
                Console.WriteLine("winer is X player");
                return true;
            }
            else if (xo_arr[6] == 'O' && xo_arr[4] == 'O' && xo_arr[2] == 'O')
            {
                o_player++;
                Console.SetCursorPosition(17, 8);
                Console.WriteLine("winer is o player");
                return true;
            }
            ///////////////////////////////////////////////////////////////////////
            else if (xo_arr[0] == 'X' && xo_arr[4] == 'X' && xo_arr[8] == 'X')
            {
                x_Player++;
                Console.SetCursorPosition(17, 8);
                Console.WriteLine("winer is X player");
                return true;
            }
            else if (xo_arr[0] == 'O' && xo_arr[4] == 'O' && xo_arr[8] == 'O')
            {
                o_player++;
                Console.SetCursorPosition(17, 8);
                Console.WriteLine("winer is o player");
                return true;
            }
            ///////////////////////////////////////////////////////////////////////////
            else if (xo_arr[0] == 'X' && xo_arr[3] == 'X' && xo_arr[6] == 'X')
            {
                x_Player++;
                Console.SetCursorPosition(17, 8);
                Console.WriteLine("winer is X player");
                return true;
            }
            else if (xo_arr[0] == 'O' && xo_arr[3] == 'O' && xo_arr[6] == 'O')
            {
                o_player++;
                Console.SetCursorPosition(17, 8);
                Console.WriteLine("winer is o player");
                return true;
            }
            ////////////////////////////////////////////////////////////////
            else if (xo_arr[1] == 'X' && xo_arr[4] == 'X' && xo_arr[7] == 'X')
            {
                x_Player++;
                Console.SetCursorPosition(17, 8);
                Console.WriteLine("winer is X player");
                return true;
            }
            else if (xo_arr[1] == 'O' && xo_arr[4] == 'O' && xo_arr[7] == 'O')
            {
                o_player++;
                Console.SetCursorPosition(17, 8);
                Console.WriteLine("winer is o player");
                return true;
            }
            //////////////////////////////////////////////////////////
            else if (xo_arr[2] == 'X' && xo_arr[5] == 'X' && xo_arr[8] == 'X')
            {
                x_Player++;
                Console.SetCursorPosition(17, 8);
                Console.WriteLine("winer is X player");
                return true;
            }
            else if (xo_arr[2] == 'O' && xo_arr[5] == 'O' && xo_arr[8] == 'O')
            {
                o_player++;
                Console.SetCursorPosition(17, 8);
                Console.WriteLine("winer is o player");
                return true;
            }
            ////////////////////////////////////////////////////////////////////
            else
            {
                return false;
            }

        }

        static void chosing()
        {
            ConsoleKeyInfo cki;
            Console.SetCursorPosition(17, 10);
            Console.Write("Enter for return ---- Q for quite");
            cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.SetCursorPosition(20, 4);
                Console.Write("X Player = {0}", x_Player);
                Console.SetCursorPosition(40, 4);
                Console.Write("O Player = {0}", o_player);
                print_game();
                
            }
            else if (cki.Key == ConsoleKey.Q)
            {
                Environment.Exit(1);
            }
            else
            {
                Environment.Exit(1);
            }
        }


    }
}
