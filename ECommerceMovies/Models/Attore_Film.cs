using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceMovies.Models
{
    public class Attore_Film
    {
        //essa tabela representa a join entre Attore e Film e carregam o id de ambas
        public int FilmId { get; set; }
        public Film Film { get; set; } //reacao com filme


        public int AttoreId { get; set; }
        public Attore Attore { get; set; }//relacao com ator
    }
}
