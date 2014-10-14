using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorLib
{
    public class Computer
    {
        private ComputerSystem mediator;
        public Computer(ComputerSystem mediator)
        {
            this.mediator = mediator;
            this.mediator.RegisterComputer(this);
        }

        public void SwitchOn()
        {
            this.mediator.ComputerSwitchedOn();
        }

        public void SwitchOff()
        {
            this.mediator.ComputerSwitchedOff();
        }
    }
}
