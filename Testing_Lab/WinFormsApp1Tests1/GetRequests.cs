using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp1;

namespace WinFormsApp1Tests1
{
    [TestClass]
    public class GetRequests
    {
        [TestMethod]
        public void Test_GetRequests_ValidSearch()
        {
            // Arrange
            string search = "работ";

            // Act
            var result = DatabaseHelper.GetRequests(search);

            // Assert
            Assert.IsTrue(result.Rows.Count > 0, "Должны быть найдены заявки с указанным описанием проблемы.");
        }

        [TestMethod]
        public void Test_GetRequests_EmptySearch()
        {
            // Act
            var result = DatabaseHelper.GetRequests("");

            // Assert
            Assert.IsTrue(result.Rows.Count > 0, "Должны быть найдены все заявки.");
        }
    }
}
