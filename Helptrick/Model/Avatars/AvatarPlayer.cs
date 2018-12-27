namespace Helptrick.Model.Avatars
{
    /// <summary>
    ///    Container for a player.
    /// </summary>
    internal abstract class AvatarPlayer
    {
        /// <summary>
        ///    The globally unique PlayerID.
        /// </summary>
        public int PlayerId { get; set; }

        /// <summary>
        ///    Container for the elements to build the avatar.
        /// </summary>
        public Avatar Avatar { get; set; } = new Avatar();

    }
}
