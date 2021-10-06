using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BrowserHistoryLogger.Models;

namespace BrowserHistoryLogger
{
    public partial class Form1 : Form
    {
        private List<string> _urlList = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var chrome = new ChromeBrowserHistory();
            var dt = chrome.GetDataTable();
            chromeDataGrid.DataSource = dt;
            
            //записываем в list все url
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                _urlList.Add(dt.Rows[i]["url"].ToString());
            }

            //приведение urlList к виду www.sitename.com
            
            BusinessLogic.ModifyHostsFile("127.0.0.1       howto.mydiv.net");
        }
    }
}
