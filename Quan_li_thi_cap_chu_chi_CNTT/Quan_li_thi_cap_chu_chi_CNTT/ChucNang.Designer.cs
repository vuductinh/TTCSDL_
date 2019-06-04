namespace Quan_li_thi_cap_chu_chi_CNTT
{
    partial class ChucNang
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
            this.bt_quanli_hoidong = new System.Windows.Forms.Button();
            this.bt_quanli_diem = new System.Windows.Forms.Button();
            this.bt_quanli_vanbang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_trove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_quanli_hoidong
            // 
            this.bt_quanli_hoidong.Location = new System.Drawing.Point(88, 181);
            this.bt_quanli_hoidong.Name = "bt_quanli_hoidong";
            this.bt_quanli_hoidong.Size = new System.Drawing.Size(114, 56);
            this.bt_quanli_hoidong.TabIndex = 0;
            this.bt_quanli_hoidong.Text = "Quản lí hội đồng";
            this.bt_quanli_hoidong.UseVisualStyleBackColor = true;
            this.bt_quanli_hoidong.Click += new System.EventHandler(this.bt_quanli_hoidong_Click);
            // 
            // bt_quanli_diem
            // 
            this.bt_quanli_diem.Location = new System.Drawing.Point(322, 181);
            this.bt_quanli_diem.Name = "bt_quanli_diem";
            this.bt_quanli_diem.Size = new System.Drawing.Size(130, 56);
            this.bt_quanli_diem.TabIndex = 1;
            this.bt_quanli_diem.Text = "Quản lí điểm";
            this.bt_quanli_diem.UseVisualStyleBackColor = true;
            this.bt_quanli_diem.Click += new System.EventHandler(this.bt_quanli_diem_Click);
            // 
            // bt_quanli_vanbang
            // 
            this.bt_quanli_vanbang.Location = new System.Drawing.Point(573, 181);
            this.bt_quanli_vanbang.Name = "bt_quanli_vanbang";
            this.bt_quanli_vanbang.Size = new System.Drawing.Size(127, 56);
            this.bt_quanli_vanbang.TabIndex = 2;
            this.bt_quanli_vanbang.Text = "Quản lí văn bằng";
            this.bt_quanli_vanbang.UseVisualStyleBackColor = true;
            this.bt_quanli_vanbang.Click += new System.EventHandler(this.bt_quanli_vanbang_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 49);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản Lí Thi Cấp Chứng Chỉ  CNTT";
            // 
            // bt_trove
            // 
            this.bt_trove.Location = new System.Drawing.Point(707, 7);
            this.bt_trove.Name = "bt_trove";
            this.bt_trove.Size = new System.Drawing.Size(75, 23);
            this.bt_trove.TabIndex = 4;
            this.bt_trove.Text = "Trở về";
            this.bt_trove.UseVisualStyleBackColor = true;
            this.bt_trove.Click += new System.EventHandler(this.bt_trove_Click);
            // 
            // ChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 348);
            this.Controls.Add(this.bt_trove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_quanli_vanbang);
            this.Controls.Add(this.bt_quanli_diem);
            this.Controls.Add(this.bt_quanli_hoidong);
            this.MaximizeBox = false;
            this.Name = "ChucNang";
            this.Text = "ChucNang";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_quanli_hoidong;
        private System.Windows.Forms.Button bt_quanli_diem;
        private System.Windows.Forms.Button bt_quanli_vanbang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_trove;
    }
}