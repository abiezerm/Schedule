namespace Schedule.Domain.Entities
{
    public class UserPage : AEntityActivable<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
}
