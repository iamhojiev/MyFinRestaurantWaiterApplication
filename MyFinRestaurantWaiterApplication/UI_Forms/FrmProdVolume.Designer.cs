namespace MyFinCassa.UI_Forms
{
    partial class FrmProdVolume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdVolume));
            this.txtTittle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtVolume = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnOk = new System.Windows.Forms.Button();
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
            this.txtTittle.Size = new System.Drawing.Size(285, 40);
            this.txtTittle.TabIndex = 0;
            this.txtTittle.Text = "Вводите количество";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.txtTittle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 50);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(35, 35);
            this.btnClose.Location = new System.Drawing.Point(319, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.PressedState.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // txtVolume
            // 
            this.txtVolume.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtVolume.DefaultText = "";
            this.txtVolume.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtVolume.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtVolume.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVolume.DisabledState.Parent = this.txtVolume;
            this.txtVolume.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtVolume.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtVolume.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVolume.FocusedState.Parent = this.txtVolume;
            this.txtVolume.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.ForeColor = System.Drawing.Color.Black;
            this.txtVolume.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtVolume.HoverState.Parent = this.txtVolume;
            this.txtVolume.Location = new System.Drawing.Point(16, 68);
            this.txtVolume.Margin = new System.Windows.Forms.Padding(6);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.PasswordChar = '\0';
            this.txtVolume.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtVolume.PlaceholderText = "";
            this.txtVolume.SelectedText = "";
            this.txtVolume.ShadowDecoration.Parent = this.txtVolume;
            this.txtVolume.Size = new System.Drawing.Size(331, 56);
            this.txtVolume.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtVolume.TabIndex = 0;
            this.txtVolume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnOk.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnOk.Location = new System.Drawing.Point(187, 136);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(175, 56);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Сохранить";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // FrmProdVolume
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(362, 193);
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProdVolume";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProdVolume_FormClosing);
            this.Load += new System.EventHandler(this.FrmProdVolume_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txtTittle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOk;
        public Guna.UI2.WinForms.Guna2TextBox txtVolume;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
    }
}