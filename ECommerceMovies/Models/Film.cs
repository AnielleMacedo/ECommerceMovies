using ECommerceMovies.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceMovies.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public DateTime DataInizio { get; set; }
        public DateTime DataFine { get; set; }
        public double Prezzo { get; set; }
        public string ImgURL { get; set; }

        //crio um Enum para a categoriia na pasta /Data/FilmCategoria
        public FilmCategoria FilmCategoria { get; set; }
    }
}
