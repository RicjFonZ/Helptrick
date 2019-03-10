namespace Helptrick.Model
{
    internal class YouthTeam
    {
        /// <summary>
        /// If the Team has a Youth academy the ID is represented here.
        /// </summary>
        /// <value>
        /// The youth team identifier.
        /// </value>
        public int YouthTeamId { get; set; }

        /// <summary>
        /// If the Team has a Youth academy the team name is represented here.
        /// </summary>
        /// <value>
        /// The name of the youth team.
        /// </value>
        public string YouthTeamName { get; set; }

        /// <summary>
        /// Container for the league of the youthTeam.
        /// Will be empty if the youthTeam is currently not playing in a league.
        /// </summary>
        /// <value>
        /// The youth league.
        /// </value>
        public YouthLeague YouthLeague { get; set; } = new YouthLeague();

    }
}
