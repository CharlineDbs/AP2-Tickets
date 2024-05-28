namespace reservationSalles2018
{
    partial class frmFacturationReservations
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
            this.lbxReserv = new System.Windows.Forms.ListBox();
            this.lblLigue = new System.Windows.Forms.Label();
            this.cbxLigues = new System.Windows.Forms.ComboBox();
            this.lblMois = new System.Windows.Forms.Label();
            this.cbxMois = new System.Windows.Forms.ComboBox();
            this.lblMontantTotal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNbtotal = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 42);
            this.label1.TabIndex = 71;
            this.label1.Text = "Statistiques réservations ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbxReserv
            // 
            this.lbxReserv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxReserv.FormattingEnabled = true;
            this.lbxReserv.ItemHeight = 25;
            this.lbxReserv.Location = new System.Drawing.Point(582, 141);
            this.lbxReserv.Margin = new System.Windows.Forms.Padding(4);
            this.lbxReserv.Name = "lbxReserv";
            this.lbxReserv.Size = new System.Drawing.Size(612, 329);
            this.lbxReserv.TabIndex = 72;
            this.lbxReserv.SelectedIndexChanged += new System.EventHandler(this.lbxSalles_SelectedIndexChanged);
            // 
            // lblLigue
            // 
            this.lblLigue.AutoSize = true;
            this.lblLigue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLigue.Location = new System.Drawing.Point(30, 170);
            this.lblLigue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLigue.Name = "lblLigue";
            this.lblLigue.Size = new System.Drawing.Size(60, 25);
            this.lblLigue.TabIndex = 74;
            this.lblLigue.Text = "Ligue";
            // 
            // cbxLigues
            // 
            this.cbxLigues.FormattingEnabled = true;
            this.cbxLigues.Location = new System.Drawing.Point(160, 170);
            this.cbxLigues.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLigues.Name = "cbxLigues";
            this.cbxLigues.Size = new System.Drawing.Size(279, 24);
            this.cbxLigues.TabIndex = 73;
            // 
            // lblMois
            // 
            this.lblMois.AutoSize = true;
            this.lblMois.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMois.Location = new System.Drawing.Point(30, 250);
            this.lblMois.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMois.Name = "lblMois";
            this.lblMois.Size = new System.Drawing.Size(54, 25);
            this.lblMois.TabIndex = 75;
            this.lblMois.Text = "Mois";
            this.lblMois.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbxMois
            // 
            this.cbxMois.FormattingEnabled = true;
            this.cbxMois.Location = new System.Drawing.Point(160, 250);
            this.cbxMois.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMois.Name = "cbxMois";
            this.cbxMois.Size = new System.Drawing.Size(279, 24);
            this.cbxMois.TabIndex = 76;
            // 
            // lblMontantTotal
            // 
            this.lblMontantTotal.AutoSize = true;
            this.lblMontantTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantTotal.Location = new System.Drawing.Point(30, 420);
            this.lblMontantTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontantTotal.Name = "lblMontantTotal";
            this.lblMontantTotal.Size = new System.Drawing.Size(129, 50);
            this.lblMontantTotal.TabIndex = 77;
            this.lblMontantTotal.Text = "Montant total \r\nréservations";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 78;
            // 
            // lblNbtotal
            // 
            this.lblNbtotal.AutoSize = true;
            this.lblNbtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbtotal.Location = new System.Drawing.Point(30, 335);
            this.lblNbtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNbtotal.Name = "lblNbtotal";
            this.lblNbtotal.Size = new System.Drawing.Size(132, 50);
            this.lblNbtotal.TabIndex = 79;
            this.lblNbtotal.Text = "Nombres total\r\nréservations\r\n";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 436);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 80;
            // 
            // frmFacturationReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 570);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNbtotal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMontantTotal);
            this.Controls.Add(this.cbxMois);
            this.Controls.Add(this.lblMois);
            this.Controls.Add(this.lblLigue);
            this.Controls.Add(this.cbxLigues);
            this.Controls.Add(this.lbxReserv);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFacturationReservations";
            this.Text = "Facturation Reservations";
            this.Load += new System.EventHandler(this.frmFacturationReservations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxReserv;
        private System.Windows.Forms.Label lblLigue;
        private System.Windows.Forms.ComboBox cbxLigues;
        private System.Windows.Forms.Label lblMois;
        private System.Windows.Forms.ComboBox cbxMois;
        private System.Windows.Forms.Label lblMontantTotal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNbtotal;
        private System.Windows.Forms.TextBox textBox2;
    }
}