using Application.Dtos.VaccineDocumentDtos;
using Application.Interfaces.IFactories;
using Domain.Entities;

namespace Application.Factories;

public class VaccineDocumentFactory : IVaccineDocumentFactory
{
    public VaccineDocument MapToVaccineDocument(VaccineDocumentCreateDto dto)
    {
        return new VaccineDocument
        {
            Id = Guid.NewGuid(),
            PatientId = dto.PatientId,
            VaccineName = dto.VaccineName,
            Manufacturer = dto.Manufacturer,
            AdministrationDate = dto.AdministrationDate,
            LotNumber = dto.LotNumber
        };
    }
}
