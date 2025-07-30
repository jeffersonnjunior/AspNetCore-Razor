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

    // GET: api/Appointment/vaccinedocuments
    [HttpGet("vaccinedocuments")]
    public async Task<IActionResult> GetVaccineDocuments()
    {
        var vaccineDocuments = new List<object>();

        using (var connection = new NpgsqlConnection(_connectionString))
        using (var command = new NpgsqlCommand(
            "SELECT \"Id\", \"PatientId\", \"VaccineName\", \"Manufacturer\", \"AdministrationDate\", \"LotNumber\" FROM \"VaccineDocument\"",
            connection))
        {
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    vaccineDocuments.Add(new
                    {
                        Id = reader.GetGuid(0),
                        PatientId = reader.GetGuid(1),
                        VaccineName = reader.GetString(2),
                        Manufacturer = reader.GetString(3),
                        AdministrationDate = reader.GetDateTime(4),
                        LotNumber = reader.GetString(5)
                    });
                }
            }
        }

        return Ok(vaccineDocuments);
    }

    // GET: api/Appointment/appointments
    [HttpGet("appointments")]
    public async Task<IActionResult> GetAppointments()
    {
        var appointments = new List<object>();

        using (var connection = new NpgsqlConnection(_connectionString))
        using (var command = new NpgsqlCommand(
            @"SELECT a.""Id"", a.""PatientId"", a.""DoctorId"", a.""AppointmentDateTime"", a.""Notes"", a.""Status"",
                 p.""Name"" AS PatientName, d.""Name"" AS DoctorName
          FROM ""Appointment"" a
          JOIN ""Patient"" p ON a.""PatientId"" = p.""Id""
          JOIN ""Doctor"" d ON a.""DoctorId"" = d.""Id""", connection))
        {
            await connection.OpenAsync();
            using (var reader = await command.ExecuteReaderAsync())
            {
                while (await reader.ReadAsync())
                {
                    appointments.Add(new
                    {
                        Id = reader.GetGuid(0),
                        PatientId = reader.GetGuid(1),
                        DoctorId = reader.GetGuid(2),
                        AppointmentDateTime = reader.GetDateTime(3),
                        Notes = reader.IsDBNull(4) ? null : reader.GetString(4),
                        Status = reader.GetInt32(5), // Se Status for enum int
                        PatientName = reader.GetString(6),
                        DoctorName = reader.GetString(7)
                    });
                }
            }
        }

        return Ok(appointments);
    }
}