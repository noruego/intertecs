using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Intertecs.Vistas
{
    class MenuDashBoard : ContentPage
    {
        private Frame menuHeader;
        public ListView OpcionesMenu { get; set; }
        private StackLayout stkLayout;
        private StackLayout stkFooter;
        public MenuDashBoard() { crearGUI(); }

        public void crearGUI()
        {
            Title = "Menu";
            Icon = "Icon.png";
            menuHeader = new Header();
            OpcionesMenu = new MenuListView();

            stkFooter = new StackLayout
            {
                Padding = new Thickness(0,0,0,5),
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                BackgroundColor = Color.AliceBlue,
                Spacing=0,
                Children=
                    {
                        new Image
                        {
                            Source ="icon.png",
                            HeightRequest =30
                        },
                        new Label
                        {   
                            VerticalTextAlignment = TextAlignment.Center,
                            Text = "TECNM | Instituto Tecnologico de Celaya",
                            FontSize = 12,
                            FontFamily = "Roboto"
                        }
                    }
            };
            stkLayout = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Spacing = 0,
                Children =
                {
                    menuHeader,
                    new Label
                    {
                        HeightRequest = 10,
                    },
                    OpcionesMenu,
                    stkFooter
                }
            };
            Content = stkLayout;
        }
    }
}
