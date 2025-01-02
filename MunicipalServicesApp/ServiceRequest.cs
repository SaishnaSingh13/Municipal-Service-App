using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp
{
    // Represents a service request in the municipal services system
    public class ServiceRequest
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime DateReported { get; set; }

        // Constructor to initialize a new instance of ServiceRequest
        public ServiceRequest(int id, string description, string status, DateTime dateReported)
        {
            Id = id;
            Description = description;
            Status = status;
            DateReported = dateReported;
        }
    }
}
