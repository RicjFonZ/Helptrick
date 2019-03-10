using System.Collections.Generic;

namespace Helptrick.Model.CupMatches
{
    /// <summary>
    ///     Information about cup matches
    /// </summary>
    internal class CupMatchesData : BaseHattrickData
    {
        /// <summary>
        ///     The global unique CupID.
        /// </summary>
        public int CupId { get; set; }

        /// <summary>
        ///     The season of the matches.
        /// </summary>
        public int CupSeason { get; set; }

        /// <summary>
        ///     The cupround of the matches.
        /// </summary>
        public int CupRound { get; set; }

        /// <summary>
        ///     The name of the cup.
        /// </summary>
        public string CupName { get; set; }

        /// <summary>
        ///     Container for matches.
        /// </summary>
        public List<CupMatch> MatchList { get; set; } = new List<CupMatch>();
    }
}