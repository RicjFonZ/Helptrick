using Helptrick.Model.CommonData;

namespace Helptrick.Model.Challenges
{
    internal class ChallengesData : BaseHattrickData
    {
        public int TeamId { get; set; }

        public string TeamName { get; set; }

        public Challenges ChallengesByMe { get; set; } = new Challenges();

        public Challenges OffersByOthers { get; set; } = new Challenges();

    }
}
