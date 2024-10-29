using Microsoft.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp1;

namespace WinFormsApp1Tests1
{
    [TestClass]
    public class UpdateRequestTests
    {
        [TestMethod]
        public void Test_UpdateRequest_NonExistentID()
        {
            // Arrange
            int id = -1; // Не существующий ID

            // Act & Assert
            Assert.ThrowsException<SqlException>(() =>
                DatabaseHelper.UpdateRequest(id, 1, "Высокий", DateTime.Now, 206720587, "Неисправность", "Описание", 2, "Неизвестно", 1000)
            );
        }
    }
}
