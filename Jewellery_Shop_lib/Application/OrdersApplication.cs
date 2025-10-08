using Jewellery_Shop_lib.Domain;
using Jewellery_Shop_lib.File_service;
using Jewellery_Shop_lib.Application.Application_Interfaces;
using Jewellery_Shop_lib.Interface_Adapter;

namespace Jewellery_Shop_lib.Application
{
    public class OrdersApplication : IOrdersApplication
    {
        private readonly IFileRepository _fileRepository;
        private readonly OrderAdapater _oAdapter;

        public OrdersApplication()
        {
            _fileRepository = FileRepository.GetInstance();
            _oAdapter = new OrderAdapater();
        }

        /// <summary>
        /// Retrieves a list of all orders.
        /// </summary>
        /// <remarks>This method returns all orders stored in the underlying data source. The returned
        /// list may be empty if no orders are available. The order of the items in the list is determined by the data
        /// source.</remarks>
        /// <returns>A list of strings representing all orders. The list will be empty if no orders are found.</returns>
        public List<string> GetAllOrders()
        {
            var getLines = _fileRepository.GetAllOrders();
            return _oAdapter.ConvertToOrderList(getLines);
        }

        /// <summary>
        /// Saves the specified order to persistent storage.
        /// </summary>
        /// <remarks>This method persists the provided order item using the underlying file repository. 
        /// Ensure that the <paramref name="item"/> contains all required data before calling this method.</remarks>
        /// <param name="item">The order item to be saved. Cannot be <see langword="null"/>.</param>
        public void SaveOrder(Item item)
        {
            _fileRepository.SaveOrder(item);
        }
    }
}
