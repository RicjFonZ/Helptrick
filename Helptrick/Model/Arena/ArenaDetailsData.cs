using Helptrick.Model.CommonData;

namespace Helptrick.Model.Arena
{
    internal class ArenaDetailsData : BaseHattrickData
    {
        public ArenaInfo Arena { get; set; } = new ArenaInfo();

        public Team Team { get; set; } = new Team();

        public League League { get; set; } = new League();

        public Region Region { get; set; } = new Region();

        public Capacity CurrentCapacity { get; set; } = new Capacity();

        public Capacity ExpandedCapacity { get; set; } = new Capacity();

    }
}
