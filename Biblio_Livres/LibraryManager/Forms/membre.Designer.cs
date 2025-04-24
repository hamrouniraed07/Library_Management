namespace Biblio_Livres.LibraryManager.Forms
{
    partial class membre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textNom = new TextBox();
            textPrenom = new TextBox();
            textEmail = new TextBox();
            textAdresse = new TextBox();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textNom
            // 
            textNom.Anchor = AnchorStyles.None;
            textNom.Location = new Point(269, 55);
            textNom.Name = "textNom";
            textNom.Size = new Size(200, 27);
            textNom.TabIndex = 0;
            textNom.TextChanged += textNom_TextChanged;
            // 
            // textPrenom
            // 
            textPrenom.Anchor = AnchorStyles.None;
            textPrenom.Location = new Point(269, 122);
            textPrenom.Name = "textPrenom";
            textPrenom.Size = new Size(200, 27);
            textPrenom.TabIndex = 1;
            // 
            // textEmail
            // 
            textEmail.Anchor = AnchorStyles.None;
            textEmail.Location = new Point(269, 184);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(200, 27);
            textEmail.TabIndex = 2;
            // 
            // textAdresse
            // 
            textAdresse.Anchor = AnchorStyles.None;
            textAdresse.Location = new Point(269, 249);
            textAdresse.Name = "textAdresse";
            textAdresse.Size = new Size(200, 27);
            textAdresse.TabIndex = 3;
            // 
            // btnAjouter
            // 
            btnAjouter.Anchor = AnchorStyles.None;
            btnAjouter.BackColor = Color.FromArgb(192, 255, 192);
            btnAjouter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAjouter.Location = new Point(120, 355);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(94, 43);
            btnAjouter.TabIndex = 4;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            // 
            // btnModifier
            // 
            btnModifier.Anchor = AnchorStyles.None;
            btnModifier.BackColor = Color.FromArgb(128, 255, 255);
            btnModifier.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModifier.Location = new Point(296, 355);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(113, 43);
            btnModifier.TabIndex = 5;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click_1;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Anchor = AnchorStyles.None;
            btnSupprimer.BackColor = Color.Red;
            btnSupprimer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSupprimer.ForeColor = SystemColors.ButtonHighlight;
            btnSupprimer.Location = new Point(498, 352);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(138, 46);
            btnSupprimer.TabIndex = 6;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 436);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(833, 195);
            dataGridView1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(158, 51);
            label1.Name = "label1";
            label1.Size = new Size(56, 28);
            label1.TabIndex = 8;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(155, 122);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 9;
            label2.Text = "Prenom";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(158, 184);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 10;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(154, 249);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 11;
            label4.Text = "Adresse";
            // 
            // membre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 631);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(textAdresse);
            Controls.Add(textEmail);
            Controls.Add(textPrenom);
            Controls.Add(textNom);
            Name = "membre";
            Text = "membre";
            Load += membre_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNom;
        private TextBox textPrenom;
        private TextBox textEmail;
        private TextBox textAdresse;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSupprimer;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}