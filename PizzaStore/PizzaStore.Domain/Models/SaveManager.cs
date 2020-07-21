using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PizzaStore.Domain.Models
{
    public class SaveManager
    {
        //XML = extensible markup language
        private const string _path = @"data/pizza_store.xml";

        public Order Read()
        {
            var reader = new StreamReader(_path);
            var xml = new XmlSerializer(typeof(Order));

            return xml.Deserialize(reader) as Order;
        }

        public void Write(Order order)
        {
            //create file
            //open file with write permissions
            //load content to write
            //convert content to XML
            //write content to file
            //Save file. Close the file.

            
            var writer = new StreamWriter(_path);
            var xml = new XmlSerializer(typeof(Order)); // will be serializing list of orders

            xml.Serialize(writer, order); //  no need to close the writer
        }
    }
}