using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
namespace Biblio_Livres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1L996PU;Initial Catalog=Library;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string query = " SELECT COUNT (*) FROM loginapp WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", textUser.Text);
            cmd.Parameters.AddWithValue("@password", textPass.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("login success", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("error in login ");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textPass.PasswordChar = checkBox1.Checked ? '\0' : '*';

        }
    }
}
