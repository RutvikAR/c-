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
namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=E:\rutvik\test\test\Database1.mdf;Integrated Security=True;User Instance=True");
            cn.Open();
            string sql = "insert into test1 values ('rutvik')";
           /* SqlCommand sc = new SqlCommand(sql,cn);
            sc.ExecuteNonQuery();*/
            SqlDataAdapter sda = new SqlDataAdapter(sql,cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }
    }
}
