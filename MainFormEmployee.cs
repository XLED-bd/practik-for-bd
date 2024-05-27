using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class MainFormEmployee : Form
    {
        public MainFormEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cForm = new ClientsForm();
            cForm.Show();
            this.Hide();
        }

        private void btn_acc_Click(object sender, EventArgs e)
        {
            var cForm = new AccForm();
            cForm.Show();
            this.Hide();
        }

        private void btn_tran_Click(object sender, EventArgs e)
        {
            var cForm = new TranForm();
            cForm.Show();
            this.Hide();
        }

        private void btn_loans_Click(object sender, EventArgs e)
        {
            var cForm = new LoanForm();
            cForm.Show();
            this.Hide();
        }

        private void btn_loans_tran_Click(object sender, EventArgs e)
        {
            var cForm = new TranLoanForm();
            cForm.Show();
            this.Hide();
        }
    }
}
