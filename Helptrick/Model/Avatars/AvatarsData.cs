using Helptrick.Model.CommonData;
using System.Collections.Generic;

namespace Helptrick.Model.Avatars
{
    /// <summary>
    ///    Avatars for all players of user's team
    /// </summary>
    internal class AvatarsData : BaseHattrickData
    {
        /// <summary>
        ///    The globally unique TeamID.
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        ///    Container for the list of players.
        /// </summary>
        public List<AvatarPlayer> Players { get; set; } = new List<AvatarPlayer>();
    }
}
