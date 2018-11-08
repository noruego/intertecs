using SIIXPATM.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Intertecs
{
	public partial class App : Application
	{
        //Titulo de nombre del deporte 
        public static String SportTitle { get; set; }
        //Número de disciplina que mandara al ws paa visualizar
        public static int SportNumber { get; set; }
        // Variable que indica que TabbedPage esta viendo el usuario
        public static int StatusDisciplina{ get; set; }
        //Tipo de competencia (individual o de conjunto)
        public static int tipoCompetencia { get; set; }

        public App ()
		{
            //Valores default
            App.SportTitle = "Fútbol";
            App.SportNumber = 5;
            App.StatusDisciplina = 2;
            App.tipoCompetencia = 2;
            
            MainPage = new SplashPage();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
