using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening1
{
    public partial class Form1 : Form
    {
        #region Constructors

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void buttonCreateDataSet_Click(object sender, EventArgs e)
        {
            CreateDataSet();
        }

        #endregion

        #region Private methods

        private void CreateDataSet()
        {
            DataSet ds = new DataSet();
            // Add the table "tblInvoices"
            ds.Tables.Add("tblInvoices");

            ds.Tables["tblInvoices"].Columns.Add("InvoiceID", typeof(System.Int32));
            ds.Tables["tblInvoices"].Columns["InvoiceID"].AllowDBNull = false;

            ds.Tables["tblInvoices"].Columns.Add("InvoiceDate", typeof(System.DateTime));            
            ds.Tables["tblInvoices"].Columns["InvoiceDate"].AllowDBNull = false;
            ds.Tables["tblInvoices"].Columns["InvoiceDate"].DefaultValue = DateTime.Now;

            ds.Tables["tblInvoices"].Columns.Add("CustomerName", typeof(System.String));
            ds.Tables["tblInvoices"].Columns["CustomerName"].MaxLength = 30;
            ds.Tables["tblInvoices"].Columns["CustomerName"].AllowDBNull = false;

            // Add the table "tblInvoiceDetails"
            ds.Tables.Add("tblInvoiceDetails");

            ds.Tables["tblInvoiceDetails"].Columns.Add("InvoiceDetailID", typeof(System.Int32));
            ds.Tables["tblInvoiceDetails"].Columns["InvoiceDetailID"].AllowDBNull = false;

            ds.Tables["tblInvoiceDetails"].Columns.Add("InvoiceID", typeof(System.Int32));
            ds.Tables["tblInvoiceDetails"].Columns["InvoiceID"].AllowDBNull = false;

            ds.Tables["tblInvoiceDetails"].Columns.Add("ProductName", typeof(System.String));
            ds.Tables["tblInvoiceDetails"].Columns["ProductName"].MaxLength = 30;
            ds.Tables["tblInvoiceDetails"].Columns["ProductName"].AllowDBNull = false;

            ds.Tables["tblInvoiceDetails"].Columns.Add("Discount", typeof(System.Boolean));
            ds.Tables["tblInvoiceDetails"].Columns["Discount"].AllowDBNull = false;
            ds.Tables["tblInvoiceDetails"].Columns["Discount"].DefaultValue = false;

            ds.Tables["tblInvoiceDetails"].Columns.Add("DiscountAmount", typeof(System.Decimal));
            ds.Tables["tblInvoiceDetails"].Columns["DiscountAmount"].AllowDBNull = false;
            ds.Tables["tblInvoiceDetails"].Columns["DiscountAmount"].DefaultValue = 0;

            ds.Tables["tblInvoiceDetails"].Columns.Add("Quantity", typeof(System.Int16));
            ds.Tables["tblInvoiceDetails"].Columns["Quantity"].AllowDBNull = false;
            ds.Tables["tblInvoiceDetails"].Columns["Quantity"].DefaultValue = 1;

            ds.Tables["tblInvoiceDetails"].Columns.Add("Amount", typeof(System.Decimal));
            ds.Tables["tblInvoiceDetails"].Columns["Amount"].AllowDBNull = false;
        }

        #endregion
    }
}
