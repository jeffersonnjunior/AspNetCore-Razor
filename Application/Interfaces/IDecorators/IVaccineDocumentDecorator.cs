using Application.Dtos.PatientDtos;
using Application.Dtos.VaccineDocumentDtos;

namespace Application.Interfaces.IDecorators;

public interface IVaccineDocumentDecorator
{
    void Add(VaccineDocumentCreateDto dto);
    Task<List<PatientReadDto>> SearchPatientsAsync();
}
