using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4Spel
{
    public class Monster1 : Blocks
    {
        public int Monster { get; set; }
        public override ByggBlock RoomType { get; set; } = ByggBlock.monster;


        public override bool isPassable()
        {
                return true;
        }

        public override char printBlock()
        {
            return (char)ByggBlock.monster;
        }

    }
}
