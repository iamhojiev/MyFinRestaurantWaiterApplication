namespace MyFinCassa.UC
{
    partial class UC_PassChange
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShow = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReloadPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOldPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnShow.BorderRadius = 10;
            this.btnShow.CheckedState.Parent = this.btnShow;
            this.btnShow.CustomImages.Parent = this.btnShow;
            this.btnShow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.btnShow.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.HoverState.Parent = this.btnShow;
            this.btnShow.Location = new System.Drawing.Point(461, 429);
            this.btnShow.Name = "btnShow";
            this.btnShow.ShadowDecoration.Parent = this.btnShow;
            this.btnShow.Size = new System.Drawing.Size(359, 45);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Сохранить";
            this.btnShow.Click += new System.EventHandler(this.BtnSavePassword_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(523, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "Смена пароля";
            // 
            // txtReloadPass
            // 
            this.txtReloadPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReloadPass.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtReloadPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReloadPass.DefaultText = "";
            this.txtReloadPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReloadPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReloadPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReloadPass.DisabledState.Parent = this.txtReloadPass;
            this.txtReloadPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReloadPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtReloadPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReloadPass.FocusedState.Parent = this.txtReloadPass;
            this.txtReloadPass.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReloadPass.ForeColor = System.Drawing.Color.Black;
            this.txtReloadPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReloadPass.HoverState.Parent = this.txtReloadPass;
            this.txtReloadPass.Location = new System.Drawing.Point(461, 370);
            this.txtReloadPass.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtReloadPass.Name = "txtReloadPass";
            this.txtReloadPass.PasswordChar = '\0';
            this.txtReloadPass.PlaceholderText = "Повторите пароль";
            this.txtReloadPass.SelectedText = "";
            this.txtReloadPass.ShadowDecoration.Parent = this.txtReloadPass;
            this.txtReloadPass.Size = new System.Drawing.Size(359, 40);
            this.txtReloadPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtReloadPass.TabIndex = 2;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPass.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.DefaultText = "";
            this.txtNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.DisabledState.Parent = this.txtNewPass;
            this.txtNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPass.FocusedState.Parent = this.txtNewPass;
            this.txtNewPass.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.ForeColor = System.Drawing.Color.Black;
            this.txtNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewPass.HoverState.Parent = this.txtNewPass;
            this.txtNewPass.Location = new System.Drawing.Point(461, 314);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '\0';
            this.txtNewPass.PlaceholderText = "Новый пароль";
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.ShadowDecoration.Parent = this.txtNewPass;
            this.txtNewPass.Size = new System.Drawing.Size(359, 40);
            this.txtNewPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNewPass.TabIndex = 1;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOldPass.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtOldPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldPass.DefaultText = "";
            this.txtOldPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOldPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOldPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldPass.DisabledState.Parent = this.txtOldPass;
            this.txtOldPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtOldPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldPass.FocusedState.Parent = this.txtOldPass;
            this.txtOldPass.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPass.ForeColor = System.Drawing.Color.Black;
            this.txtOldPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOldPass.HoverState.Parent = this.txtOldPass;
            this.txtOldPass.Location = new System.Drawing.Point(461, 258);
            this.txtOldPass.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '\0';
            this.txtOldPass.PlaceholderText = "Старый пароль";
            this.txtOldPass.SelectedText = "";
            this.txtOldPass.ShadowDecoration.Parent = this.txtOldPass;
            this.txtOldPass.Size = new System.Drawing.Size(359, 40);
            this.txtOldPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtOldPass.TabIndex = 0;
            // 
            // UC_PassChange
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReloadPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtOldPass);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UC_PassChange";
            this.Size = new System.Drawing.Size(1280, 680);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnShow;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtReloadPass;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPass;
        private Guna.UI2.WinForms.Guna2TextBox txtOldPass;
    }
}
