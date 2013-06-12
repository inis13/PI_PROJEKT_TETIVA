namespace PI
{
    partial class Narudzbenice
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
            this.btnOdobriNarudzbenicu = new System.Windows.Forms.Button();
            this.btnIspisNarudzbenice = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOdobriNarudzbenicu
            // 
            this.btnOdobriNarudzbenicu.Location = new System.Drawing.Point(38, 118);
            this.btnOdobriNarudzbenicu.Name = "btnOdobriNarudzbenicu";
            this.btnOdobriNarudzbenicu.Size = new System.Drawing.Size(87, 38);
            this.btnOdobriNarudzbenicu.TabIndex = 0;
            this.btnOdobriNarudzbenicu.Text = "Odobri narudzbenicu";
            this.btnOdobriNarudzbenicu.UseVisualStyleBackColor = true;
            // 
            // btnIspisNarudzbenice
            // 
            this.btnIspisNarudzbenice.Location = new System.Drawing.Point(38, 196);
            this.btnIspisNarudzbenice.Name = "btnIspisNarudzbenice";
            this.btnIspisNarudzbenice.Size = new System.Drawing.Size(87, 39);
            this.btnIspisNarudzbenice.TabIndex = 1;
            this.btnIspisNarudzbenice.Text = "Ispis narudzbenice";
            this.btnIspisNarudzbenice.UseVisualStyleBackColor = true;
            this.btnIspisNarudzbenice.Click += new System.EventHandler(this.btnIspisNarudzbenice_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(377, 30);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(87, 37);
            this.btnIzlaz.TabIndex = 2;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(150, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(313, 166);
            this.dataGridView1.TabIndex = 3;
            // 
            // Narudzbenice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 262);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnIspisNarudzbenice);
            this.Controls.Add(this.btnOdobriNarudzbenicu);
            this.Name = "Narudzbenice";
            this.Text = "Pregled narudzbenice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOdobriNarudzbenicu;
        private System.Windows.Forms.Button btnIspisNarudzbenice;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}