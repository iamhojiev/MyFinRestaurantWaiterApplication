namespace MyFinCassa.UI_Forms
{
    partial class CassaSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CassaSelector));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtTittle = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbCassa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.txtTittle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 63);
            this.panel1.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(35, 35);
            this.btnClose.Location = new System.Drawing.Point(344, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.PressedState.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtTittle
            // 
            this.txtTittle.AutoSize = true;
            this.txtTittle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTittle.ForeColor = System.Drawing.Color.White;
            this.txtTittle.Location = new System.Drawing.Point(12, 9);
            this.txtTittle.Name = "txtTittle";
            this.txtTittle.Size = new System.Drawing.Size(431, 65);
            this.txtTittle.TabIndex = 0;
            this.txtTittle.Text = "Назначение кассы";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.btnSave.BorderRadius = 5;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(12, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(360, 45);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 63);
            this.panel2.TabIndex = 8;
            // 
            // cmbCassa
            // 
            this.cmbCassa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCassa.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCassa.FormattingEnabled = true;
            this.cmbCassa.Location = new System.Drawing.Point(124, 95);
            this.cmbCassa.Name = "cmbCassa";
            this.cmbCassa.Size = new System.Drawing.Size(237, 56);
            this.cmbCassa.TabIndex = 103;
            this.cmbCassa.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 55);
            this.label1.TabIndex = 102;
            this.label1.Text = "Касса:";
            // 
            // CassaSelector
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 230);
            this.ControlBox = false;
            this.Controls.Add(this.cmbCassa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CassaSelector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CasheSelector";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label txtTittle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbCassa;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
    }
}