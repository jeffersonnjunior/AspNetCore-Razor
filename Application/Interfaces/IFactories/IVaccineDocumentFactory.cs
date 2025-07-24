using Application.Dtos.VaccineDocumentDtos;
using Domain.Entities;

namespace Application.Interfaces.IFactories;

public interface IVaccineDocumentFactory
{
    VaccineDocument MapToVaccineDocument(VaccineDocumentCreateDto dto);
}
