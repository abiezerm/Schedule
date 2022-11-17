namespace Schedule.Domain.Entities
{
    public class User : AEntityActivable<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
