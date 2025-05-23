namespace mediatek86.view
{
    partial class FrmAuthentification
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
            this.txtPwd = new System.Windows.Forms.Label();
            this.txbLogin = new System.Windows.Forms.TextBox();
            this.txbPwd = new System.Windows.Forms.TextBox();
            this.btnConnection = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblErreur = new System.Windows.Forms.Label();
            this.btnCredits = new System.Windows.Forms.Button();
            this.btnProbleme = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPwd
            // 
            this.txtPwd.AutoSize = true;
            this.txtPwd.Location = new System.Drawing.Point(11, 154);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(77, 13);
            this.txtPwd.TabIndex = 2;
            this.txtPwd.Text = "Mot de passe :";
            // 
            // txbLogin
            // 
            this.txbLogin.Location = new System.Drawing.Point(92, 121);
            this.txbLogin.Name = "txbLogin";
            this.txbLogin.Size = new System.Drawing.Size(188, 20);
            this.txbLogin.TabIndex = 3;
            // 
            // txbPwd
            // 
            this.txbPwd.Location = new System.Drawing.Point(92, 147);
            this.txbPwd.Name = "txbPwd";
            this.txbPwd.PasswordChar = '*';
            this.txbPwd.Size = new System.Drawing.Size(188, 20);
            this.txbPwd.TabIndex = 5;
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(92, 204);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(113, 35);
            this.btnConnection.TabIndex = 6;
            this.btnConnection.Text = "Se connecter";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(11, 124);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(39, 13);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Login :";
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.ForeColor = System.Drawing.Color.Red;
            this.lblErreur.Location = new System.Drawing.Point(14, 181);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(10, 13);
            this.lblErreur.TabIndex = 8;
            this.lblErreur.Text = " ";
            // 
            // btnCredits
            // 
            this.btnCredits.Location = new System.Drawing.Point(11, 216);
            this.btnCredits.Name = "btnCredits";
            this.btnCredits.Size = new System.Drawing.Size(75, 23);
            this.btnCredits.TabIndex = 9;
            this.btnCredits.Text = "Crédits";
            this.btnCredits.UseVisualStyleBackColor = true;
            this.btnCredits.Click += new System.EventHandler(this.btnCredits_Click);
            // 
            // btnProbleme
            // 
            this.btnProbleme.BackColor = System.Drawing.Color.White;
            this.btnProbleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbleme.Location = new System.Drawing.Point(213, 204);
            this.btnProbleme.Name = "btnProbleme";
            this.btnProbleme.Size = new System.Drawing.Size(75, 35);
            this.btnProbleme.TabIndex = 10;
            this.btnProbleme.Text = "Signaler un problème";
            this.btnProbleme.UseVisualStyleBackColor = false;
            this.btnProbleme.Click += new System.EventHandler(this.btnProbleme_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::mediatek86.Properties.Resources.mediatek86;
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAuthentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 245);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnProbleme);
            this.Controls.Add(this.btnCredits);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.txbPwd);
            this.Controls.Add(this.txbLogin);
            this.Controls.Add(this.txtPwd);
            this.Name = "FrmAuthentification";
            this.Text = "MediaTek86 - Connexion";
            this.Load += new System.EventHandler(this.FrmAuthentification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtPwd;
        private System.Windows.Forms.TextBox txbLogin;
        private System.Windows.Forms.TextBox txbPwd;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.Button btnCredits;
        private System.Windows.Forms.Button btnProbleme;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}