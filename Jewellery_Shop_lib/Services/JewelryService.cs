using Jewellery_Shop_lib.Domain;
using Jewellery_Shop_lib.File_service;
using Jewellery_Shop_lib.Services.Service_Interfaces;

namespace Jewellery_Shop_lib.Services
{
    internal class JewelryService : IJewelryService
    {
        private readonly IFileRepository _fileRepository;
        public JewelryService()
        {
            _fileRepository = FileRepository.GetInstance();
        }

        /// <summary>
        /// Retrieves a list of all jewelry items.
        /// </summary>
        /// <returns>A list of <see cref="Jewelry"/> objects representing all jewelry items.  Returns an empty list if no items
        /// are found.</returns>
        public List<Jewelry> GetAllJewelryItems()
        {
            return _fileRepository.GetAllJewelry();
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
            return _fileRepository.GetJewelryItem(jewelryId);
        }
    }
}
