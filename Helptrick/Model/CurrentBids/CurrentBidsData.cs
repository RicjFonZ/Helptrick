using System.Collections.Generic;

namespace Helptrick.Model.CurrentBids
{
    /// <summary>
    ///     Shows the current transfer activity for a team.
    /// </summary>
    internal class CurrentBidsData : BaseHattrickData
    {
        /// <summary>
        ///     Globally unique identifier of the team whose bids are shown.
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        ///     Container for the current transfers.
        /// </summary>
        public List<BidItem> BidItems { get; set; } = new List<BidItem>();
    }
}