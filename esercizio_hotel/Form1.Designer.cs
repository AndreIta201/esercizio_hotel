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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcb_n2 = new System.Windows.Forms.PictureBox();
            this.pcb_n1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_n1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_n2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_n1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.Location = new System.Drawing.Point(298, 9);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(455, 74);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "Benvenuto, prenota un hotel:\r\nprezzo base: 15€";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.Location = new System.Drawing.Point(431, 108);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(137, 29);
            this.lbl_n2.TabIndex = 1;
            this.lbl_n2.Text = "Tipo stanza";
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n3.Location = new System.Drawing.Point(447, 196);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(109, 29);
            this.lbl_n3.TabIndex = 2;
            this.lbl_n3.Text = "Stagione";
            // 
            // cmb_n1
            // 
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
            this.lbl_n4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n4.Location = new System.Drawing.Point(404, 298);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(190, 29);
            this.lbl_n4.TabIndex = 5;
            this.lbl_n4.Text = "Giorni prenotati?";
            // 
            // chk_n1
            // 
            this.chk_n1.AutoSize = true;
            this.chk_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_n1.Location = new System.Drawing.Point(342, 407);
            this.chk_n1.Name = "chk_n1";
            this.chk_n1.Size = new System.Drawing.Size(353, 35);
            this.chk_n1.TabIndex = 6;
            this.chk_n1.Text = "Parcheggio privato (+5€/g)";
            this.chk_n1.UseVisualStyleBackColor = true;
            // 
            // nud_n1
            // 
            this.nud_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_n1.Location = new System.Drawing.Point(452, 330);
            this.nud_n1.Name = "nud_n1";
            this.nud_n1.Size = new System.Drawing.Size(89, 38);
            this.nud_n1.TabIndex = 9;
            // 
            // btn_n1
            // 
            this.btn_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_n1.Location = new System.Drawing.Point(393, 500);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(210, 76);
            this.btn_n1.TabIndex = 10;
            this.btn_n1.Text = "Prenota l\'hotel";
            this.btn_n1.UseVisualStyleBackColor = true;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::esercizio_hotel.Properties.Resources.hotel3;
            this.pictureBox1.Location = new System.Drawing.Point(805, 595);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pcb_n2
            // 
            this.pcb_n2.Image = global::esercizio_hotel.Properties.Resources.hotel2;
            this.pcb_n2.Location = new System.Drawing.Point(805, 322);
            this.pcb_n2.Name = "pcb_n2";
            this.pcb_n2.Size = new System.Drawing.Size(340, 220);
            this.pcb_n2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_n2.TabIndex = 12;
            this.pcb_n2.TabStop = false;
            // 
            // pcb_n1
            // 
            this.pcb_n1.Image = global::esercizio_hotel.Properties.Resources.hotel1;
            this.pcb_n1.Location = new System.Drawing.Point(805, 35);
            this.pcb_n1.Name = "pcb_n1";
            this.pcb_n1.Size = new System.Drawing.Size(340, 232);
            this.pcb_n1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_n1.TabIndex = 11;
            this.pcb_n1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 826);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pcb_n2);
            this.Controls.Add(this.pcb_n1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_n2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_n1)).EndInit();
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
        private System.Windows.Forms.PictureBox pcb_n1;
        private System.Windows.Forms.PictureBox pcb_n2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

