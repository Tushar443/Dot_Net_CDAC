using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

public class Service : IService
{
    public void RegisterForCallBack(string value)
    {
        Update obj = new Update();
        obj.callback = OperationContext.Current.GetCallbackChannel<IClientCallBack>();
        //do some work here
        System.Threading.Thread.Sleep(10000);
        obj.SendUpdateToClient(value);
        //obj.SendUpdateToClient("new value");
        

    }
}

public class Update
{
    public IClientCallBack callback = null;
    public void SendUpdateToClient(string value)
    {
        callback.GetData(value, value.ToUpper());
    }
}