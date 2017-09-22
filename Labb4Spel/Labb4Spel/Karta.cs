using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4Spel
{
    public class Karta
    {
        public void Map()
        {

                int rad = 20, kolumn = 40;
                string[,] map = new string[rad, kolumn];
                int positionX = 18;
                int positionY = 3;
            //string startPosition = map[positionX, positionY];
            while (true)
            {
                for (int r = 0; r < rad; r++)
                {
                    for (int k = 0; k < kolumn; k++)
                    {

                        if (r == positionX && k == positionY)
                            Console.Write("@");
                        if (r == 0 || k == 0 || k == 39 || r == 19)
                        {
                            map[r, k] = "#";
                            Console.Write(map[r, k]);
                        }
                        else
                        {
                            map[r, k] = ".";
                            Console.Write(map[r, k]);
                        }

                    }//for k

                    Console.WriteLine();

                }//for r
                System.ConsoleKeyInfo moveCharacter = Console.ReadKey();
                if (moveCharacter.Key == ConsoleKey.W)
                {
                    positionX--;
                    Console.Clear();
                }
                if(moveCharacter.Key == ConsoleKey.S)
                {
                    positionX++;
                    Console.Clear();
                }
                if(moveCharacter.Key == ConsoleKey.D)
                {
                    positionY++;
                    Console.Clear();
                }
                if(moveCharacter.Key == ConsoleKey.A)
                {
                    positionY--;
                    Console.Clear();
                }
            }//while
        }//Map
           
    }
}
