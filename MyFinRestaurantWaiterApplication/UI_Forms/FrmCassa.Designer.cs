namespace MyFinCassa.UI_Forms
{
    partial class FrmCassa
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
            this.components = new System.ComponentModel.Container();
            this.btnX = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlUp = new System.Windows.Forms.Panel();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlUp.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlUp.Controls.Add(this.btnRefresh);
            this.pnlUp.Controls.Add(this.btnX);
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUp.Location = new System.Drawing.Point(0, 0);
            this.pnlUp.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(1264, 44);
            this.pnlUp.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.FillColor = System.Drawing.Color.SeaGreen;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(124, 44);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Обновить";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tabControl.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tabControl.Location = new System.Drawing.Point(0, 44);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(1264, 637);
            this.tabControl.TabIndex = 5;
            this.tabControl.UseSelectable = true;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // FrmCassa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlUp);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCassa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Coordinator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlUp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ControlBox btnX;
        private System.Windows.Forms.Panel pnlUp;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}