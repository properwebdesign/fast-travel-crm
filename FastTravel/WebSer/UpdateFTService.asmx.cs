using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
//using System.Web.Configuration;
using System.Web.Services;

namespace WebSer
{
    /// <summary>
    /// Summary description for UpdateFTService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class UpdateFTService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        
        [WebMethod]
        public List<Hotel> GetHotelsforUpdate()
        {
            HotelRepository hr = new HotelRepository();
            return hr.GetHotels(); 
        }

    }
}