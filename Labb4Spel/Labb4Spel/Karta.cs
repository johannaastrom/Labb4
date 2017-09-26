using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4Spel
{
    public class Karta
    {
        public void Map()
        {
            Wall vägg = new Wall();
            Character gubbe = new Character();

            int rad = 20, kolumn = 40;
            Blocks[,] map = new Blocks[rad, kolumn];
            int positionX = 18;
            int positionY = 3;
            int r;
            int k;
            r = 0;
            k = 0;


            //string startPosition = map[positionX, positionY];
            while (true)
            {
                
                for (r = 0; r < rad; r++)
                {
                    for (k = 0; k < kolumn; k++)
                    {

                        if (r == positionX && k == positionY)
                        {
                            map[r, k] = new Character();
                            Console.Write(map[r, k]);
                        }
                        else if (r == 0 || k == 0 || k == 39 || r == 19)
                        {
                            map[r, k] = new Wall(); //vägg.printBlock();
                            Console.Write(map[r, k].printBlock());
                        }
                           
                        else
                        {
                            map[r, k] = new EmptySpace();//tomrum
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
                if (moveCharacter.Key == ConsoleKey.S)
                {
                    positionX++;
                    Console.Clear();
                }
                if (moveCharacter.Key == ConsoleKey.D)
                {
                    //if(map[r,k+1]=="#")
                        positionY++;
                        Console.Clear();
                    
                        // #####################
                        // #.......@...........#
                }
                if (moveCharacter.Key == ConsoleKey.A)
                {
                    positionY--;
                    Console.Clear();
                }
            }//while
        }//Map

    }
}
