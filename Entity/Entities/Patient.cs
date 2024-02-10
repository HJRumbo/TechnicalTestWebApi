using System.ComponentModel.DataAnnotations;

namespace Entity.Entities
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string DocumentType { get; set; } = string.Empty;
        public string DocumentNumber { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
    }
}
