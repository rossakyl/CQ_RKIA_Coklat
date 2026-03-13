namespace PraktikumADO
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnHitungMhs = new System.Windows.Forms.Button();
            this.btnHitungMK = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnLatihan1 = new System.Windows.Forms.Button();
            this.btnLatihan2 = new System.Windows.Forms.Button();
            this.btnLatihan3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasil";
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(213, 118);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(100, 22);
            this.txtHasil.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(115, 273);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(102, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnHitungMhs
            // 
            this.btnHitungMhs.Location = new System.Drawing.Point(269, 272);
            this.btnHitungMhs.Name = "btnHitungMhs";
            this.btnHitungMhs.Size = new System.Drawing.Size(107, 23);
            this.btnHitungMhs.TabIndex = 3;
            this.btnHitungMhs.Text = "Hitung Mhs";
            this.btnHitungMhs.UseVisualStyleBackColor = true;
            this.btnHitungMhs.Click += new System.EventHandler(this.btnHitungMhs_Click);
            // 
            // btnHitungMK
            // 
            this.btnHitungMK.Location = new System.Drawing.Point(437, 272);
            this.btnHitungMK.Name = "btnHitungMK";
            this.btnHitungMK.Size = new System.Drawing.Size(96, 23);
            this.btnHitungMK.TabIndex = 4;
            this.btnHitungMK.Text = "Hitung MK";
            this.btnHitungMK.UseVisualStyleBackColor = true;
            this.btnHitungMK.Click += new System.EventHandler(this.btnHitungMK_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(594, 272);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnLatihan1
            // 
            this.btnLatihan1.Location = new System.Drawing.Point(115, 371);
            this.btnLatihan1.Name = "btnLatihan1";
            this.btnLatihan1.Size = new System.Drawing.Size(107, 23);
            this.btnLatihan1.TabIndex = 6;
            this.btnLatihan1.Text = "Latihan 1";
            this.btnLatihan1.UseVisualStyleBackColor = true;
            this.btnLatihan1.Click += new System.EventHandler(this.btnLatihan1_Click);
            // 
            // btnLatihan2
            // 
            this.btnLatihan2.Location = new System.Drawing.Point(280, 371);
            this.btnLatihan2.Name = "btnLatihan2";
            this.btnLatihan2.Size = new System.Drawing.Size(96, 23);
            this.btnLatihan2.TabIndex = 7;
            this.btnLatihan2.Text = "Latihan 2";
            this.btnLatihan2.UseVisualStyleBackColor = true;
            this.btnLatihan2.Click += new System.EventHandler(this.btnLatihan2_Click);
            // 
            // btnLatihan3
            // 
            this.btnLatihan3.Location = new System.Drawing.Point(437, 371);
            this.btnLatihan3.Name = "btnLatihan3";
            this.btnLatihan3.Size = new System.Drawing.Size(96, 23);
            this.btnLatihan3.TabIndex = 8;
            this.btnLatihan3.Text = "Latihan 3";
            this.btnLatihan3.UseVisualStyleBackColor = true;
            this.btnLatihan3.Click += new System.EventHandler(this.btnLatihan3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLatihan3);
            this.Controls.Add(this.btnLatihan2);
            this.Controls.Add(this.btnLatihan1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnHitungMK);
            this.Controls.Add(this.btnHitungMhs);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnHitungMhs;
        private System.Windows.Forms.Button btnHitungMK;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnLatihan1;
        private System.Windows.Forms.Button btnLatihan2;
        private System.Windows.Forms.Button btnLatihan3;
    }
}

