using Application.Dtos.VaccineDocumentDtos;
using Application.Interfaces.IDecorators;
using Application.Interfaces.IFactories;
using Application.Interfaces.IServices;
using Domain.Entities;

namespace Application.Decorators;

public class VaccineDocumentDecorator : IVaccineDocumentDecorator
{
    private readonly IVaccineDocumentServices _vaccineDocumentServices;
    private readonly IVaccineDocumentFactory _vaccineDocumentFactory;

    public VaccineDocumentDecorator(IVaccineDocumentServices vaccineDocumentServices, IVaccineDocumentFactory vaccineDocumentFactory)
    {
        _vaccineDocumentServices = vaccineDocumentServices;
        _vaccineDocumentFactory = vaccineDocumentFactory;
    }

    public void Add(VaccineDocumentCreateDto dto)
    {
        VaccineDocument vaccineDocument = _vaccineDocumentFactory.MapToVaccineDocument(dto);

        _vaccineDocumentServices.Add(vaccineDocument);
    }
}
