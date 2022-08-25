namespace THITN
{
    partial class frmDangNhap
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
            this.cmbCoso = new System.Windows.Forms.ComboBox();
            this.grBox = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.rdoSinhVien = new System.Windows.Forms.RadioButton();
            this.rdoGiangVien = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbCoSo = new System.Windows.Forms.Label();
            this.grBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCoso
            // 
            this.cmbCoso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoso.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCoso.FormattingEnabled = true;
            this.cmbCoso.Location = new System.Drawing.Point(204, 100);
            this.cmbCoso.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCoso.Name = "cmbCoso";
            this.cmbCoso.Size = new System.Drawing.Size(286, 28);
            this.cmbCoso.TabIndex = 0;
            this.cmbCoso.SelectedIndexChanged += new System.EventHandler(this.cmbCoso_SelectedIndexChanged);
            // 
            // grBox
            // 
            this.grBox.Controls.Add(this.btnThoat);
            this.grBox.Controls.Add(this.btnDangNhap);
            this.grBox.Controls.Add(this.rdoSinhVien);
            this.grBox.Controls.Add(this.rdoGiangVien);
            this.grBox.Controls.Add(this.txtPassword);
            this.grBox.Controls.Add(this.txtLogin);
            this.grBox.Controls.Add(this.lbPassword);
            this.grBox.Controls.Add(this.lbLogin);
            this.grBox.Controls.Add(this.lbCoSo);
            this.grBox.Controls.Add(this.cmbCoso);
            this.grBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBox.Location = new System.Drawing.Point(161, 60);
            this.grBox.Margin = new System.Windows.Forms.Padding(4);
            this.grBox.Name = "grBox";
            this.grBox.Padding = new System.Windows.Forms.Padding(4);
            this.grBox.Size = new System.Drawing.Size(562, 390);
            this.grBox.TabIndex = 1;
            this.grBox.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(346, 294);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 39);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(132, 294);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(139, 39);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // rdoSinhVien
            // 
            this.rdoSinhVien.AutoSize = true;
            this.rdoSinhVien.Location = new System.Drawing.Point(335, 46);
            this.rdoSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.rdoSinhVien.Name = "rdoSinhVien";
            this.rdoSinhVien.Size = new System.Drawing.Size(99, 25);
            this.rdoSinhVien.TabIndex = 9;
            this.rdoSinhVien.TabStop = true;
            this.rdoSinhVien.Text = "Sinh viên";
            this.rdoSinhVien.UseVisualStyleBackColor = true;
            this.rdoSinhVien.CheckedChanged += new System.EventHandler(this.rdoSinhVien_CheckedChanged);
            // 
            // rdoGiangVien
            // 
            this.rdoGiangVien.AutoSize = true;
            this.rdoGiangVien.Checked = true;
            this.rdoGiangVien.Location = new System.Drawing.Point(134, 46);
            this.rdoGiangVien.Margin = new System.Windows.Forms.Padding(4);
            this.rdoGiangVien.Name = "rdoGiangVien";
            this.rdoGiangVien.Size = new System.Drawing.Size(110, 25);
            this.rdoGiangVien.TabIndex = 8;
            this.rdoGiangVien.TabStop = true;
            this.rdoGiangVien.Text = "Giảng viên";
            this.rdoGiangVien.UseVisualStyleBackColor = true;
            this.rdoGiangVien.CheckedChanged += new System.EventHandler(this.rdoGiangVien_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(204, 220);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(286, 28);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "123";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(204, 164);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(286, 28);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.Text = "kdt";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(74, 229);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(79, 21);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Mật khẩu";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(74, 168);
            this.lbLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(84, 21);
            this.lbLogin.TabIndex = 2;
            this.lbLogin.Text = "Tài khoản";
            // 
            // lbCoSo
            // 
            this.lbCoSo.AutoSize = true;
            this.lbCoSo.Location = new System.Drawing.Point(74, 105);
            this.lbCoSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCoSo.Name = "lbCoSo";
            this.lbCoSo.Size = new System.Drawing.Size(56, 21);
            this.lbCoSo.TabIndex = 1;
            this.lbCoSo.Text = "Cơ sở";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 518);
            this.Controls.Add(this.grBox);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.grBox.ResumeLayout(false);
            this.grBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCoso;
        private System.Windows.Forms.GroupBox grBox;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbCoSo;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;

        private System.Windows.Forms.RadioButton rdoSinhVien;
        private System.Windows.Forms.RadioButton rdoGiangVien;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtLogin;
    }
}