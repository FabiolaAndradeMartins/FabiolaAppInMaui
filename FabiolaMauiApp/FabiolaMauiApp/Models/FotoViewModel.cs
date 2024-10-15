using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabiolaMauiApp.Models
{
    public class FotoViewModel
    {

        public ObservableCollection<Foto> fotos { get; private set; }

        public ObservableCollection<Foto> Fotos
        {
            get { return fotos; }
            set { fotos = value; }
        }
  
        public FotoViewModel()
        {
            Fotos = new ObservableCollection<Foto>()
            {
                new Foto() { Nome = "Andrômeda", ImageUrl = "galaxia1.jpg" },
                new Foto() { Nome = "Via Láctea", ImageUrl = "galaxia2.jpg" },
                new Foto() { Nome = "Universo", ImageUrl = "galaxia3.jpg" },
                new Foto() { Nome = "Galáxia", ImageUrl = "galaxia4.jpg" },
                new Foto() { Nome = "Sombrero", ImageUrl = "galaxia5.jpg" },
				new Foto() { Nome = "Andrômeda", ImageUrl = "galaxia1.jpg" },
				new Foto() { Nome = "Via Láctea", ImageUrl = "galaxia2.jpg" },
				new Foto() { Nome = "Universo", ImageUrl = "galaxia3.jpg" },
				new Foto() { Nome = "Galáxia", ImageUrl = "galaxia4.jpg" },
				new Foto() { Nome = "Sombrero", ImageUrl = "galaxia5.jpg" }
			};
		}
	}
}
