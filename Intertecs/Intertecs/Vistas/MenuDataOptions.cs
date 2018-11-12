using Intertecs.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intertecs.Vistas
{
    class MenuDataOptions : List<MenuOpcion>
    {
        public MenuDataOptions()
        {
            this.Add(new MenuOpcion()
                {
                    Title= "Inicio",
                    IconSource = "icon.png"
                });
            this.Add(new MenuOpcion()
            {
                Title = "Grupos",
                IconSource = "icon.png"
            });
            this.Add(new MenuOpcion()
            {
                Title = "Instituciones",
                IconSource = "icon.png",
                TargetType = typeof(InstitucionesPage),
            });

        }
    }
}
