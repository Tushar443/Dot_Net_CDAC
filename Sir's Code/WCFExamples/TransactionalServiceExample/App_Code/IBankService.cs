using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: If you change the interface name "IService" here, you must also update the reference to "IService" in Web.config.
[ServiceContract]
public interface IBankService
{

[OperationContract]
	void Transfer(int AccountFrom, int AccountTo, decimal Amount);

	[OperationContract]
	decimal GetBalance(int Account);

	// TODO: Add your service operations here	
}

