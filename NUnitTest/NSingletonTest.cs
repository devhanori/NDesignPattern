using NDesignPattern;
using System.Reflection.Emit;

namespace NUnitTest
{
    [TestClass]
    public class NSingletonTest
    {

        [TestMethod]
        public void Test_Singleton_1()
        {
            var test = NSingleton.instance;
        }

        public class Test : Singleton<Test>
        {
            public Test() { }
            public int testNum = 100;
        }

        [TestMethod]
        public void Test_Singleton_Lasy()
        {
            var test = Test.Instance.testNum;
        }

        [TestMethod]
        public void Test_Singleton_2()
        {
            var test = NSingletonStatic.getId();
        }
    }
}