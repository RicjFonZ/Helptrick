namespace Helptrick.Model.HallOfFame
{
    internal abstract class Player
    {
        /// <summary>
        ///     The globally unique PlayerID.
        /// </summary>
        public int PlayerId { get; set; }

        /// <summary>
        ///     Player FirstName name.
        /// </summary>
        public int FirstName { get; set; }

        /// <summary>
        ///     Player NickName name.
        /// </summary>
        public int NickName { get; set; }

        /// <summary>
        ///     Player LastName name.
        /// </summary>
        public int LastName { get; set; }

        /// <summary>
        ///     The age of the player in years.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        ///     The aproximate Date/time of next birthday.
        /// </summary>
        public int NextBirthday { get; set; }

        /// <summary>
        ///     CountryID of the country where the player was born.
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        ///     The date of arrival to the team.
        /// </summary>
        public int ArrivalDate { get; set; }

        /// <summary>
        ///     An identifier to show which type of job the player have now.
        /// </summary>
        public int ExpertType { get; set; }

        /// <summary>
        ///     The date the player was made hall of fame.
        /// </summary>
        public int HofDate { get; set; }

        /// <summary>
        ///     The age of the player in years when he was made hall of fame.
        /// </summary>
        public int HofAge { get; set; }
    }
}