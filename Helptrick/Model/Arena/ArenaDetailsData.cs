namespace Helptrick.Model.Arena
{
    /// <summary>
    ///     Information about specific arenas, supporter statistics and the largest
    ///     arenas in Hattrick.
    /// </summary>
    internal class ArenaDetailsData : BaseHattrickData
    {
        /// <summary>
        ///     Container for the data about the arena.
        /// </summary>
        public ArenaInfo Arena { get; set; } = new ArenaInfo();

        /// <summary>
        ///     Container for the data about the team owning this arena.
        /// </summary>
        public Team Team { get; set; } = new Team();

        /// <summary>
        ///     Container for the data about the league of the arena's team.
        /// </summary>
        public League League { get; set; } = new League();

        /// <summary>
        ///     Container for the data about the region of the arena.
        /// </summary>
        public Region Region { get; set; } = new Region();

        /// <summary>
        ///     Container for the data about the current capacity of the arena.
        /// </summary>
        public Capacity CurrentCapacity { get; set; } = new Capacity();

        /// <summary>
        ///     Container for the data about the expanded capacity of the
        ///     arena during construction.
        /// </summary>
        public Capacity ExpandedCapacity { get; set; } = new Capacity();
    }
}