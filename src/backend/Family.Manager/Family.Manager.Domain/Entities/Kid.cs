using System;

namespace Family.Manager.Domain.Entities
{
    public class Kid : Entity<Guid>
    {
        private Kid() { }

        public Kid(
            string name,
            DateTime birthDate,
            string observation,
            Guid familyId)
        {
            Id = Guid.NewGuid();
            Name = name;
            BirthDate = birthDate;
            Observation = observation;
            FamilyId = familyId;
        }

        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Observation { get; private set; }
        public Guid FamilyId { get; private set; }
        public Family Family { get; private set; }
        public KidReligionInformation KidReligionInformation { get; private set; }

        public void UpdateReligionInformation(KidReligionInformation religionInformation) => KidReligionInformation = religionInformation;

        public void UpdateName(string name) => Name = name;

        public void UpdateBirthDate(DateTime birthDate) => BirthDate = birthDate;

        public void UpdateObservation(string observation) => Observation = observation;
    }
}
