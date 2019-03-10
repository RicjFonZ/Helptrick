using System.Collections.Generic;

namespace Helptrick.Model
{
    internal abstract class MatchLive : Match
    {
        /// <summary>
        ///     Specifies which source system the match belongs to,
        ///     this replace the old isYouth param
        /// </summary>
        public string SourceSystem { get; set; }

        /// <summary>
        ///     Container for all the events.
        /// </summary>
        public List<Event> EventList { get; set; } = new List<Event>();

        /// <summary>
        ///     Container for the substitutions in the game.
        /// </summary>
        public List<Substitution> Substitutions { get; set; } = new List<Substitution>();

        /// <summary>
        ///     List of players in the hometeam who started the game
        /// </summary>
        public List<StartingLineup> HomeTeamLineup { get; set; } = new List<StartingLineup>();

        /// <summary>
        ///     List of players in the awayteam who started the game
        /// </summary>
        public List<StartingLineup> AwayTeamLineup { get; set; } = new List<StartingLineup>();

        /// <summary>
        ///     The last shown event. Use this as LastShownIndexes
        ///     for actionType=viewNew.
        /// </summary>
        public string LastShownEventIndex { get; set; }

        /// <summary>
        ///     The minute that the next matchevent will happen,
        ///     this allows you to only ask for new events when needed.
        ///     Only available while the match is ongoing.
        /// </summary>
        public string NextEventMinute { get; set; }

        /// <summary>
        ///     The matchPart in which the next matchevent will happen,
        ///     this allows you to only ask for new events when needed.
        ///     Only available while the match is ongoing.
        /// </summary>
        public string NextEventMatchPart { get; set; }

    }
}
