using Helptrick.Model.CommonData;
using System;
using System.Collections.Generic;

namespace Helptrick.Model.GlobalLadder
{
    /// <summary>
    ///     Information about teams in the ladder and posistions in it
    /// </summary>
    internal class GlobalLadderData : BaseHattrickData
    {
        /// <summary>
        ///     Container for the data about the player.
        /// </summary>
        public int LadderId { get; set; }

        /// <summary>
        ///     The name of the ladder.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     How many teams there is in the ladder.
        /// </summary>
        public int NumOfTeams { get; set; }

        /// <summary>
        ///     How many results are being shown.
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        ///     What page is being shown.
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        ///     The team id of the leader.
        /// </summary>
        public int KingTeamId { get; set; }

        /// <summary>
        ///     The teamname of the leader.
        /// </summary>
        public string KingTeamName { get; set; }

        /// <summary>
        ///     Since when has the team been the king.
        /// </summary>
        public DateTime KingSince { get; set; } = new DateTime();

        /// <summary>
        ///     Container for the data about the team.
        /// </summary>
        public List<GlobalLadderTeam> LadderTeam { get; set; } = new List<GlobalLadderTeam>();
    }
}
