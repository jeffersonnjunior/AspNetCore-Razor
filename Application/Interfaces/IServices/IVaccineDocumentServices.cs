using Domain.Entities;

namespace Application.Interfaces.IServices;

public interface IVaccineDocumentServices
{
    Task Add(VaccineDocument dto);
    Task<List<VaccineDocument>> GetVaccineDocumentsList();
}
