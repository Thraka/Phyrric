﻿using Microsoft.Xna.Framework;
using SadConsole;
using SadConsole.Consoles;

namespace Phyrric.Panels
{
    public class MessagePanel : Console
    {

        public MessagePanel()
            : base(Constants.MESSAGEPANEL_WIDTH - 2, Constants.MESSAGEPANEL_HEIGHT - 2)
        {
            Position = new Point(Constants.MESSAGEPANEL_X + 1, Constants.MESSAGEPANEL_Y + 1);

            ShiftRight(1);
        }

        public void PrintMessage(string msg)
        {
            ShiftDown(1);
            VirtualCursor.Print(msg).CarriageReturn();
        }

        public void PrintMessage(ColoredString msg)
        {
            ShiftDown(1);
            VirtualCursor.Print(msg).CarriageReturn();
        }
    }
}
