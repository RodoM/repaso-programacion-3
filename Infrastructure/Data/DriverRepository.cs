using System;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DriverRepository : EFRepository<Driver>, IDriverRepository
{
  public DriverRepository(ApplicationDbContext context) : base(context)
  {
  }

  public async Task<List<Driver>> getAllDrivers()
  {
    return await _context.Drivers.ToListAsync();
  }
}
