namespace MyFinCassa.UI_Forms
{
    partial class FrmWaiterSelect
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
            this.mainContainer = new System.Windows.Forms.Panel();
            this.btnX = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlUp = new System.Windows.Forms.Panel();
            this.pnlUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.BackColor = System.Drawing.Color.White;
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 44);
            this.mainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(1264, 637);
            this.mainContainer.TabIndex = 1;
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.FillColor = System.Drawing.Color.Brown;
            this.btnX.HoverState.Parent = this.btnX;
            this.btnX.IconColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(1190, 6);
            this.btnX.Name = "btnX";
            this.btnX.ShadowDecoration.Parent = this.btnX;
            this.btnX.Size = new System.Drawing.Size(69, 33);
            this.btnX.TabIndex = 3;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.Color.White;
            this.pnlUp.Controls.Add(this.btnX);
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUp.Location = new System.Drawing.Point(0, 0);
            this.pnlUp.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(1264, 44);
            this.pnlUp.TabIndex = 4;
            // 
            // FrmWaiterSelect
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.pnlUp);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWaiterSelect";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Coordinator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlUp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainContainer;
        private Guna.UI2.WinForms.Guna2ControlBox btnX;
        private System.Windows.Forms.Panel pnlUp;
    }
}