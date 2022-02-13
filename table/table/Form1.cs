using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disp(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m1 = Convert.ToInt32(txt1.Text);
                

            string sql = "insert into table1 values('" + txt1.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(sql, Class1.cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            disp();
        }
        private void disp()
        {
            string sel = "select * from table1";
            SqlDataAdapter dal = new SqlDataAdapter(sel, Class1.cn);
            DataTable dt1 = new DataTable();
            dal.Fill(dt1);
            dataGridView1.DataSource = dt1;
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
