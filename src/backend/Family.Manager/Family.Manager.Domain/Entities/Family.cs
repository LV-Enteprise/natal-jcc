using System;
using System.Collections.Generic;

namespace Family.Manager.Domain.Entities
{
    public class Family : Entity<Guid>
    {
        private Family() { }

        public Family(
            string address,
            string phoneNumber,
            string cellPhoneNumber,
            string religion,
            string churchInformation,
            string observation,
            int totalFamilyMembers,
            IEnumerable<Kinship> kinships,
            IEnumerable<Kid> kids)
        {
            Id = Guid.NewGuid();
            Address = address;
            PhoneNumber = phoneNumber;
            CellPhoneNumber = cellPhoneNumber;
            Religion = religion;
            ChurchInformation = churchInformation;
            Observation = observation;
            TotalFamilyMembers = totalFamilyMembers;
            Kinships = kinships;
            Kids = kids;
        }

        public string Address { get; private set; }
        public string PhoneNumber { get; private set; }
        public string CellPhoneNumber { get; private set; }
        public string Religion { get; private set; }
        public string ChurchInformation { get; private set; }
        public string Observation { get; private set; }
        public int TotalFamilyMembers { get; private set; }
        public IEnumerable<Kinship> Kinships { get; private set; }
        public IEnumerable<Kid> Kids { get; private set; }
    }
}
