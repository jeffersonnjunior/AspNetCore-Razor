using Application.Dtos.VaccineDocumentDtos;
using Application.Interfaces.IDecorators;
using Application.Interfaces.IFactories;
using Application.Interfaces.IServices;
using Domain.Entities;

public class VaccineDocumentDecorator : IVaccineDocumentDecorator
{
    private readonly IVaccineDocumentServices _vaccineDocumentServices;
    private readonly IVaccineDocumentFactory _vaccineDocumentFactory;
    private readonly IPatientDecorator _patientDecorator;

    public VaccineDocumentDecorator(
        IVaccineDocumentServices vaccineDocumentServices,
        IVaccineDocumentFactory vaccineDocumentFactory,
        IPatientServices patientService,
        IPatientDecorator patientDecorator)
    {
        _vaccineDocumentServices = vaccineDocumentServices;
        _vaccineDocumentFactory = vaccineDocumentFactory;
        _patientDecorator = patientDecorator;
    }

    public void Add(VaccineDocumentCreateDto dto)
    {
        VaccineDocument vaccineDocument = _vaccineDocumentFactory.MapToVaccineDocument(dto);
        _vaccineDocumentServices.Add(vaccineDocument);
    }

    public async Task<IEnumerable<object>> SearchPatientsAsync()
    {
       return await _patientDecorator.GetPatientsNamesAsync();
    }
}