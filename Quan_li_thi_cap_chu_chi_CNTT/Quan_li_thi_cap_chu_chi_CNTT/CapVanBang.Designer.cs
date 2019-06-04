namespace Quan_li_thi_cap_chu_chi_CNTT
{
    partial class CapVanBang
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
            this.dt_danhsach = new System.Windows.Forms.DataGridView();
            this.tb_sbd = new System.Windows.Forms.TextBox();
            this.tb_mahd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_tenchungchi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_ngaycap = new System.Windows.Forms.DateTimePicker();
            this.tb_sovaoso = new System.Windows.Forms.TextBox();
            this.tb_sovanbang = new System.Windows.Forms.TextBox();
            this.bt_cap = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_danhsach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_danhsach
            // 
            this.dt_danhsach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_danhsach.BackgroundColor = System.Drawing.Color.White;
            this.dt_danhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_danhsach.Location = new System.Drawing.Point(39, 245);
            this.dt_danhsach.Name = "dt_danhsach";
            this.dt_danhsach.ReadOnly = true;
            this.dt_danhsach.Size = new System.Drawing.Size(811, 335);
            this.dt_danhsach.TabIndex = 0;
            // 
            // tb_sbd
            // 
            this.tb_sbd.Location = new System.Drawing.Point(77, 84);
            this.tb_sbd.Name = "tb_sbd";
            this.tb_sbd.Size = new System.Drawing.Size(201, 20);
            this.tb_sbd.TabIndex = 1;
            // 
            // tb_mahd
            // 
            this.tb_mahd.Location = new System.Drawing.Point(77, 33);
            this.tb_mahd.Name = "tb_mahd";
            this.tb_mahd.Size = new System.Drawing.Size(201, 20);
            this.tb_mahd.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.cb_tenchungchi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dt_ngaycap);
            this.groupBox1.Controls.Add(this.tb_sovaoso);
            this.groupBox1.Controls.Add(this.tb_sovanbang);
            this.groupBox1.Controls.Add(this.tb_mahd);
            this.groupBox1.Controls.Add(this.tb_sbd);
            this.groupBox1.Location = new System.Drawing.Point(39, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 204);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điền thông tin";
            // 
            // cb_tenchungchi
            // 
            this.cb_tenchungchi.FormattingEnabled = true;
            this.cb_tenchungchi.Items.AddRange(new object[] {
            "Ứng dụng CNTT cơ bản",
            "Ứng dụng CNTT nâng cao"});
            this.cb_tenchungchi.Location = new System.Drawing.Point(77, 139);
            this.cb_tenchungchi.Name = "cb_tenchungchi";
            this.cb_tenchungchi.Size = new System.Drawing.Size(201, 21);
            this.cb_tenchungchi.TabIndex = 13;
            this.cb_tenchungchi.SelectedIndexChanged += new System.EventHandler(this.cb_tenchungchi_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ngày cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số vào sổ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số văn bằng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên chứng chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "SBD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã hội đồng";
            // 
            // dt_ngaycap
            // 
            this.dt_ngaycap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_ngaycap.Location = new System.Drawing.Point(335, 141);
            this.dt_ngaycap.Name = "dt_ngaycap";
            this.dt_ngaycap.Size = new System.Drawing.Size(190, 20);
            this.dt_ngaycap.TabIndex = 6;
            // 
            // tb_sovaoso
            // 
            this.tb_sovaoso.Location = new System.Drawing.Point(335, 84);
            this.tb_sovaoso.Name = "tb_sovaoso";
            this.tb_sovaoso.Size = new System.Drawing.Size(190, 20);
            this.tb_sovaoso.TabIndex = 5;
            // 
            // tb_sovanbang
            // 
            this.tb_sovanbang.Location = new System.Drawing.Point(335, 33);
            this.tb_sovanbang.Name = "tb_sovanbang";
            this.tb_sovanbang.Size = new System.Drawing.Size(190, 20);
            this.tb_sovanbang.TabIndex = 4;
            // 
            // bt_cap
            // 
            this.bt_cap.Location = new System.Drawing.Point(660, 176);
            this.bt_cap.Name = "bt_cap";
            this.bt_cap.Size = new System.Drawing.Size(75, 23);
            this.bt_cap.TabIndex = 5;
            this.bt_cap.Text = "Xác nhận";
            this.bt_cap.UseVisualStyleBackColor = true;
            this.bt_cap.Click += new System.EventHandler(this.bt_cap_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(757, 176);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 23);
            this.bt_exit.TabIndex = 6;
            this.bt_exit.Text = "Trở về";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Danh sách cấp chứng chỉ";
            // 
            // CapVanBang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 588);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_cap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dt_danhsach);
            this.Name = "CapVanBang";
            this.Text = "CapVanBang";
            ((System.ComponentModel.ISupportInitialize)(this.dt_danhsach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_danhsach;
        private System.Windows.Forms.TextBox tb_sbd;
        private System.Windows.Forms.TextBox tb_mahd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_tenchungchi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_ngaycap;
        private System.Windows.Forms.TextBox tb_sovaoso;
        private System.Windows.Forms.TextBox tb_sovanbang;
        private System.Windows.Forms.Button bt_cap;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Label label7;
    }
}