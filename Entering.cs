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
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Library_v1._2
{
    public partial class Entering : Form
    {
        private SoundPlayer enter;
        public Entering()
        {
            InitializeComponent();
            enter = new SoundPlayer("bell.wav");
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-NJT7QHD1\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True");
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmdLogin = new SqlCommand("select * from dbo.Admin where AdminName=@q1 or Password=@q2 ",conn);
            cmdLogin.Parameters.AddWithValue("@q1",txtName.Text);
            cmdLogin.Parameters.AddWithValue("@q2",txtPassword.Text);
            SqlDataReader reader = cmdLogin.ExecuteReader();
            if (reader.Read())  
            {
                enter.Play();
                Management mng = new Management();
                mng.Show();
                this.Hide();
                
            }
            else MessageBox.Show("Wrong Name or Password");
            conn.Close();
        }

        
    }
}
