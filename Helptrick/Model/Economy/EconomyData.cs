using Helptrick.Model.CommonData;

namespace Helptrick.Model.Economy
{
    /// <summary>
    ///     Economy
    /// </summary>
    internal class EconomyData : BaseHattrickData
    {
        /// <summary>
        ///     The globally unique TeamID.
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        ///     The name of the team.
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        ///     The team's cash.
        /// </summary>
        public int Cash { get; set; }

        /// <summary>
        ///     The budgeted cash for next week for the team.
        /// </summary>
        public int ExpectedCash { get; set; }

        /// <summary>
        ///     The popularity among the sponsors of the team.
        /// </summary>
        public int SponsorsPopularity { get; set; }

        /// <summary>
        ///     The popularity among the supporters of the team.
        /// </summary>
        public int SupportersPopularity { get; set; }

        /// <summary>
        ///     The size of the team's fanclub.
        /// </summary>
        public int FanClubSize { get; set; }

        /// <summary>
        ///     The budgeted income from spectators for the team this week.
        /// </summary>
        public int IncomeSpectators { get; set; }

        /// <summary>
        ///     The budgeted income from sponsors for the team this week.
        /// </summary>
        public int IncomeSponsors { get; set; }

        /// <summary>
        ///     The budgeted financial income for the team this week.
        /// </summary>
        public int IncomeFinancial { get; set; }

        /// <summary>
        ///     The income from sold players of the team this week.
        /// </summary>
        public int IncomeSoldPlayers { get; set; }

        /// <summary>
        ///     The income from sold players commission team this week.
        /// </summary>
        public int IncomeSoldPlayersCommission { get; set; }

        /// <summary>
        ///     The budgeted total income for the team this week.
        /// </summary>
        public int IncomeSum { get; set; }

        /// <summary>
        ///     The budgeted costs of the arena for the team this week.
        /// </summary>
        public int CostsArena { get; set; }

        /// <summary>
        ///     The budgeted costs of the players for the team this week.
        /// </summary>
        public int CostsPlayer { get; set; }

        /// <summary>
        ///     The budgeted financial costs for the team this week.
        /// </summary>
        public int CostsFinancial { get; set; }

        /// <summary>
        ///     The costs from bought players to the team this week.
        /// </summary>
        public int CostsBoughtPlayers { get; set; }

        /// <summary>
        ///     The costs from expanding your arena this week.
        /// </summary>
        public int CostsArenaBuilding { get; set; }

        /// <summary>
        ///     The budgeted costs of the staff for the team this week.
        /// </summary>
        public int CostsStaff { get; set; }

        /// <summary>
        ///     The budgeted costs of the youth squad for the team this week.
        /// </summary>
        public int CostsYouth { get; set; }

        /// <summary>
        ///     The budgeted total cost for the team this week.
        /// </summary>
        public int CostsSum { get; set; }

        /// <summary>
        ///     The budgeted economic result for the team this week.
        /// </summary>
        public int ExpectedWeeksTotal { get; set; }

        /// <summary>
        ///     The budgeted income from spectators for the team last week.
        /// </summary>
        public int LastIncomeSpectators { get; set; }

        /// <summary>
        ///     The budgeted income from sponsors for the team last week.
        /// </summary>
        public int LastIncomeSponsors { get; set; }

        /// <summary>
        ///     The budgeted financial income for the team last week.
        /// </summary>
        public int LastIncomeFinancial { get; set; }

        /// <summary>
        ///     The income from sold players of the team last week.
        /// </summary>
        public int LastIncomeSoldPlayers { get; set; }

        /// <summary>
        ///     The income from sold players commission team last week.
        /// </summary>
        public int LastIncomeSoldPlayersCommission { get; set; }

        /// <summary>
        ///     The budgeted total income for the team last week.
        /// </summary>
        public int LastIncomeSum { get; set; }

        /// <summary>
        ///     The budgeted total income for the team last week.
        /// </summary>
        public int LastCostsArena { get; set; }

        /// <summary>
        ///     The budgeted costs of the players for the team last week.
        /// </summary>
        public int LastCostsPlayer { get; set; }

        /// <summary>
        ///     The budgeted financial costs for the team last week.
        /// </summary>
        public int LastCostsFinancial { get; set; }

        /// <summary>
        ///     The costs from bought players to the team last week.
        /// </summary>
        public int LastCostsBoughtPlayers { get; set; }

        /// <summary>
        ///     The costs from expanding your arena last week.
        /// </summary>
        public int LastCostsArenaBuilding { get; set; }

        /// <summary>
        ///     The budgeted costs of the staff for the team last week.
        /// </summary>
        public int LastCostsStaff { get; set; }

        /// <summary>
        ///     The budgeted costs of the youth squad for the team last week.
        /// </summary>
        public int LastCostsYouth { get; set; }

        /// <summary>
        ///     The budgeted total cost for the team last week.
        /// </summary>
        public int LastCostsSum { get; set; }

        /// <summary>
        ///     The budgeted economic result for the team last week.
        /// </summary>
        public int LastWeeksTotal { get; set; }
    }
}