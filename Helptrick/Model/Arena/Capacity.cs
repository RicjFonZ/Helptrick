using System;

namespace Helptrick.Model.Arena
{
    internal class Capacity
    {
        public DateTime Date { get; set; } = new DateTime();

        public int Terraces { get; set; }

        public int Basic { get; set; }

        public int Roof { get; set; }

        public int Vip { get; set; }

        public int Total { get; set; }

    }
}
