namespace JuegoDeRol
{
    public class User{
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;

        public List<Character> Characters { get; set; }
    }
}