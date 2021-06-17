using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo2
{
    public partial class Demo2 : Form
    {
        // Bewaar nooit een connectionstring in plain code vermits dit probleemloos via ILDASM.exe gelezen kan worden
        // Deze tool wordt automatisch geïnstalleerd bij Visual Studio en kan je via de Developer Command prompt aanspreken
        string demonstrateILDASM = "Als je dit kan lezen merk je dat een connection string op deze manier open en bloot staat!";

        public Demo2()
        {
            InitializeComponent();
        }
    }
}
