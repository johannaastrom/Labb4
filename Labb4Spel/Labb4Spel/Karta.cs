using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4Spel
{
    public class Karta
    {
        

        public void Map()
        {
           

            #region Gammal kod
            ////Wall vägg = new Wall();
            ////Character gubbe = new Character();

            //int rad = 20, kolumn = 40;
            //Blocks[,] map = new Blocks[rad, kolumn];
            //int positionX = 18;
            //int positionY = 3;
            //int r;
            //int k;
            //r = 0;
            //k = 0;


            ////string startPosition = map[positionX, positionY];
            //while (true)
            //{

            //    for (r = 0; r < rad; r++)
            //    {
            //        for (k = 0; k < kolumn; k++)
            //        {

            //            if (r == positionX && k == positionY)
            //            {
            //                map[r, k] = new Character();
            //                Console.Write(map[r, k]);
            //            }
            //            else if (r == 0 || k == 0 || k == 39 || r == 19)
            //            {
            //                map[r, k] = new Wall(); //vägg.printBlock();
            //                Console.Write(map[r, k].printBlock());
            //            }

            //            else
            //            {
            //                map[r, k] = new EmptySpace();//tomrum
            //                Console.Write(map[r, k]);   
            //            }

            //        }//for k

            //        Console.WriteLine();

            //    }//for r
            //    System.ConsoleKeyInfo moveCharacter = Console.ReadKey();
            //    if (moveCharacter.Key == ConsoleKey.W)
            //    {
            //        positionX--;
            //        Console.Clear();
            //    }
            //    if (moveCharacter.Key == ConsoleKey.S)
            //    {
            //        positionX++;
            //        Console.Clear();
            //    }
            //    if (moveCharacter.Key == ConsoleKey.D)
            //    {
            //            positionY++;
            //            Console.Clear();
            //    }
            //    if (moveCharacter.Key == ConsoleKey.A)
            //    {
            //        positionY--;
            //        Console.Clear();
            //    }
            //}//while
            #endregion
            const int ROWS = 16, COLUMNS = 24;
            Blocks[,] map = new Blocks[COLUMNS, ROWS];

            Character gubbe = new Character(3, 11);
            Wall square = new Wall();
            
            // Skapa karta
            for (int row = 0; row < ROWS; row++)
            {
                for (int column = 0; column < COLUMNS; column++)
                {

                    if (row == 0 || row == ROWS - 1 || column == 0 || column == COLUMNS - 1)
                        map[column, row] = new Wall();

                    else
                        map[column, row] = new EmptySpace();

                }
            }

            while (true)  // TODO: lägg till ett mål som avbryter loopen
            {
                // Rita ut kartan
                string buffer = "";
                for (int row = 0; row < ROWS; row++)
                {
                    string line = "";
                    for (int column = 0; column < COLUMNS; column++)
                    {
                        if (column == gubbe.playerColumn && row == gubbe.playerRow)
                            line += gubbe.DisplayString();

                        else
                            line += map[column, row].printBlock();
                    }
                    //Console.WriteLine(line);
                    buffer += line + "\n";
                }
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                Console.Write(buffer);

                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.W && .isPassable)
                {
                    gubbe.playerRow--;
                }
                else if (key.Key == ConsoleKey.A)
                    gubbe.playerColumn--;
                else if (key.Key == ConsoleKey.S)
                    gubbe.playerRow++;
                else if (key.Key == ConsoleKey.D)
                    gubbe.playerColumn++;
            }//while
        }//Map

    }
}