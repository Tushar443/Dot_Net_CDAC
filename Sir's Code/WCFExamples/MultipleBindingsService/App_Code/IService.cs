using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: If you change the interface name "IService" here, you must also update the reference to "IService" in Web.config.
[ServiceContract]
public interface IService1
{
	[OperationContract]
	string Method1();
    [OperationContract]
    string Method2();
}

[ServiceContract]
public interface IService2
{
    [OperationContract]
    string Method3();
    [OperationContract]
    string Method4();
}

[ServiceContract]
public interface IServiceAll : IService1, IService2
{}
