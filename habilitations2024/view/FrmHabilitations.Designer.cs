using System;

namespace habilitations2024.view
{
    partial class FrmHabilitations
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbLesDeveloppeurs = new System.Windows.Forms.GroupBox();
            this.BtnDemandeSupprDev = new System.Windows.Forms.Button();
            this.BtnDemandeChangePwd = new System.Windows.Forms.Button();
            this.BtnDemandeModifDev = new System.Windows.Forms.Button();
            this.dgvDeveloppeurs = new System.Windows.Forms.DataGridView();
            this.grbDeveloppeur = new System.Windows.Forms.GroupBox();
            this.cboProfil = new System.Windows.Forms.ComboBox();
            this.BtnAnnulDev = new System.Windows.Forms.Button();
            this.BtnEnregDev = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblProfil = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.grbPwd = new System.Windows.Forms.GroupBox();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.txtPwd1 = new System.Windows.Forms.TextBox();
            this.BtnAnnulPwd = new System.Windows.Forms.Button();
            this.BtnEnregPwd = new System.Windows.Forms.Button();
            this.lblEncore = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.cboFiltrProfil = new System.Windows.Forms.ComboBox();
            this.lblFiltrProfil = new System.Windows.Forms.Label();
            this.grbLesDeveloppeurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeveloppeurs)).BeginInit();
            this.grbDeveloppeur.SuspendLayout();
            this.grbPwd.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLesDeveloppeurs
            // 
            this.grbLesDeveloppeurs.Controls.Add(this.lblFiltrProfil);
            this.grbLesDeveloppeurs.Controls.Add(this.cboFiltrProfil);
            this.grbLesDeveloppeurs.Controls.Add(this.BtnDemandeSupprDev);
            this.grbLesDeveloppeurs.Controls.Add(this.BtnDemandeChangePwd);
            this.grbLesDeveloppeurs.Controls.Add(this.BtnDemandeModifDev);
            this.grbLesDeveloppeurs.Controls.Add(this.dgvDeveloppeurs);
            this.grbLesDeveloppeurs.Location = new System.Drawing.Point(12, 12);
            this.grbLesDeveloppeurs.Name = "grbLesDeveloppeurs";
            this.grbLesDeveloppeurs.Size = new System.Drawing.Size(869, 319);
            this.grbLesDeveloppeurs.TabIndex = 0;
            this.grbLesDeveloppeurs.TabStop = false;
            this.grbLesDeveloppeurs.Text = "les développeurs";
            // 
            // BtnDemandeSupprDev
            // 
            this.BtnDemandeSupprDev.Location = new System.Drawing.Point(159, 272);
            this.BtnDemandeSupprDev.Name = "BtnDemandeSupprDev";
            this.BtnDemandeSupprDev.Size = new System.Drawing.Size(130, 35);
            this.BtnDemandeSupprDev.TabIndex = 4;
            this.BtnDemandeSupprDev.Text = "supprimer";
            this.BtnDemandeSupprDev.UseVisualStyleBackColor = true;
            this.BtnDemandeSupprDev.Click += new System.EventHandler(this.BtnDemandeSupprDev_Click_1);
            // 
            // BtnDemandeChangePwd
            // 
            this.BtnDemandeChangePwd.Location = new System.Drawing.Point(316, 272);
            this.BtnDemandeChangePwd.Name = "BtnDemandeChangePwd";
            this.BtnDemandeChangePwd.Size = new System.Drawing.Size(130, 35);
            this.BtnDemandeChangePwd.TabIndex = 3;
            this.BtnDemandeChangePwd.Text = "changer pwd";
            this.BtnDemandeChangePwd.UseVisualStyleBackColor = true;
            this.BtnDemandeChangePwd.Click += new System.EventHandler(this.BtnDemandeChangePwd_Click_1);
            // 
            // BtnDemandeModifDev
            // 
            this.BtnDemandeModifDev.Location = new System.Drawing.Point(6, 272);
            this.BtnDemandeModifDev.Name = "BtnDemandeModifDev";
            this.BtnDemandeModifDev.Size = new System.Drawing.Size(130, 35);
            this.BtnDemandeModifDev.TabIndex = 1;
            this.BtnDemandeModifDev.Text = "modiffier";
            this.BtnDemandeModifDev.UseVisualStyleBackColor = true;
            this.BtnDemandeModifDev.Click += new System.EventHandler(this.BtnDemandeModifDev_Click_1);
            // 
            // dgvDeveloppeurs
            // 
            this.dgvDeveloppeurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeveloppeurs.Location = new System.Drawing.Point(6, 25);
            this.dgvDeveloppeurs.Name = "dgvDeveloppeurs";
            this.dgvDeveloppeurs.RowHeadersVisible = false;
            this.dgvDeveloppeurs.RowHeadersWidth = 62;
            this.dgvDeveloppeurs.RowTemplate.Height = 28;
            this.dgvDeveloppeurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeveloppeurs.Size = new System.Drawing.Size(857, 241);
            this.dgvDeveloppeurs.TabIndex = 0;
            // 
            // grbDeveloppeur
            // 
            this.grbDeveloppeur.Controls.Add(this.cboProfil);
            this.grbDeveloppeur.Controls.Add(this.BtnAnnulDev);
            this.grbDeveloppeur.Controls.Add(this.BtnEnregDev);
            this.grbDeveloppeur.Controls.Add(this.txtNom);
            this.grbDeveloppeur.Controls.Add(this.txtTel);
            this.grbDeveloppeur.Controls.Add(this.lblProfil);
            this.grbDeveloppeur.Controls.Add(this.txtMail);
            this.grbDeveloppeur.Controls.Add(this.lblNom);
            this.grbDeveloppeur.Controls.Add(this.lblTel);
            this.grbDeveloppeur.Controls.Add(this.lblPrenom);
            this.grbDeveloppeur.Controls.Add(this.lblMail);
            this.grbDeveloppeur.Controls.Add(this.txtPrenom);
            this.grbDeveloppeur.Location = new System.Drawing.Point(12, 355);
            this.grbDeveloppeur.Name = "grbDeveloppeur";
            this.grbDeveloppeur.Size = new System.Drawing.Size(869, 206);
            this.grbDeveloppeur.TabIndex = 1;
            this.grbDeveloppeur.TabStop = false;
            this.grbDeveloppeur.Text = "ajouter un développeur";
            // 
            // cboProfil
            // 
            this.cboProfil.FormattingEnabled = true;
            this.cboProfil.Location = new System.Drawing.Point(484, 110);
            this.cboProfil.Name = "cboProfil";
            this.cboProfil.Size = new System.Drawing.Size(347, 28);
            this.cboProfil.TabIndex = 11;
            // 
            // BtnAnnulDev
            // 
            this.BtnAnnulDev.Location = new System.Drawing.Point(148, 160);
            this.BtnAnnulDev.Name = "BtnAnnulDev";
            this.BtnAnnulDev.Size = new System.Drawing.Size(110, 30);
            this.BtnAnnulDev.TabIndex = 3;
            this.BtnAnnulDev.Text = "annuler";
            this.BtnAnnulDev.UseVisualStyleBackColor = true;
            this.BtnAnnulDev.Click += new System.EventHandler(this.BtnAnnulDev_Click_1);
            // 
            // BtnEnregDev
            // 
            this.BtnEnregDev.Location = new System.Drawing.Point(18, 160);
            this.BtnEnregDev.Name = "BtnEnregDev";
            this.BtnEnregDev.Size = new System.Drawing.Size(110, 30);
            this.BtnEnregDev.TabIndex = 2;
            this.BtnEnregDev.Text = "enregistrer";
            this.BtnEnregDev.UseVisualStyleBackColor = true;
            this.BtnEnregDev.Click += new System.EventHandler(this.BtnEnregDev_Click_1);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(83, 25);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(273, 26);
            this.txtNom.TabIndex = 2;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(484, 69);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(347, 26);
            this.txtTel.TabIndex = 5;
            // 
            // lblProfil
            // 
            this.lblProfil.AutoSize = true;
            this.lblProfil.Location = new System.Drawing.Point(435, 110);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Size = new System.Drawing.Size(43, 20);
            this.lblProfil.TabIndex = 10;
            this.lblProfil.Text = "profil";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(484, 25);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(347, 26);
            this.txtMail.TabIndex = 4;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(15, 30);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(40, 20);
            this.lblNom.TabIndex = 6;
            this.lblNom.Text = "nom";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(435, 65);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(26, 20);
            this.lblTel.TabIndex = 9;
            this.lblTel.Text = "tel";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(14, 69);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(63, 20);
            this.lblPrenom.TabIndex = 7;
            this.lblPrenom.Text = "prenom";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(435, 31);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(37, 20);
            this.lblMail.TabIndex = 8;
            this.lblMail.Text = "mail";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(83, 65);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(273, 26);
            this.txtPrenom.TabIndex = 3;
            // 
            // grbPwd
            // 
            this.grbPwd.Controls.Add(this.txtPwd2);
            this.grbPwd.Controls.Add(this.txtPwd1);
            this.grbPwd.Controls.Add(this.BtnAnnulPwd);
            this.grbPwd.Controls.Add(this.BtnEnregPwd);
            this.grbPwd.Controls.Add(this.lblEncore);
            this.grbPwd.Controls.Add(this.lblPwd);
            this.grbPwd.Location = new System.Drawing.Point(12, 591);
            this.grbPwd.Name = "grbPwd";
            this.grbPwd.Size = new System.Drawing.Size(869, 132);
            this.grbPwd.TabIndex = 2;
            this.grbPwd.TabStop = false;
            this.grbPwd.Text = "changer le mot de passe";
            // 
            // txtPwd2
            // 
            this.txtPwd2.Location = new System.Drawing.Point(498, 34);
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.Size = new System.Drawing.Size(347, 26);
            this.txtPwd2.TabIndex = 5;
            // 
            // txtPwd1
            // 
            this.txtPwd1.Location = new System.Drawing.Point(53, 34);
            this.txtPwd1.Name = "txtPwd1";
            this.txtPwd1.PasswordChar = '*';
            this.txtPwd1.Size = new System.Drawing.Size(340, 26);
            this.txtPwd1.TabIndex = 4;
            // 
            // BtnAnnulPwd
            // 
            this.BtnAnnulPwd.Location = new System.Drawing.Point(148, 84);
            this.BtnAnnulPwd.Name = "BtnAnnulPwd";
            this.BtnAnnulPwd.Size = new System.Drawing.Size(110, 30);
            this.BtnAnnulPwd.TabIndex = 3;
            this.BtnAnnulPwd.Text = "annuler";
            this.BtnAnnulPwd.UseVisualStyleBackColor = true;
            this.BtnAnnulPwd.Click += new System.EventHandler(this.BtnAnnulPwd_Click_1);
            // 
            // BtnEnregPwd
            // 
            this.BtnEnregPwd.Location = new System.Drawing.Point(19, 84);
            this.BtnEnregPwd.Name = "BtnEnregPwd";
            this.BtnEnregPwd.Size = new System.Drawing.Size(110, 30);
            this.BtnEnregPwd.TabIndex = 2;
            this.BtnEnregPwd.Text = "Enregistrer";
            this.BtnEnregPwd.UseVisualStyleBackColor = true;
            this.BtnEnregPwd.Click += new System.EventHandler(this.BtnEnregPwd_Click_1);
            // 
            // lblEncore
            // 
            this.lblEncore.AutoSize = true;
            this.lblEncore.Location = new System.Drawing.Point(434, 40);
            this.lblEncore.Name = "lblEncore";
            this.lblEncore.Size = new System.Drawing.Size(58, 20);
            this.lblEncore.TabIndex = 1;
            this.lblEncore.Text = "encore";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(9, 37);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(38, 20);
            this.lblPwd.TabIndex = 0;
            this.lblPwd.Text = "pwd";
            // 
            // cboFiltrProfil
            // 
            this.cboFiltrProfil.FormattingEnabled = true;
            this.cboFiltrProfil.Location = new System.Drawing.Point(719, 272);
            this.cboFiltrProfil.Name = "cboFiltrProfil";
            this.cboFiltrProfil.Size = new System.Drawing.Size(144, 28);
            this.cboFiltrProfil.TabIndex = 5;
            this.cboFiltrProfil.SelectedIndexChanged += new System.EventHandler(this.cboFiltrProfil_SelectedIndexChanged);
            // 
            // lblFiltrProfil
            // 
            this.lblFiltrProfil.AutoSize = true;
            this.lblFiltrProfil.Location = new System.Drawing.Point(608, 279);
            this.lblFiltrProfil.Name = "lblFiltrProfil";
            this.lblFiltrProfil.Size = new System.Drawing.Size(105, 20);
            this.lblFiltrProfil.TabIndex = 6;
            this.lblFiltrProfil.Text = "filtre par motif";
            // 
            // FrmHabilitations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 736);
            this.Controls.Add(this.grbPwd);
            this.Controls.Add(this.grbDeveloppeur);
            this.Controls.Add(this.grbLesDeveloppeurs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHabilitations";
            this.Text = "Habilitations";
            this.grbLesDeveloppeurs.ResumeLayout(false);
            this.grbLesDeveloppeurs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeveloppeurs)).EndInit();
            this.grbDeveloppeur.ResumeLayout(false);
            this.grbDeveloppeur.PerformLayout();
            this.grbPwd.ResumeLayout(false);
            this.grbPwd.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.GroupBox grbLesDeveloppeurs;
        private System.Windows.Forms.DataGridView dgvDeveloppeurs;
        private System.Windows.Forms.Button BtnDemandeSupprDev;
        private System.Windows.Forms.Button BtnDemandeChangePwd;
        private System.Windows.Forms.Button BtnDemandeModifDev;
        private System.Windows.Forms.GroupBox grbDeveloppeur;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Button BtnAnnulDev;
        private System.Windows.Forms.Button BtnEnregDev;
        private System.Windows.Forms.Label lblProfil;
        private System.Windows.Forms.ComboBox cboProfil;
        private System.Windows.Forms.GroupBox grbPwd;
        private System.Windows.Forms.Button BtnAnnulPwd;
        private System.Windows.Forms.Button BtnEnregPwd;
        private System.Windows.Forms.Label lblEncore;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.TextBox txtPwd1;
        private System.Windows.Forms.Label lblFiltrProfil;
        private System.Windows.Forms.ComboBox cboFiltrProfil;
    }
}

