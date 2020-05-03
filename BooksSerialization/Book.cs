using System;
using System.Xml.Serialization;

namespace BooksSerialization
{
    [Serializable, XmlType("book")]
    public class Book
    {
        [XmlAttribute("id")]
        public string Id;

        [XmlElement("isbn", IsNullable = false)]
        public string Isbn;

        [XmlElement("author")]
        public string Author;

        [XmlElement("title")]
        public string Title;

        [XmlElement("genre")]
        public Genre Genre;

        [XmlElement("publisher")]
        public string Publisher;

        [XmlIgnore]
        public DateTime PublishDate;

        [XmlElement("publish_date")]
        public string PublishDateString
        {
            get => PublishDate.ToString("yyyy-MM-dd");
            set => PublishDate = DateTime.Parse(value);
        }

        [XmlElement("description")]
        public string Description;

        [XmlIgnore]
        public DateTime RegistrationDate;

        [XmlElement("registration_date")]
        public string RegistrationDateString
        {
            get => RegistrationDate.ToString("yyyy-MM-dd");
            set => RegistrationDate = DateTime.Parse(value);
        }

        public Book()
        {
        }

        public Book(string id = "Test1", bool useIsbn = true, Genre genre = Genre.Computer)
        {
            Id = DateTime.Now.Second.ToString();
            Isbn = useIsbn ? id : null;
            Author = id;
            Title = id;
            Genre = genre;
            Publisher = id;
            PublishDate = DateTime.Now;
            Description = id;
            RegistrationDate = DateTime.Now;
        }
    }
}
