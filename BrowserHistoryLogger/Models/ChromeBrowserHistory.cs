using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BrowserHistoryLogger.Models
{
    class ChromeBrowserHistory : BrowserHistory
    {
        public ChromeBrowserHistory()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) +
                   @"\Google\Chrome\User Data\Default\History";
            query =
                @"SELECT url AS URL, title AS TITLE, time(last_visit_time / 1000000 + (strftime('%s','1601-01-01')), 'unixepoch', 'localtime') AS Time, date(last_visit_time / 1000000 + (strftime('%s','1601-01-01')), 'unixepoch') AS Date
                FROM urls ORDER BY last_visit_time DESC LIMIT 50";
            name = "Crome";
        }
    }
}
