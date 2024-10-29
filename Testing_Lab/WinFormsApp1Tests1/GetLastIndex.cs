using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp1;

namespace WinFormsApp1Tests1
{
    [TestClass]
    public class GetLastIndex
    {
        [TestMethod]
        public void Test_GetLastIndex_ExistingTable()
        {
            // Act
            var result = DatabaseHelper.GetLastIndex("Заявка");

            // Assert
            Assert.IsTrue(result.HasValue, "Должен возвращаться действующий номер.");
        }

        [TestMethod]
        public void Test_GetLastIndex_ReturnsLastIndex()
        {
            // Act
            var lastIndex = DatabaseHelper.GetLastIndex();

            // Assert
            Assert.AreEqual(lastIndex, DatabaseHelper.GetTotalRequests());
        }
    }
}
