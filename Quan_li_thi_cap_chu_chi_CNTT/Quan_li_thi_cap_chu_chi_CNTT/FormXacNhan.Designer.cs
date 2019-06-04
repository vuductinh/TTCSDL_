namespace Quan_li_thi_cap_chu_chi_CNTT
{
    partial class FormXacNhan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_xacnhan = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.tb_ma = new System.Windows.Forms.TextBox();
            this.tb_hoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(727, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Xác nhận thông tin";
            // 
            // bt_xacnhan
            // 
            this.bt_xacnhan.Location = new System.Drawing.Point(72, 90);
            this.bt_xacnhan.Name = "bt_xacnhan";
            this.bt_xacnhan.Size = new System.Drawing.Size(75, 23);
            this.bt_xacnhan.TabIndex = 2;
            this.bt_xacnhan.Text = "OK";
            this.bt_xacnhan.UseVisualStyleBackColor = true;
            this.bt_xacnhan.Click += new System.EventHandler(this.bt_xacnhan_Click);
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(200, 90);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(75, 23);
            this.bt_back.TabIndex = 3;
            this.bt_back.Text = "Trở về";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // tb_ma
            // 
            this.tb_ma.Location = new System.Drawing.Point(72, 37);
            this.tb_ma.Name = "tb_ma";
            this.tb_ma.Size = new System.Drawing.Size(203, 20);
            this.tb_ma.TabIndex = 4;
            // 
            // tb_hoten
            // 
            this.tb_hoten.Location = new System.Drawing.Point(72, 64);
            this.tb_hoten.Name = "tb_hoten";
            this.tb_hoten.Size = new System.Drawing.Size(203, 20);
            this.tb_hoten.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Danh sách thí sinh";
            // 
            // FormXacNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 509);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_hoten);
            this.Controls.Add(this.tb_ma);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.bt_xacnhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormXacNhan";
            this.Text = "FormXacNhan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_xacnhan;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.TextBox tb_ma;
        private System.Windows.Forms.TextBox tb_hoten;
        private System.Windows.Forms.Label label2;
    }
}