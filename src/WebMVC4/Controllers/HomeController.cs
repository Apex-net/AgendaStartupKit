namespace WebMVC4.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Agenda.Model;
    using PagedList;

    public class HomeController : Controller
    {
        private const int PageSize = 15;

        // GET: /Home/
        public ActionResult Index(int page = 1)
        {
            using (var context = new AgendaContext())
            {
                var utenti = context.AGE_UTENTI.Where(u => u.Nome.Contains("FABIO"))
                                    .OrderBy(u => u.Cognome)
                                    .ToPagedList(page, PageSize);

                return this.View(utenti);
            }
        }
    }
}
