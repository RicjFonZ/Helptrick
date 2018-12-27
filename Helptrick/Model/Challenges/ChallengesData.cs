using Helptrick.Model.CommonData;

namespace Helptrick.Model.Challenges
{
    /// <summary>
    ///     Challenges
    /// </summary>
    internal class ChallengesData : BaseHattrickData
    {
        /// <summary>
        ///     The globally unique nationalTeamID.
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        ///     The team name.
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        ///     Container for the challenges that the user has done.
        /// </summary>
        public Challenges ChallengesByMe { get; set; } = new Challenges();

        /// <summary>
        ///     Container for the offers of friendlies that other
        ///     teams have given to the logged on user's team.
        /// </summary>
        public Challenges OffersByOthers { get; set; } = new Challenges();
    }
}