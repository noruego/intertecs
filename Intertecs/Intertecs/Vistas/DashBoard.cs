using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Intertecs.Vistas
{
    class DashBoard : MasterDetailPage
    {
        private MenuDashBoard menuPage;
        private string sportSelected;
        private Fondo fondo;
        public DashBoard()
        {
            crearGui();
        }

        private void crearGui()
        {
            menuPage = new MenuDashBoard();
            fondo = new Fondo();
            menuPage.OpcionesMenu.ItemSelected += (sender, e) => NavigationTo(e.SelectedItem as MenuOpcion);
            ToolbarItems.Add(
                new ToolbarItem
                {
                    Icon ="icon.png",
                    Text ="Selección de disciplinas",
                    Order = ToolbarItemOrder.Primary,
                    Command = new Command (async()=>
                    {
                        sportSelected = await App.Current.MainPage.DisplayActionSheet("Disciplinas", "Cancelar", null,
                            "Ajedrez", "Atletismo", "Básquetbol", "Béisbol",
                            "Fútbol", "Natación", "Tenis",
                            "Vóleibol de Playa", "Vóleibol de Sala");
                        if(sportSelected==null)
                            sportSelected = App.SportTitle;
                        if(!sportSelected.Equals("Cancelar"))
                        {
                            App.SportTitle = sportSelected;
                            switch(App.SportTitle)
                            {
                                case "Ajedrez":
                                    App.SportNumber = 1;
                                    App.tipoCompetencia = 1; //Individual
                                    break;
                                case "Atletismo":
                                    App.SportNumber = 2;
                                    App.tipoCompetencia = 2; //Equipo
                                    break;
                                case "Básquetbol":
                                    App.SportNumber = 3;
                                    App.tipoCompetencia = 2;
                                    break;
                                case "Béisbol":
                                    App.SportNumber = 4;
                                    App.tipoCompetencia = 2; 
                                    break;
                                case "Fútbol":
                                    App.SportNumber = 5;
                                    App.tipoCompetencia = 2; 
                                    break;
                                case "Natación":
                                    App.SportNumber = 6;
                                    App.tipoCompetencia = 2;
                                    break;
                                case "Tenis":
                                    App.SportNumber = 7;
                                    App.tipoCompetencia = 1;
                                    break;
                                case "Vóleibol de Playa":
                                    App.SportNumber = 8;
                                    App.tipoCompetencia = 2;
                                    break;
                                case "Vóleibol de Sala":
                                    App.SportNumber = 9;
                                    App.tipoCompetencia = 2;
                                    break;
                            }
                        }
                    })
                }
            );
            Master = menuPage;
            Detail = new NavigationPage(fondo);

        }
    }
}
