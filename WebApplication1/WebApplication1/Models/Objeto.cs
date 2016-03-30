using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Objeto
    {
        public int Precio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string TiempoLimite { get; set; }
        public string imagen { get; set; }

        public Objeto(int Precio, string Nombre, string Descripcion, string TiempoLimite,string imagen)
        {
            this.Precio = Precio;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.TiempoLimite = TiempoLimite;
            this.imagen = imagen;
        }
        public Objeto()
        {

        }

    }
}