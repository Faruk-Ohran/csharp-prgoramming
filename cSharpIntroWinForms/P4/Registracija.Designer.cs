namespace cSharpIntroWinForms
{
    partial class Registracija
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUcitajSliku = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbSlikaKorisnika = new System.Windows.Forms.PictureBox();
            this.ofdUcitajSliku = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaKorisnika)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(177, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(177, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPrezime.Location = new System.Drawing.Point(294, 67);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(245, 27);
            this.txtPrezime.TabIndex = 6;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIme.Location = new System.Drawing.Point(294, 22);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(245, 27);
            this.txtIme.TabIndex = 5;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(177, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Lozinka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(177, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Korisničko ime:";
            // 
            // txtLozinka
            // 
            this.txtLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLozinka.Location = new System.Drawing.Point(294, 154);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.ReadOnly = true;
            this.txtLozinka.Size = new System.Drawing.Size(210, 27);
            this.txtLozinka.TabIndex = 10;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKorisnickoIme.Location = new System.Drawing.Point(294, 109);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.ReadOnly = true;
            this.txtKorisnickoIme.Size = new System.Drawing.Size(245, 27);
            this.txtKorisnickoIme.TabIndex = 9;
            // 
            // btnSpasi
            // 
            this.btnSpasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpasi.Location = new System.Drawing.Point(446, 187);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(93, 28);
            this.btnSpasi.TabIndex = 13;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // btnUcitajSliku
            // 
            this.btnUcitajSliku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUcitajSliku.Location = new System.Drawing.Point(12, 187);
            this.btnUcitajSliku.Name = "btnUcitajSliku";
            this.btnUcitajSliku.Size = new System.Drawing.Size(150, 28);
            this.btnUcitajSliku.TabIndex = 15;
            this.btnUcitajSliku.Text = "Ucitaj sliku";
            this.btnUcitajSliku.UseVisualStyleBackColor = true;
            this.btnUcitajSliku.Click += new System.EventHandler(this.btnUcitajSliku_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::cSharpIntroWinForms.Properties.Resources.eye;
            this.pictureBox2.Location = new System.Drawing.Point(510, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbSlikaKorisnika
            // 
            this.pbSlikaKorisnika.Location = new System.Drawing.Point(13, 22);
            this.pbSlikaKorisnika.Name = "pbSlikaKorisnika";
            this.pbSlikaKorisnika.Size = new System.Drawing.Size(149, 159);
            this.pbSlikaKorisnika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlikaKorisnika.TabIndex = 14;
            this.pbSlikaKorisnika.TabStop = false;
            // 
            // ofdUcitajSliku
            // 
            this.ofdUcitajSliku.FileName = "openFileDialog1";
            // 
            // Registracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 221);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnUcitajSliku);
            this.Controls.Add(this.pbSlikaKorisnika);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnickoIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Name = "Registracija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registracija";
            this.Load += new System.EventHandler(this.Registracija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaKorisnika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnUcitajSliku;
        private System.Windows.Forms.PictureBox pbSlikaKorisnika;
        private System.Windows.Forms.OpenFileDialog ofdUcitajSliku;
    }
}