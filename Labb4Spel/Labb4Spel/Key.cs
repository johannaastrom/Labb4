using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4Spel
{
    public class Key : Blocks
    {
        public bool hasKey { get; set; }
        public override ByggBlock RoomType { get; set; } = ByggBlock.keyroom;

        public override bool isPassable()
        {
            return true;
        }

        public override char printBlock()
        {
            return (char)ByggBlock.keyroom;
        }

    }
}
