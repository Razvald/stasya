using Microsoft.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp1;

namespace WinFormsApp1Tests1
{
    [TestClass]
    public class AddRequest
    {
        [TestMethod]
        public void Test_AddRequest_ValidData()
        {
            // Arrange
            int id = (int)DatabaseHelper.GetLastIndex() + 1;

            // Act
            DatabaseHelper.AddRequest(id, 1, "Высокий", DateTime.Now, 206720587, "Неисправность", "Описание", 2, "Неизвестно", 1000);

            // Assert
            var lastIndex = DatabaseHelper.GetLastIndex();
            Assert.AreEqual(id, lastIndex, "Новая заявка должна быть добавлена с указанным идентификатором.");
        }

        [TestMethod]
        public void Test_AddRequest_DuplicateID()
        {
            // Arrange
            int id = 1; // Существующий ID

            // Act & Assert
            Assert.ThrowsException<SqlException>(() => DatabaseHelper.AddRequest(id, 1, "Высокий", DateTime.Now, 1, "Неисправность", "Описание", 2, "Неизвестно", 1000));
        }

    }
}
