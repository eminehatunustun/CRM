using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM.Common;
using CRM.Entity;
using System.Data.SqlClient;

namespace CRM.Dal
{
   public class ContactDetailsDAL
    {
       public Result<List<ContactDetails>> ListOfContact()
        {
            Result<List<ContactDetails>> rLc = new Result<List<ContactDetails>>();
            List<ContactDetails> allContact = new List<ContactDetails>();
            SqlProvider provider = new SqlProvider("Select * from ContactDetails", false);
            SqlDataReader reader = provider.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ContactDetails cd = new ContactDetails();
                    cd.Id = Convert.ToInt32(reader["Id"].ToString());
                    cd.Mail = reader["Mail"].ToString();
                    cd.Phone= reader["Phone"].ToString();
                    cd.CreateDate = DateTime.Parse(reader["CreateDate"].ToString());
                    cd.CustomerID = int.Parse(reader["CustomerID"].ToString());
                    allContact.Add(cd);
                }
            }
            reader.Close();
            rLc.TransactionResult = allContact;
            rLc.IsSucceeded = rLc.TransactionResult != null;
            return rLc;
        }
       public Result<List<ContactDetails>> ListIDContact(int customerID)
        {
            Result<List<ContactDetails>> rLc = new Result<List<ContactDetails>>();
            SqlProvider provider = new SqlProvider("Select * from ContactDetails where CustomerID=@CustomerID", false);
            provider.AddParameter("@CustomerID", customerID);
            List<ContactDetails> ListIDContact = new List<ContactDetails>();
            SqlDataReader reader = provider.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ContactDetails cd = new ContactDetails();
                    cd.Id = Convert.ToInt32(reader["Id"].ToString());
                    cd.Mail = reader["Mail"].ToString();
                    cd.Phone = reader["Phone"].ToString();
                    cd.CreateDate = DateTime.Parse(reader["CreateDate"].ToString());
                    cd.CustomerID = int.Parse(reader["CustomerID"].ToString());
                    ListIDContact.Add(cd);
                }
            }
            reader.Close();
            rLc.TransactionResult = ListIDContact;
            rLc.IsSucceeded = rLc.TransactionResult != null;
            return rLc;
        }
        public Result DeleteCustomerID(object instanceId)
        {
            Result result = new Result();
            int returnValue = 0;
            SqlProvider sqlProvider = new SqlProvider("Delete from ContactDetails where CustomerID=@Id", false);
            sqlProvider.AddParameter("@Id", instanceId);
            returnValue = sqlProvider.ExecuteNonQuery();
            result.IsSucceeded = returnValue != -1;
            return result;
        }
        public Result Save(ContactDetails instance)
        {

            Result result = new Result();
            int returnValue = 0;
            SqlProvider sqlProvider = new SqlProvider("Insert Into ContactDetails (Phone, Mail, CustomerID) values (@Phone, @Mail, @CustomerID)", false);
            sqlProvider.AddParameter("@Phone", instance.Phone);
            sqlProvider.AddParameter("@Mail", instance.Mail);
            sqlProvider.AddParameter("@CustomerID", instance.CustomerID);
            returnValue = sqlProvider.ExecuteNonQuery();
            result.IsSucceeded = returnValue != -1;
            return result;
        }
        public Result Update(ContactDetails newInstance)
        {
            Result result = new Result();
            int returnValue = 0;
            SqlProvider sqlProvider = new SqlProvider("Update ContactDetails set Mail = @Mail,Phone = @Phone where Id=@Id", false);
            sqlProvider.AddParameter("@Id", newInstance.Id);
            sqlProvider.AddParameter("@Mail", newInstance.Mail);
            sqlProvider.AddParameter("@Phone", newInstance.Phone);
            returnValue = sqlProvider.ExecuteNonQuery();
            result.IsSucceeded = returnValue != -1;
            return result;
        }

    }
}
