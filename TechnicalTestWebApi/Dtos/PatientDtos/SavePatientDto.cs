namespace TechnicalTestWebApi.Dtos.PatientDtos
{
    public class SavePatientDto
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string DocumentType { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
    }
}
