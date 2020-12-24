using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: If you change the class name "Service" here, you must also update the reference to "Service" in Web.config and in the associated .svc file.
public class HelloService : IService
{

    #region IService Members

    public string Hello()
    {
        return "Hello World";
    }

    #endregion
}
