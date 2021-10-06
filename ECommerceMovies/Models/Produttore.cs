using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceMovies.Models
{
    public class Produttore
    {
        [Key]
        public int Id { get; set; } 
        public string NomeCompleto { get; set; }
        public string ProfiloFotoURL { get; set; }
        public string Bio { get; set; }

        //Relationship : uma produtora pode prduzir N filmes
        public List<Film> Filmes { get; set; }

    }
}
