using Kurs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KursTests
{
    [TestClass]
    public class InsRaspTests
    {
        MethRasp methRasp = new MethRasp();

        [TestMethod]
        public void InsRaspTestSuccess()
        {
            bool actual = true,
               expected = true;

            string TxtДатаТ = "20.12.2020",
                   TxtУпр = "Подача",
                   TxtIdPT = "1",
                   Group = "1";

            try
            {
                actual = methRasp.Button_Ins(TxtДатаТ, TxtУпр, TxtIdPT, Group);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsRaspTestNullFail()
        {
            bool actual = false,
               expected = false;

            string TxtДатаТ = "",
                   TxtУпр = "",
                   TxtIdPT = "",
                   Group = "";

            try
            {
                actual = methRasp.Button_Ins(TxtДатаТ, TxtУпр, TxtIdPT, Group);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsRaspTestDateNullFail()
        {
            bool actual = false,
               expected = false;

            string TxtДатаТ = "",
                   TxtУпр = "Подача",
                   TxtIdPT = "1",
                   Group = "2";

            try
            {
                actual = methRasp.Button_Ins(TxtДатаТ, TxtУпр, TxtIdPT, Group);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsRaspTestExNullFail()
        {
            bool actual = false,
               expected = false;

            string TxtДатаТ = "20.12.2020",
                   TxtУпр = "",
                   TxtIdPT = "1",
                   Group = "2";

            try
            {
                actual = methRasp.Button_Ins(TxtДатаТ, TxtУпр, TxtIdPT, Group);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsRaspTestIdPTNullFail()
        {
            bool actual = false,
               expected = false;

            string TxtДатаТ = "20.12.2020",
                   TxtУпр = "Подача",
                   TxtIdPT = "",
                   Group = "2";

            try
            {
                actual = methRasp.Button_Ins(TxtДатаТ, TxtУпр, TxtIdPT, Group);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
