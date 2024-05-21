using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmeApi.Models;


namespace FilmeApi.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Diretor { get; set; }
        public string AnoLancamento { get; set; }
        public string Classificacao { get; set; }
        public string Genero { get; set; }
    }
}
