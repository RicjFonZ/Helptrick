using Helptrick.Model.CommonData;
using System;

namespace Helptrick.Model.Challenges
{
    internal class Opponent
    {
        /// <summary>
        ///   The globally unique nationalTeamID.
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        ///  The team name.
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        ///   The url for the opponent's logo, if it has one.
        /// </summary>
        public Uri LogoUrl { get; set; }

        /// <summary>
        ///   Container for the data about the arena for the friendly.
        /// </summary>
        public ArenaInfo Arena { get; set; } = new ArenaInfo();

        /// <summary>
        ///   Container for the data about the country that the
        ///   friendly would be played in.
        /// </summary>
        public Country Country { get; set; } = new Country();

        /// <summary>
        ///   Container for the data about the league that the
        ///   friendly would be played in.
        /// </summary>
        public League League { get; set; } = new League();

        /// <summary>
        ///   Container for the data about the opponent.
        /// </summary>
        public bool IsAgreed { get; set; }
    }
}
