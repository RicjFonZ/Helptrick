namespace Helptrick.Model
{
    internal abstract class Event
    {
        /// <summary>
        ///     Indicates the order of the event relative to the other
        ///     events sent in the same batch for this match.
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        ///     The match minute when the event happened.
        /// </summary>
        public int Minute { get; set; }

        /// <summary>
        ///     Which part of the match the event happened.
        /// </summary>
        public int MatchPart { get; set; }

        /// <summary>
        ///     A unique key defining what type of event it was.
        /// </summary>
        public int EventKey { get; set; }

        /// <summary>
        ///     String describing the event as it would appear in the match report.
        /// </summary>
        public string EventText { get; set; }

        /// <summary>
        ///     Integer that, for goals and chances, is indicating the attacking team.
        /// </summary>
        public int SubjectTeamId { get; set; }

        /// <summary>
        ///     Integer that, for goals and chances,
        ///     is indicating the scorer or the player failing to score.
        /// </summary>
        public int SubjectPlayerId { get; set; }

        /// <summary>
        ///     Integer that, for regular goals and chances, is indicating
        ///     the defending team's goal keeper. For special event chances/goals,
        ///     the ObjectPlayer is often the assisting player of the attacking team,
        ///     but can be any other player that is involved in the event.
        /// </summary>
        public int ObjectPlayerId { get; set; }
    }
}
