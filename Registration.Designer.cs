namespace test
{
    partial class RegForm
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
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_secondName = new System.Windows.Forms.TextBox();
            this.btn_reg = new System.Windows.Forms.Button();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.fdaf = new System.Windows.Forms.Label();
            this.txt_passport = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_snils = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_inn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(190, 64);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(232, 20);
            this.txt_firstName.TabIndex = 0;
            // 
            // txt_secondName
            // 
            this.txt_secondName.Location = new System.Drawing.Point(190, 103);
            this.txt_secondName.Name = "txt_secondName";
            this.txt_secondName.Size = new System.Drawing.Size(232, 20);
            this.txt_secondName.TabIndex = 1;
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(190, 402);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(232, 29);
            this.btn_reg.TabIndex = 3;
            this.btn_reg.Text = "Зарегистрироваться";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(190, 142);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(232, 20);
            this.txt_date.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата рождения( в формате день-месяц-год)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Телефон";
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(190, 181);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(232, 20);
            this.txt_phone.TabIndex = 9;
            // 
            // fdaf
            // 
            this.fdaf.AutoSize = true;
            this.fdaf.Location = new System.Drawing.Point(187, 204);
            this.fdaf.Name = "fdaf";
            this.fdaf.Size = new System.Drawing.Size(132, 13);
            this.fdaf.TabIndex = 10;
            this.fdaf.Text = "Серия и номер паспорта";
            // 
            // txt_passport
            // 
            this.txt_passport.Location = new System.Drawing.Point(190, 220);
            this.txt_passport.Name = "txt_passport";
            this.txt_passport.Size = new System.Drawing.Size(232, 20);
            this.txt_passport.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "СНИЛС";
            // 
            // txt_snils
            // 
            this.txt_snils.Location = new System.Drawing.Point(190, 259);
            this.txt_snils.Name = "txt_snils";
            this.txt_snils.Size = new System.Drawing.Size(232, 20);
            this.txt_snils.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ИНН";
            // 
            // txt_inn
            // 
            this.txt_inn.Location = new System.Drawing.Point(190, 298);
            this.txt_inn.Name = "txt_inn";
            this.txt_inn.Size = new System.Drawing.Size(232, 20);
            this.txt_inn.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Электронная почта";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(190, 337);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(232, 20);
            this.txt_email.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Пароль";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(190, 376);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(232, 20);
            this.txt_password.TabIndex = 19;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 511);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_inn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_snils);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_passport);
            this.Controls.Add(this.fdaf);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.btn_reg);
            this.Controls.Add(this.txt_secondName);
            this.Controls.Add(this.txt_firstName);
            this.Name = "RegForm";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_secondName;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label fdaf;
        private System.Windows.Forms.TextBox txt_passport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_snils;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_inn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_password;
    }
}