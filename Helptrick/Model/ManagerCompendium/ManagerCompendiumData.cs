using System.Collections.Generic;

namespace Helptrick.Model.ManagerCompendium
{
    /// <summary>
    ///     The manager compendium of the logged in user.
    /// </summary>
    internal class ManagerCompendiumData : BaseHattrickData
    {
        /// <summary>
        ///     The 'username' or 'nickname' used in Forums and around the site.
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        ///     The current level of Hattrick Supporter
        ///     that the user has. Empty if not a Supporter.
        /// </summary>
        public string SupporterTier { get; set; }

        /// <summary>
        ///     Container for the last logins.
        /// </summary>
        public List<LastLogin> LastLogins { get; set; } = new List<LastLogin>();

        /// <summary>
        ///     Container for the language.
        /// </summary>
        public Language Language { get; set; } = new Language();

        /// <summary>
        ///     Container for the country.
        /// </summary>
        public Country Country { get; set; } = new Country();

        /// <summary>
        ///     Container for the list of Teams.
        /// </summary>
        public List<UserTeam> Teams { get; set; } = new List<UserTeam>();


    }
}
