namespace CDC
{
    partial class frmCDC
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblDa = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.ofdDatabase = new System.Windows.Forms.OpenFileDialog();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtPercorso = new System.Windows.Forms.TextBox();
            this.btnSfoglia = new System.Windows.Forms.Button();
            this.btnConverti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Access"});
            this.comboBox1.Location = new System.Drawing.Point(28, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "MongoDB"});
            this.comboBox2.Location = new System.Drawing.Point(197, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // lblDa
            // 
            this.lblDa.AutoSize = true;
            this.lblDa.Location = new System.Drawing.Point(78, 33);
            this.lblDa.Name = "lblDa";
            this.lblDa.Size = new System.Drawing.Size(27, 13);
            this.lblDa.TabIndex = 2;
            this.lblDa.Text = "Da: ";
            // 
            // lblA
            // 
            this.lblA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(255, 33);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(20, 13);
            this.lblA.TabIndex = 3;
            this.lblA.Text = "A: ";
            // 
            // ofdDatabase
            // 
            this.ofdDatabase.FileName = "openFileDialog1";
            this.ofdDatabase.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdDatabase_FileOk);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(113, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(120, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Converti il tuo Database";
            // 
            // txtPercorso
            // 
            this.txtPercorso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPercorso.Location = new System.Drawing.Point(12, 121);
            this.txtPercorso.Name = "txtPercorso";
            this.txtPercorso.ReadOnly = true;
            this.txtPercorso.Size = new System.Drawing.Size(322, 20);
            this.txtPercorso.TabIndex = 5;
            this.txtPercorso.TextChanged += new System.EventHandler(this.txtPercorso_TextChanged);
            // 
            // btnSfoglia
            // 
            this.btnSfoglia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSfoglia.Location = new System.Drawing.Point(136, 92);
            this.btnSfoglia.Name = "btnSfoglia";
            this.btnSfoglia.Size = new System.Drawing.Size(75, 23);
            this.btnSfoglia.TabIndex = 6;
            this.btnSfoglia.Text = "Sfoglia";
            this.btnSfoglia.UseVisualStyleBackColor = true;
            this.btnSfoglia.Click += new System.EventHandler(this.btnSfoglia_Click);
            // 
            // btnConverti
            // 
            this.btnConverti.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConverti.Location = new System.Drawing.Point(136, 157);
            this.btnConverti.Name = "btnConverti";
            this.btnConverti.Size = new System.Drawing.Size(75, 23);
            this.btnConverti.TabIndex = 7;
            this.btnConverti.Text = "Converti";
            this.btnConverti.UseVisualStyleBackColor = true;
            // 
            // frmCDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 199);
            this.Controls.Add(this.btnConverti);
            this.Controls.Add(this.btnSfoglia);
            this.Controls.Add(this.txtPercorso);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.lblDa);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCDC";
            this.Text = "COMMoDE Database Converter";
            this.Load += new System.EventHandler(this.frmCDC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblDa;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.OpenFileDialog ofdDatabase;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtPercorso;
        private System.Windows.Forms.Button btnSfoglia;
        private System.Windows.Forms.Button btnConverti;
    }
}

