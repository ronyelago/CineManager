using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineManager.Classes
{
    class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string TituloPT { get; set; }
        public int IdGenero { get; set; }
        public string Sinopse { get; set; }
        public int Ano { get; set; }
        public int Duracao { get; set; }
        public string Origem { get; set; }
        public int IdDiretor { get; set; }
        public int Classificacao { get; set; }
        public byte[] Foto { get; set; }
    }
}
