using System;

namespace Helptrick.Model.CommonData
{
    internal class BaseHattrickData
    {
        public string FileName { get; set; }

        public string Version { get; set; }

        public int UserId { get; set; }

        public DateTime FetchedDate { get; set; } = new DateTime();
    }
}