using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SQLite;
using System.Windows;

namespace WpfApp2
{
    class SqlControl
    {
        public DataTable DT = new DataTable();
        String CS = "Data Source=C:\\Users\\klboy\\Google Drive\\Route9094\\Projects\\WpfApp2\\WpfApp2\\AppData\\Route9094.SQLite;";
        
      
            try
            {
                using (SQLiteConnection Conn = new SQLiteConnection(CS))
                
                    String query = "Select * from Route";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, Conn);
                }

                da.Fill(DT);

                da.Update(DT);
                Conn.Close();
            }
            catch (Exception)

            { 
                MessageBox.Show("An Error Occured");
            throw;
            }
        }

    }
}
