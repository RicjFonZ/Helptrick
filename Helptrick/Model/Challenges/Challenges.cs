namespace Helptrick.Model.Challenges
{
    /// <summary>
    ///     Container for a particular challenge.
    /// </summary>
    internal class Challenges
    {
        /// <summary>
        ///     The globally unique identifier for the challenge/offer.
        /// </summary>
        public int TrainingMatchId { get; set; }

        /// <summary>
        ///     The match start time.
        /// </summary>
        public int MatchTime { get; set; }

        /// <summary>
        ///     The matchid for the match that was created for an accepted challenge.
        /// </summary>
        public int MatchId { get; set; }

        /// <summary>
        ///     Integer defining the type of friendly.
        /// </summary>
        public int FriendlyType { get; set; }

        /// <summary>
        ///     Container for the data about the opponent.
        /// </summary>
        public Opponent Opponent { get; set; } = new Opponent();
    }
}