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
    public class CustomerDAL
    {
        public Result<List<Customers>> ListOfCustomers()
        {
            Result<List<Customers>> rLc = new Result<List<Customers>>();
            SqlProvider sqlProvider = new SqlProvider("Select * from Customers", false);
            SqlDataReader reader = sqlProvider.ExecuteReader();         
            List<Customers> allCustomers = new List<Customers>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Customers c = new Customers();
                    c.Id = int.Parse(reader["Id"].ToString());
                    c.Name = reader["Name"].ToString();
                    c.Surname = reader["Surname"].ToString();

                    //  c.Phone = reader["Phone"].ToString();
                    //  c.Mail = reader["Mail"].ToString();

                    c.Gender = Convert.ToBoolean(reader["Gender"].ToString());
                    c.PhotoPath = reader["PhotoPath"].ToString();
                    c.CreateDate = DateTime.Parse(reader["CreateDate"].ToString());
                    allCustomers.Add(c);
                }
            }
            reader.Close();
            rLc.TransactionResult = allCustomers;
            rLc.IsSucceeded = rLc.TransactionResult != null;
            return rLc;

        }
        public Result<List<Customers>> ListIDCustomers(int ID)
        {
            Result<List<Customers>> rLc = new Result<List<Customers>>();
            SqlProvider sqlProvider = new SqlProvider("Select * from Customers where Id=@CustomerID ", false);
            sqlProvider.AddParameter("@CustomerID", ID);
            SqlDataReader reader = sqlProvider.ExecuteReader();
            List<Customers> allCustomers = new List<Customers>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Customers c = new Customers();
                    c.Id = int.Parse(reader["Id"].ToString());
                    c.Name = reader["Name"].ToString();
                    c.Surname = reader["Surname"].ToString();
                    c.Gender = Convert.ToBoolean(reader["Gender"].ToString());
                    c.PhotoPath = reader["PhotoPath"].ToString();
                    c.CreateDate = DateTime.Parse(reader["CreateDate"].ToString());
                    allCustomers.Add(c);
                }
            }
            reader.Close();
            rLc.TransactionResult = allCustomers;
            rLc.IsSucceeded = rLc.TransactionResult != null;
            return rLc;

        }
        public Result Update (Customers newInstance)
        {
            //   Address = @Address,City = @City, Country = @Country
            // Phone=@Phone, Mail=@Mail, 
            Result result = new Result();
            int returnValue = 0;
            SqlProvider sqlProvider = new SqlProvider("Update Customers set Name=@Name, Surname=@Surname  where Id=@Id", false);
            sqlProvider.AddParameter("@Id", newInstance.Id);
            sqlProvider.AddParameter("@Name", newInstance.Name);
            sqlProvider.AddParameter("@Surname", newInstance.Surname);
            returnValue = sqlProvider.ExecuteNonQuery();
            result.IsSucceeded = returnValue != -1;
            return result;
        }
        public Result Save(Customers instance)
        {
            Result result = new Result();
            int returnValue = 0;
            SqlProvider sqlProvider = new SqlProvider("Insert Into Customers (Name, Surname,  Gender) values (@Name, @Surname, @Gender)", false);
            sqlProvider.AddParameter("@Name", instance.Name);
            sqlProvider.AddParameter("@Surname", instance.Surname);
            sqlProvider.AddParameter("@Gender", instance.Gender);
            returnValue = sqlProvider.ExecuteNonQuery();
            result.IsSucceeded = returnValue != -1;
            return result;
        }
        public Result Delete(object instanceId)
        {
            Result result = new Result();
            int returnValue = 0;
            SqlProvider sqlProvider = new SqlProvider("Delete from Customers where Id=@Id", false);
            sqlProvider.AddParameter("@Id", instanceId);
            returnValue = sqlProvider.ExecuteNonQuery();
            result.IsSucceeded = returnValue != -1;
            return result;
        }

    }
}
