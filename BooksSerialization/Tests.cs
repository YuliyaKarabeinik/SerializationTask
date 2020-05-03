using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BooksSerialization
{
    [TestClass]
    public class Tests
    {
        private string WriteToFileName = "MyBooks.xml";
        private string ReadFromFileName = "Books.xml";


        [TestMethod]
        public void Serialization()
        {
            var catalog = new Catalog()
            {
                Books = new List<Book>
                {
                    new Book("Test", genre: Genre.Fantasy),
                    new Book("Test2", false),
                    new Book("Test3", genre: Genre.ScienceFiction)
                }
            };

            var xmlSerializer = new XmlSerializer(typeof(Catalog));
            using (var stream = new FileStream(WriteToFileName, FileMode.Create))
            {
                xmlSerializer.Serialize(stream, catalog);
            }
        }

        [TestMethod]
        public void Deserialization()
        {
            var serializer = new XmlSerializer(typeof(Catalog));
            var catalog = serializer.Deserialize(new FileStream(ReadFromFileName, FileMode.Open)) as Catalog;
            
            var xmlSerializer = new XmlSerializer(typeof(Catalog));
            using (var stream = new FileStream(WriteToFileName, FileMode.Create))
            {
                xmlSerializer.Serialize(stream, catalog);
            }
        }
    }
}
