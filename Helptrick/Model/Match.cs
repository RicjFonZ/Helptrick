namespace Helptrick.Model
{
    internal class Match : BaseMatch
    {
        /// <summary>
        ///     Container for the match results.
        /// </summary>
        public MatchResult MatchResult { get; set; } = new MatchResult();
    }
}