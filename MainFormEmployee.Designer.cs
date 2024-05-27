namespace test
{
    partial class MainFormEmployee
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
            this.btn_clients = new System.Windows.Forms.Button();
            this.btn_acc = new System.Windows.Forms.Button();
            this.btn_tran = new System.Windows.Forms.Button();
            this.btn_loans = new System.Windows.Forms.Button();
            this.btn_loans_tran = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_clients
            // 
            this.btn_clients.Location = new System.Drawing.Point(245, 27);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(391, 63);
            this.btn_clients.TabIndex = 0;
            this.btn_clients.Text = "Клиенты";
            this.btn_clients.UseVisualStyleBackColor = true;
            this.btn_clients.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_acc
            // 
            this.btn_acc.Location = new System.Drawing.Point(245, 96);
            this.btn_acc.Name = "btn_acc";
            this.btn_acc.Size = new System.Drawing.Size(391, 63);
            this.btn_acc.TabIndex = 1;
            this.btn_acc.Text = "Счета";
            this.btn_acc.UseVisualStyleBackColor = true;
            this.btn_acc.Click += new System.EventHandler(this.btn_acc_Click);
            // 
            // btn_tran
            // 
            this.btn_tran.Location = new System.Drawing.Point(245, 165);
            this.btn_tran.Name = "btn_tran";
            this.btn_tran.Size = new System.Drawing.Size(391, 63);
            this.btn_tran.TabIndex = 2;
            this.btn_tran.Text = "Транзакции";
            this.btn_tran.UseVisualStyleBackColor = true;
            this.btn_tran.Click += new System.EventHandler(this.btn_tran_Click);
            // 
            // btn_loans
            // 
            this.btn_loans.Location = new System.Drawing.Point(245, 234);
            this.btn_loans.Name = "btn_loans";
            this.btn_loans.Size = new System.Drawing.Size(391, 63);
            this.btn_loans.TabIndex = 3;
            this.btn_loans.Text = "Кредиты";
            this.btn_loans.UseVisualStyleBackColor = true;
            this.btn_loans.Click += new System.EventHandler(this.btn_loans_Click);
            // 
            // btn_loans_tran
            // 
            this.btn_loans_tran.Location = new System.Drawing.Point(245, 303);
            this.btn_loans_tran.Name = "btn_loans_tran";
            this.btn_loans_tran.Size = new System.Drawing.Size(391, 63);
            this.btn_loans_tran.TabIndex = 4;
            this.btn_loans_tran.Text = "Транзакции по кредитам";
            this.btn_loans_tran.UseVisualStyleBackColor = true;
            this.btn_loans_tran.Click += new System.EventHandler(this.btn_loans_tran_Click);
            // 
            // MainFormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 514);
            this.Controls.Add(this.btn_loans_tran);
            this.Controls.Add(this.btn_loans);
            this.Controls.Add(this.btn_tran);
            this.Controls.Add(this.btn_acc);
            this.Controls.Add(this.btn_clients);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainFormEmployee";
            this.Text = "Form4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clients;
        private System.Windows.Forms.Button btn_acc;
        private System.Windows.Forms.Button btn_tran;
        private System.Windows.Forms.Button btn_loans;
        private System.Windows.Forms.Button btn_loans_tran;
    }
}