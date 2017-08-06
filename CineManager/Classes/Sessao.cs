using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineManager.Classes
{
    class Sessao
    {
        public int Id { get; set; }
        public string IdCinema { get; set; }
        public int IdFilme { get; set; }
        public string IdSala { get; set; }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }
        public DateTime Data { get; set; }
    }
}
