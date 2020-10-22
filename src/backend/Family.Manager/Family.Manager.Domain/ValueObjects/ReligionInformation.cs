namespace Family.Manager.Domain.ValueObjects
{
    public class ReligionInformation : ValueObject
    {
        public ReligionInformation(
            bool isBaptized,
            bool doingCatechesis,
            bool doneCatechesis,
            bool doingPerse,
            bool donePerse,
            bool doingConfirmationSacrament,
            bool doneConfirmationSacrament)
        {
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
    }
}
