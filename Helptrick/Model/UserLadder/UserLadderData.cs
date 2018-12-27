using Helptrick.Model.CommonData;
using System.Collections.Generic;

namespace Helptrick.Model.UserLadder
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