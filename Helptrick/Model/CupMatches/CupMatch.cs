using Helptrick.Model.CommonData;

namespace Helptrick.Model.CupMatches
{
    internal abstract class CupMatch : Match
    {
        /// <summary>
        ///   Container for information about the participating team's league.
        /// </summary>
        public LeagueInfo LeagueInfo { get; set; } = new LeagueInfo();
    }
}
