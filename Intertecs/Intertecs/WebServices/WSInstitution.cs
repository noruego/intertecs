using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Intertecs.Modelos;
using Newtonsoft.Json.Linq;

namespace Intertecs.WebServices
{
    class WSInstitution
    {
        HttpClient http;
        public async Task<List<Institucion>> listaInstituciones()
        {
            List<Institucion> listaInst = null;
            try
            {
                http = new HttpClient();
                http.BaseAddress = new Uri("http://ws.itcelaya.edu.mx:8080");

                var authData = string.Format("{0}:{1}", "intertecs", "1nt3rt3c5");                        //auth
                var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData)); //auth
                http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);

                var result = await http.GetAsync("/intertecs/apirest/institucion/listado");//+Settings.settings.token);
                var cadena = result.Content.ReadAsStringAsync().Result;
                listaInst = new List<Institucion>();

                var objJson = JObject.Parse(cadena);

                var arrJson = objJson.SelectToken("institucion").ToList();

                Institucion institution;
                foreach (var institucion in arrJson)
                {
                    institution = new Institucion ();
                    institution.institution = institucion["institucion"].ToString();
                    institution.short_name = institucion["nombre_corto"].ToString();
                    institution.logo = institucion["logotipo"].ToString();
                    listaInst.Add(institution);
                }
            }
            catch (Exception e) {

                e.ToString();
            }
            return listaInst;
        }
    }
}
