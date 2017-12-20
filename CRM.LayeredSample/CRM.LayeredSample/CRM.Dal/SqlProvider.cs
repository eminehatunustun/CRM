using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Dal
{
    using Common;
    using Entity;
    using System.Data.SqlClient;
    using System.Data;
    public class SqlProvider
    {
        #region FieldAndConstructors
        private SqlConnection cnn;
        private SqlCommand cmd;
        public SqlProvider(string commandText, bool isProcedure)
        {
            cnn = new SqlConnection(Tools.ConnectionString);
            cmd = new SqlCommand(commandText, cnn);
            cmd.CommandType = isProcedure ? System.Data.CommandType.StoredProcedure : System.Data.CommandType.Text;
        }
        #endregion
        public void AddParameter(string parameterName, object value)
        {
            cmd.Parameters.AddWithValue(parameterName, value);
        }
        #region ConnectionMethods
        public void OpenConnection()
        {
            if (cnn.State==ConnectionState.Closed)
            {
                cnn.Open();
            }
        }
        public void CloseConnection()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        #region ExecuteMethods
        public SqlDataReader ExecuteReader()
        {
            OpenConnection();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public int ExecuteNonQuery()
        {
            int result = -1;
            try
            {
                OpenConnection();
                result = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                result = -1;
            }
            catch (Exception)
            {

                result=-1;
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }
        public object ExecuteScalar()
        {
            object result = null;
            try
            {
                OpenConnection();
                result = cmd.ExecuteScalar();
            }
            catch (SqlException)
            {
                result = null;
            }
            catch (Exception)
            {

                result = null;
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }
        #endregion
        #endregion
    }
}
