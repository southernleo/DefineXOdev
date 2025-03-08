namespace WinFormsapp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblSonuc = new Label();
            txtSoyadi = new TextBox();
            txtBolum = new TextBox();
            txtAdi = new TextBox();
            btnDogrula = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(175, 150);
            label1.Name = "label1";
            label1.Size = new Size(32, 18);
            label1.TabIndex = 0;
            label1.Text = "ADI";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(409, 154);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 1;
            label2.Text = "BÖLÜM";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(175, 210);
            label3.Name = "label3";
            label3.Size = new Size(63, 18);
            label3.TabIndex = 2;
            label3.Text = "SOYADI";
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSonuc.Location = new Point(244, 268);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(445, 44);
            lblSonuc.TabIndex = 3;
            lblSonuc.Text = "\r\n                                                                                       ";
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(244, 204);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(125, 27);
            txtSoyadi.TabIndex = 4;
            // 
            // txtBolum
            // 
            txtBolum.Location = new Point(497, 145);
            txtBolum.Name = "txtBolum";
            txtBolum.Size = new Size(125, 27);
            txtBolum.TabIndex = 5;
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(244, 145);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(125, 27);
            txtAdi.TabIndex = 6;
            // 
            // btnDogrula
            // 
            btnDogrula.BackColor = SystemColors.ActiveCaption;
            btnDogrula.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDogrula.Location = new Point(497, 202);
            btnDogrula.Name = "btnDogrula";
            btnDogrula.Size = new Size(125, 32);
            btnDogrula.TabIndex = 7;
            btnDogrula.Text = "Dogrula";
            btnDogrula.UseVisualStyleBackColor = false;
            btnDogrula.Click += btnDogrula_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 509);
            Controls.Add(btnDogrula);
            Controls.Add(txtAdi);
            Controls.Add(txtBolum);
            Controls.Add(txtSoyadi);
            Controls.Add(lblSonuc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblSonuc;
        private TextBox txtSoyadi;
        private TextBox txtBolum;
        private TextBox txtAdi;
        private Button btnDogrula;
    }
}
