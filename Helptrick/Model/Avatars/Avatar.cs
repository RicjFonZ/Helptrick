using System;
using System.Collections.Generic;

namespace Helptrick.Model.Avatars
{
    internal class Avatar
    {
        /// <summary>
        ///    The URL to the card background-image.
        ///    This will show a silouette for non-supporter teams.
        /// </summary>
        public Uri BackgroundImage { get; set; }

        /// <summary>
        ///    The container for each avatar bodypart item.
        /// </summary>
        public List<Layer> Layer { get; set; } = new List<Layer>();
    }
}
