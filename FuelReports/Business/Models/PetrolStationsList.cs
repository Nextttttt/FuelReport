namespace FuelReports.Business.Models
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "petrolStations")]
    public class PetrolStationsList
    {
        [XmlElement(ElementName = "petrolStations")]
        public List<PetrolStationModel> PetrolStations { get; set; }

    }
}
