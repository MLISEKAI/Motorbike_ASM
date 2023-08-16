namespace Motorcycle_management
{
    partial class Login_frame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_frame));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_acc = new TextBox();
            txt_pass = new TextBox();
            btn_login = new Button();
            btn_exit = new Button();
            ckb_showpass = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-7, 0);
            pictureBox1.Margin = new Padding(7, 3, 7, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1057, 753);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(231, 178);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(225, 45);
            label1.TabIndex = 1;
            label1.Text = "Login Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(116, 267);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(101, 32);
            label2.TabIndex = 2;
            label2.Text = "Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(116, 334);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 32);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txt_acc
            // 
            txt_acc.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txt_acc.Location = new Point(259, 263);
            txt_acc.Margin = new Padding(7, 3, 7, 3);
            txt_acc.Name = "txt_acc";
            txt_acc.Size = new Size(298, 36);
            txt_acc.TabIndex = 4;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.Location = new Point(259, 330);
            txt_pass.Margin = new Padding(7, 3, 7, 3);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(298, 36);
            txt_pass.TabIndex = 5;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.Location = new Point(161, 445);
            btn_login.Margin = new Padding(7, 3, 7, 3);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(127, 63);
            btn_login.TabIndex = 6;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_exit.Location = new Point(351, 445);
            btn_exit.Margin = new Padding(7, 3, 7, 3);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(126, 63);
            btn_exit.TabIndex = 7;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_Exit_Click;
            // 
            // ckb_showpass
            // 
            ckb_showpass.AutoSize = true;
            ckb_showpass.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ckb_showpass.Location = new Point(259, 383);
            ckb_showpass.Margin = new Padding(7, 3, 7, 3);
            ckb_showpass.Name = "ckb_showpass";
            ckb_showpass.Size = new Size(162, 29);
            ckb_showpass.TabIndex = 8;
            ckb_showpass.Text = "Show password";
            ckb_showpass.UseVisualStyleBackColor = true;
            ckb_showpass.CheckedChanged += ckb_Showpass_CheckedChanged;
            // 
            // Login_frame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 747);
            Controls.Add(ckb_showpass);
            Controls.Add(btn_exit);
            Controls.Add(btn_login);
            Controls.Add(txt_pass);
            Controls.Add(txt_acc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(7, 3, 7, 3);
            Name = "Login_frame";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_acc;
        private TextBox txt_pass;
        private Button btn_login;
        private Button btn_exit;
        private CheckBox ckb_showpass;
    }
}