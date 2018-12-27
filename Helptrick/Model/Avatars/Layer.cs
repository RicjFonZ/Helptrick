using System;

namespace Helptrick.Model.Avatars
{
    internal abstract class Layer
    {
        /// <summary>
        ///    x-coordinate of image layer
        /// </summary>
        public int X { get; set; }

        /// <summary>
        ///    y-coordinate of image layer
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        ///    The URL to the bodypart item.
        /// </summary>
        public Uri Image { get; set; }

    }
}
