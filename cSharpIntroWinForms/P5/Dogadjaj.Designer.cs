namespace cSharpIntroWinForms.P5
{
    partial class Dogadjaj
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbBHTelcom = new System.Windows.Forms.CheckBox();
            this.cbEronet = new System.Windows.Forms.CheckBox();
            this.txtPoruka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(174, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salji SMS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbBHTelcom
            // 
            this.cbBHTelcom.AutoSize = true;
            this.cbBHTelcom.Location = new System.Drawing.Point(20, 54);
            this.cbBHTelcom.Name = "cbBHTelcom";
            this.cbBHTelcom.Size = new System.Drawing.Size(85, 17);
            this.cbBHTelcom.TabIndex = 1;
            this.cbBHTelcom.Text = "BH Telecom";
            this.cbBHTelcom.UseVisualStyleBackColor = true;
            this.cbBHTelcom.CheckedChanged += new System.EventHandler(this.cbBHTelcom_CheckedChanged);
            // 
            // cbEronet
            // 
            this.cbEronet.AutoSize = true;
            this.cbEronet.Location = new System.Drawing.Point(111, 54);
            this.cbEronet.Name = "cbEronet";
            this.cbEronet.Size = new System.Drawing.Size(57, 17);
            this.cbEronet.TabIndex = 2;
            this.cbEronet.Text = "Eronet";
            this.cbEronet.UseVisualStyleBackColor = true;
            this.cbEronet.CheckedChanged += new System.EventHandler(this.cbEronet_CheckedChanged);
            // 
            // txtPoruka
            // 
            this.txtPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPoruka.Location = new System.Drawing.Point(20, 28);
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(148, 23);
            this.txtPoruka.TabIndex = 3;
            this.txtPoruka.TextChanged += new System.EventHandler(this.txtPoruka_TextChanged);
            // 
            // Dogadjaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 96);
            this.Controls.Add(this.txtPoruka);
            this.Controls.Add(this.cbEronet);
            this.Controls.Add(this.cbBHTelcom);
            this.Controls.Add(this.button1);
            this.Name = "Dogadjaj";
            this.Text = "Dogadjaj";
            this.Load += new System.EventHandler(this.Dogadjaj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbBHTelcom;
        private System.Windows.Forms.CheckBox cbEronet;
        private System.Windows.Forms.TextBox txtPoruka;
    }
}