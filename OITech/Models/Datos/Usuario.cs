using System;
using System.Collections.Generic;

#nullable disable

namespace OITech.Models.Datos
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public int IdStatus { get; set; }
        public int IdProfile { get; set; }
        public string FirstName { get; set; }
        public string SecondFirstName { get; set; }
        public string LastName { get; set; }
        public string SecondLastName { get; set; }
        public int IdDocumentType { get; set; }
        public int? IdCountry { get; set; }
        public int? IdCity { get; set; }
        public string DocumentNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
