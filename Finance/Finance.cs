﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance
{
    public partial class Finance : Form
    {
        public Finance()
        {
           // InitializeComponent();
        }

        private void Finance_Load(object sender, EventArgs e)
        {

        }

        private void connect_click(object sender, EventArgs e)
        {
            Database database = new Database();
            database.ConnectToDatabaseAndPullData(); 
        }

    }
}
