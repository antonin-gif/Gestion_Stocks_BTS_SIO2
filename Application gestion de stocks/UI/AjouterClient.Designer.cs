
namespace Application_gestion_de_stocks
{
    partial class AjouterClient
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
            this.telClient = new System.Windows.Forms.TextBox();
            this.prenomCli = new System.Windows.Forms.TextBox();
            this.nomClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjoutCli = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // telClient
            // 
            this.telClient.Location = new System.Drawing.Point(312, 166);
            this.telClient.Name = "telClient";
            this.telClient.Size = new System.Drawing.Size(160, 27);
            this.telClient.TabIndex = 15;
            this.telClient.TextChanged += new System.EventHandler(this.emailFournisseur_TextChanged);
            // 
            // prenomCli
            // 
            this.prenomCli.Location = new System.Drawing.Point(312, 133);
            this.prenomCli.Name = "prenomCli";
            this.prenomCli.Size = new System.Drawing.Size(160, 27);
            this.prenomCli.TabIndex = 14;
            // 
            // nomClient
            // 
            this.nomClient.Location = new System.Drawing.Point(312, 100);
            this.nomClient.Name = "nomClient";
            this.nomClient.Size = new System.Drawing.Size(160, 27);
            this.nomClient.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telephone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prenom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom";
            // 
            // btnAjoutCli
            // 
            this.btnAjoutCli.Location = new System.Drawing.Point(105, 301);
            this.btnAjoutCli.Name = "btnAjoutCli";
            this.btnAjoutCli.Size = new System.Drawing.Size(367, 29);
            this.btnAjoutCli.TabIndex = 16;
            this.btnAjoutCli.Text = "Ajouter le client";
            this.btnAjoutCli.UseVisualStyleBackColor = true;
            this.btnAjoutCli.Click += new System.EventHandler(this.ajouterCli_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(105, 235);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(50, 20);
            this.lbError.TabIndex = 17;
            this.lbError.Text = "label4";
            this.lbError.Visible = false;
            // 
            // AjouterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnAjoutCli);
            this.Controls.Add(this.telClient);
            this.Controls.Add(this.prenomCli);
            this.Controls.Add(this.nomClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjouterClient";
            this.Text = "Ajouter un client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox telClient;
        private System.Windows.Forms.TextBox prenomCli;
        private System.Windows.Forms.TextBox nomClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAjoutCli;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button ajouterCli;
    }
}