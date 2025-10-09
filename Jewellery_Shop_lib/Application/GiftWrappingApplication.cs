using Jewellery_Shop_lib.Application.Application_Interfaces;
using Jewellery_Shop_lib.Domain;
using Jewellery_Shop_lib.File_service;
using Jewellery_Shop_lib.Interface_Adapter;

namespace Jewellery_Shop_lib.Application
{
    /// <summary>
    /// Handles all logic related to gift wrapping in the application.
    /// Connects the file repository with the adapter to read wrapping data 
    /// and apply the selected wrapping to an item.
    /// </summary>
    public class GiftWrappingApplication : IGiftWrapApplication
    {
        private readonly IFileRepository _fileRepository;
        private readonly GiftWrappingAdapter _gAdapter;

        public GiftWrappingApplication()
        {
            _fileRepository = FileRepository.GetInstance();
            _gAdapter = new GiftWrappingAdapter();
        }

        /// <summary>
        /// Adds gift wrapping to the specified item using the provided gift wrapping ID.
        /// </summary>
        /// <remarks>This method retrieves gift wrapping information from an external repository and
        /// applies the selected  gift wrapping to the item. The gift wrapping includes details such as its description and
        /// additional cost.</remarks>
        /// <param name="item">The item to which gift wrapping will be added.</param>
        /// <param name="giftWrappingID">The unique identifier of the gift wrapping option to apply.</param>
        /// <returns>A new <see cref="Item"/> instance with the selected gift wrapping applied.  If the specified gift wrapping
        /// ID is not found, the original item is returned unchanged.</returns>
        
        public Item AddGiftWrapping(Item item, int giftWrappingID)
        {
            var allGiftWrappings = GetGiftWrappingInfoList();
            return _gAdapter.CreateGiftWrappedItem(item, allGiftWrappings, giftWrappingID);
        }

        /// <summary>
        /// Retrieves a list of gift wrapping information.
        /// </summary>
        /// <returns>A list of strings containing gift wrapping details. The list will be empty if no gift wrapping information
        /// is available.</returns>
        public List<string> GetGiftWrappingInfoList()
        {
            var lines = _fileRepository.GetGiftWrappingInfo();
            return _gAdapter.ConvertToGiftWrappingList(lines);
        }
    }
}
