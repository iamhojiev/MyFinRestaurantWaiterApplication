namespace MyFinCassa.UC
{
    partial class MyTable
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
            this.btn.BorderThickness = 1;
            this.btn.CheckedState.Parent = this.btn;
            this.btn.CustomImages.Parent = this.btn;
            this.btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btn.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.HoverState.Parent = this.btn;
            this.btn.Location = new System.Drawing.Point(0, 0);
            this.btn.Name = "btn";
            this.btn.ShadowDecoration.Parent = this.btn;
            this.btn.Size = new System.Drawing.Size(276, 222);
            this.btn.TabIndex = 0;
            // 
            // MyTable
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "MyTable";
            this.Size = new System.Drawing.Size(276, 222);
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2Button btn;
    }
}
