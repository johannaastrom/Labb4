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
                return true;
        }

        public override char printBlock()
        {
            return (char)ByggBlock.exit;
        }
    }
}
