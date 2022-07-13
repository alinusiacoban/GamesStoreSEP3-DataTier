namespace GamesStoreSEP3.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool isAdmin { get; set; } = false;
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}