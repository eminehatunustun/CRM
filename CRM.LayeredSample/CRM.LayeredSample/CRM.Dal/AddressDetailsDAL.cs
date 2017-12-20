using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Dal
{
    using CRM.Common;
    using CRM.Dal;
    using CRM.Entity;
    using System.Data.SqlClient;
    public class AddressDetailsDAL
    {

        public Result<List<AddressDetails>> ListAllAddress()
        {
            Result<List<AddressDetails>> rLa = new Result<List<AddressDetails>>();
            SqlProvider provider = new SqlProvider("Select * from AddressDetails", false);
            List<AddressDetails> allAddressDetails = new List<AddressDetails>();
            SqlDataReader reader = provider.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    AddressDetails d = new AddressDetails();
                    d.Id = int.Parse(reader["Id"].ToString());
                    d.Address = reader["Address"].ToString();
                    d.City = reader["City"].ToString();
                    d.Country = reader["Country"].ToString();
                    d.CreateDate = DateTime.Parse(reader["CreateDate"].ToString());
                    d.CustomerID = int.Parse(reader["CustomerID"].ToString());
                    allAddressDetails.Add(d);
                }
            }
            reader.Close();
            rLa.TransactionResult = allAddressDetails;
            rLa.IsSucceeded = rLa.TransactionResult != null;
            return rLa;
        }
        public Result<List<AddressDetails>> ListIDAddress(int customerID)
        {
            Result<List<AddressDetails>> rLa = new Result<List<AddressDetails>>();
            SqlProvider provider = new SqlProvider("Select * from AddressDetails where CustomerID=@CustomerID", false);
            provider.AddParameter("@CustomerID", customerID);
            List<AddressDetails> ListIDAddress = new List<AddressDetails>();
            SqlDataReader reader = provider.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    AddressDetails d = new AddressDetails();
                    d.Id = int.Parse(reader["Id"].ToString());
                    d.Address = reader["Address"].ToString();
                    d.City = reader["City"].ToString();
                    d.Country = reader["Country"].ToString();
                    d.CreateDate = DateTime.Parse(reader["CreateDate"].ToString());
                    d.CustomerID = int.Parse(reader["CustomerID"].ToString());
                    ListIDAddress.Add(d);
                }
            }
            reader.Close();
            rLa.TransactionResult = ListIDAddress;
            rLa.IsSucceeded = rLa.TransactionResult != null;
            return rLa;
        }
        public Result Delete(object instanceId)
        {
            Result result = new Result();
            int returnValue = 0;
            SqlProvider sqlProvider = new SqlProvider("Delete from AddressDetails where Id=@Id", false);
            sqlProvider.AddParameter("@Id", instanceId);
            returnValue = sqlProvider.ExecuteNonQuery();
            result.IsSucceeded = returnValue != -1;
            return result;
        }
        public Result DeleteCustomerID(object instanceId)
        {
            Result result = new Result();
            int returnValue = 0;
            SqlProvider sqlProvider = new SqlProvider("Delete from AddressDetails where CustomerID=@Id", false);
            sqlProvider.AddParameter("@Id", instanceId);
            returnValue = sqlProvider.ExecuteNonQuery();
            result.IsSucceeded = returnValue != -1;
            return result;
        }
        public Result Save(AddressDetails instance)
        {

            Result result = new Result();
            int returnValue = 0;
            SqlProvider sqlProvider = new SqlProvider("Insert Into AddressDetails (Address, City,  Country, CustomerID) values (@Address, @City, @Country, @CustomerID)", false);
            sqlProvider.AddParameter("@Address", instance.Address);
            sqlProvider.AddParameter("@Country", instance.Country);
            sqlProvider.AddParameter("@City", instance.City);
            sqlProvider.AddParameter("@CustomerID", instance.CustomerID);
            returnValue = sqlProvider.ExecuteNonQuery();
            result.IsSucceeded = returnValue != -1;
            return result;
        }
        public Result Update(AddressDetails newInstance)
        {
            Result result = new Result();
            int returnValue = 0;
            SqlProvider sqlProvider = new SqlProvider("Update AddressDetails set Address = @Address,City = @City, Country = @Country  where Id=@Id", false);
            sqlProvider.AddParameter("@Id", newInstance.Id);
            sqlProvider.AddParameter("@Address", newInstance.Address);
            sqlProvider.AddParameter("@City", newInstance.City);
            sqlProvider.AddParameter("@Country", newInstance.Country);
            returnValue = sqlProvider.ExecuteNonQuery();
            result.IsSucceeded = returnValue != -1;
            return result;
        }

    }
}
