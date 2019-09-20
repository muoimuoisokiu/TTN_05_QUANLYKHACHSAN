namespace Qlks
{
    partial class suaphong
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
            this.lb_tenp = new System.Windows.Forms.Label();
            this.txt_giaphong = new System.Windows.Forms.TextBox();
            this.cb_lp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_tenp
            // 
            this.lb_tenp.AutoSize = true;
            this.lb_tenp.BackColor = System.Drawing.Color.SeaGreen;
            this.lb_tenp.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenp.ForeColor = System.Drawing.Color.Honeydew;
            this.lb_tenp.Location = new System.Drawing.Point(69, 9);
            this.lb_tenp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tenp.Name = "lb_tenp";
            this.lb_tenp.Size = new System.Drawing.Size(208, 24);
            this.lb_tenp.TabIndex = 99;
            this.lb_tenp.Text = "Edit room information";
            // 
            // txt_giaphong
            // 
            this.txt_giaphong.Location = new System.Drawing.Point(128, 79);
            this.txt_giaphong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_giaphong.Name = "txt_giaphong";
            this.txt_giaphong.Size = new System.Drawing.Size(107, 23);
            this.txt_giaphong.TabIndex = 1;
            // 
            // cb_lp
            // 
            this.cb_lp.AutoCompleteCustomSource.AddRange(new string[] {
            "VIP",
            "Lo?i 1",
            "Lo?i 2"});
            this.cb_lp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lp.FormattingEnabled = true;
            this.cb_lp.Location = new System.Drawing.Point(128, 120);
            this.cb_lp.Margin = new System.Windows.Forms.Padding(4);
            this.cb_lp.Name = "cb_lp";
            this.cb_lp.Size = new System.Drawing.Size(160, 24);
            this.cb_lp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 99;
            this.label2.Text = "Price Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 99;
            this.label3.Text = "Type of room";
            // 
            // bt_luu
            // 
            this.bt_luu.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_luu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_luu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_luu.Location = new System.Drawing.Point(196, 168);
            this.bt_luu.Margin = new System.Windows.Forms.Padding(4);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(80, 30);
            this.bt_luu.TabIndex = 3;
            this.bt_luu.Text = "Save";
            this.bt_luu.UseVisualStyleBackColor = false;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.BackColor = System.Drawing.Color.Red;
            this.bt_huy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_huy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_huy.Location = new System.Drawing.Point(92, 168);
            this.bt_huy.Margin = new System.Windows.Forms.Padding(4);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(80, 30);
            this.bt_huy.TabIndex = 4;
            this.bt_huy.Text = "Delete";
            this.bt_huy.UseVisualStyleBackColor = false;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 99;
            this.label1.Text = "Code room";
            // 
            // txt_mp
            // 
            this.txt_mp.Location = new System.Drawing.Point(128, 42);
            this.txt_mp.Name = "txt_mp";
            this.txt_mp.Size = new System.Drawing.Size(86, 23);
            this.txt_mp.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 100;
            this.label4.Text = "Vnd";
            // 
            // suaphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Qlks.Properties.Resources.images__9_5;
            this.ClientSize = new System.Drawing.Size(304, 211);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_mp);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.cb_lp);
            this.Controls.Add(this.txt_giaphong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_tenp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(320, 250);
            this.MinimumSize = new System.Drawing.Size(320, 250);
            this.Name = "suaphong";
            this.Text = "suaphong";
            this.Load += new System.EventHandler(this.suaphong_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tenp;
        private System.Windows.Forms.TextBox txt_giaphong;
        private System.Windows.Forms.ComboBox cb_lp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mp;
        private System.Windows.Forms.Label label4;
    }
}