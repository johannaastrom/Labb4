using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4Spel
{
    class EmptyRoom : Blocks
    {
        public override ByggBlock RoomType { get; set; } = ByggBlock.emptyroom;

        public override bool isPassable()
        {
            return true;
        }

        public override char printBlock()
        {
            return (char)ByggBlock.emptyroom;
        }
    }
}
