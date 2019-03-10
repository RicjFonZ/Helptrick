namespace Helptrick.Model
{
    internal class Team
    {
        /// <summary>
        ///     The globally unique teamID.
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        ///     The name of the team.
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        ///     The short team name of the Home team in the match.
        /// </summary>
        public string HomeTeamShortName { get; set; }
    }
}