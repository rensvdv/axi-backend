using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    [Table("Gebruiker")]
    public record GebruikerDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("GebruikerId")]
        public int Id { get; init; }
        [Column("Naam")]
        public string Name { get; init; }
        [Column("Email")]
        public string Email { get; init; }
        [Column("Wachtwoord")]
        public string Password { get; init; }
        [Column("Actief")]
        public bool Actief { get; init; }
        //public ProfielDTO ProfielDTO { get; init; }
    }
}
