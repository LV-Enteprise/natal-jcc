using System;
using System.Collections.Generic;

namespace Family.Manager.API.Models
{
    public class FamilyWithKidsAndKinshipsResponse
    {
        public FamilyWithKidsAndKinshipsResponse()
        {
            Kinships = new List<FamilyWithKidsAndKinships_Kinships_Response>();
            Kids = new List<FamilyWithKidsAndKinships_Kid_Response>();
        }

        public Guid Id { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string CellPhoneNumber { get; set; }

        public string Religion { get; set; }

        public string ChurchInformation { get; set; }

        public string Observation { get; set; }

        public int TotalFamilyMembers { get; set; }

        public IEnumerable<FamilyWithKidsAndKinships_Kinships_Response> Kinships { get; set; }

        public IEnumerable<FamilyWithKidsAndKinships_Kid_Response> Kids { get; set; }
    }
}
