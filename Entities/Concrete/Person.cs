using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;

namespace Entities.Concrete
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Otomatik artan olarak belirtiliyor
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Key]
        [MaxLength(12), MinLength(11)]
        public long NationalIdentity { get; set; }
        public int DateOfBirthYear { get; set; }
        public bool HasMask { get; set; }
    }
}
