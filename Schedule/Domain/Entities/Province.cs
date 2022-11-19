namespace Schedule.Domain.Entities
{
    public class Province : AEntityActivable<int>
    {
        public string Name { get; set; }

        public IList<Country> Countries { get; set; }
    }
}
