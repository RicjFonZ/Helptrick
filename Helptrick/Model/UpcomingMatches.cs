namespace Helptrick.Model
{
    internal abstract class UpcomingMatches : BaseMatch
    {
        /// <summary>
        ///     Integer defining the type of match.
        /// </summary>
        public int MatchType { get; set; }

        /// <summary>
        ///     Expectation for the match.
        /// </summary>
        public int FanMatchExpectation { get; set; }
    }
}