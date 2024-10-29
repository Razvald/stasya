using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp1;

namespace WinFormsApp1Tests1
{
    [TestClass]
    public class GetTotalRequests
    {
        [TestMethod]
        public void Test_GetTotalRequests()
        {
            // Act
            var totalRequests = DatabaseHelper.GetTotalRequests();

            // Assert
            Assert.IsTrue(totalRequests >= 0, "Общее количество заявок должно быть неотрицательным.");
        }
    }
}
