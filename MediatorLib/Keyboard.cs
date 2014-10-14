﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class Keyboard
    {
        private ComputerSystem mediator;
        public Keyboard(ComputerSystem mediator)
        {
            this.mediator = mediator;
            this.mediator.RegisterKeyboard(this);
        }

        public void Enabled()
        {

        }

        public void Disabled()
        {

        }

        public void KeyPressed()
        {
            mediator.KeyboardKeyPressed();
        }
    }
}
