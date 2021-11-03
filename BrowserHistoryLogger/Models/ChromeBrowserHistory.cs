using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrowserHistoryLogger.Models
{
    class ChromeBrowserHistory
    {
        private string Path { get; set; }
        private string Query { get; set; }

        public ChromeBrowserHistory()
        {
            Path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
                   @"\Google\Chrome\User Data\Default\History";
            Query =
                @"SELECT url AS URL, title AS TITLE, time(last_visit_time / 1000000 + (strftime('%s','1601-01-01')), 'unixepoch', 'localtime') AS Time, date(last_visit_time / 1000000 + (strftime('%s','1601-01-01')), 'unixepoch') AS Date
                FROM urls ORDER BY last_visit_time DESC LIMIT 5";
        }

        public DataTable GetDataTable()
        {
            using (SQLiteConnection cn = new SQLiteConnection("Data Source=" + Path + ";Version=3;New=False;Compress=True;"))
            {
                try
                {
                    cn.Open();
                    SQLiteDataAdapter sd = new SQLiteDataAdapter(Query, cn);

                    DataTable dt = new DataTable();
                    sd.Fill(dt);
                    return dt;
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to connect browser");
                    throw;
                }
            }
        }
    }
}
