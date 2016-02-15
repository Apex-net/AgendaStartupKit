namespace WebMVC4.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Agenda.Model;
    using WebMVC4.Models;

    public class TestGridViewController : Controller
    {
        private AgendaContext context = new AgendaContext();

        public ActionResult Show()
        {
            var model = new GridControlModel("testGridView") { ViewModel = this.GetUtenti() };

            return this.PartialView(model);
        }

        private IQueryable<Utenti> GetUtenti()
        {
            return this.context.Set<Utenti>().Where(u => u.Nome != null);
        }
    }
}