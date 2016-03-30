using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Puja
    {
        private int valorInic;
        private int valorCompra;
        private int Incremento;

        public Puja(int valorInic, int valorCompra, int incremento)
        {
            this.valorInic = valorInic;
            this.valorCompra = valorCompra;
            Incremento = incremento;
        }

        public int ValorInic
        {
            get
            {
                return valorInic;
            }

            set
            {
                valorInic = value;
            }
        }

        public int ValorCompra
        {
            get
            {
                return valorCompra;
            }

            set
            {
                valorCompra = value;
            }
        }

        public int Incremento1
        {
            get
            {
                return Incremento;
            }

            set
            {
                Incremento = value;
            }
        }
    }
}