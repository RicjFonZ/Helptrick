using System.Collections.Generic;

namespace Helptrick.Model.Avatars
{
    internal class Avatar
    {
        public string BackgroundImage { get; set; }

        public List<Layer> Layer { get; set; } = new List<Layer>();
    }
}
