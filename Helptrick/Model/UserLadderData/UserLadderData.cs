using System.Collections.Generic;

namespace Helptrick.Model.UserLadderData
{
    /// <summary>
    ///     Information about ladder that the user is currently playing in.
    /// </summary>
    internal class UserLadderData : BaseHattrickData
    {
        /// <summary>
        ///     Container for the list of ladders.
        /// </summary>
        public List<UserLadder> UserLadders { get; set; } = new List<UserLadder>();
    }
}