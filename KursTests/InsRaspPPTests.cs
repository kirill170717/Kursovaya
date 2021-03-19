using Kurs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KursTests
{
    [TestClass]
    public class InsRaspPPTests
    {
        MethRasp methRasp = new MethRasp();

        [TestMethod]
        public void InsRaspPPTestSuccess()
        {
            bool actual = true,
               expected = true;

            string TxtДатаНПП = "01.01.2020",
                   TxtДатаКПП = "31.12.2020",
                   Group2 = "2";

            try
            {
                actual = methRasp.Button_InsPP(TxtДатаНПП, TxtДатаКПП, Group2);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsRaspPPTestNullFail()
        {
            bool actual = false,
               expected = false;

            string TxtДатаНПП = "",
                   TxtДатаКПП = "",
                   Group2 = "";

            try
            {
                actual = methRasp.Button_InsPP(TxtДатаНПП, TxtДатаКПП, Group2);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsRaspPPTestNPPNullFail()
        {
            bool actual = false,
               expected = false;

            string TxtДатаНПП = "",
                   TxtДатаКПП = "31.12.2020",
                   Group2 = "2";

            try
            {
                actual = methRasp.Button_InsPP(TxtДатаНПП, TxtДатаКПП, Group2);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsRaspPPTestKPPNullFail()
        {
            bool actual = false,
               expected = false;

            string TxtДатаНПП = "01.01.2020",
                   TxtДатаКПП = "",
                   Group2 = "2";

            try
            {
                actual = methRasp.Button_InsPP(TxtДатаНПП, TxtДатаКПП, Group2);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsRaspPPTestGrNullFail()
        {
            bool actual = false,
               expected = false;

            string TxtДатаНПП = "01.01.2020",
                   TxtДатаКПП = "31.12.2020",
                   Group2 = "";

            try
            {
                actual = methRasp.Button_InsPP(TxtДатаНПП, TxtДатаКПП, Group2);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
