namespace WinFormsApp3
{
    partial class Management_framework
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
            dgv_Motorcycle = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            OwnerName = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Image = new DataGridViewTextBoxColumn();
            Describe = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txt_Name = new TextBox();
            btn_Add = new Button();
            cb_Brand = new ComboBox();
            dtp_Date = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            btn_Edit = new Button();
            btn_Delete = new Button();
            btn_Exit = new Button();
            label4 = new Label();
            txt_ID = new TextBox();
            label5 = new Label();
            picb_Image = new PictureBox();
            btn_Browserr = new Button();
            label6 = new Label();
            txt_Image = new TextBox();
            label7 = new Label();
            rtb_Describe = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Motorcycle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picb_Image).BeginInit();
            SuspendLayout();
            // 
            // dgv_Motorcycle
            // 
            dgv_Motorcycle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Motorcycle.BackgroundColor = Color.LightGray;
            dgv_Motorcycle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Motorcycle.Columns.AddRange(new DataGridViewColumn[] { ID, OwnerName, Brand, Date, Image, Describe });
            dgv_Motorcycle.Location = new Point(313, 489);
            dgv_Motorcycle.Name = "dgv_Motorcycle";
            dgv_Motorcycle.RowTemplate.Height = 25;
            dgv_Motorcycle.Size = new Size(937, 163);
            dgv_Motorcycle.TabIndex = 0;
            dgv_Motorcycle.CellClick += dgv_Motorcycle_CellClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "Motorcycle ID";
            ID.Name = "ID";
            // 
            // OwnerName
            // 
            OwnerName.DataPropertyName = "OwnerName";
            OwnerName.HeaderText = "Owner Name";
            OwnerName.Name = "OwnerName";
            // 
            // Brand
            // 
            Brand.DataPropertyName = "Brand";
            Brand.HeaderText = "Brand";
            Brand.Name = "Brand";
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date of manufacture";
            Date.Name = "Date";
            // 
            // Image
            // 
            Image.DataPropertyName = "Image";
            Image.HeaderText = "Motorcycle Image";
            Image.Name = "Image";
            // 
            // Describe
            // 
            Describe.DataPropertyName = "Describe";
            Describe.HeaderText = "Motorcycle Describe";
            Describe.Name = "Describe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 167);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 1;
            label1.Text = "Owner Name";
            // 
            // txt_Name
            // 
            txt_Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Name.Location = new Point(258, 163);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(341, 29);
            txt_Name.TabIndex = 2;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.White;
            btn_Add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Add.Location = new Point(48, 489);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(107, 70);
            btn_Add.TabIndex = 3;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // cb_Brand
            // 
            cb_Brand.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Brand.FormattingEnabled = true;
            cb_Brand.Location = new Point(258, 219);
            cb_Brand.Name = "cb_Brand";
            cb_Brand.Size = new Size(341, 29);
            cb_Brand.TabIndex = 4;
            // 
            // dtp_Date
            // 
            dtp_Date.CalendarFont = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_Date.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_Date.Location = new Point(258, 280);
            dtp_Date.Name = "dtp_Date";
            dtp_Date.Size = new Size(341, 29);
            dtp_Date.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 223);
            label2.Name = "label2";
            label2.Size = new Size(161, 25);
            label2.TabIndex = 6;
            label2.Text = "Motorcycle Brand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(48, 284);
            label3.Name = "label3";
            label3.Size = new Size(185, 25);
            label3.TabIndex = 7;
            label3.Text = "Date of manufacture";
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = Color.White;
            btn_Edit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Edit.Location = new Point(177, 489);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(109, 70);
            btn_Edit.TabIndex = 8;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.White;
            btn_Delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Delete.Location = new Point(48, 585);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(107, 64);
            btn_Delete.TabIndex = 9;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.White;
            btn_Exit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Exit.Location = new Point(177, 585);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(109, 67);
            btn_Exit.TabIndex = 10;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(48, 107);
            label4.Name = "label4";
            label4.Size = new Size(134, 25);
            label4.TabIndex = 11;
            label4.Text = "Motorcycle ID ";
            // 
            // txt_ID
            // 
            txt_ID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ID.Location = new Point(258, 103);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(341, 29);
            txt_ID.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(406, 9);
            label5.Name = "label5";
            label5.Size = new Size(499, 59);
            label5.TabIndex = 13;
            label5.Text = "Motorcycle management";
            // 
            // picb_Image
            // 
            picb_Image.BackColor = Color.White;
            picb_Image.Location = new Point(682, 103);
            picb_Image.Name = "picb_Image";
            picb_Image.Size = new Size(568, 266);
            picb_Image.TabIndex = 15;
            picb_Image.TabStop = false;
            // 
            // btn_Browserr
            // 
            btn_Browserr.BackColor = Color.White;
            btn_Browserr.Location = new Point(521, 337);
            btn_Browserr.Name = "btn_Browserr";
            btn_Browserr.Size = new Size(78, 32);
            btn_Browserr.TabIndex = 16;
            btn_Browserr.Text = "Browser..";
            btn_Browserr.UseVisualStyleBackColor = false;
            btn_Browserr.Click += btn_Browser_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(46, 344);
            label6.Name = "label6";
            label6.Size = new Size(163, 25);
            label6.TabIndex = 17;
            label6.Text = "Motorcycle Image";
            // 
            // txt_Image
            // 
            txt_Image.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Image.Location = new Point(258, 340);
            txt_Image.Name = "txt_Image";
            txt_Image.Size = new Size(230, 29);
            txt_Image.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(47, 402);
            label7.Name = "label7";
            label7.Size = new Size(184, 25);
            label7.TabIndex = 19;
            label7.Text = "Motorcycle Describe";
            // 
            // rtb_Describe
            // 
            rtb_Describe.Location = new Point(258, 393);
            rtb_Describe.Name = "rtb_Describe";
            rtb_Describe.Size = new Size(992, 67);
            rtb_Describe.TabIndex = 21;
            rtb_Describe.Text = "";
            // 
            // Management_framework
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 666);
            Controls.Add(rtb_Describe);
            Controls.Add(label7);
            Controls.Add(txt_Image);
            Controls.Add(label6);
            Controls.Add(btn_Browserr);
            Controls.Add(picb_Image);
            Controls.Add(label5);
            Controls.Add(txt_ID);
            Controls.Add(label4);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Edit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dtp_Date);
            Controls.Add(cb_Brand);
            Controls.Add(btn_Add);
            Controls.Add(txt_Name);
            Controls.Add(label1);
            Controls.Add(dgv_Motorcycle);
            Name = "Management_framework";
            Text = "Management framework";
            ((System.ComponentModel.ISupportInitialize)dgv_Motorcycle).EndInit();
            ((System.ComponentModel.ISupportInitialize)picb_Image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Motorcycle;
        private Label label1;
        private TextBox txt_Name;
        private Button btn_Add;
        private ComboBox cb_Brand;
        private DateTimePicker dtp_Date;
        private Label label2;
        private Label label3;
        private Button btn_Edit;
        private Button btn_Delete;
        private Button btn_Exit;
        private Label label4;
        private TextBox txt_ID;
        private Label label5;
        private PictureBox picb_Image;
        private Button btn_Browserr;
        private Label label6;
        private TextBox txt_Image;
        private Label label7;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn OwnerName;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Image;
        private DataGridViewTextBoxColumn Describe;
        private RichTextBox rtb_Describe;
    }
}