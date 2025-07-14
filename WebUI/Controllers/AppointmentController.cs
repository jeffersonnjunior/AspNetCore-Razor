using Microsoft.AspNetCore.Mvc;
using Npgsql; 
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebUI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AppointmentController : ControllerBase
{
    private readonly string _connectionString;

    public AppointmentController(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("DefaultConnection");
    }

    // GET: api/Appointment/patients
    [HttpGet("patients")]
    public async Task<IActionResult> GetPatients()
    {
        var patients = new List<object>();

        using (var connection = new NpgsqlConnection(_connectionString))
        using (var command = new NpgsqlCommand("SELECT \"Id\", \"Name\" FROM \"Patient\"", connection))
        {
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    patients.Add(new
                    {
                        Id = reader.GetGuid(0), // Alterado para GetGuid
                        Name = reader.GetString(1)
                    });
                }
            }
        }

        return Ok(patients);
    }

    // GET: api/Appointment/doctors
    [HttpGet("doctors")]
    public async Task<IActionResult> GetDoctors()
    {
        var doctors = new List<object>();

        using (var connection = new NpgsqlConnection(_connectionString))
        using (var command = new NpgsqlCommand("SELECT \"Id\", \"Name\" FROM \"Doctor\"", connection))
        {
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    doctors.Add(new
                    {
                        Id = reader.GetGuid(0), // Alterado para GetGuid
                        Name = reader.GetString(1)
                    });
                }
            }
        }

        return Ok(doctors);
    }
}