using System.Collections.Generic;

namespace Helptrick.Model.Live
{
    /// <summary>
    ///     Get (live) match ticker.
    /// </summary>
    internal class LiveData : BaseHattrickData
    {
        /// <summary>
        ///     Container for all the matches.
        /// </summary>
        public List<MatchLive> MatchList { get; set; } = new List<MatchLive>();
    }
}
