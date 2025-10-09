using Jewellery_Shop_lib.Domain;

namespace Jewellery_Shop_lib.File_service
{
    /// <summary>
    /// Handles all file operations for the jewellery shop.
    /// Used to read and save data for jewelry items, gift wrappings, shipments, and orders.
    /// </summary>
    public class FileRepository : IFileRepository
    {
        private List<Jewelry> _jevelry_Items = new List<Jewelry>();
        private const string JEWELRY_FILE = "Jewelry.txt";
        private const string GIFTWRAPPING_FILE = "GiftWrapping.txt";
        private const string SHIPMENT_FILE = "Shipment.txt";
        private const string ORDER_FILE = "Orders.txt";

        private FileRepository()
        {
            
        }

        /// <summary>
        /// Returns all jewelry items from the file and stores them as a list of the class Jewelry
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllJewelry()
        {
            List<string> getLines = new List<string>();
           
            if(File.Exists(JEWELRY_FILE))
            {
                using(StreamReader sr = new StreamReader(JEWELRY_FILE))
                { 
                    while(sr.Peek() >= 0)
                    {
                        getLines.Add(sr.ReadLine());
                    }
                }
            }
            return getLines;
        }

        /// <summary>
        /// returns all orders from the file as a list of strings
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllOrders()
        {
            List<string> orders = new List<string>();
            if (!File.Exists(ORDER_FILE))
            {
                File.Create(ORDER_FILE);
            }
            using (StreamReader sr = new StreamReader(ORDER_FILE))
            {
                while (sr.Peek() >= 0)
                {
                    orders.Add(sr.ReadLine());
                }
            }

            return orders;
        }

        /// <summary>
        /// returns all gift wrapping options from the file as a list of strings
        /// </summary>
        /// <returns></returns>
        public List<string> GetGiftWrappingInfo()
        {
            List<string> giftWrappingInfoList = new List<string>();
            if (File.Exists(GIFTWRAPPING_FILE))
            {
                using (StreamReader sr = new StreamReader(GIFTWRAPPING_FILE))
                {
                    while (sr.Peek() >= 0)
                    {
                        giftWrappingInfoList.Add(sr.ReadLine());
                    }
                }
            }
            return giftWrappingInfoList;
        }

        /// <summary>
        /// returns a jewelry item based on the given id
        /// </summary>
        /// <param name="jewelryId"></param>
        /// <returns></returns>
        public Jewelry GetJewelryItem(int jewelryId)
        {
            if(_jevelry_Items == null)
            {
                GetAllJewelry();
            }
            return _jevelry_Items.Find(j => j.Id == jewelryId);
        }

        /// <summary>
        /// returns all shipping options from the file as a list of strings
        /// </summary>
        /// <returns></returns>
        public List<string> GetShipmentInfo()
        {
            List<string> shippingInfoList = new List<string>();
            if (File.Exists(SHIPMENT_FILE))
            {
                using (StreamReader sr = new StreamReader(SHIPMENT_FILE))
                {
                    while (sr.Peek() >= 0)
                    {
                        shippingInfoList.Add(sr.ReadLine());
                    }
                }
            }
            return shippingInfoList;
        }

        /// <summary>
        /// Saves the given item to the orders file
        /// </summary>
        /// <param name="item"></param>
        public void SaveOrder(Item item)
        {
            List<string> ordersList = GetAllOrders();
            
            string order = $"{item.Id}|{item.Description}|{item.Price}";
            ordersList.Add(order);
            File.WriteAllLines(ORDER_FILE, ordersList);
        }

        /// <summary>
        /// Creates and returns a new instance of the <see cref="FileRepository"/> class.
        /// </summary>
        /// <returns>A new instance of the <see cref="FileRepository"/> class.</returns>
        public static FileRepository GetInstance()
        {
            return new FileRepository();
        }
    }
}
