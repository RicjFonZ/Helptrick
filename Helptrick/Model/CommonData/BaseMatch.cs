using System;

namespace Helptrick.Model.CommonData
{
    internal abstract class BaseMatch
    {
        /// <summary>
        ///   The globally unique identifier of the match.
        /// </summary>
        public int MatchId { get; set; }

        /// <summary>
        ///   The start date (kick-off) of the match.
        /// </summary>
        public DateTime MatchDate { get; set; } = new DateTime();

        /// <summary>
        ///   Container for the home team in the match.
        /// </summary>
        public Team HomeTeam { get; set; } = new Team();

        /// <summary>
        ///   Container for the away team in the match.
        /// </summary>
        public Team AwayTeam { get; set; } = new Team();

    }
}
