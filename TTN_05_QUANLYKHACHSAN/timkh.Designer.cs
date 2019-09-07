namespace Qlks
{
    partial class timkh
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
            this.bt_tk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tk = new System.Windows.Forms.TextBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Socm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namsinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaydp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaytp = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(256, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search for booking customer";
            // 
            // bt_xoa
            // 
            this.bt_xoa.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_xoa.Location = new System.Drawing.Point(597, 54);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 32);
            this.bt_xoa.TabIndex = 0;
            this.bt_xoa.Text = "Delete";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(74, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "(Name, Date of birth, code..)";
            // 
            // bt_ct
            // 
            this.bt_ct.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_ct.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_ct.Location = new System.Drawing.Point(678, 54);
            this.bt_ct.Name = "bt_ct";
            this.bt_ct.Size = new System.Drawing.Size(75, 32);
            this.bt_ct.TabIndex = 0;
            this.bt_ct.Text = "Detail";
            this.bt_ct.UseVisualStyleBackColor = false;
            this.bt_ct.Click += new System.EventHandler(this.bt_ct_Click);
            // 
            // timkh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Qlks.Properties.Resources.images__3_7;
            this.ClientSize = new System.Drawing.Size(779, 301);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.txt_tk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_ct);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_tk);
            this.MaximumSize = new System.Drawing.Size(795, 340);
            this.MinimumSize = new System.Drawing.Size(795, 340);
            this.Name = "timkh";
            this.Text = "timkh";
            this.Load += new System.EventHandler(this.timkh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_tk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tk;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Socm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namsinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaydp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaytp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_ct;
    }
}