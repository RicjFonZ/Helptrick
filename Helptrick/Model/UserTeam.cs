namespace Helptrick.Model
{
    internal abstract class UserTeam
    {
        /// <summary>
        ///     The user team.
        /// </summary>
        public Team Team { get; set; } = new Team();

        /// <summary>
        ///     Container for the arena.
        /// </summary>
        public ArenaInfo Arena { get; set; } = new ArenaInfo();

        /// <summary>
        ///     Container for the league.
        /// </summary>
        public League League { get; set; } = new League();

        /// <summary>
        ///     Container for the country.
        /// </summary>
        public Country Country { get; set; } = new Country();

        /// <summary>
        ///     Container for the LeagueLevelUnit ('series').
        /// </summary>
        public LeagueLevelUnit LeagueLevelUnit { get; set; } = new LeagueLevelUnit();

        /// <summary>
        ///     Container for the region.
        /// </summary>
        public Region Region { get; set; } = new Region();


    }
}
