using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario.Model
{
    internal class Pessoa
    {
        public string Nome {  get; set; }
        public string SobreNome {  get; set; }

        public override string ToString()
        {
            return $"{Nome} {SobreNome}";
        }
    }
}
