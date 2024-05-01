using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    public class Pessoa
    {
        public Pessoa(string Nome)
        {
            this.Nome = Nome;
        }
        protected string Nome { get; set; }

        public override string ToString()
        {
            return "Olá, meu nome é " + Nome;
        }
    }
}
