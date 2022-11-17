namespace Schedule.Domain.Entities;

public class City : AEntityActivable<int>
{
    public int CountryId { get; set; }
    public string Name { get; set; } 
    public Country Country { get; set; }
}