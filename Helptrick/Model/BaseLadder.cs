namespace Helptrick.Model
{
    internal class BaseLadder
    {
        /// <summary>
        ///     The position in the ladder.
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        ///     Total numbers of wins.
        /// </summary>
        public int Wins { get; set; }

        /// <summary>
        ///     Total number of losses.
        /// </summary>
        public int Lost { get; set; }
    }
}