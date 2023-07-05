using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAWA_Transacciones.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Nombre { get; set; }
        public int Periodo { get; set; }
        public string Sello { get; set; }
        public bool Estado { get; set; }
        public Cancion Cancion { get; set; }
    }
}
