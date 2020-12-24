using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: If you change the class name "Service" here, you must also update the reference to "Service" in Web.config and in the associated .svc file.
public class Service : IServiceAll
{

    #region IService1 Members

    public string Method1()
    {
        return "M1";
    }

    public string Method2()
    {
        return "M2";
    }

    #endregion

    #region IService2 Members

    public string Method3()
    {
        return "M3";
    }

    public string Method4()
    {
        return "M4";
    }

    #endregion
}
