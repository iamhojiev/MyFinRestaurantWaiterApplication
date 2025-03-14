namespace MyFinCassa.UI_UserControls.Cassa
{
    partial class UC_Detail
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
            this.txtTotal = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.DarkCyan;
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(0, 0);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(27, 20);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "88";
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(27, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(45, 17);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Mantu";
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UC_Detail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Detail";
            this.Size = new System.Drawing.Size(150, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label txtName;
    }
}
