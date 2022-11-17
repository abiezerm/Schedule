
namespace Schedule.Domain.Entities;

public class Country : AEntityActivable<int>
{
    public string Name { get; set; }
    
    public IList<City> Cities { get; set; }
}