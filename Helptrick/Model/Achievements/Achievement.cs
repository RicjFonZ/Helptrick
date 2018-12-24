using System;

namespace Helptrick.Model.Achievements
{
    internal abstract class Achievement
    {
        public int AchievementTypeId { get; set; }

        public string AchievementText { get; set; }

        public int CategoryId { get; set; }

        public DateTime EventDate { get; set; } = new DateTime();

        public int Points { get; set; }

        public bool MultiLevel { get; set; }

        public int Rank { get; set; }

        public int NumberOfEvents { get; set; }
    }
}
