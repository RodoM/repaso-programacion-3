using Domain.Enums;

namespace Domain.Entities;

public class Car
{
  public int Id { get; set; }
  public Brand Brand { get; set; }
  public string? Model { get; set; }
  public string? Color { get; set; }
  public Driver? Driver { get; set; }
}
