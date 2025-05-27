using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Doctor_DoctorId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Patient_PatientId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamDocument_Patient_PatientId",
                table: "ExamDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalSpecialty_MedicalSpecialty_MedicalSpecialtyId",
                table: "MedicalSpecialty");

            migrationBuilder.DropForeignKey(
                name: "FK_OtherDocument_Patient_PatientId",
                table: "OtherDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_VaccineDocument_Patient_PatientId",
                table: "VaccineDocument");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Doctor_DoctorId",
                table: "Appointment",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Patient_PatientId",
                table: "Appointment",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamDocument_Patient_PatientId",
                table: "ExamDocument",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalSpecialty_MedicalSpecialty_MedicalSpecialtyId",
                table: "MedicalSpecialty",
                column: "MedicalSpecialtyId",
                principalTable: "MedicalSpecialty",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OtherDocument_Patient_PatientId",
                table: "OtherDocument",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VaccineDocument_Patient_PatientId",
                table: "VaccineDocument",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Doctor_DoctorId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Patient_PatientId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_ExamDocument_Patient_PatientId",
                table: "ExamDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalSpecialty_MedicalSpecialty_MedicalSpecialtyId",
                table: "MedicalSpecialty");

            migrationBuilder.DropForeignKey(
                name: "FK_OtherDocument_Patient_PatientId",
                table: "OtherDocument");

            migrationBuilder.DropForeignKey(
                name: "FK_VaccineDocument_Patient_PatientId",
                table: "VaccineDocument");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Doctor_DoctorId",
                table: "Appointment",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Patient_PatientId",
                table: "Appointment",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamDocument_Patient_PatientId",
                table: "ExamDocument",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalSpecialty_MedicalSpecialty_MedicalSpecialtyId",
                table: "MedicalSpecialty",
                column: "MedicalSpecialtyId",
                principalTable: "MedicalSpecialty",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OtherDocument_Patient_PatientId",
                table: "OtherDocument",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_VaccineDocument_Patient_PatientId",
                table: "VaccineDocument",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id");
        }
    }
}
