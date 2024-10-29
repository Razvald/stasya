using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp1;

namespace WinFormsApp1Tests1
{
    [TestClass]
    public class TryAuth
    {
        [TestMethod]
        public void Test_TryAuth_ValidCredentials()
        {
            // Arrange
            string login = "1";
            string password = "1";

            // Act
            var result = DatabaseHelper.TryAuth(login, password);

            // Assert
            Assert.IsNotNull(result, "Должен быть возвращен действующий номер сотрудника.");
        }

        [TestMethod]
        public void Test_TryAuth_InvalidCredentials()
        {
            // Arrange
            string login = "invalidLogin";
            string password = "invalidPassword";

            // Act
            var result = DatabaseHelper.TryAuth(login, password);

            // Assert
            Assert.IsNull(result, "При неверных данных аутентификации должен возвращаться null.");
        }

    }
}
