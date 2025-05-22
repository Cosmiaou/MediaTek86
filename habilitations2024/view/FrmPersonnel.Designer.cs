namespace mediatek86.view
{
    partial class FrmPersonnel
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
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.btnAbsence = new System.Windows.Forms.Button();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.dgwDonnees = new System.Windows.Forms.DataGridView();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifierItem = new System.Windows.Forms.Button();
            this.grbAjouterPerso = new System.Windows.Forms.GroupBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.txbTel = new System.Windows.Forms.TextBox();
            this.txbMail = new System.Windows.Forms.TextBox();
            this.txbPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txbNom = new System.Windows.Forms.TextBox();
            this.btnAnnulerPersonnel = new System.Windows.Forms.Button();
            this.btnAjouterPersonnel = new System.Windows.Forms.Button();
            this.tbcControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grbModifierAbsence = new System.Windows.Forms.GroupBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.lblMotif = new System.Windows.Forms.Label();
            this.cmbMotif = new System.Windows.Forms.ComboBox();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.btnAnnulerAbsence = new System.Windows.Forms.Button();
            this.btnEnregistrerAbsence = new System.Windows.Forms.Button();
            this.grbAbsence = new System.Windows.Forms.GroupBox();
            this.btnRetour = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwAbsence = new System.Windows.Forms.DataGridView();
            this.btnSupprimerAbsence = new System.Windows.Forms.Button();
            this.btnModifierAbsence = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.grbPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDonnees)).BeginInit();
            this.grbAjouterPerso.SuspendLayout();
            this.tbcControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grbModifierAbsence.SuspendLayout();
            this.grbAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAbsence)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.btnAjout);
            this.grbPersonnel.Controls.Add(this.btnAbsence);
            this.grbPersonnel.Controls.Add(this.lblConfirm);
            this.grbPersonnel.Controls.Add(this.dgwDonnees);
            this.grbPersonnel.Controls.Add(this.btnSupprimer);
            this.grbPersonnel.Controls.Add(this.btnModifierItem);
            this.grbPersonnel.Location = new System.Drawing.Point(5, 6);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(553, 177);
            this.grbPersonnel.TabIndex = 0;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "Personnels";
            // 
            // btnAbsence
            // 
            this.btnAbsence.Enabled = false;
            this.btnAbsence.Location = new System.Drawing.Point(425, 148);
            this.btnAbsence.Name = "btnAbsence";
            this.btnAbsence.Size = new System.Drawing.Size(120, 23);
            this.btnAbsence.TabIndex = 5;
            this.btnAbsence.Text = "Voir les absences";
            this.btnAbsence.UseVisualStyleBackColor = true;
            this.btnAbsence.Click += new System.EventHandler(this.btnAbsence_Click);
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(423, 153);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(0, 13);
            this.lblConfirm.TabIndex = 4;
            // 
            // dgwDonnees
            // 
            this.dgwDonnees.AllowUserToAddRows = false;
            this.dgwDonnees.AllowUserToDeleteRows = false;
            this.dgwDonnees.AllowUserToResizeColumns = false;
            this.dgwDonnees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwDonnees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDonnees.Location = new System.Drawing.Point(10, 21);
            this.dgwDonnees.MultiSelect = false;
            this.dgwDonnees.Name = "dgwDonnees";
            this.dgwDonnees.ReadOnly = true;
            this.dgwDonnees.RowHeadersVisible = false;
            this.dgwDonnees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDonnees.Size = new System.Drawing.Size(535, 121);
            this.dgwDonnees.TabIndex = 3;
            this.dgwDonnees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwDonnees_CellContentClick);
            this.dgwDonnees.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgwDonnees_MouseClick);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Enabled = false;
            this.btnSupprimer.Location = new System.Drawing.Point(198, 148);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(88, 23);
            this.btnSupprimer.TabIndex = 1;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifierItem
            // 
            this.btnModifierItem.Enabled = false;
            this.btnModifierItem.Location = new System.Drawing.Point(104, 148);
            this.btnModifierItem.Name = "btnModifierItem";
            this.btnModifierItem.Size = new System.Drawing.Size(88, 23);
            this.btnModifierItem.TabIndex = 0;
            this.btnModifierItem.Text = "Modifier";
            this.btnModifierItem.UseVisualStyleBackColor = true;
            this.btnModifierItem.Click += new System.EventHandler(this.btnModifierItem_Click);
            // 
            // grbAjouterPerso
            // 
            this.grbAjouterPerso.Controls.Add(this.lblTel);
            this.grbAjouterPerso.Controls.Add(this.lblMail);
            this.grbAjouterPerso.Controls.Add(this.lblService);
            this.grbAjouterPerso.Controls.Add(this.cmbService);
            this.grbAjouterPerso.Controls.Add(this.txbTel);
            this.grbAjouterPerso.Controls.Add(this.txbMail);
            this.grbAjouterPerso.Controls.Add(this.txbPrenom);
            this.grbAjouterPerso.Controls.Add(this.lblPrenom);
            this.grbAjouterPerso.Controls.Add(this.lblNom);
            this.grbAjouterPerso.Controls.Add(this.txbNom);
            this.grbAjouterPerso.Controls.Add(this.btnAnnulerPersonnel);
            this.grbAjouterPerso.Controls.Add(this.btnAjouterPersonnel);
            this.grbAjouterPerso.Enabled = false;
            this.grbAjouterPerso.Location = new System.Drawing.Point(5, 189);
            this.grbAjouterPerso.Name = "grbAjouterPerso";
            this.grbAjouterPerso.Size = new System.Drawing.Size(553, 105);
            this.grbAjouterPerso.TabIndex = 1;
            this.grbAjouterPerso.TabStop = false;
            this.grbAjouterPerso.Text = "Ajouter un personnel :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(273, 50);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(115, 13);
            this.lblTel.TabIndex = 14;
            this.lblTel.Text = "Numéro de téléphone :";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(273, 25);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(41, 13);
            this.lblMail.TabIndex = 14;
            this.lblMail.Text = "E-mail :";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(352, 81);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(49, 13);
            this.lblService.TabIndex = 13;
            this.lblService.Text = "Service :";
            // 
            // cmbService
            // 
            this.cmbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(407, 76);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(138, 21);
            this.cmbService.TabIndex = 12;
            // 
            // txbTel
            // 
            this.txbTel.Location = new System.Drawing.Point(407, 47);
            this.txbTel.Name = "txbTel";
            this.txbTel.Size = new System.Drawing.Size(138, 20);
            this.txbTel.TabIndex = 11;
            // 
            // txbMail
            // 
            this.txbMail.Location = new System.Drawing.Point(361, 22);
            this.txbMail.Name = "txbMail";
            this.txbMail.Size = new System.Drawing.Size(184, 20);
            this.txbMail.TabIndex = 10;
            // 
            // txbPrenom
            // 
            this.txbPrenom.Location = new System.Drawing.Point(70, 45);
            this.txbPrenom.Name = "txbPrenom";
            this.txbPrenom.Size = new System.Drawing.Size(100, 20);
            this.txbPrenom.TabIndex = 9;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(7, 50);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblPrenom.TabIndex = 8;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(7, 22);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 7;
            this.lblNom.Text = "Nom :";
            // 
            // txbNom
            // 
            this.txbNom.Location = new System.Drawing.Point(70, 19);
            this.txbNom.Name = "txbNom";
            this.txbNom.Size = new System.Drawing.Size(100, 20);
            this.txbNom.TabIndex = 7;
            // 
            // btnAnnulerPersonnel
            // 
            this.btnAnnulerPersonnel.Location = new System.Drawing.Point(105, 76);
            this.btnAnnulerPersonnel.Name = "btnAnnulerPersonnel";
            this.btnAnnulerPersonnel.Size = new System.Drawing.Size(93, 23);
            this.btnAnnulerPersonnel.TabIndex = 6;
            this.btnAnnulerPersonnel.Text = "Annuler";
            this.btnAnnulerPersonnel.UseVisualStyleBackColor = true;
            this.btnAnnulerPersonnel.Click += new System.EventHandler(this.btnAnnulerPerso_Click);
            // 
            // btnAjouterPersonnel
            // 
            this.btnAjouterPersonnel.Location = new System.Drawing.Point(6, 76);
            this.btnAjouterPersonnel.Name = "btnAjouterPersonnel";
            this.btnAjouterPersonnel.Size = new System.Drawing.Size(93, 23);
            this.btnAjouterPersonnel.TabIndex = 6;
            this.btnAjouterPersonnel.Text = "Enregistrer";
            this.btnAjouterPersonnel.UseVisualStyleBackColor = true;
            this.btnAjouterPersonnel.Click += new System.EventHandler(this.btnAjouterPerso_Click);
            // 
            // tbcControl
            // 
            this.tbcControl.Controls.Add(this.tabPage1);
            this.tbcControl.Controls.Add(this.tabPage2);
            this.tbcControl.Location = new System.Drawing.Point(3, 7);
            this.tbcControl.Name = "tbcControl";
            this.tbcControl.SelectedIndex = 0;
            this.tbcControl.Size = new System.Drawing.Size(569, 343);
            this.tbcControl.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grbAjouterPerso);
            this.tabPage1.Controls.Add(this.grbPersonnel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(561, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grbModifierAbsence);
            this.tabPage2.Controls.Add(this.grbAbsence);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(561, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grbModifierAbsence
            // 
            this.grbModifierAbsence.Controls.Add(this.dtpFin);
            this.grbModifierAbsence.Controls.Add(this.lblDateFin);
            this.grbModifierAbsence.Controls.Add(this.dtpDebut);
            this.grbModifierAbsence.Controls.Add(this.lblMotif);
            this.grbModifierAbsence.Controls.Add(this.cmbMotif);
            this.grbModifierAbsence.Controls.Add(this.lblDateDebut);
            this.grbModifierAbsence.Controls.Add(this.btnAnnulerAbsence);
            this.grbModifierAbsence.Controls.Add(this.btnEnregistrerAbsence);
            this.grbModifierAbsence.Location = new System.Drawing.Point(5, 189);
            this.grbModifierAbsence.Name = "grbModifierAbsence";
            this.grbModifierAbsence.Size = new System.Drawing.Size(553, 105);
            this.grbModifierAbsence.TabIndex = 2;
            this.grbModifierAbsence.TabStop = false;
            this.grbModifierAbsence.Text = "Ajouter une absence :";
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(93, 45);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 17;
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(7, 48);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(65, 13);
            this.lblDateFin.TabIndex = 16;
            this.lblDateFin.Text = "Date de fin :";
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(93, 19);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDebut.TabIndex = 15;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(352, 24);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(36, 13);
            this.lblMotif.TabIndex = 13;
            this.lblMotif.Text = "Motif :";
            // 
            // cmbMotif
            // 
            this.cmbMotif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotif.FormattingEnabled = true;
            this.cmbMotif.Location = new System.Drawing.Point(407, 19);
            this.cmbMotif.Name = "cmbMotif";
            this.cmbMotif.Size = new System.Drawing.Size(138, 21);
            this.cmbMotif.TabIndex = 12;
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(7, 22);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(81, 13);
            this.lblDateDebut.TabIndex = 7;
            this.lblDateDebut.Text = "Date de début :";
            // 
            // btnAnnulerAbsence
            // 
            this.btnAnnulerAbsence.Location = new System.Drawing.Point(105, 76);
            this.btnAnnulerAbsence.Name = "btnAnnulerAbsence";
            this.btnAnnulerAbsence.Size = new System.Drawing.Size(93, 23);
            this.btnAnnulerAbsence.TabIndex = 6;
            this.btnAnnulerAbsence.Text = "Annuler";
            this.btnAnnulerAbsence.UseVisualStyleBackColor = true;
            this.btnAnnulerAbsence.Click += new System.EventHandler(this.btnAnnulerAbsence_Click);
            // 
            // btnEnregistrerAbsence
            // 
            this.btnEnregistrerAbsence.Location = new System.Drawing.Point(6, 76);
            this.btnEnregistrerAbsence.Name = "btnEnregistrerAbsence";
            this.btnEnregistrerAbsence.Size = new System.Drawing.Size(93, 23);
            this.btnEnregistrerAbsence.TabIndex = 6;
            this.btnEnregistrerAbsence.Text = "Enregistrer";
            this.btnEnregistrerAbsence.UseVisualStyleBackColor = true;
            this.btnEnregistrerAbsence.Click += new System.EventHandler(this.btnEnregistrerAbsence_Click);
            // 
            // grbAbsence
            // 
            this.grbAbsence.Controls.Add(this.btnRetour);
            this.grbAbsence.Controls.Add(this.label1);
            this.grbAbsence.Controls.Add(this.dgwAbsence);
            this.grbAbsence.Controls.Add(this.btnSupprimerAbsence);
            this.grbAbsence.Controls.Add(this.btnModifierAbsence);
            this.grbAbsence.Location = new System.Drawing.Point(5, 6);
            this.grbAbsence.Name = "grbAbsence";
            this.grbAbsence.Size = new System.Drawing.Size(553, 177);
            this.grbAbsence.TabIndex = 1;
            this.grbAbsence.TabStop = false;
            this.grbAbsence.Text = "Absences";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(410, 148);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(135, 23);
            this.btnRetour.TabIndex = 5;
            this.btnRetour.Text = "Retourner au personnel";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // dgwAbsence
            // 
            this.dgwAbsence.AllowUserToAddRows = false;
            this.dgwAbsence.AllowUserToDeleteRows = false;
            this.dgwAbsence.AllowUserToResizeColumns = false;
            this.dgwAbsence.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwAbsence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAbsence.Location = new System.Drawing.Point(10, 21);
            this.dgwAbsence.MultiSelect = false;
            this.dgwAbsence.Name = "dgwAbsence";
            this.dgwAbsence.ReadOnly = true;
            this.dgwAbsence.RowHeadersVisible = false;
            this.dgwAbsence.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwAbsence.Size = new System.Drawing.Size(535, 121);
            this.dgwAbsence.TabIndex = 3;
            this.dgwAbsence.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAbsence_CellContentClick);
            // 
            // btnSupprimerAbsence
            // 
            this.btnSupprimerAbsence.Enabled = false;
            this.btnSupprimerAbsence.Location = new System.Drawing.Point(104, 148);
            this.btnSupprimerAbsence.Name = "btnSupprimerAbsence";
            this.btnSupprimerAbsence.Size = new System.Drawing.Size(88, 23);
            this.btnSupprimerAbsence.TabIndex = 1;
            this.btnSupprimerAbsence.Text = "Supprimer";
            this.btnSupprimerAbsence.UseVisualStyleBackColor = true;
            this.btnSupprimerAbsence.Click += new System.EventHandler(this.btnSupprimerAbsence_Click);
            // 
            // btnModifierAbsence
            // 
            this.btnModifierAbsence.Enabled = false;
            this.btnModifierAbsence.Location = new System.Drawing.Point(10, 148);
            this.btnModifierAbsence.Name = "btnModifierAbsence";
            this.btnModifierAbsence.Size = new System.Drawing.Size(88, 23);
            this.btnModifierAbsence.TabIndex = 0;
            this.btnModifierAbsence.Text = "Modifier";
            this.btnModifierAbsence.UseVisualStyleBackColor = true;
            this.btnModifierAbsence.Click += new System.EventHandler(this.btnModifierAbsence_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.Location = new System.Drawing.Point(11, 148);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(88, 23);
            this.btnAjout.TabIndex = 6;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // FrmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 353);
            this.Controls.Add(this.tbcControl);
            this.Name = "FrmPersonnel";
            this.Text = "MediaTek86 - gestion du personnel V0.5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbPersonnel.ResumeLayout(false);
            this.grbPersonnel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDonnees)).EndInit();
            this.grbAjouterPerso.ResumeLayout(false);
            this.grbAjouterPerso.PerformLayout();
            this.tbcControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.grbModifierAbsence.ResumeLayout(false);
            this.grbModifierAbsence.PerformLayout();
            this.grbAbsence.ResumeLayout(false);
            this.grbAbsence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAbsence)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPersonnel;
        private System.Windows.Forms.GroupBox grbAjouterPerso;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifierItem;
        private System.Windows.Forms.Button btnAjouterPersonnel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.TextBox txbTel;
        private System.Windows.Forms.TextBox txbMail;
        private System.Windows.Forms.TextBox txbPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txbNom;
        private System.Windows.Forms.Button btnAnnulerPersonnel;
        private System.Windows.Forms.DataGridView dgwDonnees;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Button btnAbsence;
        private System.Windows.Forms.TabControl tbcControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grbAbsence;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwAbsence;
        private System.Windows.Forms.Button btnSupprimerAbsence;
        private System.Windows.Forms.Button btnModifierAbsence;
        private System.Windows.Forms.GroupBox grbModifierAbsence;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.ComboBox cmbMotif;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.Button btnAnnulerAbsence;
        private System.Windows.Forms.Button btnEnregistrerAbsence;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.Button btnAjout;
    }
}

