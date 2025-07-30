using Application.Dtos.PatientDtos;
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

    public async Task Add(VaccineDocumentCreateDto dto)
    {
        VaccineDocument vaccineDocument = _vaccineDocumentFactory.MapToVaccineDocument(dto);
        await _vaccineDocumentServices.Add(vaccineDocument);
    }

    public async Task<List<PatientReadDto>> SearchPatientsAsync()
    {
        return await _patientDecorator.GetPatientsList();
    }
}