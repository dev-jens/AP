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

        public void CreateDataSet()
        {
            DataSet ds = new DataSet();

            ds.Tables.Add("tblInvoices");

            ds.Tables["tblInvoices"].Columns.Add("InvoiceID", typeof(Int32));
            ds.Tables["tblInvoices"].Columns["invoiceID"].AllowDBNull = false;
            

            ds.Tables["tblInvoices"].Columns.Add("InvoiceDate", typeof(DateTime));
            ds.Tables["tblInvoices"].Columns["invoiceDate"].AllowDBNull = false;
            ds.Tables["tblInvoices"].Columns["invoiceDate"].DefaultValue = DateTime.Now;

            ds.Tables["tblInvoices"].Columns.Add("CustomerName", typeof(String));
            ds.Tables["tblInvoices"].Columns["CustomerName"].MaxLength = 30;
            ds.Tables["tblInvoices"].Columns["CustomerName"].AllowDBNull = false;

            ds.Tables.Add("tblInvoiceDetail");

            ds.Tables["tblInvoiceDetail"].Columns.Add("InvoiceDetailID", typeof(Int32));
            ds.Tables["tblInvoiceDetail"].Columns["InvoiceDetailID"].AllowDBNull = false;

            ds.Tables["tblInvoiceDetail"].Columns.Add("InvoiceID", typeof(Int32));
            ds.Tables["tblInvoiceDetail"].Columns["InvoiceID"].AllowDBNull = false;

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
    }
}
