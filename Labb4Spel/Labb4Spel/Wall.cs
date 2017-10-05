using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4Spel
{
    public class Wall : Blocks
    {
        public override ByggBlock RoomType { get; set; } = ByggBlock.wall;

        public override char printBlock()
        {
            return (char)ByggBlock.wall;
        }
        public override bool isPassable()
        {
            return false;
        }

    }
}
