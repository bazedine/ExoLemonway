using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using Newtonsoft.Json;

namespace WebServiceExo
{
    /// <summary>
    /// Description résumée de WSFibonacci
    /// </summary>
    [WebService(Namespace = "http://localhost/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService 
    



    public class WebServiceFX : System.Web.Services.WebService
    {
       /// <summary>
       /// Method Fibonacci
       /// </summary>
       /// <param name="n"></param>
       /// <returns></returns>
        [WebMethod]
        public int Fibonacci(int n)
        {
           
            int w;
            if (n <= 0) return -1;
            if (n > 100) return -1;
            if (n == 1) return 1;

            int u = 0;
            int v = 1;
            for (int i = 2; i <= n; i++)
            {
                w = u + v;
                u = v;
                v = w;
            };

            //string va = Convert.ToString(v);
            //string VaJsonString = XmlToJson(va);
            //return JsonConvert.SerializeObject(v, Newtonsoft.Json.Formatting.Indented);
            return v;


        }

        /// <summary>
        /// Method XML TO JSON
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        [WebMethod]
        public string XmlToJson(string xml)
        {


            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                string json = Newtonsoft.Json.JsonConvert.SerializeXmlNode(doc);
                return json;
            }
            catch
            {
                return "bad xml format";
            }

        }


    }
}
