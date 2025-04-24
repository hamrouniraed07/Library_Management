using System;
using System.Windows.Forms;
using WinFormsApp1;
using Microsoft.Data.SqlClient;
using Biblio_Livres.LibraryManager.Forms; // Ajouter l'importation correcte de l'espace de noms

namespace Biblio_Livres
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = SqlConnectionManager.GetConnection())
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM loginapp WHERE username=@username AND password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", textUser.Text);
                cmd.Parameters.AddWithValue("@password", textPass.Text);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Login success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Ouvrir le formulaire Membre
                    this.Hide(); // Cacher la fenêtre de login
                    membre membreForm = new membre(); // Créer une instance du formulaire membre
                    membreForm.ShowDialog(); // Ouvre le form membre en modal
                    this.Close(); // Ferme le form login après que Membre soit fermé
                }
                else
                {
                    MessageBox.Show("Error in login", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
