using Helptrick.Model.CommonData;

namespace Helptrick.Model.Fans
{
    internal abstract class PlayedMatches : Match
    {
        /// <summary>
        ///   Integer defining the type of match.
        /// </summary>
        public int MatchType { get; set; }

        /// <summary>
        ///   Expectation for the match.
        /// </summary>
        public int FanMatchExpectation { get; set; }

        /// <summary>
        ///   Fan mood after the match.
        /// </summary>
        public int FanMoodAfterMatch { get; set; }

        /// <summary>
        ///   Wheather during the match.
        /// </summary>
        public int Weather { get; set; }

        /// <summary>
        ///   The total number of sold seats.
        /// </summary>
        public int SoldSeats { get; set; }

    }
}
