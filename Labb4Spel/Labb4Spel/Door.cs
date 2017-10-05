using System;
using System.Collections.Generic;
using System.Text;

namespace Labb4Spel
{
    public class Door : Blocks
    {
        public override ByggBlock RoomType { get; set; } = ByggBlock.door;

        public bool OpenDoor {
            get;
            set;
        }

        public override bool isPassable()
        {
            if (OpenDoor == true)
                return true;
            else
                return false;
        }

        public override char printBlock()
        {
            return (char)ByggBlock.door;
        }
    }
}
