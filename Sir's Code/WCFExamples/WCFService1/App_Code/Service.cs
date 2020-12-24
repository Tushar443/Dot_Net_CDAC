using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;

// NOTE: If you change the class name "Service" here, you must also update the reference to "Service" in Web.config and in the associated .svc file.
public class Service : IService
{
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}

    public DataSet GetDataSet()
    {
        SqlDataAdapter da = new SqlDataAdapter("select * from employees", "Data source=.;Initial Catalog=Vikram;Integrated Security=true");
        DataSet ds = new DataSet();
        da.Fill(ds, "Employees");
        return ds;
    }
}
