using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAWA_Transacciones.Models
{
    public class Cantante
    {
        public int AutorId { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }
        public char Genero { get; set; }
        public bool Estado { get; set; }
        public Musica Cancion { get; set; }
    }
}
