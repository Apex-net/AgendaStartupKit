using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using WebMVC4.Model;

namespace WebMVC4.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        public ActionResult Index(int? page)
        {
            var ctx = new Context();

            const int pageSize = 15;
            int pageNumber = (page ?? 1);
            var utenti = ctx.AGE_UTENTI.Where(u => u.Nome.Contains("FABIO")).OrderBy(u => u.Cognome).ToPagedList(pageNumber, pageSize);

            return this.View(utenti);
        }
    }
}