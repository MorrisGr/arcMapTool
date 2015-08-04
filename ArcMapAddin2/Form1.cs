using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ArcMapAddin2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Products.DataSource = DataSourceSpecial.CreateSource(); 
 


            //string connectionString = "Data Source=.;Initial Catalog=pubs;Integrated Security=True";
            //string sql = "SELECT * FROM Authors";
            //SqlConnection connection = new SqlConnection(connectionString);
            //SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            //DataSet ds = new DataSet();
            //connection.Open();
            //dataadapter.Fill(ds, "Authors_table");
            //connection.Close();
            //dataGridView1.DataSource = ds;
            //dataGridView1.DataMember = "Authors_table";

            //DataTable table = new DataTable("Person");
            //DataGridView1.AutoGenerateColumns = True;
            //DataGridView1.DataSource = ds; // dataset
            //DataGridView1.DataMember = "TableName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.label1.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
