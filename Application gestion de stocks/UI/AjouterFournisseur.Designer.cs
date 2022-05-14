
namespace Application_gestion_de_stocks
{
    partial class AjouterFournisseur
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomFournisseur = new System.Windows.Forms.TextBox();
            this.adresseFournisseur = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.emailFournisseur = new System.Windows.Forms.TextBox();
            this.telFournisseur = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adresse email";
            // 
            // nomFournisseur
            // 
            this.nomFournisseur.Location = new System.Drawing.Point(312, 100);
            this.nomFournisseur.Name = "nomFournisseur";
            this.nomFournisseur.Size = new System.Drawing.Size(160, 27);
            this.nomFournisseur.TabIndex = 5;
            // 
            // adresseFournisseur
            // 
            this.adresseFournisseur.Location = new System.Drawing.Point(312, 133);
            this.adresseFournisseur.Name = "adresseFournisseur";
            this.adresseFournisseur.Size = new System.Drawing.Size(160, 27);
            this.adresseFournisseur.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(367, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ajouter le fournisseur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(37, 248);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(832, 20);
            this.lbError.TabIndex = 10;
            this.lbError.Text = "Erreur de saisie. Les champs doivent être composés d\'au moins 3 caractères et le " +
    "telephone ne doit contenir que 10 numéros.";
            this.lbError.Visible = false;
            this.lbError.Click += new System.EventHandler(this.lbError_Click);
            // 
            // emailFournisseur
            // 
            this.emailFournisseur.Location = new System.Drawing.Point(312, 166);
            this.emailFournisseur.Name = "emailFournisseur";
            this.emailFournisseur.Size = new System.Drawing.Size(160, 27);
            this.emailFournisseur.TabIndex = 7;
            // 
            // telFournisseur
            // 
            this.telFournisseur.Location = new System.Drawing.Point(312, 199);
            this.telFournisseur.Name = "telFournisseur";
            this.telFournisseur.Size = new System.Drawing.Size(160, 27);
            this.telFournisseur.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telephone";
            // 
            // AjouterFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.telFournisseur);
            this.Controls.Add(this.emailFournisseur);
            this.Controls.Add(this.adresseFournisseur);
            this.Controls.Add(this.nomFournisseur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjouterFournisseur";
            this.Text = "Ajouter un fournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomFournisseur;
        private System.Windows.Forms.TextBox adresseFournisseur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.TextBox emailFournisseur;
        private System.Windows.Forms.TextBox telFournisseur;
        private System.Windows.Forms.Label label4;
    }
}