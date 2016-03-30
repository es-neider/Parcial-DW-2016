using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PujaController: Controller
    {
        int valorAntiguo = 150000;
        public Puja incremento () {
           Puja puja = new Puja(150000, 623000, 50 );

            return puja;
        }

    }
}