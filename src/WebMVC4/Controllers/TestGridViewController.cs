namespace WebMVC4.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Agenda.Model;
    using WebMVC4.Models;

    public class TestGridViewController : Controller
    {
        public ActionResult Show()
        {
            var model = new GridControlModel("testGridView") { ViewModel = GetUtenti() };

            return this.PartialView(model);
        }

        private static IEnumerable<object> GetUtenti()
        {
            using (var context = new AgendaContext())
            {
                return context.Set<Utenti>();
            }
        }
    }
}
