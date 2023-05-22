using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Library_v1._2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#8294C4");
            panel1.BackColor = ColorTranslator.FromHtml("#ACB1D6");
            
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-NJT7QHD1\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.library' table. You can move, or remove it, as needed.
            this.libraryTableAdapter.Fill(this.libraryDataSet.library);

        }
        /*
        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmdsave = new SqlCommand("insert into library (BookID,BookName,Author,Page,Genre) values (@q1,@q2,@q3,@q4,@q5)",conn);
            cmdsave.Parameters.AddWithValue("@q1", textBox1.Text);
            cmdsave.Parameters.AddWithValue("@q2", textBox2.Text);
            cmdsave.Parameters.AddWithValue("@q3", textBox3.Text);
            cmdsave.Parameters.AddWithValue("@q4", textBox4.Text);
            cmdsave.Parameters.AddWithValue("@q5", textBox5.Text);
            //cmdsave.Parameters.AddWithValue("@q6", txtName.Text);
             cmdsave.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully");
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            this.libraryTableAdapter.Fill(this.libraryDataSet.library);
        }
    }
}
