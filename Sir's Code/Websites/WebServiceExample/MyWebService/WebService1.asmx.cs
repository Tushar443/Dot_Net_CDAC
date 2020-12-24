using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyWebService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public int Add(int a, int b)
        {
            return a + b;
        }
        [WebMethod]
        public string LomgRunningMethod()
        {
            System.Threading.Thread.Sleep(10000);
            return "Hello World";
        }
        //To Do
        //MyCustomClass GetMyCustomClassObject() 
        //DataSet GetDataSet()    - client is a wpf app
        //void UpdateDataSet(DataSet ds) - client is a wpf app

    }
}
//To Do : try wsdl.exe at command prompt
//wsdl <filename.wsdl>