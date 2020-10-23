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

        public bool IsBaptized { get; private set; }
        public bool DoingCatechesis { get; private set; }
        public bool DoneCatechesis { get; private set; }
        public bool DoingPerse { get; private set; }
        public bool DonePerse { get; private set; }
        public bool DoingConfirmationSacrament { get; private set; }
        public bool DoneConfirmationSacrament { get; private set; }
        public Kid Kid { get; private set; }
    }
}
