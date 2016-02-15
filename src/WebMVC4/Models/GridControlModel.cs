namespace WebMVC4.Models
{
    using System.Linq;
    using Agenda.Model;

    public class GridControlModel
    {
        public GridControlModel(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public IQueryable<Utenti> ViewModel { get; set; }
    }
}
