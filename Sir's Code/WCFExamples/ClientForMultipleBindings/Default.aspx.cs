using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.Service1Client o1 = new ServiceReference1.Service1Client(); ;
        Response.Write(o1.Method1());

        ServiceReference1.Service2Client o2 = new ServiceReference1.Service2Client("Service2Basic");
        Response.Write(o2.Method4());

        
        ServiceReference1.ServiceAllClient oall = new ServiceReference1.ServiceAllClient();
        Response.Write(oall.Method4());
        
    }
}
