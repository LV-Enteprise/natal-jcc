using Family.Manager.Domain.ValueObjects;
using System;

namespace Family.Manager.Domain.Entities
{
    public class Kid : Entity
    {
        protected Kid() { }

        public Kid(
            string name,
            DateTime birthDate,
            ReligionInformation kidReligionInformation,
            string observation,
            Guid familyId)
        {
            Id = Guid.NewGuid();
            Name = name;
            BirthDate = birthDate;
            KidReligionInformation = kidReligionInformation;
            Observation = observation;
            FamilyId = familyId;
        }

        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public ReligionInformation KidReligionInformation { get; private set; }
        public string Observation { get; private set; }
        public Guid FamilyId { get; private set; }
        public Family Family { get; private set; }
    }
}
