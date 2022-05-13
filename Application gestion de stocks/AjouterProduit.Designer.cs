
namespace Application_gestion_de_stocks
{
    partial class AjouterProduit
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
            this.lbError = new System.Windows.Forms.Label();
            this.btnAjoutCli = new System.Windows.Forms.Button();
            this.prixProd = new System.Windows.Forms.TextBox();
            this.txtPoidsPdt = new System.Windows.Forms.TextBox();
            this.tbNomPdt = new System.Windows.Forms.TextBox();
            this.poidsProd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomProd = new System.Windows.Forms.Label();
            this.alleeProd = new System.Windows.Forms.TextBox();
            this.placeProd = new System.Windows.Forms.TextBox();
            this.etageProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(105, 308);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(50, 20);
            this.lbError.TabIndex = 25;
            this.lbError.Text = "label4";
            this.lbError.Visible = false;
            // 
            // btnAjoutCli
            // 
            this.btnAjoutCli.Location = new System.Drawing.Point(105, 363);
            this.btnAjoutCli.Name = "btnAjoutCli";
            this.btnAjoutCli.Size = new System.Drawing.Size(367, 29);
            this.btnAjoutCli.TabIndex = 24;
            this.btnAjoutCli.Text = "Ajouter le produit";
            this.btnAjoutCli.UseVisualStyleBackColor = true;
            this.btnAjoutCli.Click += new System.EventHandler(this.btnAjoutCli_Click);
            // 
            // prixProd
            // 
            this.prixProd.Location = new System.Drawing.Point(312, 165);
            this.prixProd.Name = "prixProd";
            this.prixProd.Size = new System.Drawing.Size(159, 27);
            this.prixProd.TabIndex = 23;
            // 
            // txtPoidsPdt
            // 
            this.txtPoidsPdt.Location = new System.Drawing.Point(312, 133);
            this.txtPoidsPdt.Name = "txtPoidsPdt";
            this.txtPoidsPdt.Size = new System.Drawing.Size(159, 27);
            this.txtPoidsPdt.TabIndex = 22;
            // 
            // tbNomPdt
            // 
            this.tbNomPdt.Location = new System.Drawing.Point(312, 100);
            this.tbNomPdt.Name = "tbNomPdt";
            this.tbNomPdt.Size = new System.Drawing.Size(159, 27);
            this.tbNomPdt.TabIndex = 21;
            // 
            // poidsProd
            // 
            this.poidsProd.AutoSize = true;
            this.poidsProd.Location = new System.Drawing.Point(105, 136);
            this.poidsProd.Name = "poidsProd";
            this.poidsProd.Size = new System.Drawing.Size(148, 20);
            this.poidsProd.TabIndex = 20;
            this.poidsProd.Text = "Poids du produit (kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Prix de vente";
            // 
            // nomProd
            // 
            this.nomProd.AutoSize = true;
            this.nomProd.Location = new System.Drawing.Point(105, 103);
            this.nomProd.Name = "nomProd";
            this.nomProd.Size = new System.Drawing.Size(115, 20);
            this.nomProd.TabIndex = 18;
            this.nomProd.Text = "Nom du Produit";
            // 
            // alleeProd
            // 
            this.alleeProd.Location = new System.Drawing.Point(312, 199);
            this.alleeProd.Name = "alleeProd";
            this.alleeProd.Size = new System.Drawing.Size(159, 27);
            this.alleeProd.TabIndex = 26;
            // 
            // placeProd
            // 
            this.placeProd.Location = new System.Drawing.Point(312, 235);
            this.placeProd.Name = "placeProd";
            this.placeProd.Size = new System.Drawing.Size(159, 27);
            this.placeProd.TabIndex = 27;
            // 
            // etageProd
            // 
            this.etageProd.Location = new System.Drawing.Point(312, 268);
            this.etageProd.Name = "etageProd";
            this.etageProd.Size = new System.Drawing.Size(159, 27);
            this.etageProd.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nom allée";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Numéro place";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Numéro étage";
            // 
            // AjouterProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.etageProd);
            this.Controls.Add(this.placeProd);
            this.Controls.Add(this.alleeProd);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnAjoutCli);
            this.Controls.Add(this.prixProd);
            this.Controls.Add(this.txtPoidsPdt);
            this.Controls.Add(this.tbNomPdt);
            this.Controls.Add(this.poidsProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomProd);
            this.Name = "AjouterProduit";
            this.Text = "Ajouter un produit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Button btnAjoutCli;
        private System.Windows.Forms.TextBox prixProd;
        private System.Windows.Forms.TextBox txtPoidsPdt;
        private System.Windows.Forms.TextBox tbNomPdt;
        private System.Windows.Forms.Label poidsProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nomProd;
        private System.Windows.Forms.TextBox alleeProd;
        private System.Windows.Forms.TextBox placeProd;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox placeAlle;
        private System.Windows.Forms.TextBox etageProd;
    }
}