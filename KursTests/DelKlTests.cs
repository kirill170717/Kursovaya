using Kurs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KursTests
{
    [TestClass]
    public class DelKlTests
    {
        MethCli methCli = new MethCli();

        [TestMethod]
        public void DelTestSuccess()
        {
            bool actual = true,
               expected = true;

            string Id = "15";

            try
            {
                actual = methCli.Button_Del(Id);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DelTestNullFail()
        {
            bool actual = false,
               expected = false;

            string Id = "";

            try
            {
                actual = methCli.Button_Del(Id);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DelTestSumbFail()
        {
            bool actual = false,
               expected = false;

            string Id = "@";

            try
            {
                actual = methCli.Button_Del(Id);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DelTestEnFail()
        {
            bool actual = false,
               expected = false;

            string Id = "ada";

            try
            {
                actual = methCli.Button_Del(Id);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DelTestRuFail()
        {
            bool actual = false,
               expected = false;

            string Id = "фвф";

            try
            {
                actual = methCli.Button_Del(Id);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
