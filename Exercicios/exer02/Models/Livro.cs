using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exer02.Models
{
    public class Livro
    {
        public string? NomeLivro { get; set; }
        //public string? Autores { get; set; }
        public List<Autores> Autores { get; set; } = new List<Autores>();
    }
}