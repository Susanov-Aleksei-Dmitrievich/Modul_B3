using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchetOborudovania.Classes
{
    internal class ClassAvtorizacia
    {
        // string con = @"Data Source = DESKTOP-LJ3RRK0\MSSQLSERVER2; DataBase = UchetOborudovania; User ID = user01; Password = 83328";
        string con = @"Data Source = DESKTOP-LJ3RRK0\MSSQLSERVER2; Initial Catalog = UchetOborudovania; Integrated Security = true";
       public DataSet ds = new DataSet();

        public DataSet getUser(string login, string parol)
        {
            // Получение данных о сотруднике с указанным логином и паролем
            string zapros = string.Format("SELECT * FROM Sotrudniki WHERE Login ='{0}' AND Password ='{1}'", login, parol);

            // Создание подключения
            using (SqlConnection  conn = new SqlConnection(con))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(zapros, con);
                    adapter.Fill(ds);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally 
                { 
                if(conn.State == ConnectionState.Open)
                    {
                        conn.Dispose();
                    }
                }
            }
            return ds;
        }

    }
}
