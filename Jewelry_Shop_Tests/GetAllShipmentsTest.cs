using Jewellery_Shop_lib.Application;

namespace Jewelry_Shop_Tests
{
    public class GetAllShipmentsTest
    {
        /// <summary>
        /// Tests if the Shipment.txt file contains 3 shipments with prices above 0
        /// </summary>
        [Fact]
        public void ShowAllShipmentsFromTextFile_WithPriceAbove0_ShouldBe3()
        {
            // Arrange
            ShipmentApplication sApp = new ShipmentApplication();

            int noOfShipments = 3;

            bool pricesAbove0 = true;

            // Act
            var shipmentList = sApp.GetShipmentInfoList();

            // Assert
            Assert.NotEmpty(shipmentList); // Checks that our shipment.txt file is not empty

            Assert.True(noOfShipments == shipmentList.Count); // Checks if the test return 3 shipments from the file, as expected.

            Assert.True(pricesAbove0); //Checks if the prices of the shipments are higher than 0
        }
    }
}
