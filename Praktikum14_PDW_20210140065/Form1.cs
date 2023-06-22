using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Praktikum14_PDW_20210140065
{
    private string stringConnection = "data surce=ZEPHYRUS-NEROBA\\FRANCONERO" + "database=ProdiTI;User ID=sa; Password=28112012";
    private SqlConnection koneksi;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DataMaster_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
