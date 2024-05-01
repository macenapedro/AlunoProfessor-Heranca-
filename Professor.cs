using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class Professor : Pessoa
    {
        public Professor(string Nome) : base(Nome)
        {
        }
        public void Explicar()
        {
            Console.WriteLine($"{Nome} está explicando...");
        }
    }
}
