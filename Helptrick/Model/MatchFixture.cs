namespace Helptrick.Model
{
    internal abstract class MatchFixture : Match
    {
        /// <summary>
        ///     MatchRound that the match is part of.
        /// </summary>
        public int MatchRound { get; set; }
    }
}
