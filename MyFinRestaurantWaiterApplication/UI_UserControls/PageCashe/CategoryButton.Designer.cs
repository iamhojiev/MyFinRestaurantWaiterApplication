namespace MyFinCassa.UI_UserControls.PageCashe
{
    partial class CategoryButton
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
            this.Button = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.BackColor = System.Drawing.Color.White;
            this.Button.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Button.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button.CheckedState.Parent = this.Button;
            this.Button.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Button.CustomImages.Parent = this.Button;
            this.Button.FillColor = System.Drawing.Color.White;
            this.Button.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button.ForeColor = System.Drawing.Color.Black;
            this.Button.HoverState.Parent = this.Button;
  //          this.Button.Image = global::MyFinCassa.Properties.Resources.cameraOf_small;
            this.Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button.ImageOffset = new System.Drawing.Point(-5, 0);
            this.Button.ImageSize = new System.Drawing.Size(50, 50);
            this.Button.Location = new System.Drawing.Point(0, 0);
            this.Button.Name = "Button";
            this.Button.PressedColor = System.Drawing.Color.RoyalBlue;
            this.Button.ShadowDecoration.Parent = this.Button;
            this.Button.Size = new System.Drawing.Size(180, 55);
            this.Button.TabIndex = 2;
            this.Button.Text = "Category";
            this.Button.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Button.TextOffset = new System.Drawing.Point(-10, 0);
            // 
            // CategoryButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Button);
            this.Name = "CategoryButton";
            this.Size = new System.Drawing.Size(180, 60);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button Button;
    }
}
