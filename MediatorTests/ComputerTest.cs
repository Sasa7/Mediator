using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MediatorLib;

namespace MediatorTests
{
    [TestClass]
    public class ComputerTest
    {
        [TestMethod]
        public void Test_That_Computer_Is_Functioning()
        {
            //Arrange
            ComputerSystem aSystem = new ComputerSystem();
            Computer aComputer = new Computer(aSystem);
            Keyboard aKeyboard = new Keyboard(aSystem);
            Screen aScreen = new Screen(aSystem);
            //Act
            aComputer.SwitchOn();
            aKeyboard.KeyPressed("C");
            //Assert
        }
    }
}
