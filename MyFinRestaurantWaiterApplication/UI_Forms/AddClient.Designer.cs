namespace MyFinCassa.UI_Forms
{
    partial class AddClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTittle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.txtTittle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 63);
            this.panel1.TabIndex = 7;
            // 
            // txtTittle
            // 
            this.txtTittle.AutoSize = true;
            this.txtTittle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTittle.ForeColor = System.Drawing.Color.White;
            this.txtTittle.Location = new System.Drawing.Point(12, 11);
            this.txtTittle.Name = "txtTittle";
            this.txtTittle.Size = new System.Drawing.Size(375, 50);
            this.txtTittle.TabIndex = 0;
            this.txtTittle.Text = "Добавление клиента";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 63);
            this.panel2.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 5;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(239, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(127, 45);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.BorderRadius = 5;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(25, 25);
            this.btnClose.Location = new System.Drawing.Point(7, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(127, 45);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Отмена";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.Location = new System.Drawing.Point(25, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 32);
            this.label1.TabIndex = 102;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label2.Location = new System.Drawing.Point(25, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 32);
            this.label2.TabIndex = 102;
            this.label2.Text = "Номер:";
            // 
            // txtNumber
            // 
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtNumber.Location = new System.Drawing.Point(109, 146);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(237, 39);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.Enter += new System.EventHandler(this.SetActiveTextBox);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtName.Location = new System.Drawing.Point(109, 84);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 39);
            this.txtName.TabIndex = 0;
            this.txtName.Enter += new System.EventHandler(this.SetActiveTextBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label3.Location = new System.Drawing.Point(26, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 32);
            this.label3.TabIndex = 102;
            this.label3.Text = "Адрес:";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtAddress.Location = new System.Drawing.Point(109, 206);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(237, 39);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Enter += new System.EventHandler(this.SetActiveTextBox);
            // 
            // AddClient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(371, 322);
            this.ControlBox = false;
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddClient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CasheSelector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddClient_FormClosing);
            this.Load += new System.EventHandler(this.AddClient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtTittle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}