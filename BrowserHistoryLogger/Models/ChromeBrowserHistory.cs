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
        private string path { get; set; }
        private string query { get; set; }

        public ChromeBrowserHistory()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
                   @"\Google\Chrome\User Data\Default\History";
            query =
                @"SELECT url AS URL, title AS TITLE, time(last_visit_time / 1000000 + (strftime('%s','1601-01-01')), 'unixepoch', 'localtime') AS Time, date(last_visit_time / 1000000 + (strftime('%s','1601-01-01')), 'unixepoch') AS Date
                FROM urls ORDER BY last_visit_time DESC LIMIT 50";
        }

        public DataTable GetDataTable()
        {
            using (SQLiteConnection cn = new SQLiteConnection("Data Source=" + path + ";Version=3;New=False;Compress=True;"))
            {
                try
                {
                    cn.Open();
                    SQLiteDataAdapter sd = new SQLiteDataAdapter(query, cn);

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
