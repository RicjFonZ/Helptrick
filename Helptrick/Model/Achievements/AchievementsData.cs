using System.Collections.Generic;

namespace Helptrick.Model.Achievements
{
    /// <summary>
    ///     The achievements of a specific user.
    /// </summary>
    internal class AchievementsData : BaseHattrickData
    {
        /// <summary>
        ///     The maximum number of points a user currently can achieve
        /// </summary>
        public int MaxPoints { get; set; }

        /// <summary>
        ///     Container for the list of Achievements.
        /// </summary>
        public List<Achievement> AchievementList { get; set; } = new List<Achievement>();
    }
}