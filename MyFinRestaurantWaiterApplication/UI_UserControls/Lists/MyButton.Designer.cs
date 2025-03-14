namespace MyFinCassa.UC
{
    partial class MyButton
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
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BorderRadius = 15;
            this.btn.CheckedState.Parent = this.btn;
            this.btn.CustomImages.Parent = this.btn;
            this.btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(74)))));
            this.btn.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.HoverState.Parent = this.btn;
            this.btn.Location = new System.Drawing.Point(0, 0);
            this.btn.Name = "btn";
            this.btn.ShadowDecoration.Parent = this.btn;
            this.btn.Size = new System.Drawing.Size(210, 183);
            this.btn.TabIndex = 0;
            this.btn.Text = "К-во мест: 123";
            // 
            // MyButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "MyButton";
            this.Size = new System.Drawing.Size(210, 183);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn;
    }
}
