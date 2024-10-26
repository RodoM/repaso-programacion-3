using Domain.Entities;

namespace Domain.Interfaces;

public interface IDriverRepository
{
  Task<List<Driver>> getAllDrivers();
}
