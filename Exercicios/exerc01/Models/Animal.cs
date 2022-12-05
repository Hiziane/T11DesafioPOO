using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerc01.Models
{
    public class Animal
    {
        public string? Raca { get; set; }
        public string? Tamanho { get; set; }

        public virtual void EmitirSom()
        {
            Console.WriteLine("Tipo de som");
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Raça:    {Raca}");
            Console.WriteLine($"Tamanho: {Tamanho}");
        }
    }
}

    