﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4Spel
{
    public class EmptySpace : Blocks 
    {
        public override ByggBlock RoomType { get; set; } = ByggBlock.emptyspace;

        public override bool isPassable()
        {
            return true;
        }

        public override char printBlock()
        {
            return (char)ByggBlock.emptyspace;
        }
    }
}
