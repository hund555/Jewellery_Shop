using Jewellery_Shop_lib.Domain;

namespace Jewellery_Shop_lib.Interface_Adapter
{
    /// <summary>
    /// Handles conversion between text file data and jewelry objects.
    /// Used to read jewelry information from files and create Jewelry instances from it.
    /// </summary>
    public class JewelryAdapter
    {
        /// <summary>
        /// Converts the lines from .txt to a Jewelry objects with the info from the file
        /// Shows one specific item
        /// </summary>
        /// <param name="line">
        /// The line to be read from the .txt file.
        /// </param>
        /// <returns>
        /// Returns a jewelry object
        /// </returns>
        /// <exception cref="FormatException">
        /// Thrown if the ID, description, or price is not in the expected format 
        /// when reading a line from the .txt file.
        /// </exception>
        public Jewelry ConvertLineToJewelry(string line)
        {
            var splitLine = line.Split('|');
            if (splitLine.Length < 3)
            {
                Console.WriteLine($"Line read: '{line}'");
                throw new FormatException("Line is missing information.");
            }

            //Converting each split in a line from string to correct datatype 
            int id = int.Parse(splitLine[0]);
            string description = splitLine[1];
            double price = double.Parse(splitLine[2]);

            return new Jewelry(id, description, price);
        }

        /// <summary>
        /// Shows all Jewelry from our .txt-file and converts them to Jewelry objects
        /// </summary>
        /// <returns></returns>
        public List<Jewelry> convertToJewelryList(List<string> lines)
        {
            return lines.Select(ConvertLineToJewelry).ToList();
        }
    }
}
