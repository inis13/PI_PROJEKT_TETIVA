namespace PI
{
    partial class Otpremnica
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
            this.dgvOtpremniceUbazi = new System.Windows.Forms.DataGridView();
            this.btnKreiranjeOtpremnice = new System.Windows.Forms.Button();
            this.btnIspisOtpremnice = new System.Windows.Forms.Button();
            this.btnBrisanjeOtpremnice = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtpremniceUbazi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOtpremniceUbazi
            // 
            this.dgvOtpremniceUbazi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtpremniceUbazi.Location = new System.Drawing.Point(109, 77);
            this.dgvOtpremniceUbazi.Name = "dgvOtpremniceUbazi";
            this.dgvOtpremniceUbazi.Size = new System.Drawing.Size(601, 325);
            this.dgvOtpremniceUbazi.TabIndex = 0;
            // 
            // btnKreiranjeOtpremnice
            // 
            this.btnKreiranjeOtpremnice.Location = new System.Drawing.Point(13, 85);
            this.btnKreiranjeOtpremnice.Name = "btnKreiranjeOtpremnice";
            this.btnKreiranjeOtpremnice.Size = new System.Drawing.Size(75, 47);
            this.btnKreiranjeOtpremnice.TabIndex = 1;
            this.btnKreiranjeOtpremnice.Text = "Kreiranje otpremnice";
            this.btnKreiranjeOtpremnice.UseVisualStyleBackColor = true;
            // 
            // btnIspisOtpremnice
            // 
            this.btnIspisOtpremnice.Location = new System.Drawing.Point(13, 149);
            this.btnIspisOtpremnice.Name = "btnIspisOtpremnice";
            this.btnIspisOtpremnice.Size = new System.Drawing.Size(75, 47);
            this.btnIspisOtpremnice.TabIndex = 2;
            this.btnIspisOtpremnice.Text = "Ispis otpremnice";
            this.btnIspisOtpremnice.UseVisualStyleBackColor = true;
            this.btnIspisOtpremnice.Click += new System.EventHandler(this.btnIspisOtpremnice_Click);
            // 
            // btnBrisanjeOtpremnice
            // 
            this.btnBrisanjeOtpremnice.Location = new System.Drawing.Point(13, 213);
            this.btnBrisanjeOtpremnice.Name = "btnBrisanjeOtpremnice";
            this.btnBrisanjeOtpremnice.Size = new System.Drawing.Size(75, 47);
            this.btnBrisanjeOtpremnice.TabIndex = 3;
            this.btnBrisanjeOtpremnice.Text = "Brisanje otpremnice";
            this.btnBrisanjeOtpremnice.UseVisualStyleBackColor = true;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(615, 12);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 42);
            this.btnIzlaz.TabIndex = 4;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "gumbicicicic";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Otpremnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 414);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnBrisanjeOtpremnice);
            this.Controls.Add(this.btnIspisOtpremnice);
            this.Controls.Add(this.btnKreiranjeOtpremnice);
            this.Controls.Add(this.dgvOtpremniceUbazi);
            this.Name = "Otpremnica";
            this.Text = "Pregled otpremnica";
            this.Load += new System.EventHandler(this.Otpremnica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtpremniceUbazi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOtpremniceUbazi;
        private System.Windows.Forms.Button btnKreiranjeOtpremnice;
        private System.Windows.Forms.Button btnIspisOtpremnice;
        private System.Windows.Forms.Button btnBrisanjeOtpremnice;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button button1;
    }
}