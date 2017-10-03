using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4Spel
{
    class EnterRoom : Blocks
    {
        public override bool isPassable()
        {
            return true;
        }

        public override string printBlock()
        {
            return "O";
        }
    }
}
