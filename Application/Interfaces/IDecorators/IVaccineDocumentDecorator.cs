using Application.Dtos.PatientDtos;
using Application.Dtos.VaccineDocumentDtos;
using Domain.Entities;

namespace Application.Interfaces.IDecorators;

public interface IVaccineDocumentDecorator
{
    Task Add(VaccineDocumentCreateDto dto);
    Task<List<PatientReadDto>> SearchPatientsAsync();
}
