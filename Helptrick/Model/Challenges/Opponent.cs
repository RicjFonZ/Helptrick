using Helptrick.Model.CommonData;
using System;

namespace Helptrick.Model.Challenges
{
    internal class Opponent
    {
        public int TeamId { get; set; }

        public string TeamName { get; set; }

        public Uri LogoUrl { get; set; }

        public ArenaInfo Arena { get; set; } = new ArenaInfo();

        public Country Country { get; set; } = new Country();

        public bool IsAgreed { get; set; }
    }
}
