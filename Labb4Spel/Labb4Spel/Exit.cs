using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4Spel
{
    class Exit : Blocks
    {
        public bool ExitDoor { get; set;  }
        public override ByggBlock RoomType { get; set; } = ByggBlock.exit;

        public override bool isPassable()
        {
            if (ExitDoor == true)
                return true;
            else
                return false;
        }

        public override char printBlock()
        {
            return (char)ByggBlock.exit;
        }
    }
}
