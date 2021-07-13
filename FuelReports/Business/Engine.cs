namespace FuelReports.Business
{
    using FuelReports.Business.Models;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Xml.Serialization;

    public static class Engine
    {
        
        public static void Run()
        {
            PetrolStationsList petrolStations = null;

            petrolStations = DeserializeToObject<PetrolStationsList>("../../../PetrolStations.xml");

            //foreach(var item in petrolStations.PetrolStation)
            //{
            //    Console.WriteLine(item.Name);
            //}

            
        }

        public static T DeserializeToObject<T>(string filepath) where T : class
        {
            

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            using StreamReader streamReader = new StreamReader(filepath);
            return (T)xmlSerializer.Deserialize(streamReader);
        }

    }
}
