namespace Helptrick.Model.Club
{
    internal class YouthSquad
    {
        /// <summary>
        ///   The weekly youth squad investment.
        /// </summary>
        public int Investment { get; set; }

        /// <summary>
        ///   Boolean value indicating if the team has promoted
        ///   a youth player this week.
        /// </summary>
        public bool HasPromoted { get; set; }

        /// <summary>
        /// 	The current level of the youth squad.
        /// </summary>
        public int YouthLevel { get; set; }
    }
}
