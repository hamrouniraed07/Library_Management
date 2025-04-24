using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace Biblio_Livres.LibraryManager.Forms
{
    public partial class membre : Form
    {
        public membre()
        {
            InitializeComponent();
        }

        private void LoadMembres()
        {
            using (SqlConnection con = SqlConnectionManager.GetConnection())
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Membres", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = SqlConnectionManager.GetConnection())
                {
                    con.Open();
                    string query = "INSERT INTO Membres (Nom, Prenom, Email, Adresse) VALUES (@Nom, @Prenom, @Email, @Adresse)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nom", textNom.Text);
                    cmd.Parameters.AddWithValue("@Prenom", textPrenom.Text);
                    cmd.Parameters.AddWithValue("@Email", textEmail.Text);
                    cmd.Parameters.AddWithValue("@Adresse", textAdresse.Text);
                    cmd.ExecuteNonQuery();
                    LoadMembres();
                    MessageBox.Show("Membre ajouté avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du membre : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null) return;

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                using (SqlConnection con = SqlConnectionManager.GetConnection())
                {
                    con.Open();
                    string query = "UPDATE Membres SET Nom=@Nom, Prenom=@Prenom, Email=@Email, Adresse=@Adresse WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nom", textNom.Text);
                    cmd.Parameters.AddWithValue("@Prenom", textPrenom.Text);
                    cmd.Parameters.AddWithValue("@Email", textEmail.Text);
                    cmd.Parameters.AddWithValue("@Adresse", textAdresse.Text);
                    cmd.ExecuteNonQuery();
                    LoadMembres();
                    MessageBox.Show("Membre modifié avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la modification du membre : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null) return;

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                using (SqlConnection con = SqlConnectionManager.GetConnection())
                {
                    con.Open();
                    string query = "DELETE FROM Membres WHERE Id=@Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                    LoadMembres();
                    MessageBox.Show("Membre supprimé avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression du membre : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                textNom.Text = dataGridView1.CurrentRow.Cells["Nom"].Value.ToString();
                textPrenom.Text = dataGridView1.CurrentRow.Cells["Prenom"].Value.ToString();
                textEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
                textAdresse.Text = dataGridView1.CurrentRow.Cells["Adresse"].Value.ToString();
            }
        }

        private void membre_Load(object sender, EventArgs e)
        {

        }

        private void textNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click_1(object sender, EventArgs e)
        {

        }
    }
}
