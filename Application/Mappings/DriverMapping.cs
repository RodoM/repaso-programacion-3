using System;
using Application.Models.Request;
using Application.Models.Response;
using Domain.Entities;

namespace Application.Mappings;

public class DriverMapping
{
  public Driver FromRequestToEntity(DriverRequest request)
  {
    return new Driver
    {
      Name = request.Name,
    };
  }

  public DriverResponse FromEntityToResponse(Driver entity)
  {
    return new DriverResponse
    {
      Id = entity.Id,
      Name = entity.Name,
    };
  }
}
