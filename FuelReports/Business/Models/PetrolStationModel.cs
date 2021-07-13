namespace FuelReports.Business.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Xml.Serialization;

    [XmlRoot(ElementName = "petrolStation")]
    public class PetrolStationModel : BaseModel
    {
        [XmlAttribute(AttributeName ="name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "address")]
        public string Address { get; set; }

       [XmlElement(ElementName ="fuels")]
        public List<FuelModel> Fuels { get; set; }

    }
}
