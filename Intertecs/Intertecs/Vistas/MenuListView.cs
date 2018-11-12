using Intertecs.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Intertecs.Vistas
{
    //consultar calificaciones como alumno, asignar calificaciones maestros
    class MenuListView : ListView
    {
        public MenuListView()
        {
            List<MenuOpcion> datosOpcion = new MenuDataOptions();
            ItemsSource = datosOpcion;
            VerticalOptions = LayoutOptions.FillAndExpand;
            ItemTemplate = new DataTemplate(typeof(OptionsCell));
        }
    }
    public class OptionsCell : ViewCell
    {
        public OptionsCell()
        {
            var imgIcon = new Image()
            {
                Opacity = 0.75,
                HeightRequest = 30,
                WidthRequest = 30,
            };
            imgIcon.SetBinding(Image.SourceProperty, "IconSource");

            var lblOpcion = new Label()
            {
                FontFamily ="Roboto",
                Opacity=0.75,
                FontSize=14,
                TextColor =Color.Black,
            };
            lblOpcion.SetBinding(Label.TextProperty,"Title");
            //Stack del master, menuDataOptions
            var MenuCellView = new StackLayout
            {
                Spacing =0,
                Padding = new Thickness(15,0,0,0),
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    imgIcon,
                    new StackLayout
                    {
                        VerticalOptions = LayoutOptions.Center,
                        Children = { lblOpcion}
                    }
                }
            };
            View = MenuCellView;
        }
    }
}
