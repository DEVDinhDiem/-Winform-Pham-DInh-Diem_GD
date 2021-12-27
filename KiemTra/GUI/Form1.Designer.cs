
namespace KiemTra
{
    partial class Form1
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
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTienno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtthongbao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Ten,
            this.Column1,
            this.Column2});
            this.dgvCustomer.Location = new System.Drawing.Point(12, 12);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 29;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(980, 261);
            this.dgvCustomer.TabIndex = 28;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // Ma
            // 
            this.Ma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ma.DataPropertyName = "id";
            this.Ma.HeaderText = "Mã Khách Hàng";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.DataPropertyName = "name";
            this.Ten.HeaderText = "Tên Khách Hàng";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "phone";
            this.Column1.HeaderText = "Số Điện Thoại";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "tienno";
            this.Column2.HeaderText = "Tiền Nợ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(152, 88);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(348, 27);
            this.tbName.TabIndex = 36;
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(152, 46);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(125, 27);
            this.tbId.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(852, 549);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(140, 56);
            this.btExit.TabIndex = 32;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(706, 549);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(140, 56);
            this.btEdit.TabIndex = 31;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(560, 549);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(140, 56);
            this.btDelete.TabIndex = 30;
            this.btDelete.Text = "Xoá";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(414, 549);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(140, 56);
            this.btNew.TabIndex = 29;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTienno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbphone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbId);
            this.groupBox1.Location = new System.Drawing.Point(12, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 221);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // tbTienno
            // 
            this.tbTienno.Location = new System.Drawing.Point(152, 175);
            this.tbTienno.Name = "tbTienno";
            this.tbTienno.Size = new System.Drawing.Size(203, 27);
            this.tbTienno.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Tiền Nợ";
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(152, 132);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(348, 27);
            this.tbphone.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Số Điện Thoại";
            // 
            // txtthongbao
            // 
            this.txtthongbao.AutoSize = true;
            this.txtthongbao.BackColor = System.Drawing.SystemColors.Control;
            this.txtthongbao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtthongbao.ForeColor = System.Drawing.Color.Red;
            this.txtthongbao.Location = new System.Drawing.Point(414, 508);
            this.txtthongbao.Name = "txtthongbao";
            this.txtthongbao.Size = new System.Drawing.Size(55, 23);
            this.txtthongbao.TabIndex = 41;
            this.txtthongbao.Text = "label5";
            this.txtthongbao.Click += new System.EventHandler(this.txtthongbao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 610);
            this.Controls.Add(this.txtthongbao);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btNew);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbTienno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtthongbao;
    }
}

