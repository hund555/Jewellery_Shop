using Jewellery_Shop_lib.Domain;
using Jewellery_Shop_lib.File_service;
using Jewellery_Shop_lib.Application.Application_Interfaces;
using Jewellery_Shop_lib.Interface_Adapter;

namespace Jewellery_Shop_lib.Application
{
    /// <summary>
    /// Handles all logic related to jewelry in the application.
    /// Uses the file repository and adapter to read jewelry data and return it as item objects.
    /// </summary>
    public class JewelryApplication : IJewelryApplication
    {
        private readonly IFileRepository _fileRepository;
        private readonly JewelryAdapter _jAdapter;

        //Constructor with dependency injection
        public JewelryApplication()
        {
            _fileRepository = FileRepository.GetInstance();
            _jAdapter = new JewelryAdapter();
        }

        /// <summary>
        /// Retrieves a list of all jewelry items.
        /// </summary>
        /// <returns>A list of <see cref="Jewelry"/> objects representing all jewelry items.  Returns an empty list if no items
        /// are found.</returns>
        public List<Jewelry> GetAllJewelryItems()
        {
            var getLines = _fileRepository.GetAllJewelry();
            return _jAdapter.convertToJewelryList(getLines);
        }

        /// <summary>
        /// Retrieves a jewelry item based on the specified identifier.
        /// </summary>
        /// <remarks>This method fetches the jewelry item from an underlying repository. Ensure that the
        /// repository  is properly initialized and contains the desired data before calling this method.</remarks>
        /// <param name="jewelryId">The unique identifier of the jewelry item to retrieve. Must be a valid, non-negative integer.</param>
        /// <returns>The <see cref="Item"/> representing the jewelry item with the specified identifier,  or <see
        /// langword="null"/> if no item with the given identifier exists.</returns>
        public Item GetJewelryItem(int jewelryId)
        {
            var jewelryList = GetAllJewelryItems();
            return jewelryList.FirstOrDefault(j => j.Id == jewelryId);
        }
    }
}
