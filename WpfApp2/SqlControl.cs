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
    public class SqlControl
    {
        String CS = " ";
        SQLiteConnection Conn = new SQLiteConnection("CS"); // ??
        SQLiteCommand Cmd = new SQLiteCommand();

        // DB DATA
        public SQLiteDataAdapter DA = new SQLiteDataAdapter();
        public DataTable DT = new DataTable();

        // QUERY PARAMETERS
        public List<SQLiteParameter> Params = new List<SQLiteParameter>();

        // QUERY STATISTICS
        public int RecordCount;
        public String Exception;

        //****** Test update 7/082017 12:10AM ******//

        //public Sub New()
        //End Sub

        //' ALLOW CONNECTION STRING OVERRIDE
        //Public Sub New(ConnectionString As String)
        //    
        //End Sub
    }
}
