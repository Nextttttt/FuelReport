namespace FuelReports.Business.Models
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

	[XmlRoot(ElementName = "petrolStations")]
	public class PetrolStationsList
	{
		[XmlElement(ElementName = "petrolStation")]
		public List<PetrolStationModel> PetrolStation { get; set; }
		[XmlAttribute(AttributeName = "date")]
		public string Date { get; set; }
	}
}
