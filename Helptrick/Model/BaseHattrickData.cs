using GalaSoft.MvvmLight;
using System;

namespace Helptrick.Model
{
    internal class BaseHattrickData : ObservableObject
    {
        public string FileName { get; set; }

        public string Version { get; set; }

        public int UserId { get; set; }

        public DateTime FetchedDate { get; set; } = new DateTime();
    }
}