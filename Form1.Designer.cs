namespace BTH43
{
    partial class Form1
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
            this.txtSo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btTang2 = new System.Windows.Forms.Button();
            this.btChandau = new System.Windows.Forms.Button();
            this.btnLe = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.BtnXoaDau = new System.Windows.Forms.Button();
            this.btnXoaCuoi = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(158, 25);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(268, 20);
            this.txtSo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số nguyên :";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(249, 394);
            this.listBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaCuoi);
            this.groupBox1.Controls.Add(this.BtnXoaDau);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.btnLe);
            this.groupBox1.Controls.Add(this.btChandau);
            this.groupBox1.Controls.Add(this.btTang2);
            this.groupBox1.Location = new System.Drawing.Point(286, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 393);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btTang2
            // 
            this.btTang2.Location = new System.Drawing.Point(33, 41);
            this.btTang2.Name = "btTang2";
            this.btTang2.Size = new System.Drawing.Size(174, 34);
            this.btTang2.TabIndex = 0;
            this.btTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btTang2.UseVisualStyleBackColor = true;
            this.btTang2.Click += new System.EventHandler(this.btTang2_Click);
            // 
            // btChandau
            // 
            this.btChandau.Location = new System.Drawing.Point(33, 98);
            this.btChandau.Name = "btChandau";
            this.btChandau.Size = new System.Drawing.Size(174, 34);
            this.btChandau.TabIndex = 0;
            this.btChandau.Text = "Chọn số chẵn đầu";
            this.btChandau.UseVisualStyleBackColor = true;
            this.btChandau.Click += new System.EventHandler(this.btChandau_Click);
            // 
            // btnLe
            // 
            this.btnLe.Location = new System.Drawing.Point(33, 156);
            this.btnLe.Name = "btnLe";
            this.btnLe.Size = new System.Drawing.Size(174, 34);
            this.btnLe.TabIndex = 0;
            this.btnLe.Text = "Chọn số lẻ cuối";
            this.btnLe.UseVisualStyleBackColor = true;
            this.btnLe.Click += new System.EventHandler(this.btnLe_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(33, 215);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(174, 34);
            this.btXoa.TabIndex = 0;
            this.btXoa.Text = "Xóa phần tử đang chọn";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // BtnXoaDau
            // 
            this.BtnXoaDau.Location = new System.Drawing.Point(33, 275);
            this.BtnXoaDau.Name = "BtnXoaDau";
            this.BtnXoaDau.Size = new System.Drawing.Size(174, 34);
            this.BtnXoaDau.TabIndex = 0;
            this.BtnXoaDau.Text = "Xóa phần tử đầu";
            this.BtnXoaDau.UseVisualStyleBackColor = true;
            this.BtnXoaDau.Click += new System.EventHandler(this.BtnXoaDau_Click);
            // 
            // btnXoaCuoi
            // 
            this.btnXoaCuoi.Location = new System.Drawing.Point(33, 329);
            this.btnXoaCuoi.Name = "btnXoaCuoi";
            this.btnXoaCuoi.Size = new System.Drawing.Size(174, 34);
            this.btnXoaCuoi.TabIndex = 0;
            this.btnXoaCuoi.Text = "Xóa phần tử cuối";
            this.btnXoaCuoi.UseVisualStyleBackColor = true;
            this.btnXoaCuoi.Click += new System.EventHandler(this.btnXoaCuoi_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(118, 481);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(319, 25);
            this.button8.TabIndex = 5;
            this.button8.Text = "Kết thúc";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 511);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoaCuoi;
        private System.Windows.Forms.Button BtnXoaDau;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btnLe;
        private System.Windows.Forms.Button btChandau;
        private System.Windows.Forms.Button btTang2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button8;
    }
}

