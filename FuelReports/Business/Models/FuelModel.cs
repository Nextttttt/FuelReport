namespace FuelReports.Business.Models
{
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "fuel")]
    public class FuelModel : BaseModel
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "price")]
        public decimal Price { get; set; }
    }
}
