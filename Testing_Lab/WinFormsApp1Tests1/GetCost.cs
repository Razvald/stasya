using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp1;

namespace WinFormsApp1Tests1
{
    [TestClass]
    public class GetCost
    {
        [TestMethod]
        public void Test_GetMaxCost()
        {
            // Act
            var maxCost = DatabaseHelper.GetMaxCost();
            var minCost = DatabaseHelper.GetMinCost();

            // Assert
            Assert.IsTrue(maxCost >= 0, "Максимальная стоимость должна быть неотрицательной.");
            Assert.IsTrue(maxCost >= minCost, "Максимальная стоимость должна быть неотрицательной.");
        }

        [TestMethod]
        public void Test_GetMinCost()
        {
            // Act
            var minCost = DatabaseHelper.GetMinCost();
            var maxCost = DatabaseHelper.GetMaxCost();

            // Assert
            Assert.IsTrue(minCost >= 0, "Минимальная стоимость должна быть неотрицательной.");
            Assert.IsTrue(minCost <= maxCost, "Минимальная стоимость должна быть неотрицательной.");
        }
    }
}
