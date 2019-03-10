using System.Collections.Generic;

namespace Helptrick.Model.LeagueFixtures
{
    /// <summary>
    ///     Information about a League Level Unit (series)
    /// </summary>
    internal class LeagueFixturesData : BaseHattrickData
    {
        /// <summary>
        ///     The ID number of the LeagueLevelUnit.
        /// </summary>
        public int LeagueLevelUnitId { get; set; }

        /// <summary>
        ///     The name of the LeagueLevelUnit.
        /// </summary>
        public string LeagueLevelUnitName { get; set; }

        /// <summary>
        ///     The season that the returned data applies to.
        /// </summary>
        public string Season { get; set; }

        /// <summary>
        ///     Container for the data for a certain match within the fixtures.
        /// </summary>
        public List<MatchFixture> Matches { get; set; } = new List<MatchFixture>();
    }
}
