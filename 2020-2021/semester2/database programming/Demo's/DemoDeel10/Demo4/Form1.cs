using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo4
{
    public partial class Form1 : Form
    {
        #region Private members

        private DataSet _ds;

        #endregion

        #region Constructors

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateDataSet();
        }

        private void buttonShowStructure_Click(object sender, EventArgs e)
        {
            ShowDataSetStructure();
        }

        #endregion

        #region Private methods

        private void CreateDataSet()
        {
            // Create DataSet
            _ds = new DataSet("Tennis");

            // Create table "PlayerFunctions"
            DataTable table = new DataTable("PlayerFunctions");
            _ds.Tables.Add(table);
            // Add columns to table
            DataColumn column = new DataColumn("PlayerNr", typeof(UInt32));
            column.AllowDBNull = false;            
            table.Columns.Add(column);

            column = new DataColumn("StartDate", typeof(DateTime));
            column.AllowDBNull = false;
            table.Columns.Add(column);

            column = new DataColumn("EndDate", typeof(DateTime));
            column.AllowDBNull = false;
            table.Columns.Add(column);

            column = new DataColumn("Function", typeof(string));
            column.AllowDBNull = false;
            column.MaxLength = 20;
            table.Columns.Add(column);

            // Add primary key to table PlayerFunctions
            table.PrimaryKey = new DataColumn[] { table.Columns["PlayerNr"], table.Columns["Function"], table.Columns["StartDate"] };

            // Create table "Players"
            table = new DataTable("Players");
            _ds.Tables.Add(table);

            column = new DataColumn("PlayerNr", typeof(UInt32));
            column.AllowDBNull = false;
            table.Columns.Add(column);
            table.PrimaryKey = new DataColumn[] { table.Columns["PlayerNr"] };

            column = new DataColumn("Name", typeof(string));
            column.AllowDBNull = false;
            column.MaxLength = 15;
            table.Columns.Add(column);

            column = new DataColumn("Initials", typeof(string));
            column.AllowDBNull = false;
            column.MaxLength = 3;
            table.Columns.Add(column);

            column = new DataColumn("BirthDate", typeof(DateTime));
            column.AllowDBNull = false;
            table.Columns.Add(column);

            column = new DataColumn("Gender", typeof(string));
            column.AllowDBNull = false;
            column.MaxLength = 1;
            table.Columns.Add(column);

            column = new DataColumn("YearOfJoining", typeof(UInt16));
            column.AllowDBNull = false;
            table.Columns.Add(column);

            column = new DataColumn("Street", typeof(string));
            column.AllowDBNull = false;
            column.MaxLength = 30;
            table.Columns.Add(column);

            column = new DataColumn("HouseNumber", typeof(string));
            column.AllowDBNull = false;
            column.MaxLength = 4;
            table.Columns.Add(column);

            column = new DataColumn("Zipcode", typeof(string));
            column.AllowDBNull = false;
            column.MaxLength = 6;
            table.Columns.Add(column);

            column = new DataColumn("City", typeof(string));
            column.AllowDBNull = false;
            column.MaxLength = 30;
            table.Columns.Add(column);

            column = new DataColumn("PhoneNr", typeof(string));
            column.AllowDBNull = false;
            column.MaxLength = 13;
            table.Columns.Add(column);

            column = new DataColumn("LeagueNr", typeof(string));
            column.AllowDBNull = false;
            column.MaxLength = 4;
            table.Columns.Add(column);

            // Add relations
            _ds.Relations.Add("Player_PlayerFunctions", _ds.Tables["Players"].Columns["PlayerNr"], _ds.Tables["PlayerFunctions"].Columns["PlayerNr"]);
        }

        private void ShowDataSetStructure()
        {
            TreeNode newNode;
            TreeNode parentNode;

            treeViewStructure.Nodes.Clear();

            foreach (DataTable dt in _ds.Tables)
            {
                newNode = new TreeNode($"{dt.TableName}\n");
                newNode.Name = dt.TableName;
                treeViewStructure.Nodes.Add(newNode);
                parentNode = newNode;

                newNode = new TreeNode("Primary key");
                parentNode.Nodes.Add(newNode);
                
                foreach(DataColumn pdc in dt.PrimaryKey)
                {
                    newNode.Nodes.Add(pdc.ColumnName);
                }                

                newNode = new TreeNode("Columns");
                parentNode.Nodes.Add(newNode);

                foreach (DataColumn dc in dt.Columns)
                {
                    newNode.Nodes.Add($"\t{dc.ColumnName}({dc.DataType.Name},{dc.AllowDBNull})\n");
                }
            }

            parentNode = new TreeNode("Relations");
            treeViewStructure.Nodes.Add(parentNode);

            foreach(DataRelation dr in _ds.Relations)
            {
                newNode = new TreeNode($"{dr.RelationName}\n");
                parentNode.Nodes.Add(newNode);
                newNode.Nodes.Add($"Foreign key '{dr.ChildColumns[0].ColumnName}' in table '{dr.ChildTable.TableName}' references primary key '{dr.ParentColumns[0].ColumnName}' in table '{dr.ParentTable.TableName}'");
            }
        }

        #endregion
    }
}
