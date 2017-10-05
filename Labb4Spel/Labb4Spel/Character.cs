using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4Spel
{
    public class Character
    {
        public int playerRow { get; set; }
        public int playerColumn { get; set; }
        public bool hasKeyToNextRoom { get; set; }


           

        public string DisplayString()
        {
            return "@";
            
        }
        public Character(int playerRow, int playerColumn)
        {
            playerRow = 3;
            playerColumn = 11;
            hasKeyToNextRoom = false;
        }
    }

}
