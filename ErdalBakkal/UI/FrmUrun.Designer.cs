namespace ErdalBakkal.UI
{
    partial class FrmUrun
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
            this.components = new System.ComponentModel.Container();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.txtdetay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txturad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbkategori = new System.Windows.Forms.ComboBox();
            this.cbmiktar = new System.Windows.Forms.ComboBox();
            this.nmstok = new System.Windows.Forms.NumericUpDown();
            this.nmfiyat = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmstok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmfiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(473, 550);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(94, 29);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "İptal";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(360, 550);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(94, 29);
            this.btnok.TabIndex = 7;
            this.btnok.Text = "Tamam";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtdetay
            // 
            this.txtdetay.Location = new System.Drawing.Point(198, 366);
            this.txtdetay.Multiline = true;
            this.txtdetay.Name = "txtdetay";
            this.txtdetay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtdetay.Size = new System.Drawing.Size(369, 144);
            this.txtdetay.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Detay :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stok Miktarı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kategori :";
            // 
            // txturad
            // 
            this.txturad.Location = new System.Drawing.Point(198, 76);
            this.txturad.Name = "txturad";
            this.txturad.Size = new System.Drawing.Size(369, 27);
            this.txturad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ad :";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(198, 23);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(369, 27);
            this.txtid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Birim :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fiyat :";
            // 
            // cbkategori
            // 
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Items.AddRange(new object[] {
            "Su ve İçecek",
            "Meyve ve Sebze",
            "Atıştırmalık",
            "Temel Gıda",
            "Kahvaltılık",
            "Süt Ürünleri",
            "Ev Bakımı"});
            this.cbkategori.Location = new System.Drawing.Point(198, 138);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(369, 28);
            this.cbkategori.TabIndex = 2;
            // 
            // cbmiktar
            // 
            this.cbmiktar.FormattingEnabled = true;
            this.cbmiktar.Items.AddRange(new object[] {
            "Kilogram",
            "Metre",
            "Adet"});
            this.cbmiktar.Location = new System.Drawing.Point(198, 310);
            this.cbmiktar.Name = "cbmiktar";
            this.cbmiktar.Size = new System.Drawing.Size(369, 28);
            this.cbmiktar.TabIndex = 5;
            // 
            // nmstok
            // 
            this.nmstok.DecimalPlaces = 2;
            this.nmstok.Location = new System.Drawing.Point(198, 254);
            this.nmstok.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nmstok.Name = "nmstok";
            this.nmstok.Size = new System.Drawing.Size(369, 27);
            this.nmstok.TabIndex = 4;
            // 
            // nmfiyat
            // 
            this.nmfiyat.DecimalPlaces = 2;
            this.nmfiyat.Location = new System.Drawing.Point(198, 198);
            this.nmfiyat.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nmfiyat.Name = "nmfiyat";
            this.nmfiyat.Size = new System.Drawing.Size(369, 27);
            this.nmfiyat.TabIndex = 3;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmUrun
            // 
            this.AcceptButton = this.btnok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(679, 647);
            this.Controls.Add(this.nmfiyat);
            this.Controls.Add(this.nmstok);
            this.Controls.Add(this.cbmiktar);
            this.Controls.Add(this.cbkategori);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtdetay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txturad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmUrun";
            ((System.ComponentModel.ISupportInitialize)(this.nmstok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmfiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btncancel;
        private Button btnok;
        private TextBox txtdetay;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txturad;
        private Label label2;
        private TextBox txtid;
        private Label label1;
        private Label label6;
        private Label label7;
        private ComboBox cbkategori;
        private ComboBox cbmiktar;
        private NumericUpDown nmstok;
        private NumericUpDown nmfiyat;
        private ErrorProvider errorProvider1;
    }
}