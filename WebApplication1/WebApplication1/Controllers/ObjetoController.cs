using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ObjetoController : Controller
    {
    
        // GET: Objeto
        public ActionResult Index()
        {
            List<Objeto> listaObjeto = new List<Objeto>();
            Objeto objeto = new Objeto(2000, "TV LED", "esta en buen estado", "27/03/1016 12:30 pm", "C:/Users/cerealeseltrigo/Desktop/tv_lcd.jpg");
            Objeto objeto2 = new Objeto(3000, "Tijeras", "esta en buen estado", "27/03/1016 12:30 pm", "C:/Users/cerealeseltrigo/Desktop/tv_lcd.jpg");
            Objeto objeto3 = new Objeto(4000, "ps4", "esta en buen estado", "27/03/1016 12:30 pm", "C:/Users/cerealeseltrigo/Desktop/tv_lcd.jpg");
            Objeto objeto4 = new Objeto(5000, "xbox one", "esta en buen estado", "27/03/1016 12:30 pm", "C:/Users/cerealeseltrigo/Desktop/tv_lcd.jpg");
            Objeto objeto5 = new Objeto(6000, "consolador", "esta en buen estado", "27/03/1016 12:30 pm", "C:/Users/cerealeseltrigo/Desktop/tv_lcd.jpg");
            listaObjeto.Add(objeto);
            listaObjeto.Add(objeto2);
            listaObjeto.Add(objeto3);
            listaObjeto.Add(objeto4);
            listaObjeto.Add(objeto5);
            return View(listaObjeto);
           
        }

        public ActionResult Detalle(Objeto objeto)
        {
          
            return View(objeto);

        }

    }
}