using System;

namespace Helptrick.Model.CurrentBids
{
    internal abstract class BidItem
    {
        /// <summary>
        ///     Unique id for the transfer. Only needed for the ignore functionality.
        /// </summary>
        public int TransferId { get; set; }

        /// <summary>
        ///     The globally unique playerID for the transferlisted player.
        /// </summary>
        public int PlayerId { get; set; }

        /// <summary>
        ///     The name for the transferlisted player.
        /// </summary>
        public int PlayerName { get; set; }

        /// <summary>
        ///     Container for the current transfers. Empty if no bids.
        /// </summary>
        public HighestBid HighestBid { get; set; } = new HighestBid();

        /// <summary>
        ///     The transfer deadline.
        /// </summary>
        public DateTime Deadline { get; set; } = new DateTime();
    }
}