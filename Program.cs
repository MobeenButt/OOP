using EZInput;
using System;

namespace Game
{
    internal class Program
    {
        static void Main()
        {
            int playerX = 2;
            int playerY = 3;
            char[,] maze = {
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },   
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', 'p', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
            };


            PrintMaze(maze);
            Console.SetCursorPosition(playerY, playerX);
            Console.Write('P');

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (Keyboard.IsKeyPressed(Key.DownArrow))
                    {
                        MovePlayerDown(maze, ref playerX, ref playerY);
                    }
                    else if (Keyboard.IsKeyPressed(Key.UpArrow))
                    {
                        MovePlayerUp(maze, ref playerX, ref playerY);
                    }
                    else if (Keyboard.IsKeyPressed(Key.LeftArrow))
                    {
                        MovePlayerLeft(maze, ref playerX, ref playerY);
                    }
                    else if (Keyboard.IsKeyPressed(Key.RightArrow))
                    {
                        MovePlayerRight(maze, ref playerX, ref playerY);
                    }
                    else if (key.Key == ConsoleKey.Escape)
                    {
                        break; // Exit the loop if the Escape key is pressed
                    }
                }
            }
        }

        static void MovePlayerRight(char[,] maze, ref int playerX, ref int playerY)
        {
            if (maze[playerX, playerY + 1] == ' ')
            {
                maze[playerX, playerY] = ' ';
                Console.SetCursorPosition(playerY, playerX);
                Console.Write(" ");
                playerY = playerY + 1;
                Console.SetCursorPosition(playerY, playerX);
                Console.Write('P');
            }
        }

        static void MovePlayerDown(char[,] maze, ref int playerX, ref int playerY)
        {
            if (maze[playerX + 1, playerY] == ' ')
            {
                maze[playerX, playerY] = ' ';
                Console.SetCursorPosition(playerY, playerX);
                Console.Write(" ");
                playerX = playerX + 1;
                Console.SetCursorPosition(playerY, playerX);
                Console.Write('P');
            }
        }
        static void MovePlayerUp(char[,] maze, ref int playerX, ref int playerY)
        {
            if (maze[playerX - 1, playerY] == ' ')
            {
                maze[playerX, playerY] = ' ';
                Console.SetCursorPosition(playerY, playerX);
                Console.Write(" ");
                playerX = playerX - 1;
                Console.SetCursorPosition(playerY, playerX);
                Console.Write('P');
            }
        }
        static void MovePlayerLeft(char[,] maze, ref int playerX, ref int playerY)
        {
            if (maze[playerX, playerY - 1] == ' ')
            {
                maze[playerX, playerY] = ' ';
                Console.SetCursorPosition(playerY, playerX);
                Console.Write(" ");
                playerY = playerY - 1;
                Console.SetCursorPosition(playerY, playerX);
                Console.Write('P');
            }
        }

        static void PrintMaze(char[,] maze)
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    Console.Write(maze[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
