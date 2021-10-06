using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using BrowserHistoryLogger.Models;

namespace BrowserHistoryLogger
{
    public partial class Form1 : Form
    {
        private List<string> urList = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChromeBrowserHistory chrome = new ChromeBrowserHistory();
            DataTable dt = chrome.GetDataTable();
            chromeDataGrid.DataSource = dt;
            
            //записываем в list все url
            for (int i = 0; i < chrome.GetDataTable().Rows.Count; i++)
            {
                urList.Add(chrome.GetDataTable().Rows[i]["url"].ToString());
            }

        }
    }
}
