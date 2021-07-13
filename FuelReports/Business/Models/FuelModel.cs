namespace FuelReports.Business.Models
{
    using System.Xml.Serialization;

	[XmlRoot(ElementName = "fuel")]
	public class FuelModel : BaseModel
	{
		[XmlElement(ElementName = "price")]
		public string Price { get; set; }
		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
	}
	}
