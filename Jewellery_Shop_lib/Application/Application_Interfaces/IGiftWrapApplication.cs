using Jewellery_Shop_lib.Domain;

namespace Jewellery_Shop_lib.Application.Application_Interfaces
{
    public interface IGiftWrapApplication
    {
        List<string> GetGiftWrappingInfoList();
        Item AddGiftWrapping(Item item, int giftWrappingID);
    }
}
