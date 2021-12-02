
namespace Calculator
{
    partial class Hasil_Perhitungan
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
            this.Hasil = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lsv = new System.Windows.Forms.ListView();
            this.btn1 = new System.Windows.Forms.Button();
            this.Hasil.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hasil
            // 
            this.Hasil.Controls.Add(this.lsv);
            this.Hasil.Location = new System.Drawing.Point(27, 42);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(289, 251);
            this.Hasil.TabIndex = 0;
            this.Hasil.TabStop = false;
            this.Hasil.Text = "Hasil";
            // 
            // lsv
            // 
            this.lsv.HideSelection = false;
            this.lsv.Location = new System.Drawing.Point(28, 37);
            this.lsv.Name = "lsv";
            this.lsv.Size = new System.Drawing.Size(236, 188);
            this.lsv.TabIndex = 0;
            this.lsv.UseCompatibleStateImageBehavior = false;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(150, 315);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Hitung";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Hasil_Perhitungan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 355);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.Hasil);
            this.Name = "Hasil_Perhitungan";
            this.Text = "Hasil Perhitungan";
            this.Hasil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Hasil;
        private System.Windows.Forms.ListView lsv;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn1;
    }
}