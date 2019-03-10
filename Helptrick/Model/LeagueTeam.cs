namespace Helptrick.Model
{
    internal abstract class LeagueTeam
    {
        /// <summary>
        ///     The globally unique UserID.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        ///     The container for the team.
        /// </summary>
        public Team Team { get; set; } = new Team();

        /// <summary>
        ///     Position in the table.
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        ///     Position change from previous matchround.
        /// </summary>
        public int PositionChange { get; set; }

        /// <summary>
        ///     How many matches the team has played.
        /// </summary>
        public int Matches { get; set; }

        /// <summary>
        ///     How many goals the team has scored.
        /// </summary>
        public int GoalsFor { get; set; }

        /// <summary>
        ///     How many goals the team has allowed their opponents to score.
        /// </summary>
        public int GoalsAgainst { get; set; }

        /// <summary>
        ///     How many points the team has.
        /// </summary>
        public int Points { get; set; }

        /// <summary>
        ///     How many matches the team has won.
        /// </summary>
        public int Won { get; set; }

        /// <summary>
        ///     How many draws the team has.
        /// </summary>
        public int Draws { get; set; }

        /// <summary>
        ///     How many matches the team has lost.
        /// </summary>
        public int Lost { get; set; }
    }
}