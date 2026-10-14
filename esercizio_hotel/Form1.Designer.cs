namespace esercizio_hotel
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
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
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.cmb_n1 = new System.Windows.Forms.ComboBox();
            this.cmb_n2 = new System.Windows.Forms.ComboBox();
            this.lbl_n4 = new System.Windows.Forms.Label();
            this.chk_n1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nud_n1 = new System.Windows.Forms.NumericUpDown();
            this.btn_n1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_n1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Location = new System.Drawing.Point(246, 22);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(145, 26);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "Benvenuto, prenota un hotel:\r\nprezzo base: 15€";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Location = new System.Drawing.Point(83, 91);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(62, 13);
            this.lbl_n2.TabIndex = 1;
            this.lbl_n2.Text = "Tipo stanza";
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Location = new System.Drawing.Point(411, 90);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(49, 13);
            this.lbl_n3.TabIndex = 2;
            this.lbl_n3.Text = "Stagione";
            // 
            // cmb_n1
            // 
            this.cmb_n1.FormattingEnabled = true;
            this.cmb_n1.Items.AddRange(new object[] {
            "- Base",
            "- Media",
            "- Alta"});
            this.cmb_n1.Location = new System.Drawing.Point(86, 117);
            this.cmb_n1.Name = "cmb_n1";
            this.cmb_n1.Size = new System.Drawing.Size(121, 21);
            this.cmb_n1.TabIndex = 3;
            this.cmb_n1.Text = "Seleziona";
            // 
            // cmb_n2
            // 
            this.cmb_n2.FormattingEnabled = true;
            this.cmb_n2.Items.AddRange(new object[] {
            "- Bassa stagione",
            "- Media stagione",
            "- Alta stagione"});
            this.cmb_n2.Location = new System.Drawing.Point(355, 117);
            this.cmb_n2.Name = "cmb_n2";
            this.cmb_n2.Size = new System.Drawing.Size(121, 21);
            this.cmb_n2.TabIndex = 4;
            this.cmb_n2.Text = "Seleziona";
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.Location = new System.Drawing.Point(222, 165);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(84, 13);
            this.lbl_n4.TabIndex = 5;
            this.lbl_n4.Text = "Giorni prenotati?";
            // 
            // chk_n1
            // 
            this.chk_n1.AutoSize = true;
            this.chk_n1.Location = new System.Drawing.Point(197, 220);
            this.chk_n1.Name = "chk_n1";
            this.chk_n1.Size = new System.Drawing.Size(142, 17);
            this.chk_n1.TabIndex = 6;
            this.chk_n1.Text = "Parcheggio privato (+5€)";
            this.chk_n1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // nud_n1
            // 
            this.nud_n1.Location = new System.Drawing.Point(197, 181);
            this.nud_n1.Name = "nud_n1";
            this.nud_n1.Size = new System.Drawing.Size(120, 20);
            this.nud_n1.TabIndex = 9;
            // 
            // btn_n1
            // 
            this.btn_n1.Location = new System.Drawing.Point(185, 279);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(149, 23);
            this.btn_n1.TabIndex = 10;
            this.btn_n1.Text = "Prenota l\'hotel";
            this.btn_n1.UseVisualStyleBackColor = true;
            this.btn_n1.Click += new System.EventHandler(this.btn_n1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.btn_n1);
            this.Controls.Add(this.nud_n1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chk_n1);
            this.Controls.Add(this.lbl_n4);
            this.Controls.Add(this.cmb_n2);
            this.Controls.Add(this.cmb_n1);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_n1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.ComboBox cmb_n1;
        private System.Windows.Forms.ComboBox cmb_n2;
        private System.Windows.Forms.Label lbl_n4;
        private System.Windows.Forms.CheckBox chk_n1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nud_n1;
        private System.Windows.Forms.Button btn_n1;
    }
}

