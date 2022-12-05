using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividades.Models
{
    public class Aluno : Pessoa // está herdando as caracteristicas de Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, eu tenho {Idade} anos, e sou um aluno nota {Nota}");
        }

    }
}