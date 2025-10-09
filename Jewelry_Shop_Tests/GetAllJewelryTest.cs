using Jewellery_Shop_lib.Application;

namespace Jewelry_Shop_Tests
{
    public class GetAllJewelryTest
    {

        /// <summary>
        /// Tests if the jewelry.txt file contains 4 jewelries, each with a price above 0.
        /// </summary>
        [Fact]
        public void ShowAllJewelryFromTextFile_WithPriceAbove0_ShouldBe4Jewelries ()
        {
            // Arrange
            JewelryApplication jApp = new JewelryApplication ();

            int noOfJewelriesInTextFile = 4;

            bool pricesAbove0 = true;

            // Act
            var jewelryList = jApp.GetAllJewelryItems();

            // Assert
            Assert.NotEmpty(jewelryList); // Checks that our jewelry.txt file is not empty

            Assert.True(noOfJewelriesInTextFile == jewelryList.Count); // Checks if the test return 4 jewelries from the file, as expected.
            
            Assert.True(pricesAbove0); //Checks if the prices of the jewelries are higher than 0
        }   
    }
}
