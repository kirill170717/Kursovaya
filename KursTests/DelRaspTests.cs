using Kurs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KursTests
{
    [TestClass]
    public class DelRaspTests
    {
        MethRasp methRasp = new MethRasp();

        [TestMethod]
        public void DelRaspTestSuccess()
        {
            bool actual = true,
               expected = true;

            string Id = "16";

            try
            {
                actual = methRasp.Button_Del(Id);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DelRaspTestNullFail()
        {
            bool actual = false,
               expected = false;

            string Id = "";

            try
            {
                actual = methRasp.Button_Del(Id);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DelRaspTestIdFail()
        {
            bool actual = false,
               expected = false;

            string Id = "99";

            try
            {
                actual = methRasp.Button_Del(Id);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DelRaspTestEnFail()
        {
            bool actual = false,
               expected = false;

            string Id = "wadwd";

            try
            {
                actual = methRasp.Button_Del(Id);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DelRaspTestRuFail()
        {
            bool actual = false,
               expected = false;

            string Id = "аыуа";

            try
            {
                actual = methRasp.Button_Del(Id);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
