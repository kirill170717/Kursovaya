using Kurs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KursTests
{
    [TestClass]
    public class Auth
    {
        MethAuth methAuth = new MethAuth();

        [TestMethod]
        public void AuthTestSuccess()
        {
            bool actual = true,
               expected = true;

            string TxtLogin = "Rinne",
                   PasPassword = "159357";

            try
            {
                actual = methAuth.Button_Auth(TxtLogin, PasPassword);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AuthTestAdminSuccess()
        {
            bool actual = true,
               expected = true;

            string TxtLogin = "Admin",
                   PasPassword = "Admin";

            try
            {
                actual = methAuth.Button_Auth(TxtLogin, PasPassword);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AuthTestFail()
        {
            bool actual = false,
               expected = false;

            string TxtLogin = "",
                   PasPassword = "";

            try
            {
                actual = methAuth.Button_Auth(TxtLogin, PasPassword);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AuthTestLoginFail()
        {
            bool actual = false,
               expected = false;

            string TxtLogin = "Rinne",
                   PasPassword = "";

            try
            {
                actual = methAuth.Button_Auth(TxtLogin, PasPassword);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AuthTestPasswordFail()
        {
            bool actual = false,
               expected = false;

            string TxtLogin = "",
                   PasPassword = "159357";

            try
            {
                actual = methAuth.Button_Auth(TxtLogin, PasPassword);
            }
            catch
            {
                Assert.Fail();
            }
            Assert.AreEqual(expected, actual);
        }
    }
}