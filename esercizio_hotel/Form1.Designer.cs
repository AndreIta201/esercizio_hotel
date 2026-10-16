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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.cmb_n1 = new System.Windows.Forms.ComboBox();
            this.cmb_n2 = new System.Windows.Forms.ComboBox();
            this.lbl_n4 = new System.Windows.Forms.Label();
            this.chk_n1 = new System.Windows.Forms.CheckBox();
            this.nud_n1 = new System.Windows.Forms.NumericUpDown();
            this.btn_n1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_info = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_n1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_n1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.Location = new System.Drawing.Point(298, 9);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(420, 68);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "Benvenuto, prenota un hotel:\r\nprezzo base: 15€";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_n2.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.Location = new System.Drawing.Point(431, 108);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(114, 28);
            this.lbl_n2.TabIndex = 1;
            this.lbl_n2.Text = "Tipo stanza";
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_n3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n3.Location = new System.Drawing.Point(431, 196);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(86, 28);
            this.lbl_n3.TabIndex = 2;
            this.lbl_n3.Text = "Stagione";
            // 
            // cmb_n1
            // 
            this.cmb_n1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_n1.FormattingEnabled = true;
            this.cmb_n1.Items.AddRange(new object[] {
            "Base",
            "Media",
            "Alta"});
            this.cmb_n1.Location = new System.Drawing.Point(371, 154);
            this.cmb_n1.Name = "cmb_n1";
            this.cmb_n1.Size = new System.Drawing.Size(258, 39);
            this.cmb_n1.TabIndex = 3;
            this.cmb_n1.Text = "Seleziona";
            // 
            // cmb_n2
            // 
            this.cmb_n2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_n2.FormattingEnabled = true;
            this.cmb_n2.Items.AddRange(new object[] {
            "Bassa stagione",
            "Media stagione",
            "Alta stagione"});
            this.cmb_n2.Location = new System.Drawing.Point(371, 228);
            this.cmb_n2.Name = "cmb_n2";
            this.cmb_n2.Size = new System.Drawing.Size(258, 39);
            this.cmb_n2.TabIndex = 4;
            this.cmb_n2.Text = "Seleziona";
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_n4.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n4.Location = new System.Drawing.Point(404, 298);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(160, 28);
            this.lbl_n4.TabIndex = 5;
            this.lbl_n4.Text = "Giorni prenotati?";
            // 
            // chk_n1
            // 
            this.chk_n1.AutoSize = true;
            this.chk_n1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chk_n1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_n1.Location = new System.Drawing.Point(342, 407);
            this.chk_n1.Name = "chk_n1";
            this.chk_n1.Size = new System.Drawing.Size(291, 37);
            this.chk_n1.TabIndex = 6;
            this.chk_n1.Text = "Parcheggio privato (+5€/g)";
            this.chk_n1.UseVisualStyleBackColor = false;
            // 
            // nud_n1
            // 
            this.nud_n1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nud_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_n1.Location = new System.Drawing.Point(452, 330);
            this.nud_n1.Name = "nud_n1";
            this.nud_n1.Size = new System.Drawing.Size(89, 38);
            this.nud_n1.TabIndex = 9;
            // 
            // btn_n1
            // 
            this.btn_n1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_n1.Font = new System.Drawing.Font("Old English Text MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_n1.Location = new System.Drawing.Point(393, 500);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(210, 76);
            this.btn_n1.TabIndex = 10;
            this.btn_n1.Text = "Prenota l\'hotel";
            this.btn_n1.UseVisualStyleBackColor = false;
            this.btn_n1.Click += new System.EventHandler(this.btn_n1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.imageList1.Images.SetKeyName(0, "wifi (no ip).png");
            this.imageList1.Images.SetKeyName(1, "Screenshot 2026-10-11 203314.png");
            this.imageList1.Images.SetKeyName(2, "Screenshot 2026-10-09 222151.png");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(28, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 278);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_info.Location = new System.Drawing.Point(28, 13);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(35, 30);
            this.btn_info.TabIndex = 15;
            this.btn_info.Text = "?";
            this.btn_info.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::esercizio_hotel.Properties.Resources.hotel3;
            this.ClientSize = new System.Drawing.Size(1162, 826);
            this.Controls.Add(this.btn_info);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_n1);
            this.Controls.Add(this.nud_n1);
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
        private System.Windows.Forms.NumericUpDown nud_n1;
        private System.Windows.Forms.Button btn_n1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_info;
    }
}

