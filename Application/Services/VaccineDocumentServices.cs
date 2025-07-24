using Application.Interfaces.IServices;
using Domain.Entities;
using Infrastructure.Interfaces.IPersistence.IRepositories;

namespace Application.Services;

public class VaccineDocumentServices : IVaccineDocumentServices
{
    private readonly IVaccineDocumentRepository _vaccineDocumentRepository;
    public VaccineDocumentServices(IVaccineDocumentRepository vaccineDocumentRepository)
    {
        _vaccineDocumentRepository = vaccineDocumentRepository;
    }

    public void Add(VaccineDocument dto)
    {
        _vaccineDocumentRepository.AddAsync(dto);
    }
}
