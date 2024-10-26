namespace Domain.Entities;

public class Garage
{
  public int Id { get; set; }
  public Driver? Driver { get; set; }
  public string? Address { get; set; }
  public List<Car>? Cars { get; set; }
}
