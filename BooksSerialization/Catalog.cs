using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BooksSerialization
{
    [Serializable, XmlRoot("catalog", Namespace = "http://library.by/catalog")]
    public class Catalog
    {
        [XmlElement("book")]
        public List<Book> Books { get; set; }

        [XmlIgnore]
        public DateTime Date { get; set; }

        [XmlElement("date")]
        public string DateString
        {
            get => Date.ToString("yyyy-MM-dd");
            set => Date = DateTime.Parse(value);
        }

        public Catalog()
        {
            
        }
        public Catalog(List<Book> books)
        {
            Date = DateTime.Now;
            Books = books;
        }
    }
}
