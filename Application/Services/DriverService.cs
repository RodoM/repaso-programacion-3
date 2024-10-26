using Application.Interfaces;
using Application.Mappings;
using Application.Models.Request;
using Application.Models.Response;
using Domain.Entities;
using Domain.Interfaces;


namespace Application.Services;

public class DriverService : IDriverService
{
  private readonly IRepositoryBase<Driver> _driverBaseRepository;
  private readonly IDriverRepository _driverRepository;
  private readonly DriverMapping _driverMapping;
  public DriverService(IRepositoryBase<Driver> driverBaseRepository, IDriverRepository driverRepository, DriverMapping driverMapping)
  {
    _driverBaseRepository = driverBaseRepository;
    _driverRepository = driverRepository;
    _driverMapping = driverMapping;
  }

  public async Task<List<DriverResponse>> GetAllDrivers()
  {
    var response = await _driverRepository.getAllDrivers();
    return response.Select(x => _driverMapping.FromEntityToResponse(x)).ToList();
  }

  public async Task<DriverResponse> CreateDriver(DriverRequest Driver)
  {
    var entity = _driverMapping.FromRequestToEntity(Driver);
    var response = await _driverBaseRepository.AddAsync(entity);
    return _driverMapping.FromEntityToResponse(response);
  }
}
