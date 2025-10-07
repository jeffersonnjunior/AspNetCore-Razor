using Core.Entities;
using Core.Interfaces.Services;

namespace Core.Services;

public class VaccineService : IVaccineService
{
    public async Task ValidateVaccineAsync(Vaccine vaccine, bool nameAlreadyExists = false)
    {
        if (string.IsNullOrWhiteSpace(vaccine.Name))
        {
            throw new ArgumentException("O nome da vacina é obrigatório.");
        }

        if (vaccine.Name.Length < 3)
        {
            throw new ArgumentException("O nome da vacina deve ter pelo menos 3 caracteres.");
        }

        if (string.IsNullOrWhiteSpace(vaccine.Manufacturer))
        {
            throw new ArgumentException("O fabricante da vacina é obrigatório.");
        }

        if (vaccine.Date > DateTime.Now)
        {
            throw new ArgumentException("A data da vacina não pode ser futura.");
        }

        // Regra de negócio que depende de dados externos
        if (nameAlreadyExists)
        {
            throw new InvalidOperationException($"Já existe uma vacina com o nome '{vaccine.Name}'.");
        }
    }
}