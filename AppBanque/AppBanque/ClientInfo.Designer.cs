
namespace AppBanque
{
    partial class ClientInfo
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
            this.infonom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.infoprenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.indoadresse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infonom
            // 
            this.infonom.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.infonom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infonom.Location = new System.Drawing.Point(141, 43);
            this.infonom.Name = "infonom";
            this.infonom.Size = new System.Drawing.Size(100, 13);
            this.infonom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenom";
            // 
            // infoprenom
            // 
            this.infoprenom.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.infoprenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoprenom.Location = new System.Drawing.Point(141, 85);
            this.infoprenom.Name = "infoprenom";
            this.infoprenom.Size = new System.Drawing.Size(100, 13);
            this.infoprenom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adresse";
            // 
            // indoadresse
            // 
            this.indoadresse.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.indoadresse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.indoadresse.Location = new System.Drawing.Point(141, 134);
            this.indoadresse.Name = "indoadresse";
            this.indoadresse.Size = new System.Drawing.Size(100, 13);
            this.indoadresse.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Les Comptes";
            // 
            // ClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.indoadresse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.infoprenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infonom);
            this.Name = "ClientInfo";
            this.Text = "ClientInfo";
            this.Load += new System.EventHandler(this.ClientInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox infonom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox infoprenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox indoadresse;
        private System.Windows.Forms.Label label4;
    }
}