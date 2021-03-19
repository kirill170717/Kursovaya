using Kurs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KursTests
{
    [TestClass]
    public class DelReqTests
    {
        MethReq methReq = new MethReq();

        [TestMethod]
        public void AuthTestSuccess()
        {
            bool actual = true,
               expected = true;

            string Id = "8";

            try
            {
                actual = methReq.Button_Del(Id);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DelReqTestRuFail()
        {
            bool actual = false,
               expected = false;

            string Id = "фцвфц";

            try
            {
                actual = methReq.Button_Del(Id);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DelReqTestFail()
        {
            bool actual = false,
               expected = false;

            string Id = "99";

            try
            {
                actual = methReq.Button_Del(Id);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DelReqTestNullFail()
        {
            bool actual = false,
               expected = false;

            string Id = "";

            try
            {
                actual = methReq.Button_Del(Id);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DelReqTestSumbFail()
        {
            bool actual = false,
               expected = false;

            string Id = "@";

            try
            {
                actual = methReq.Button_Del(Id);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
