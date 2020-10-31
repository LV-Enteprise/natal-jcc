using System;
using System.Collections.Generic;

namespace Family.Manager.Domain.Entities
{
    public class Family : Entity<Guid>
    {
        private Family() { }

        public Family(
            string description,
            string address,
            string phoneNumber,
            string cellPhoneNumber,
            string religion,
            string churchInformation,
            string observation,
            int totalFamilyMembers)
        {
            Id = Guid.NewGuid();
            Description = description;
            Address = address;
            PhoneNumber = phoneNumber;
            CellPhoneNumber = cellPhoneNumber;
            Religion = religion;
            ChurchInformation = churchInformation;
            Observation = observation;
            TotalFamilyMembers = totalFamilyMembers;
            Kinships = new List<Kinship>();
            Kids = new List<Kid>();
        }

        public string Description { get; private set; }
        public string Address { get; private set; }
        public string PhoneNumber { get; private set; }
        public string CellPhoneNumber { get; private set; }
        public string Religion { get; private set; }
        public string ChurchInformation { get; private set; }
        public string Observation { get; private set; }
        public int TotalFamilyMembers { get; private set; }
        public IEnumerable<Kinship> Kinships { get; private set; }
        public IEnumerable<Kid> Kids { get; private set; }

        public void AddKinships(IEnumerable<Kinship> kinships) => Kinships = kinships;

        public void AddKids(IEnumerable<Kid> kids) => Kids = kids;
    }
}
