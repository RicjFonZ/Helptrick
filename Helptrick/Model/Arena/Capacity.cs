using System;

namespace Helptrick.Model.Arena
{
    internal class Capacity
    {
        /// <summary>
        ///     The date when of the capacity.
        /// </summary>
        public DateTime Date { get; set; } = new DateTime();

        /// <summary>
        ///     The capacity on the terraces.
        /// </summary>
        public int Terraces { get; set; }

        /// <summary>
        ///     The capacity on the basic seats.
        /// </summary>
        public int Basic { get; set; }

        /// <summary>
        ///     The capacity on the seats under roof.
        /// </summary>
        public int Roof { get; set; }

        /// <summary>
        ///     The capacity in the VIP lounge.
        /// </summary>
        public int Vip { get; set; }

        /// <summary>
        ///     The arenas total capacity.
        /// </summary>
        public int Total { get; set; }
    }
}