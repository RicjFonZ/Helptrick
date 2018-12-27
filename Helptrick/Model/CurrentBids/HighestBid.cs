namespace Helptrick.Model.CurrentBids
{
    internal class HighestBid
    {
        /// <summary>
        ///     Amount of the highest bid.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        ///     Id of the team holding the highest bid.
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        ///     Name of the team holding the highest bid.
        /// </summary>
        public string TeamName { get; set; }
    }
}