using Newtonsoft.Json;
using System;

namespace Family.Manager.API.Models
{
    public class EditKinship_Request
    {
        [JsonIgnore]
        public Guid Id { get; set; }

        public string Description { get; set; }

        public string PersonName { get; set; }

        [JsonIgnore]
        public Guid FamilyId { get; set; }
    }
}
