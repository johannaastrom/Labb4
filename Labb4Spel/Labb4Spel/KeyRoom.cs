using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4Spel
{
    class KeyRoom : Blocks
    {
        public override ByggBlock RoomType { get; set; } = ByggBlock.keyroom;

        public bool hasTheKey { get; set; }

        public override bool isPassable()
        {
            return true;
        }

        public override char printBlock()
        {
            if (hasTheKey)
                return (char)ByggBlock.keyroom;
            else
                return (char)ByggBlock.emptyroom;
        }
        public KeyRoom()
        {
            hasTheKey = true;
            RoomType = ByggBlock.keyroom;
        }        
    }
}
