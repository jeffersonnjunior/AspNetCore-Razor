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

    public async Task Add(VaccineDocument dto)
    {
        await _vaccineDocumentRepository.AddAsync(dto);
    }

    public async Task<List<VaccineDocument>> GetVaccineDocumentsList()
    {
        var documents = await _vaccineDocumentRepository.GetAllVaccineDocumentsAsync();
        return documents.ToList();
    }
}
