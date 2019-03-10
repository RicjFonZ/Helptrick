namespace Helptrick.Model
{
    internal abstract class StartingLineup
    {
        /// <summary>
        ///     Globally unique ID of the player.
        /// </summary>
        public int PlayerId { get; set; }

        /// <summary>
        ///     An integer indicating which formal 'slot' (Role)
        ///     the player has filled in the match.
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        ///     The full name of the player.
        /// </summary>
        public string PlayerName { get; set; }

        /// <summary>
        ///     An integer indicating the individual order or repositioning
        ///     that the player has played with.
        /// </summary>
        public int Behaviour { get; set; }
    }
}
