using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace Oefening1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void createDataset()
        {
            DataSet ds = new DataSet();
            ds.Tables.Add("tblInvoices");
            
            ds.Tables["tblInvoices"].Columns.Add("InvoiceID", typeof())

        }
    }
}
