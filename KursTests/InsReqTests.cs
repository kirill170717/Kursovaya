using Kurs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KursTests
{
    [TestClass]
    public class InsReqTests
    {
        MethPZ methPZ = new MethPZ();

        [TestMethod]
        public void ReqTestSuccess()
        {
            bool actual = true,
               expected = true;

            string CbTr = "8",
                   TxtPur = "Играть";

            try
            {
                actual = methPZ.Button_App(CbTr, TxtPur);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReqTestPurFail()
        {
            bool actual = false,
               expected = false;

            string CbTr = "7",
                   TxtPur = "";

            try
            {
                actual = methPZ.Button_App(CbTr, TxtPur);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReqTestTrFail()
        {
            bool actual = false,
               expected = false;

            string CbTr = "",
                   TxtPur = "Играть";

            try
            {
                actual = methPZ.Button_App(CbTr, TxtPur);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReqTestNullFail()
        {
            bool actual = false,
               expected = false;

            string CbTr = "",
                   TxtPur = "";

            try
            {
                actual = methPZ.Button_App(CbTr, TxtPur);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReqTestSumbFail()
        {
            bool actual = false,
               expected = false;

            string CbTr = "@",
                   TxtPur = "@";

            try
            {
                actual = methPZ.Button_App(CbTr, TxtPur);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
