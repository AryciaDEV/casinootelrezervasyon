using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace CasinoAppV1
{

    /*
     * class for insert/update/delete/get all client
     * 
     * */
    class Client
    {
        SqlConnection conn = new SqlConnection("Server=localhost; Database=appdatabase; Integrated Security=True");

        //insert new client
        public bool InsertClient(String fname, String lname, String phone, String country)
        {
            SqlCommand command = new SqlCommand();
            String queryInsert = "INSERT INTO clients(first_name,last_name,phone,country) VALUES (@fname, @lname, @phone, @country)";
            command.CommandText = queryInsert;

            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@country", SqlDbType.VarChar).Value = country;

            conn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        //get all clients
        public DataTable GetAllClients()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM clients");
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //edit client data
        public bool EditClient(int id, String fname, String lname, String phone, String country)
        {
            SqlCommand command = new SqlCommand();
            String queryUpdate = "UPDATE clients SET first_name=@fname, last_name=@lname, phone=@phone, country=@country WHERE id=@cid";
            command.CommandText = queryUpdate;

            command.Parameters.Add("@cid", SqlDbType.Int).Value = id;
            command.Parameters.Add("@fname", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phone", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@country", SqlDbType.VarChar).Value = country;

            conn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }

        //remove client
        public bool RemoveClient(int id)
        {
            SqlCommand command = new SqlCommand();
            String queryDelete = "DELETE FROM clients WHERE id=@cid";
            command.CommandText = queryDelete;

            command.Parameters.Add("@cid", SqlDbType.Int).Value = id;

            conn.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }
    }
}
