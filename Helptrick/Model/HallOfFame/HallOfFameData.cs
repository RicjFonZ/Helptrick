using System.Collections.Generic;

namespace Helptrick.Model.HallOfFame
{
    /// <summary>
    ///     Hall of Fame Players
    /// </summary>
    internal class HallOfFameData : BaseHattrickData
    {
        /// <summary>
        ///     Container for the data about the player.
        /// </summary>
        public List<Player> Players { get; set; } = new List<Player>();
    }
}