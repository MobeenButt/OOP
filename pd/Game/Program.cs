using EZInput;
using System;
using System.Threading;
namespace ConsoleApp5
{
    class Program
    {
        static int height = 27;
        static int width = 100;
        static bool EnemyMove = false; 
        static bool EnemyMove2 = false;

        static void Main()
        {
            int px = 2, py = 2;
            int ex = 55, ey = 18;
            int ex2 = 15, ey2 = 5;
            MAZE();
            PLAYER(ref px, ref py);
            ENEMY(ref ex, ref ey);



            while (true)
            {
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    MOVEPLAYER("left", ref px, ref py, ref width);
                }

                else if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    MOVEPLAYER("right", ref px, ref py, ref width);
                }
                else if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    MOVEPLAYERUP("UP", ref px, ref py, ref height);
                }
                else if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    MOVEPLAYERUP("DOWN", ref px, ref py, ref height);
                }
                MOVEENEMY(ref ex, ref ey, ref width);
                MOVEENEMY2UP(ref ex2, ref ey2, ref height);

                Thread.Sleep(100);
            }





        }

        static void PLAYER(ref int px, ref int py)
        {
            Console.SetCursorPosition(px, py);
            Console.WriteLine("P");

        }
        static void ENEMY(ref int ex, ref int ey)
        {
            Console.SetCursorPosition(ex, ey);
            Console.WriteLine("E");
        }
        static void ENEMY2(ref int ex2, ref int ey2)
        {
            Console.SetCursorPosition(ex2, ey2);
            Console.WriteLine("|E");
        }

        static void MOVEPLAYER(string direction, ref int px, ref int py, ref int width)
        {
            REMOVEPLAYER(ref px, ref py);

            if (direction == "left" && px > 1)
            {
                px = px - 1;
               
            }
            else if (direction == "right" && px < width)
            {
                px = px + 1;
                
            }
            PLAYER(ref px, ref py);
        } 

            static void MOVEENEMY(ref int ex, ref int ey, ref int width)
            {
                REMOVEENEMY(ref ex, ref ey);
                Console.SetCursorPosition(ex, ey);

                if (ex > 1 && EnemyMove)
                {
                    ex = ex - 1;
                }
                else if (ex < width && !EnemyMove)
                {
                    ex = ex + 1;
                }

                // Switch direction when reaching the boundary
                if (ex <= 1 || ex >= width)
                {
                    EnemyMove = !EnemyMove;
                }

                ENEMY(ref ex, ref ey);
            }



            static void MOVEPLAYERUP(string direction, ref int px, ref int py, ref int height)
        {
            REMOVEPLAYER(ref px, ref py);
            if (direction == "UP" && py > 1)
            {
                py = py - 1;
               
            }
            else if (direction == "DOWN" && py < height)
            {
                py = py + 1;
               
            }
            PLAYER(ref px, ref py);
        }
        static void MOVEENEMY2UP(ref int ex2, ref int ey2, ref int height)
        {
            REMOVEENEMY2(ref ex2, ref ey2);
            Console.SetCursorPosition(ex2, ey2);
            if (ey2 > 1 && EnemyMove2)
            {
                ey2 = ey2 - 1;
               
            }
            else if (ey2 < height && !EnemyMove2)
            {
                ey2 = ey2 + 1;
               
            }
            if (ey2 <= 1 || ey2 >= height)
            {
                EnemyMove2 = !EnemyMove2;
            }

            ENEMY2(ref ex2, ref ey2);
        }

        static void REMOVEPLAYER(ref int px, ref int py)
        {
            Console.SetCursorPosition(px, py);
            Console.WriteLine(" ");
        }
        static void REMOVEENEMY(ref int ex, ref int ey)
        {
            Console.SetCursorPosition(ex, ey);
            Console.WriteLine(" ");
        }
        static void REMOVEENEMY2(ref int ex2, ref int ey2)
        {
            Console.SetCursorPosition(ex2, ey2);
            Console.WriteLine("  ");
        }
        static void MAZE()
        {
            Console.Clear();
            Console.WriteLine("######################################################################################################");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("#                                                                                                    #");
            Console.WriteLine("######################################################################################################");
        }
    }
}