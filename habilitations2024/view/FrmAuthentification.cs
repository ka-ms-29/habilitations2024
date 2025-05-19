﻿using habilitations2024.controller;
using habilitations2024.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace habilitations2024.view
{
    public partial class FrmAuthentification : Form
    {
        private FrmAuthentificationController controller;
        public FrmAuthentification()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            controller = new FrmAuthentificationController();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string pwd = txtPwd.Text;
            if (String.IsNullOrEmpty(nom) || String.IsNullOrEmpty(prenom) || String.IsNullOrEmpty(pwd) )
            {
                MessageBox.Show("Tous les champs doievent etre remplis", "Information");
                
            }
            else
            {
                Admin admin = new Admin(nom, prenom, pwd);
                if (controller.ControleAuthentification(admin))
                {
                    FrmHabilitations frm = new FrmHabilitations();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte, vous etes pas admin","Alert");
                }

            }

        }
    }
}
