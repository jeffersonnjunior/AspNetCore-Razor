using Application.Dtos.VaccineDocumentDtos;
using Domain.Entities;

namespace Application.Interfaces.IServices;

public interface IVaccineDocumentServices
{
    void Add(VaccineDocument dto);
}
