namespace MyFinCassa.UC
{
    partial class UC_ShiftChange
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
            this.txtInfoChange = new System.Windows.Forms.Label();
            this.line = new Guna.UI2.WinForms.Guna2Separator();
            this.btnChange = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtInfoChange
            // 
            this.txtInfoChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfoChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtInfoChange.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoChange.Location = new System.Drawing.Point(0, 278);
            this.txtInfoChange.Name = "txtInfoChange";
            this.txtInfoChange.Size = new System.Drawing.Size(1280, 54);
            this.txtInfoChange.TabIndex = 17;
            this.txtInfoChange.Text = "Смена №1 15.05.2022 в 11.00";
            this.txtInfoChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // line
            // 
            this.line.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.line.Location = new System.Drawing.Point(415, 326);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(450, 10);
            this.line.TabIndex = 18;
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChange.Animated = true;
            this.btnChange.AutoRoundedCorners = true;
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnChange.BorderRadius = 24;
            this.btnChange.CheckedState.Parent = this.btnChange;
            this.btnChange.CustomImages.Parent = this.btnChange;
            this.btnChange.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.btnChange.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnChange.HoverState.Parent = this.btnChange;
            this.btnChange.Location = new System.Drawing.Point(460, 588);
            this.btnChange.Name = "btnChange";
            this.btnChange.ShadowDecoration.Parent = this.btnChange;
            this.btnChange.Size = new System.Drawing.Size(361, 50);
            this.btnChange.TabIndex = 5;
            this.btnChange.Text = "Открыть смену";
            this.btnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // UC_ShiftChange
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.line);
            this.Controls.Add(this.txtInfoChange);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UC_ShiftChange";
            this.Size = new System.Drawing.Size(1280, 680);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtInfoChange;
        private Guna.UI2.WinForms.Guna2Separator line;
        private Guna.UI2.WinForms.Guna2Button btnChange;
    }
}
