using Kurs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KursTests
{
    [TestClass]
    public class Reg
    {
        MethReg methReg = new MethReg();

        [TestMethod]
        public void RegTestSuccess()
        {
            bool actual = true,
               expected = true;

            string TxtLogin = "login3",
                   PasPassword = "login3",
                   TxtФамилия = "Иванов",
                   TxtИмя = "Иван",
                   TxtОтчество = "Иванович",
                   TxtДатаР = "17.08.2000",
                   TxtВозраст = "20",
                   TxtПол = "1",
                   TxtНомер = "89123456789";

            try
            {
                actual = methReg.Button_Reg(TxtLogin, PasPassword, TxtФамилия, TxtИмя, TxtОтчество, TxtДатаР, TxtВозраст, TxtПол, TxtНомер);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RegTestPasswordFail()
        {
            bool actual = false,
               expected = false;

            string TxtLogin = "login1",
                   PasPassword = "",
                   TxtФамилия = "Иванов",
                   TxtИмя = "Иван",
                   TxtОтчество = "Иванович",
                   TxtДатаР = "17.08.2000",
                   TxtВозраст = "20",
                   TxtПол = "1",
                   TxtНомер = "89123456789";

            try
            {
                actual = methReg.Button_Reg(TxtLogin, PasPassword, TxtФамилия, TxtИмя, TxtОтчество, TxtДатаР, TxtВозраст, TxtПол, TxtНомер);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RegTestSecondFail()
        {
            bool actual = false,
               expected = false;

            string TxtLogin = "login1",
                   PasPassword = "login1",
                   TxtФамилия = "",
                   TxtИмя = "Иван",
                   TxtОтчество = "Иванович",
                   TxtДатаР = "17.08.2000",
                   TxtВозраст = "20",
                   TxtПол = "1",
                   TxtНомер = "89123456789";

            try
            {
                actual = methReg.Button_Reg(TxtLogin, PasPassword, TxtФамилия, TxtИмя, TxtОтчество, TxtДатаР, TxtВозраст, TxtПол, TxtНомер);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RegTestFirstFail()
        {
            bool actual = false,
               expected = false;

            string TxtLogin = "login1",
                   PasPassword = "login1",
                   TxtФамилия = "Иванов",
                   TxtИмя = "",
                   TxtОтчество = "Иванович",
                   TxtДатаР = "17.08.2000",
                   TxtВозраст = "20",
                   TxtПол = "1",
                   TxtНомер = "89123456789";

            try
            {
                actual = methReg.Button_Reg(TxtLogin, PasPassword, TxtФамилия, TxtИмя, TxtОтчество, TxtДатаР, TxtВозраст, TxtПол, TxtНомер);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RegTestMiddleSuccess()
        {
            bool actual = true,
               expected = true;

            string TxtLogin = "login1",
                   PasPassword = "login1",
                   TxtФамилия = "Иванов",
                   TxtИмя = "Иванов",
                   TxtОтчество = "",
                   TxtДатаР = "17.08.2000",
                   TxtВозраст = "20",
                   TxtПол = "1",
                   TxtНомер = "89123456789";

            try
            {
                actual = methReg.Button_Reg(TxtLogin, PasPassword, TxtФамилия, TxtИмя, TxtОтчество, TxtДатаР, TxtВозраст, TxtПол, TxtНомер);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
