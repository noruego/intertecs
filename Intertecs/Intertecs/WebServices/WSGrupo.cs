using Intertecs.Modelos;
using Intertecs.WebServices;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Intertecs.WebServices
{
    class WSGrupo
    {
        HttpClient http;
        public async Task<List<Grupos>> listaGrupos()
        {
            List<Grupos> listaGrupos = null;
            try
            {
                http = new HttpClient();
                http.BaseAddress = new Uri("http://ws.itcelaya.edu.mx:8080");

                var authData = string.Format("{0}:{1}", "intertecs", "1nt3rt3c5");                        //auth
                var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData)); //auth
                http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);

                var result = await http.GetAsync("/intertecs/apirest/grupos/listado/5");//+Settings.settings.token);
                var cadena = result.Content.ReadAsStringAsync().Result;
                listaGrupos = new List<Grupos>();

                var objJson = JObject.Parse(cadena);

                var arrJson = objJson.SelectToken("grupos").ToList();

                Institucion institution;
                foreach (var grup in arrJson)
                {
                    Grupos grupo = new Grupos();
                    grupo.grupo = grup["grupo"].ToString();
                    grupo.rama = grup["id_rama"].ToString();
                    grupo.intitucion = grup["institucion"].ToString();
                    grupo.logotipo = grup["logotipo"].ToString();
                    grupo.nombre_corto = grup["nombre_corto"].ToString();
                    grupo.posicion = grup["posicion_grupo"].ToString();
                    grupo.rama = grup["rama"].ToString();
                    listaGrupos.Add(grupo);
                }
            }
            catch (Exception e)
            {

                e.ToString();
            }
            return listaGrupos;
        }
    }
}
