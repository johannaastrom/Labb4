using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4Spel
{
    public class Key : Blocks
    {
        public bool hasKey { get; set; }

        public override bool isPassable()
        {
            return true;
        }

        public override string printBlock()
        {
            return "K";
        }

    }
}
