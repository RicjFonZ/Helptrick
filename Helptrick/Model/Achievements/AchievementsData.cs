using System.Collections.Generic;
using Helptrick.Model.CommonData;

namespace Helptrick.Model.Achievements
{
    internal class AchievementsData : BaseHattrickData
    {
        public int MaxPoints { get; set; }

        public List<Achievement> AchievementList { get; set; } = new List<Achievement>();
    }
}
