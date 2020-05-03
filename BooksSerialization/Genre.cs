using System.Xml.Serialization;

namespace BooksSerialization
{
    public enum Genre
    {
        [XmlEnum] Computer,
        [XmlEnum] Fantasy,
        [XmlEnum] Romance,
        [XmlEnum] Horror,
        [XmlEnum("Science Fiction")] ScienceFiction
    }
}
