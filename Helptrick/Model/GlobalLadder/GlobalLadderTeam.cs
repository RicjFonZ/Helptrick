using Helptrick.Model.CommonData;

namespace Helptrick.Model.GlobalLadder
{
    internal abstract class GlobalLadderTeam : BaseLadder
    {
        /// <summary>
        ///     Container for the data about the ladder team.
        /// </summary>
        public Team Team { get; set; } = new Team();

        /// <summary>
        ///     Number of wins in a row.
        /// </summary>
        public int WinsInARow { get; set; }

        /// <summary>
        ///     Number of losses in a row.
        /// </summary>
        public int LostInARow { get; set; }
    }
}
