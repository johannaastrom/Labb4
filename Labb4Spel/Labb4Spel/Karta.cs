using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4Spel

//De som spelat:      Poäng:
//1.
//2.
//3.    
{
    public class Karta : IColor
    {
        public void Color()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        public void Map()
        {
            Color();
            Console.WriteLine(@"Welcome to the craziest game on earth!

Press any key to enter...");
            Console.ReadKey();
            Console.Clear();

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

            int Counter = 0;

            Door door = null;
            Exit exit = null;
            Monster1 monster = null;
            KeyRoom key1 = new KeyRoom();
            key1.hasTheKey = false;
            Character gubbe = new Character(3, 11);
            gubbe.playerColumn = 3;
            gubbe.playerRow = 11;

            // Skapa karta
            for (int row = 0; row < ROWS; row++)
            {
                for (int column = 0; column < COLUMNS; column++)
                {

                    if (row == 0 || row == ROWS - 1 || column == 0 || column == COLUMNS - 1 || column == 1 && row == 8 || column == 2 && row == 8 ||
                        column == 3 && row == 8 || column == 5 && row == 8 || column == 6 && row == 8 || column == 7 && row == 8 || column == 8 && row == 8
                        || column == 9 && row == 8 || column == 10 && row == 8 || column == 11 && row == 8 || column == 12 && row == 8 || column == 13 && row == 8
                        || column == 14 && row == 8 || column == 15 && row == 8 || column == 16 && row == 8 || column == 17 && row == 8 || column == 18 && row == 8
                        || column == 19 && row == 8 || column == 20 && row == 8 || column == 21 && row == 8 || column == 22 && row == 8)
                        map[column, row] = new Wall();

                    else if (row == 10 && column == 20)
                        map[column, row] = new KeyRoom();

                    else if (row == 8 && column == 4)
                    {
                        map[column, row] = new Door();
                        door = (Door)map[column, row];
                    }
                    else if (row == 1 && column == 22)
                    {
                        map[column, row] = new Exit();
                        exit = (Exit)map[column, row];
                    }
                    else if (row == 3 && column == 20 || row == 9 && column == 3 || row == 9 && column == 5 )
                    {
                        map[column, row] = new Monster1();
                        monster = (Monster1)map[column, row];
                    }
                    else
                        map[column, row] = new EmptySpace();

                }
            }
            bool endGame = true;
            while (endGame)  // TODO: lägg till ett mål som avbryter loopen
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

                // ta reda på om rummet är ett keyroom (enum)
                // gör typecast på map[..]
                // if hasthekey
                Blocks newPosition = map[gubbe.playerColumn, gubbe.playerRow];
                if (newPosition.RoomType == Blocks.ByggBlock.monster)
                {
                    Counter += 10;
                }
                if (newPosition.RoomType == Blocks.ByggBlock.keyroom)
                {

                    KeyRoom keyRoom = (KeyRoom)newPosition;
                    if (keyRoom.hasTheKey)
                    {
                        gubbe.hasKeyToNextRoom = true;
                        keyRoom.hasTheKey = false;

                        door.OpenDoor = true;
                    }

                }
                if (newPosition.RoomType == Blocks.ByggBlock.exit)
                    endGame = false;



                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.W && map[gubbe.playerColumn, gubbe.playerRow - 1].isPassable())
                {
                    gubbe.playerRow--;
                    Counter++;
                }
                else if (key.Key == ConsoleKey.A && map[gubbe.playerColumn - 1, gubbe.playerRow].isPassable())
                {
                    gubbe.playerColumn--;
                    Counter++;
                }
                else if (key.Key == ConsoleKey.S && map[gubbe.playerColumn, gubbe.playerRow + 1].isPassable())
                {
                    gubbe.playerRow++;
                    Counter++;
                }
                else if (key.Key == ConsoleKey.D && map[gubbe.playerColumn + 1, gubbe.playerRow].isPassable())
                {
                    gubbe.playerColumn++;
                    Counter++;
                }

                Console.WriteLine("");
                Console.WriteLine($"You have taken {Counter} steps!");
            }//while

            Console.Clear();
            Console.WriteLine($"Grattis du klarade det! Du fick {Counter} poäng");
            
        }//Map


    }
}