using Helptrick.Model.CommonData;

namespace Helptrick.Model.Club
{
    internal class ClubData : BaseHattrickData
    {
        /// <summary>
        ///   The globally unique TeamID.
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        ///   The name of the team.
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        ///   Container for the staff.
        /// </summary>
        public Staff Staff { get; set; } = new Staff();


    }
}
