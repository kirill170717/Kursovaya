using Kurs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KursTests
{
    [TestClass]
    public class InsTrTests
    {
        MethTrain methTrain = new MethTrain();

        [TestMethod]
        public void InsTrTestSuccess()
        {
            bool actual = true,
               expected = true;

            string TxtДостиж = "Мастер",
                   TxtОпыт = "11",
                   TxtЛогин = "Tr2",
                   TxtПароль = "Tr2",
                   TxtФамилия = "Иванов",
                   TxtИмя = "Иван",
                   TxtОтчество = "Иванович",
                   TxtНомер = "89231456789";

            try
            {
                actual = methTrain.Button_Ins(TxtДостиж, TxtОпыт, TxtЛогин, TxtПароль, TxtФамилия, TxtИмя, 
                    TxtОтчество, TxtНомер);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsTrTestNullFail()
        {
            bool actual = false,
               expected = false;

            string TxtДостиж = "",
                   TxtОпыт = "",
                   TxtЛогин = "",
                   TxtПароль = "",
                   TxtФамилия = "",
                   TxtИмя = "",
                   TxtОтчество = "",
                   TxtНомер = "";

            try
            {
                actual = methTrain.Button_Ins(TxtДостиж, TxtОпыт, TxtЛогин, TxtПароль, TxtФамилия, TxtИмя,
                    TxtОтчество, TxtНомер);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsTrTestMidSuccess()
        {
            bool actual = true,
               expected = true;

            string TxtДостиж = "Мастер",
                   TxtОпыт = "11",
                   TxtЛогин = "Tr",
                   TxtПароль = "Tr",
                   TxtФамилия = "Иванов",
                   TxtИмя = "Иван",
                   TxtОтчество = "",
                   TxtНомер = "89231456789";

            try
            {
                actual = methTrain.Button_Ins(TxtДостиж, TxtОпыт, TxtЛогин, TxtПароль, TxtФамилия, TxtИмя,
                    TxtОтчество, TxtНомер);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsTrTestAchFail()
        {
            bool actual = false,
               expected = false;

            string TxtДостиж = "",
                   TxtОпыт = "11",
                   TxtЛогин = "Tr",
                   TxtПароль = "Tr",
                   TxtФамилия = "Иванов",
                   TxtИмя = "Иван",
                   TxtОтчество = "Иванович",
                   TxtНомер = "89231456789";

            try
            {
                actual = methTrain.Button_Ins(TxtДостиж, TxtОпыт, TxtЛогин, TxtПароль, TxtФамилия, TxtИмя,
                    TxtОтчество, TxtНомер);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsTrTestExFail()
        {
            bool actual = false,
               expected = false;

            string TxtДостиж = "Мастер",
                   TxtОпыт = "",
                   TxtЛогин = "Tr3",
                   TxtПароль = "Tr3",
                   TxtФамилия = "Иванов",
                   TxtИмя = "Иван",
                   TxtОтчество = "Иванович",
                   TxtНомер = "89231456789";

            try
            {
                actual = methTrain.Button_Ins(TxtДостиж, TxtОпыт, TxtЛогин, TxtПароль, TxtФамилия, TxtИмя,
                    TxtОтчество, TxtНомер);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }
    }
}
