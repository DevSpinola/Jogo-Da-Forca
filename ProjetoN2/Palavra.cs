using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoN2
{
    internal class Palavra
    {
        public int tamanho;
        public string palavra, tema;

        public Palavra(int t, string p, string tema)
        {
            this.tamanho = t;
            this.palavra = p;
            this.tema = tema;
        }
        public Palavra(int t, string p)
        {
            this.tamanho = t;
            this.palavra = p;            
        }

    }
}
