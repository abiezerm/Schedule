namespace Schedule.Domain.Entities;

public class AEntityActivable<T> : ABaseEntity<T>
{
    public bool IsActive { get; set; }
}