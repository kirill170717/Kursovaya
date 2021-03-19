using Kurs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KursTests
{
    [TestClass]
    public class UpdRaspKlTests
    {
        MethPre methPre = new MethPre();

        [TestMethod]
        public void PresTestSuccess()
        {
            bool actual = true,
               expected = true;

            string Date = "02.09.2020",
                   Pres = "1";

            try
            {
                actual = methPre.Button_Pre(Date, Pres);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PresTestDateNullFail()
        {
            bool actual = false,
               expected = false;

            string Date = "",
                   Pres = "1";

            try
            {
                actual = methPre.Button_Pre(Date, Pres);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PresTestPresNullFail()
        {
            bool actual = false,
               expected = false;

            string Date = "02.09.2020",
                   Pres = "";

            try
            {
                actual = methPre.Button_Pre(Date, Pres);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PresTestNullFail()
        {
            bool actual = false,
               expected = false;

            string Date = "",
                   Pres = "";

            try
            {
                actual = methPre.Button_Pre(Date, Pres);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PresTestSuccess2()
        {
            bool actual = true,
               expected = true;

            string Date = "02.09.2020",
                   Pres = "2";

            try
            {
                actual = methPre.Button_Pre(Date, Pres);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
