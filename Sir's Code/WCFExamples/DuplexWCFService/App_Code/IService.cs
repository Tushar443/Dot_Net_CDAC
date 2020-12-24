using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

[ServiceContract(CallbackContract= typeof(IClientCallBack) )]
public interface IService
{
	[OperationContract(IsOneWay=true)]
	void RegisterForCallBack(string value);
}

public interface IClientCallBack
{
    [OperationContract(IsOneWay=true)]
    void GetData(string value, string value2);
}

