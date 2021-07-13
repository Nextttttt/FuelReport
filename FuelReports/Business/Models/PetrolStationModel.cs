namespace FuelReports.Business.Models
{
    using System.Text;
    using System.Xml.Serialization;

	[XmlRoot(ElementName = "petrolStation")]
	public class PetrolStationModel : BaseModel
	{
		[XmlElement(ElementName = "fuels")]
		public FuelList Fuels { get; set; }

		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }

		[XmlAttribute(AttributeName = "address")]
		public string Address { get; set; }

		[XmlAttribute(AttributeName = "city")]
		public string City { get; set; }
	}
}
