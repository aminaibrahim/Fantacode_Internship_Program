using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace TestMyApp
{
    [TestFixture(Platform.Android)]
  //  [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }
        [Test]
        public void Add_6_to_10()
        {
            //Arrange
            app.EnterText("num1","12");
            app.EnterText("num2", "12");
            //Act
            app.Tap("AddTap");
            //Assert
            var appResult = app.Query("ResultId").First(result => result.Text == "24");
            Assert.IsTrue(appResult != null, "label not displaying");
        }
        [Test]
        public void Mul_6_to_10()
        {
            //Arrange
            app.EnterText("num1", "2");
            app.EnterText("num2", "2");
            //Act
            app.Tap("MulTap");
            //Assert
            var appResult = app.Query("ResultId").First(result => result.Text == "4");
            Assert.IsTrue(appResult != null, "label not displaying");
        }
    }
}

