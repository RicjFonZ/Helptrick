using System;

namespace Helptrick.Model.Achievements
{
    /// <summary>
    ///    Container for the data about a particular Achievement.
    /// </summary>
    internal abstract class Achievement
    {
        /// <summary>
        ///    The AchievementTypeID
        /// </summary>
        public int AchievementTypeId { get; set; }

        /// <summary>
        ///    The text describing the achievement
        /// </summary>
        public string AchievementText { get; set; }

        /// <summary>
        ///    The CategoryID the achievement belongs to
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        ///    The date when achievement was awarded
        /// </summary>
        public DateTime EventDate { get; set; } = new DateTime();

        /// <summary>
        ///    Points awarded for achievement
        /// </summary>
        public int Points { get; set; }

        /// <summary>
        ///    True if AchievementTypeID has multiple levels.
        /// </summary>
        public bool MultiLevel { get; set; }

        /// <summary>
        ///    The user's current rank in this achievement,
        ///    where 1 = best rank possible.
        /// </summary>
        public int Rank { get; set; }

        /// <summary>
        ///    Global number of users been awarded this achievement
        /// </summary>
        public int NumberOfEvents { get; set; }
    }
}
