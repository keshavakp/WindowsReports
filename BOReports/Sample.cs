using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BOReports
{
    public partial class Sample : Form
    {
        public Sample()
        {
            InitializeComponent();
        }
              

        private void button1_Click_1(object sender, EventArgs e)
        {
            DBConnection DbConn = new DBConnection();
            SqlConnection SqlConn = DbConn.CreateConnection();
            SqlTransaction SqlTrans;



          //  Session["RPT"] = "TGDCR";

        }

        private void Sample_Load(object sender, EventArgs e)
        {

           // this.reportViewer1.RefreshReport();//
            this.reportViewer1.RefreshReport();
        }

  


    }
}
