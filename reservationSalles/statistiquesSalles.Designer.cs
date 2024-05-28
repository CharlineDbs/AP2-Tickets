
namespace reservationSalles2018
{
    partial class frmStatistiquesSalles
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
            this.cbxMois = new System.Windows.Forms.ComboBox();
            this.lblMois = new System.Windows.Forms.Label();
            this.lbxStatsSalles = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNbtotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMontantTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 42);
            this.label1.TabIndex = 73;
            this.label1.Text = "Statistiques par salles";
            // 
            // cbxMois
            // 
            this.cbxMois.FormattingEnabled = true;
            this.cbxMois.Location = new System.Drawing.Point(106, 148);
            this.cbxMois.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMois.Name = "cbxMois";
            this.cbxMois.Size = new System.Drawing.Size(279, 24);
            this.cbxMois.TabIndex = 78;
            // 
            // lblMois
            // 
            this.lblMois.AutoSize = true;
            this.lblMois.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMois.Location = new System.Drawing.Point(26, 147);
            this.lblMois.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMois.Name = "lblMois";
            this.lblMois.Size = new System.Drawing.Size(54, 25);
            this.lblMois.TabIndex = 77;
            this.lblMois.Text = "Mois";
            // 
            // lbxStatsSalles
            // 
            this.lbxStatsSalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxStatsSalles.FormattingEnabled = true;
            this.lbxStatsSalles.ItemHeight = 25;
            this.lbxStatsSalles.Location = new System.Drawing.Point(443, 136);
            this.lbxStatsSalles.Margin = new System.Windows.Forms.Padding(4);
            this.lbxStatsSalles.Name = "lbxStatsSalles";
            this.lbxStatsSalles.Size = new System.Drawing.Size(612, 329);
            this.lbxStatsSalles.TabIndex = 79;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(162, 360);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 84;
            // 
            // lblNbtotal
            // 
            this.lblNbtotal.AutoSize = true;
            this.lblNbtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbtotal.Location = new System.Drawing.Point(26, 259);
            this.lblNbtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbtotal.Name = "lblNbtotal";
            this.lblNbtotal.Size = new System.Drawing.Size(132, 50);
            this.lblNbtotal.TabIndex = 83;
            this.lblNbtotal.Text = "Nombres total\r\nréservations\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(162, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 82;
            // 
            // lblMontantTotal
            // 
            this.lblMontantTotal.AutoSize = true;
            this.lblMontantTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantTotal.Location = new System.Drawing.Point(26, 344);
            this.lblMontantTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontantTotal.Name = "lblMontantTotal";
            this.lblMontantTotal.Size = new System.Drawing.Size(129, 50);
            this.lblMontantTotal.TabIndex = 81;
            this.lblMontantTotal.Text = "Montant total \r\nréservations";
            // 
            // frmStatistiquesSalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNbtotal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMontantTotal);
            this.Controls.Add(this.lbxStatsSalles);
            this.Controls.Add(this.cbxMois);
            this.Controls.Add(this.lblMois);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStatistiquesSalles";
            this.Text = "statistiquesSalles";
            this.Load += new System.EventHandler(this.frmStatistiquesSalles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMois;
        private System.Windows.Forms.Label lblMois;
        private System.Windows.Forms.ListBox lbxStatsSalles;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblNbtotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMontantTotal;
    }
}