using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create schema
            DataSet dsTemp = new DataSet();
            dsTemp.Tables.Add(new DataTable("Person"));

            dsTemp.Tables["Person"].Columns.Add(new DataColumn("PersonID", typeof(UInt32)));
            dsTemp.Tables["Person"].Columns.Add(new DataColumn("FirstName", typeof(string)));
            dsTemp.Tables["Person"].Columns.Add(new DataColumn("LastName", typeof(string)));

            // Create new row for table "Person"
            DataRow drNew = dsTemp.Tables["Person"].NewRow();
            drNew["PersonID"] = 1;
            drNew["FirstName"] = "Apu";
            drNew["LastName"] = "Nahasapeemapetillon";

            Console.WriteLine("Rowstate of new row : {0}", drNew.RowState);

            // Add new row to table "Person"
            dsTemp.Tables["Person"].Rows.Add(drNew);
            Console.WriteLine("Rowstate of added row : {0}", drNew.RowState);

            // Accept all changes
            dsTemp.Tables["Person"].AcceptChanges();
            Console.WriteLine("Rowstate of added row after AcceptChanges() : {0}", drNew.RowState);

            // Modify row
            dsTemp.Tables["Person"].Rows[0]["FirstName"] = "Clancey";
            Console.WriteLine("Rowstate of modified row : {0}", drNew.RowState);

            // Reject Changes
            drNew.RejectChanges();
            Console.WriteLine("Rowstate of modified row after RejectChanges() : {0}", drNew.RowState);

            // Delete Row
            drNew.Delete();
            Console.WriteLine("Rowstate after delete : {0}", drNew.RowState);

            // Accept changes and try to get rowstate
            drNew.AcceptChanges();
            Console.WriteLine("Rowstate of delete row after AcceptChanges() : {0}", drNew.RowState);
            // Console.WriteLine("Rowstate of delete row after AcceptChanges() via Table : {0}", dsTemp.Tables["Person"].Rows[0].RowState);

            Console.ReadKey();
        }
    }
}
