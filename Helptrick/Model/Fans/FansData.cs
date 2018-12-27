using Helptrick.Model.CommonData;
using System.Collections.Generic;

namespace Helptrick.Model.Fans
{
    /// <summary>
    ///     Fanclub information
    /// </summary>
    internal class FansData : BaseHattrickData
    {
        /// <summary>
        ///     The globally unique TeamID for logged on user.
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        ///     The globally unique FanclubID.
        /// </summary>
        public int FanClubId { get; set; }

        /// <summary>
        ///     The name of the fanclub. If the user have not set a
        ///     fanclub name the container is empty.
        /// </summary>
        public string FanClubName { get; set; }

        /// <summary>
        ///     The popularity among the supporters of the team.
        ///     If the team is playing a match the container is empty.
        /// </summary>
        public int FanMood { get; set; }

        /// <summary>
        ///     TThe size of the team's fanclub.
        /// </summary>
        public int Members { get; set; }

        /// <summary>
        ///     The expectations for current season.
        /// </summary>
        public int FanSeasonExpectation { get; set; }

        /// <summary>
        ///     Container for the data about the three last played matches.
        ///     Only series, qualification, cup and hattrick master games are listed.
        /// </summary>
        public List<PlayedMatches> PlayedMatches { get; set; } = new List<PlayedMatches>();

        /// <summary>
        ///     Container for the data about the three upcoming matches.
        ///     Only series, qualification, cup and hattrick master games are listed.
        /// </summary>
        public List<UpcomingMatches> UpcomingMatches { get; set; } = new List<UpcomingMatches>();
    }
}