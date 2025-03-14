namespace MyFinCassa.UC
{
    partial class CardBtn
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
            this.btn = new Guna.UI2.WinForms.Guna2Button();
            this.picCardLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCardLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BorderRadius = 15;
            this.btn.BorderThickness = 1;
            this.btn.CheckedState.Parent = this.btn;
            this.btn.CustomImages.Parent = this.btn;
            this.btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(107)))));
            this.btn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.HoverState.Parent = this.btn;
            this.btn.Location = new System.Drawing.Point(0, 0);
            this.btn.Name = "btn";
            this.btn.ShadowDecoration.Parent = this.btn;
            this.btn.Size = new System.Drawing.Size(189, 136);
            this.btn.TabIndex = 0;
            this.btn.Text = "{CardName}";
            this.btn.TextOffset = new System.Drawing.Point(0, 30);
            // 
            // picCardLogo
            // 
            this.picCardLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picCardLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(132)))), ((int)(((byte)(107)))));
            this.picCardLogo.Location = new System.Drawing.Point(60, 17);
            this.picCardLogo.Name = "picCardLogo";
            this.picCardLogo.Size = new System.Drawing.Size(68, 56);
            this.picCardLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCardLogo.TabIndex = 1;
            this.picCardLogo.TabStop = false;
            // 
            // CardBtn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.picCardLogo);
            this.Controls.Add(this.btn);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "CardBtn";
            this.Size = new System.Drawing.Size(189, 136);
            ((System.ComponentModel.ISupportInitialize)(this.picCardLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn;
        private System.Windows.Forms.PictureBox picCardLogo;
    }
}
