
namespace Application_gestion_de_stocks
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLancerApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailAdmin = new System.Windows.Forms.TextBox();
            this.mdpAdmin = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLancerApp
            // 
            this.btnLancerApp.Location = new System.Drawing.Point(51, 226);
            this.btnLancerApp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLancerApp.Name = "btnLancerApp";
            this.btnLancerApp.Size = new System.Drawing.Size(320, 22);
            this.btnLancerApp.TabIndex = 1;
            this.btnLancerApp.Text = "Lancer l\'application";
            this.btnLancerApp.UseVisualStyleBackColor = true;
            this.btnLancerApp.Visible = false;
            this.btnLancerApp.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de passe";
            // 
            // emailAdmin
            // 
            this.emailAdmin.Location = new System.Drawing.Point(208, 95);
            this.emailAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailAdmin.Name = "emailAdmin";
            this.emailAdmin.Size = new System.Drawing.Size(163, 23);
            this.emailAdmin.TabIndex = 4;
            // 
            // mdpAdmin
            // 
            this.mdpAdmin.Location = new System.Drawing.Point(208, 130);
            this.mdpAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mdpAdmin.Name = "mdpAdmin";
            this.mdpAdmin.PasswordChar = '*';
            this.mdpAdmin.Size = new System.Drawing.Size(163, 23);
            this.mdpAdmin.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(51, 193);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(320, 22);
            this.button3.TabIndex = 6;
            this.button3.Text = "Me connecter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(51, 160);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(149, 15);
            this.lbError.TabIndex = 7;
            this.lbError.Text = "Authentification incorrecte";
            this.lbError.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bienvenue sur notre application de gestion de stocks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 281);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mdpAdmin);
            this.Controls.Add(this.emailAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLancerApp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLancerApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailAdmin;
        private System.Windows.Forms.TextBox mdpAdmin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label label3;
    }
}

