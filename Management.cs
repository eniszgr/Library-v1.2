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
using System.Security.Cryptography;

namespace Library_v1._2
{
    public partial class Management : Form
    {
        
        public Management()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#8294C4");
            panel1.BackColor = ColorTranslator.FromHtml("#ACB1D6");   //style
            
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-NJT7QHD1\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");
        //sql connection
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.library' table. You can move, or remove it, as needed.
            this.libraryTableAdapter.Fill(this.libraryDataSet.library);

        }
        private void btnList_Click(object sender, EventArgs e)
        {
            this.libraryTableAdapter.Fill(this.libraryDataSet.library);
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(100000000, 999999999);
            lblID.Text = randomNumber.ToString();

        }
        private void btnAdd_Click(object sender, EventArgs e) //add new book
        {
            conn.Open();
            SqlCommand cmdsave = new SqlCommand("insert into library (BookID,BookName,Author,Page,Genre,Loan) values (@q1,@q2,@q3,@q4,@q5,@q6)", conn);
            cmdsave.Parameters.AddWithValue("@q1", lblID.Text);
            cmdsave.Parameters.AddWithValue("@q2", txtName.Text);
            cmdsave.Parameters.AddWithValue("@q3", txtAuthor.Text);
            cmdsave.Parameters.AddWithValue("@q4", txtPage.Text);
            cmdsave.Parameters.AddWithValue("@q5", cmbGenre.Text);
            cmdsave.Parameters.AddWithValue("@q6", label2.Text);
            cmdsave.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        { 
            if (radioButton1.Checked==true)
            label2.Text = "True";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked==true)
            label2.Text="False";
        }

        private void begin_info(object sender, DataGridViewCellEventArgs e)
        {
            int select = dataGridView1.SelectedCells[0].RowIndex;
            lblID.Text= dataGridView1.Rows[select].Cells[0].Value.ToString();
            txtName.Text= dataGridView1.Rows[select].Cells[1].Value.ToString();
            txtAuthor.Text = dataGridView1.Rows[select].Cells[2].Value.ToString();
            txtPage.Text = dataGridView1.Rows[select].Cells[3].Value.ToString();
            cmbGenre.Text = dataGridView1.Rows[select].Cells[4].Value.ToString();
            label2.Text = dataGridView1.Rows[select].Cells[5].Value.ToString();
        
        }

        private void lbl2changed(object sender, EventArgs e)
        {
            if(label2.Text=="True") radioButton1.Checked = true;
            else radioButton2.Checked = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmdUpdate = new SqlCommand("Update dbo.library Set  BookName=@a1, Author=@a2, Page=@a3, Genre=@a4, Loan=@a5 where BookID=@a6",conn);
            cmdUpdate.Parameters.AddWithValue("@a1", txtName.Text);
            cmdUpdate.Parameters.AddWithValue("@a2", txtAuthor.Text);
            cmdUpdate.Parameters.AddWithValue("@a3", txtPage.Text);
            cmdUpdate.Parameters.AddWithValue("@a4", cmbGenre.Text);
            cmdUpdate.Parameters.AddWithValue("@a5", label2.Text);
            cmdUpdate.Parameters.AddWithValue("@a6", lblID.Text);
            cmdUpdate.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("successfull");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblID.Text = "";
            txtName.Text = "";
            txtAuthor.Text = "";
            txtPage.Text = "";
            cmbGenre.Text = "";
            radioButton1.Checked=false;
            radioButton2.Checked=false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmdDelete = new SqlCommand("Delete from dbo.library where BookID=@k1",conn);
            cmdDelete.Parameters.AddWithValue("@k1", lblID.Text);
            cmdDelete.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Successfully");
        }

        private void btnStatics_Click(object sender, EventArgs e)
        {
            frmStatics frmStatics= new frmStatics();
            frmStatics.Show();
        }
    }
}
