using System;
using System.Windows.Forms;
using PaymentApp.Data;
using PaymentApp.Services;
using PaymentApp.Models;
using System.Linq;

namespace PaymentApp
{
    public partial class Form1 : Form
    {
        private readonly IPaymentService _paymentService;
        private readonly IPaymentMethodService _paymentMethodService;

        public Form1()
        {
            InitializeComponent();

            // Initialize service and repository dependencies
            var context = new ApplicationDbContext();
            var paymentRepository = new PaymentRepository(context);
            _paymentService = new PaymentService(paymentRepository);
            _paymentMethodService = new PaymentMethodService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load payment methods into combobox
            LoadPaymentMethods();

            // Load existing payments
            LoadPaymentData();
        }

        private void LoadPaymentMethods()
        {
            cmbPaymentMethod.Items.Clear();
            var methods = _paymentMethodService.GetAvailablePaymentMethods();
            foreach (var method in methods)
            {
                cmbPaymentMethod.Items.Add(method);
            }

            if (cmbPaymentMethod.Items.Count > 0)
            {
                cmbPaymentMethod.SelectedIndex = 0;
            }
        }

        private void LoadPaymentData()
        {
            // Clear existing data
            dgvPayments.Rows.Clear();

            // Get payments from service
            var payments = _paymentService.GetAllPayments();

            // Add each payment to the grid
            foreach (var payment in payments)
            {
                AddPaymentRow(
                    payment.PaymentMethod,
                    payment.Amount.ToString(),
                    payment.PaymentDate.ToString("dd-MM-yyyy")
                );
            }
        }

        private void AddPaymentRow(string method, string amount, string date)
        {
            int index = dgvPayments.Rows.Add();
            dgvPayments.Rows[index].Cells["colPaymentMethod"].Value = method;
            dgvPayments.Rows[index].Cells["colAmount"].Value = amount;
            dgvPayments.Rows[index].Cells["colPaymentDate"].Value = date;
        }

        private void btnCompletePayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAmountToPay.Text))
            {
                MessageBox.Show("Please enter an amount to pay", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string method = cmbPaymentMethod.Text;

            // Convert amount to decimal
            if (!decimal.TryParse(txtAmountToPay.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Process payment via service
            bool success = _paymentService.ProcessPayment(method, amount);

            if (success)
            {
                // Refresh payment data grid
                LoadPaymentData();

                MessageBox.Show("Payment completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAmountToPay.Clear();
            }
            else
            {
                MessageBox.Show("Failed to process payment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddPaymentMethod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPaymentMethod.Text))
            {
                MessageBox.Show("Please enter a payment method name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newMethod = txtPaymentMethod.Text;

            // Add payment method via service
            bool success = _paymentMethodService.AddPaymentMethod(newMethod);

            if (success)
            {
                // Refresh payment methods dropdown
                LoadPaymentMethods();

                MessageBox.Show("Payment method added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPaymentMethod.Clear();
            }
            else
            {
                MessageBox.Show("This payment method already exists or is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}