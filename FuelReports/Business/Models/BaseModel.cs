namespace FuelReports.Business.Models
{
    using System;
   
    public class BaseModel
    {

        public string Id { get; set; } = Guid.NewGuid().ToString();

    }
}
