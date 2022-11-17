namespace Schedule.Domain.Entities;

public abstract  class ABaseEntity<T> 
{
    public T Id { get; set; }
}