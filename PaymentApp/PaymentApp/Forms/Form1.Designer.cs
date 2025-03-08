namespace PaymentApp
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
            lblMakePayment = new Label();
            lblPaymentMethod1 = new Label();
            cmbPaymentMethod = new ComboBox();
            lblAmountToPay = new Label();
            txtAmountToPay = new TextBox();
            btnCompletePayment = new Button();
            pnlRightSide = new Panel();
            lblPaymentMethodTitle = new Label();
            txtPaymentMethod = new TextBox();
            btnAddPaymentMethod = new Button();
            dgvPayments = new DataGridView();
            colPaymentMethod = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colPaymentDate = new DataGridViewTextBoxColumn();
            pnlRightSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();
            // 
            // lblMakePayment
            // 
            lblMakePayment.AutoSize = true;
            lblMakePayment.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMakePayment.Location = new Point(89, 99);
            lblMakePayment.Name = "lblMakePayment";
            lblMakePayment.Size = new Size(170, 28);
            lblMakePayment.TabIndex = 0;
            lblMakePayment.Text = "Make a Payment";
            // 
            // lblPaymentMethod1
            // 
            lblPaymentMethod1.AutoSize = true;
            lblPaymentMethod1.Location = new Point(89, 164);
            lblPaymentMethod1.Name = "lblPaymentMethod1";
            lblPaymentMethod1.Size = new Size(121, 20);
            lblPaymentMethod1.TabIndex = 1;
            lblPaymentMethod1.Text = "Payment Method";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Credit Card", "Kredi Kartı", "Banka Kartı", "Havale/EFT", "PayPal", "Bitcoin", "Ethereum", "Apple Pay", "Papara", "Ininal" });
            cmbPaymentMethod.Location = new Point(342, 164);
            cmbPaymentMethod.Margin = new Padding(3, 4, 3, 4);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(212, 28);
            cmbPaymentMethod.TabIndex = 2;
            cmbPaymentMethod.Text = "Credit Card";
            // 
            // lblAmountToPay
            // 
            lblAmountToPay.AutoSize = true;
            lblAmountToPay.Location = new Point(89, 245);
            lblAmountToPay.Name = "lblAmountToPay";
            lblAmountToPay.Size = new Size(106, 20);
            lblAmountToPay.TabIndex = 3;
            lblAmountToPay.Text = "Amount to Pay";
            // 
            // txtAmountToPay
            // 
            txtAmountToPay.Location = new Point(342, 245);
            txtAmountToPay.Margin = new Padding(3, 4, 3, 4);
            txtAmountToPay.Name = "txtAmountToPay";
            txtAmountToPay.Size = new Size(212, 27);
            txtAmountToPay.TabIndex = 4;
            // 
            // btnCompletePayment
            // 
            btnCompletePayment.BackColor = Color.Lime;
            btnCompletePayment.FlatStyle = FlatStyle.Flat;
            btnCompletePayment.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCompletePayment.ForeColor = Color.Black;
            btnCompletePayment.Location = new Point(342, 315);
            btnCompletePayment.Margin = new Padding(3, 4, 3, 4);
            btnCompletePayment.Name = "btnCompletePayment";
            btnCompletePayment.Size = new Size(212, 47);
            btnCompletePayment.TabIndex = 5;
            btnCompletePayment.Text = "Complete Payment";
            btnCompletePayment.UseVisualStyleBackColor = false;
            btnCompletePayment.Click += btnCompletePayment_Click;
            // 
            // pnlRightSide
            // 
            pnlRightSide.Controls.Add(lblPaymentMethodTitle);
            pnlRightSide.Controls.Add(txtPaymentMethod);
            pnlRightSide.Controls.Add(btnAddPaymentMethod);
            pnlRightSide.Dock = DockStyle.Right;
            pnlRightSide.Location = new Point(776, 0);
            pnlRightSide.Margin = new Padding(3, 4, 3, 4);
            pnlRightSide.Name = "pnlRightSide";
            pnlRightSide.Size = new Size(375, 841);
            pnlRightSide.TabIndex = 6;
            // 
            // lblPaymentMethodTitle
            // 
            lblPaymentMethodTitle.AutoSize = true;
            lblPaymentMethodTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPaymentMethodTitle.Location = new Point(93, 114);
            lblPaymentMethodTitle.Name = "lblPaymentMethodTitle";
            lblPaymentMethodTitle.Size = new Size(175, 28);
            lblPaymentMethodTitle.TabIndex = 7;
            lblPaymentMethodTitle.Text = "Payment Method";
            // 
            // txtPaymentMethod
            // 
            txtPaymentMethod.Location = new Point(93, 165);
            txtPaymentMethod.Margin = new Padding(3, 4, 3, 4);
            txtPaymentMethod.Name = "txtPaymentMethod";
            txtPaymentMethod.Size = new Size(212, 27);
            txtPaymentMethod.TabIndex = 9;
            // 
            // btnAddPaymentMethod
            // 
            btnAddPaymentMethod.BackColor = Color.LightSlateGray;
            btnAddPaymentMethod.FlatStyle = FlatStyle.Flat;
            btnAddPaymentMethod.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAddPaymentMethod.ForeColor = Color.White;
            btnAddPaymentMethod.Location = new Point(93, 343);
            btnAddPaymentMethod.Margin = new Padding(3, 4, 3, 4);
            btnAddPaymentMethod.Name = "btnAddPaymentMethod";
            btnAddPaymentMethod.Size = new Size(212, 47);
            btnAddPaymentMethod.TabIndex = 10;
            btnAddPaymentMethod.Text = "Add Payment Method";
            btnAddPaymentMethod.UseVisualStyleBackColor = false;
            btnAddPaymentMethod.Click += btnAddPaymentMethod_Click;
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.BackgroundColor = SystemColors.ControlLight;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Columns.AddRange(new DataGridViewColumn[] { colPaymentMethod, colAmount, colPaymentDate });
            dgvPayments.Dock = DockStyle.Bottom;
            dgvPayments.GridColor = SystemColors.ScrollBar;
            dgvPayments.Location = new Point(0, 404);
            dgvPayments.Margin = new Padding(3, 4, 3, 4);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.RowHeadersWidth = 51;
            dgvPayments.Size = new Size(776, 437);
            dgvPayments.TabIndex = 7;
            
            // 
            // colPaymentMethod
            // 
            colPaymentMethod.HeaderText = "Payment Method";
            colPaymentMethod.MinimumWidth = 6;
            colPaymentMethod.Name = "colPaymentMethod";
            colPaymentMethod.Width = 250;
            // 
            // colAmount
            // 
            colAmount.HeaderText = "Amount";
            colAmount.MinimumWidth = 6;
            colAmount.Name = "colAmount";
            colAmount.Width = 150;
            // 
            // colPaymentDate
            // 
            colPaymentDate.HeaderText = "Payment Date";
            colPaymentDate.MinimumWidth = 6;
            colPaymentDate.Name = "colPaymentDate";
            colPaymentDate.Width = 300;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 841);
            Controls.Add(dgvPayments);
            Controls.Add(pnlRightSide);
            Controls.Add(btnCompletePayment);
            Controls.Add(txtAmountToPay);
            Controls.Add(lblAmountToPay);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(lblPaymentMethod1);
            Controls.Add(lblMakePayment);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            pnlRightSide.ResumeLayout(false);
            pnlRightSide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMakePayment;
        private System.Windows.Forms.Label lblPaymentMethod1;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.TextBox txtAmountToPay;
        private System.Windows.Forms.Button btnCompletePayment;
        private System.Windows.Forms.Panel pnlRightSide;
        private System.Windows.Forms.Label lblPaymentMethodTitle;
        private System.Windows.Forms.TextBox txtPaymentMethod;
        private System.Windows.Forms.Button btnAddPaymentMethod;
        private System.Windows.Forms.DataGridView dgvPayments;
        private DataGridViewTextBoxColumn colPaymentMethod;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colPaymentDate;
    }
}