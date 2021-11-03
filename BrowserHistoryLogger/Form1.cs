using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
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
            //chromeDataGrid.DataSource = dt;
            
            //записываем в list все url из dataTable
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                _urlList.Add(dt.Rows[i]["url"].ToString());
            }

            //приведение urlList к виду www.sitename.com или sitename.com
            for (int i =0; i<_urlList.Count;i++)
            {
                string str = _urlList[i];
                str = str.Replace("//", "/");
                str = str.Substring(str.IndexOf('/') + 1);
                str = str.Remove(str.IndexOf("/"));
                _urlList[_urlList.IndexOf(_urlList[i])] = str;
            }

            _urlList = _urlList.Distinct().ToList();//удаляем дубли в листе

            chromeDataGrid.DataSource = _urlList.Select(x => new { Value = x }).ToList();//вывод доменов в dataGrid;
            

            //BusinessLogic.ModifyHostsFile("127.0.0.1       howto.mydiv.net");
        }
    }
}
