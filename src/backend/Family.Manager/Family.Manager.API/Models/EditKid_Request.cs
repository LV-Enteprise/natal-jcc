using Newtonsoft.Json;
using System;

namespace Family.Manager.API.Models
{
    public class EditKid_Request
    {
        [JsonIgnore]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string Observation { get; set; }

        public bool IsBaptized { get; set; }

        public bool DoingCatechesis { get; set; }

        public bool DoneCatechesis { get; set; }

        public bool DoingPerse { get; set; }

        public bool DonePerse { get; set; }

        public bool DoingConfirmationSacrament { get; set; }

        public bool DoneConfirmationSacrament { get; set; }
        
        [JsonIgnore]
        public Guid FamilyId { get; set; }
    }
}
