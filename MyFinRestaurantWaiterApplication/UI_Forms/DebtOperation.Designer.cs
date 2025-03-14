namespace MyFinCassa.UI_Forms
{
    partial class DebtOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebtOperation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtTittle = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(418, 63);
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
            this.btnClose.Location = new System.Drawing.Point(375, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.PressedState.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // txtTittle
            // 
            this.txtTittle.AutoSize = true;
            this.txtTittle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTittle.ForeColor = System.Drawing.Color.White;
            this.txtTittle.Location = new System.Drawing.Point(12, 9);
            this.txtTittle.Name = "txtTittle";
            this.txtTittle.Size = new System.Drawing.Size(307, 45);
            this.txtTittle.TabIndex = 0;
            this.txtTittle.Text = "Оформлении долга";
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
            this.btnSave.Size = new System.Drawing.Size(394, 45);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 63);
            this.panel2.TabIndex = 8;
            // 
            // cmbClient
            // 
            this.cmbClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClient.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(139, 94);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(237, 40);
            this.cmbClient.TabIndex = 103;
            this.cmbClient.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 102;
            this.label1.Text = "Клиент:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 102;
            this.label2.Text = "Сумма:";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(139, 166);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(237, 39);
            this.txtPrice.TabIndex = 105;
            // 
            // DebtOperation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(418, 299);
            this.ControlBox = false;
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DebtOperation";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CasheSelector";
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
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
    }
}