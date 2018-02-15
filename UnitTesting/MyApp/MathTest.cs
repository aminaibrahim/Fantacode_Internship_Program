using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting.ViewModels;

namespace MyApp
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void Add_8_and_6()
        {
            //Arrange
            var test = new MainViewModel();
            test.valueA = 8;
            test.valueB = 6;
            //Act
            test.AddCommand.Execute(null);
            //Assert
            Assert.IsTrue(test.result == 14, "not correct");
        }
    }
}
