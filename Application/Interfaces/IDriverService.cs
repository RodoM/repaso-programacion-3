using System;
using Application.Models.Request;
using Application.Models.Response;

namespace Application.Interfaces;

public interface IDriverService
{
  Task<List<DriverResponse>> GetAllDrivers();
  Task<DriverResponse> CreateDriver(DriverRequest Driver);
}
