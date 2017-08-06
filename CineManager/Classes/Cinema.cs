using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineManager.Classes
{
    class Cinema
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int NSalas { get; set; }
        public int Capacidade { get; set; }
        public byte[] Foto { get; set; }
    }
}
