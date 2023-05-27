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

namespace Library_v1._2
{
    public partial class frmStatics : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-NJT7QHD1\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");
        public frmStatics()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#BFCCB5");
            panel1.BackColor = ColorTranslator.FromHtml("#EDC6B1");

            conn.Open();
            SqlCommand cmdlist1= new SqlCommand("Select Genre, count(*) from dbo.library group by Genre", conn);
            SqlDataReader reader = cmdlist1.ExecuteReader();
            while (reader.Read()) chart1.Series["Genres"].Points.AddXY(reader[0], reader[1]);
            conn.Close();

            conn.Open();
            SqlCommand cmdlist2 = new SqlCommand("Select Genre, count(*) from dbo.library where loan=0 group by Genre", conn);
            SqlDataReader reader2 = cmdlist2.ExecuteReader();
            while (reader2.Read()) chart2.Series["Genres"].Points.AddXY(reader2[0], reader2[1]);
            conn.Close();

            conn.Open();
            SqlCommand cmdtotal = new SqlCommand("select count(*) from dbo.library",conn);
            SqlDataReader readertotal = cmdtotal.ExecuteReader();
            while (readertotal.Read()) lblBtotal.Text = readertotal[0].ToString();
            conn.Close();


            conn.Open();
            SqlCommand cmdloan = new SqlCommand("Select count (*) from dbo.library where Loan=1", conn);
            SqlDataReader readerloan = cmdloan.ExecuteReader();
            while (readerloan.Read()) lblBLoan.Text = readerloan[0].ToString();
            conn.Close();

            conn.Open();
            SqlCommand cmdnloan = new SqlCommand("Select count (*) from dbo.library where Loan=0", conn);
            SqlDataReader readernloan = cmdnloan.ExecuteReader();
            while (readernloan.Read()) lblBnLoan.Text = readernloan[0].ToString();
            conn.Close();



        }

        
    }    
}
