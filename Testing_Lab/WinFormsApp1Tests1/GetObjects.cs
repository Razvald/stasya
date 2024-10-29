using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp1;

namespace WinFormsApp1Tests1
{
    [TestClass]
    public class GetObjects
    {
        [TestMethod]
        public void Test_GetClients()
        {
            // Act
            var clients = DatabaseHelper.GetClients();

            // Assert
            Assert.IsTrue(clients.Count > 0, "Должны быть найдены клиенты.");
        }

        [TestMethod]
        public void Test_GetEquipment()
        {
            // Act
            var equipmentList = DatabaseHelper.GetEquipment();

            // Assert
            Assert.IsTrue(equipmentList.Count > 0, "Должны быть найдены записи об оборудовании.");
        }
    }
}
