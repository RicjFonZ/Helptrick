namespace Helptrick.Model.Avatars
{
    internal abstract class Player
    {
        public int PlayerId { get; set; }

        public Avatar Avatar { get; set; } = new Avatar();

    }
}
