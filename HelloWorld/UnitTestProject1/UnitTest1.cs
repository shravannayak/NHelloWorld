using System;
using HelloWorld.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddCommandCheck()
        {
            //Arrange
            var vm = new SQL_VM();  
            //Act
            vm.AddCommand.Execute(null);
            //Assert
            Assert.IsTrue(vm.TFlag == 1,"Failed");
        }
    }
}
