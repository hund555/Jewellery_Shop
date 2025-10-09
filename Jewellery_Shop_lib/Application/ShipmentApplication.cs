using Jewellery_Shop_lib.Application.Application_Interfaces;
using Jewellery_Shop_lib.Domain;
using Jewellery_Shop_lib.File_service;
using Jewellery_Shop_lib.Interface_Adapter;

namespace Jewellery_Shop_lib.Application
{
    /// <summary>
    /// Handles all logic related to shipment in the application.
    /// Uses the file repository and adapter to read shipment data and add it to items when needed.
    /// </summary
    public class ShipmentApplication : IShipmentApplication
    {
        private readonly IFileRepository _fileRepository;
        private readonly ShipmentAdapter _sAdapter;

        public ShipmentApplication()
        {
            _fileRepository = FileRepository.GetInstance();
            _sAdapter = new ShipmentAdapter();
        }

        /// <summary>
        /// Adds shipment details to the specified item based on the provided shipment ID.
        /// </summary>
        /// <remarks>This method retrieves shipment information from a repository and associates it with
        /// the specified item. If the shipment ID does not match any existing shipment, the original item is returned
        /// unchanged.</remarks>
        /// <param name="item">The item to which the shipment details will be added.</param>
        /// <param name="shipmentID">The unique identifier of the shipment to retrieve details for.</param>
        /// <returns>A new <see cref="Item"/> instance with the shipment details added, or the original item if the shipment ID
        /// is not found.</returns>
        public Item AddShipment(Item item, int shipmentID)
        {
            var allShipments = GetShipmentInfoList();
            return _sAdapter.CreateShipmentItem(item, allShipments, shipmentID);
        }

        /// <summary>
        /// Retrieves a list of shipment information.
        /// </summary>
        /// <remarks>The method returns a collection of shipment details as strings. The exact format and
        /// content of each string  depend on the underlying data source.</remarks>
        /// <returns>A list of strings representing shipment information. The list will be empty if no shipment data is
        /// available.</returns>
        public List<string> GetShipmentInfoList()
        {
            var getShipmentLines = _fileRepository.GetShipmentInfo();
            return _sAdapter.ConvertToShipmentList(getShipmentLines);
        }
    }
}
