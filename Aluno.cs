using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class Aluno : Pessoa
    {
        public Aluno(string Nome) : base(Nome)
        {
            this.Nome = Nome;
        }
        public void Estudar()
        {
            Console.WriteLine($"{Nome} está estudando...");
        }
    }
}
