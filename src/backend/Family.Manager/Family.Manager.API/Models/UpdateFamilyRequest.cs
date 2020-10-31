using Newtonsoft.Json;
using System;

namespace Family.Manager.API.Models
{
    public class UpdateFamilyRequest
    {
        [JsonIgnore]
        public Guid Id { get; set; }

        public string Description { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string CellPhoneNumber { get; set; }

        public string Religion { get; set; }

        public string ChurchInformation { get; set; }

        public string Observation { get; set; }

        public int TotalFamilyMembers { get; set; }
    }
}
