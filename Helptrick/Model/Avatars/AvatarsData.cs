using System.Collections.Generic;
using Helptrick.Model.CommonData;

namespace Helptrick.Model.Avatars
{
    internal class AvatarsData : BaseHattrickData
    {
        public int TeamId { get; set; }

        public List<Player> Players { get; set; } = new List<Player>();
    }
}
