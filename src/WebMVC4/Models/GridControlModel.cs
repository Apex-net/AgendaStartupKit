namespace WebMVC4.Models
{
    using System.Collections.Generic;

    public class GridControlModel
    {
        public GridControlModel(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public IEnumerable<object> ViewModel { get; set; }
    }
}
