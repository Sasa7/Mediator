using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class ComputerSystem
    {
        private Computer computer;
        private Keyboard keyboard;
        private Screen screen;
        internal void RegisterComputer(Computer computer)
        {
            this.computer = computer;
        }


        internal void RegisterKeyboard(Keyboard keyboard)
        {
            this.keyboard = keyboard;
        }

        internal void RegisterScreen(Screen screen)
        {
            this.screen = screen;
        }

        internal void ComputerSwitchedOn()
        {
            Console.WriteLine("Computer switched ON");
        }

        internal void ComputerSwitchedOff()
        {
            Console.WriteLine("Computer switched OFF");
        }

        internal void KeyboardKeyPressed(string key)
        {
            Console.WriteLine("Keyboard key pressed");
            screen.DisplayCharacter(key);
        }
    }
}
