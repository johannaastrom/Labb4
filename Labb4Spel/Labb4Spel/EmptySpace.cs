﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4Spel
{
    public class EmptySpace : Blocks 
    {
        public override bool isPassable()
        {
            return true;
        }

        public override string printBlock()
        {
            return ".";
        }
    }
}
