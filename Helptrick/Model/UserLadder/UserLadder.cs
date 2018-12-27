using Helptrick.Model.CommonData;
using System;

namespace Helptrick.Model.UserLadder
{
    internal abstract class UserLadder : BaseLadder
    {
        /// <summary>
        ///     The globally unique id for the ladder.
        /// </summary>
        public int LadderId { get; set; }

        /// <summary>
        ///     The name of the ladder.
        /// </summary>
        public int Name { get; set; }

        /// <summary>
        ///     The date of the next match.
        ///     During matches this will be the Next match round.
        /// </summary>
        public DateTime NextMatchDate { get; set; } = new DateTime();
    }
}