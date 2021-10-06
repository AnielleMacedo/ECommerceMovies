using ECommerceMovies.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        //relationship
        public List<Attore_Film> Attori_Films { get; set; }

        //relacao con cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //relacao con Produttore
        public int ProduttoreId { get; set; }
        [ForeignKey("ProduttoreId")]
        public Produttore Produttore { get; set; }
    }
}
