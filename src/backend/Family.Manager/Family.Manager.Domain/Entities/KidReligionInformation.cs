using System;

namespace Family.Manager.Domain.Entities
{
    public class KidReligionInformation : Entity<Guid>
    {
        private KidReligionInformation() { }

        public KidReligionInformation(
            Kid kid,
            bool isBaptized = false,
            bool doingCatechesis = false,
            bool doneCatechesis = false,
            bool doingPerse = false,
            bool donePerse = false,
            bool doingConfirmationSacrament = false,
            bool doneConfirmationSacrament = false)
        {
            Id = kid.Id;
            Kid = kid;
            IsBaptized = isBaptized;
            DoingCatechesis = doingCatechesis;
            DoneCatechesis = doneCatechesis;
            DoingPerse = doingPerse;
            DonePerse = donePerse;
            DoingConfirmationSacrament = doingConfirmationSacrament;
            DoneConfirmationSacrament = doneConfirmationSacrament;
        }

        public bool IsBaptized { get; set; }
        public bool DoingCatechesis { get; set; }
        public bool DoneCatechesis { get; set; }
        public bool DoingPerse { get; set; }
        public bool DonePerse { get; set; }
        public bool DoingConfirmationSacrament { get; set; }
        public bool DoneConfirmationSacrament { get; set; }
        public Kid Kid { get; private set; }
    }
}
