using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4Spel
{
    public abstract class Blocks
    {
        public abstract char printBlock();

        public abstract bool isPassable();

        public enum ByggBlock
        {
            keyroom = 'K',
            emptyroom = 'O',
            wall = '#',
            emptyspace = '.',
            door = 'D',
            monster = 'M',
                exit = 'E'
        }


        public abstract ByggBlock RoomType { get; set; }
    }
}
