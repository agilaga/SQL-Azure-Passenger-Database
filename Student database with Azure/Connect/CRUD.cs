using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_database_with_Azure
{
    public class CRUD
    {
        string sql = String.Empty;
        SqlConnection conn = new SqlConnection(Dalc.GetConnect);
        SqlCommand command;
        int result;

        public int Insert(string Name, string Surname, string Patrynomic, string Birthdate, string Address, string Email, string Gender, string Status)
        {
            sql = "insert into Passe values('" + Name + "','" + Surname + "','" + Patrynomic + "','" + Birthdate + "','" + Address + "','" + Email + "','" + Gender + "','" + Status + "'";
            command = new SqlCommand(sql, conn);
            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                int rslt = command.ExecuteNonQuery();
                if (rslt > 0)
                {
                    result = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return 1;
        }

        public int Update(int id, string Name, string Surname, string Patrynomic, string Birthdate, string Address, string Email, string Gender, string Status)
        {
            if (id <= 0)
            {
                return 0;
            }
            sql = "Update Passe set Name = '" + Name + "', Surname='" + Surname + "', Patrynomic='" + Patrynomic + "', Birthdate='" + Birthdate + "', Address='" + Address + "', Email='" + Email + "', Gender='" + Gender + "', Status='" + Status + "'";
            command = new SqlCommand(sql, conn);
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                int res = command.ExecuteNonQuery();
                if (res > 0)
                {
                    result = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return 1;

        }

        public int Delete(int id)
        {
            sql = "Delete from Passe where ID=" + id;
            command = new SqlCommand(sql, conn);
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }
                int res = command.ExecuteNonQuery();
                if (res > 0)
                {
                    result = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return 1;
        }

        public List<Data> Select()
        {
            sql = "Selecet * From Passe";
            command = new SqlCommand(sql, conn);
            List<Data> lst = new List<Data>();
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                }

                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    lst.Add(new Data((int)dr[0], dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return lst;
        }


    }

}
