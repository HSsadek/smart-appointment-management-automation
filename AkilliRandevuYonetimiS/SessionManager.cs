namespace AkilliRandevuYonetimiS
{
    // Simple session holder for current user
    public static class SessionManager
    {
        public static int? UserId { get; set; }
        public static string Username { get; set; }
        public static string Email { get; set; }
        public static string DisplayName { get; set; }
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static byte[] AvatarBytes { get; set; }
        public static string Role { get; set; }
    }
}