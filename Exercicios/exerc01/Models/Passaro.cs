using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exerc01.Models
{
    public class Passaro: Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("som : Bem-te-vi");
        }
    }
}