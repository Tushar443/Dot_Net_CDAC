using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;

// NOTE: If you change the class name "Service" here, you must also update the reference to "Service" in Web.config and in the associated .svc file.
public class BankService : IBankService
{
    #region IBankService Members

    [OperationBehavior ( TransactionScopeRequired=true , TransactionAutoComplete=true)]
    public void Transfer(int AccountFrom, int AccountTo, decimal Amount)
    {
        try
        {
            Withdraw(AccountFrom, Amount);
            Deposit(AccountTo, Amount);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [OperationBehavior( TransactionScopeRequired=false)]
    public decimal GetBalance(int Account)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True");
        cn.Open();

        SqlCommand cmd = new SqlCommand("select Amount from Bank where Account = " + Account.ToString(), cn);
        decimal retval = (decimal)cmd.ExecuteScalar();
        cn.Close();
        return retval;
    }


    #endregion
    private void Withdraw(int Account, decimal Amount)
    {
        if(!IsValidAccount(Account))
            throw new Exception("Insufficient Balance");
        if (GetBalance(Account) < Amount)
            throw new Exception("Insufficient Balance");
        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True");
        cn.Open();
        
        SqlCommand cmd = new SqlCommand("Update Bank set Amount = Amount - " + Amount.ToString() + " where Account = " + Account.ToString(), cn);
        cmd.ExecuteNonQuery();
        cn.Close();
    }
    private bool IsValidAccount(int Account)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True");
        cn.Open();

        SqlCommand cmd = new SqlCommand("select count(*) from Bank where Account = " + Account.ToString(), cn);
        bool retval= (((int) cmd.ExecuteScalar()) == 1);
        cn.Close();
        return retval;
    }

    private void Deposit(int Account, decimal Amount)
    {

        if (!IsValidAccount(Account))
            throw new Exception("Insufficient Balance");

        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=JKDec20;Integrated Security=True");
        cn.Open();

        SqlCommand cmd = new SqlCommand("Update Bank set Amount = Amount + " + Amount.ToString() + " where Account = " + Account.ToString(), cn);
        cmd.ExecuteNonQuery();
        cn.Close();

    }

}
/*
 CREATE TABLE [dbo].Bank
(
	[Account] INT NOT NULL PRIMARY KEY, 
    [Amount] DECIMAL(18, 2) NOT NULL
)

 */