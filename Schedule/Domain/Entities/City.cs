namespace Schedule.Domain.Entities;

public class City : AEntityActivable<int>
{
    public int ProvinceId { get; set; }
    public string Name { get; set; } 
    
    //public Country Country { get; set; }
    public Province Province { get; set; }
}
