using System;
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
            InitializeComponent();
        }

        private void Finance_Load(object sender, EventArgs e)
        {

        }

        private void connect_click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = new SqlConnection("Server=LAPTOP-QOCJCAOK;Database=PortfolioData;Trusted_Connection=True;");
                sqlConnection.Open();

                SqlCommand command = new SqlCommand();

            }
            catch
            {

            }
        }

    }
}
