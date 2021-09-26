using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceMovies.Data
{
    //Enumeratore per le categorie
    //se deixa os valores de default do Enum ele inicia por zero mas quero configurar os valores e bastar configurar o 1
    public enum FilmCategoria
    {
        Azione = 1,
        Commedia,
        Horror,
        Avventura
    }
}
