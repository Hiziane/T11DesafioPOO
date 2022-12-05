using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerc01.Models
{
    public class Gato: Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("som : MIAU");
        }
    }
}