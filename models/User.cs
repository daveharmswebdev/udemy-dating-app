namespace DatingApp.API.models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PaswwordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}