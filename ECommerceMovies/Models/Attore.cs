using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceMovies.Models
{
    public class Attore
    {
        [Key]
        public int Id { get; set; } //PK della tabella
        public string NomeCompleto { get; set; }
        public string ProfiloFotoURL { get; set; }
        public string Bio { get; set; }

        //relationship
        public List<Attore_Film> Attori_Films { get; set; }

    }
}
