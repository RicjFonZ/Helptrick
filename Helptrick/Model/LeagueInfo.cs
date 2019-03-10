namespace Helptrick.Model
{
    internal class LeagueInfo
    {
        /// <summary>
        ///     The LeagueID of the home team in the match.
        /// </summary>
        public int HomeLeagueId { get; set; }

        /// <summary>
        ///     The LeagueID of the away team in the match.
        /// </summary>
        public int AwayLeagueId { get; set; }

        /// <summary>
        ///     The league name of the home team in the match.
        /// </summary>
        public string HomeLeagueName { get; set; }

        /// <summary>
        ///     The league name of the away team in the match.
        /// </summary>
        public int AwayLeagueName { get; set; }
    }
}