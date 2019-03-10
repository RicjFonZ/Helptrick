namespace Helptrick.Model
{
    internal abstract class Substitution
    {
        /// <summary>
        ///     The globally unique TeamID for which the orders were sent.
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        ///     If a/ substitution: The player leaving.
        ///     If b/ behaviour change: The player changing his behaviour.
        ///     Or c/ position swap: the first player that will change his position.
        /// </summary>
        public int SubjectPlayerId { get; set; }

        /// <summary>
        ///     The player entering (or once more the player changing behaviour).
        ///     Or if position swap, the player to swap with.
        /// </summary>
        public int ObjectPlayerId { get; set; }

        /// <summary>
        ///     The type of the order.
        /// </summary>
        public int OrderType { get; set; }

        /// <summary>
        ///     An integer representing the new position for
        ///     the (entering or staying) player.
        /// </summary>
        public int NewPositionId { get; set; }

        /// <summary>
        ///     An integer representing the new behaviour for
        ///     the (entering or staying) player.
        /// </summary>
        public int NewPositionBehaviour { get; set; }

        /// <summary>
        ///     An integer indicating in which minute the order was executed.
        /// </summary>
        public int MatchMinute { get; set; }

        /// <summary>
        ///     Which part of the match the order was executed.
        /// </summary>
        public int MatchPart { get; set; }
    }
}
