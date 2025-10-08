using Jewellery_Shop_lib.Domain;

namespace Jewellery_Shop_lib.Services.Service_Interfaces
{
    public interface IGriftWrapService
    {
        List<string> GetGiftWrappingInfoList();
        Item AddGiftWrapping(Item item, int giftWrappingID);
    }
}
