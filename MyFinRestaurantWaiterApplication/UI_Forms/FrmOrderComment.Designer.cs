namespace MyFinCassa.UI_Forms
{
    partial class FrmOrderComment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderComment));
            this.txtTittle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtComment = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnPending = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTittle
            // 
            this.txtTittle.AutoSize = true;
            this.txtTittle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTittle.ForeColor = System.Drawing.Color.White;
            this.txtTittle.Location = new System.Drawing.Point(10, 5);
            this.txtTittle.Name = "txtTittle";
            this.txtTittle.Size = new System.Drawing.Size(377, 50);
            this.txtTittle.TabIndex = 0;
            this.txtTittle.Text = "Коментарии к заказу";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.txtTittle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 50);
            this.panel1.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.CheckedState.Parent = this.BtnClose;
            this.BtnClose.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnClose.HoverState.Parent = this.BtnClose;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnClose.Location = new System.Drawing.Point(513, 5);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnClose.PressedState.Parent = this.BtnClose;
            this.BtnClose.Size = new System.Drawing.Size(40, 40);
            this.BtnClose.TabIndex = 2;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // txtComment
            // 
            this.txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.DefaultText = "";
            this.txtComment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtComment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtComment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComment.DisabledState.Parent = this.txtComment;
            this.txtComment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComment.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtComment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComment.FocusedState.Parent = this.txtComment;
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.ForeColor = System.Drawing.Color.Black;
            this.txtComment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComment.HoverState.Parent = this.txtComment;
            this.txtComment.Location = new System.Drawing.Point(16, 68);
            this.txtComment.Margin = new System.Windows.Forms.Padding(6);
            this.txtComment.Name = "txtComment";
            this.txtComment.PasswordChar = '\0';
            this.txtComment.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtComment.PlaceholderText = "";
            this.txtComment.SelectedText = "";
            this.txtComment.ShadowDecoration.Parent = this.txtComment;
            this.txtComment.Size = new System.Drawing.Size(524, 56);
            this.txtComment.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtComment.TabIndex = 0;
            // 
            // BtnPending
            // 
            this.BtnPending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPending.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPending.FlatAppearance.BorderSize = 0;
            this.BtnPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPending.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.BtnPending.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BtnPending.Location = new System.Drawing.Point(351, 136);
            this.BtnPending.Name = "BtnPending";
            this.BtnPending.Size = new System.Drawing.Size(205, 56);
            this.BtnPending.TabIndex = 1;
            this.BtnPending.Text = "В отложку";
            this.BtnPending.UseVisualStyleBackColor = false;
            this.BtnPending.Click += new System.EventHandler(this.BtnPending_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.BtnSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSave.Location = new System.Drawing.Point(141, 136);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(210, 56);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Сохранить";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmOrderComment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(556, 193);
            this.ControlBox = false;
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnPending);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrderComment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmOrderComment_FormClosing);
            this.Load += new System.EventHandler(this.FrmOrderComment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txtTittle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnPending;
        public Guna.UI2.WinForms.Guna2TextBox txtComment;
        private Guna.UI2.WinForms.Guna2ImageButton BtnClose;
        private System.Windows.Forms.Button BtnSave;
    }
}