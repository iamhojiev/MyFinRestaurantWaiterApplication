namespace MyFinCassa.UI_Forms
{
    partial class FrmTableChange
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
            this.btnX = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlUp = new System.Windows.Forms.Panel();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlUp.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.btnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.Color.White;
            this.pnlUp.Controls.Add(this.flowLayoutPanel1);
            this.pnlUp.Controls.Add(this.btnX);
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUp.Location = new System.Drawing.Point(0, 0);
            this.pnlUp.Margin = new System.Windows.Forms.Padding(0);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(1264, 44);
            this.pnlUp.TabIndex = 4;
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
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(333, 44);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 15);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "- Свободен";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel2.Location = new System.Drawing.Point(107, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 15);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(128, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = " - Занять";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel3.Location = new System.Drawing.Point(195, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 15);
            this.panel3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(216, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = " - Забронирован";
            // 
            // FrmTableChange
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
            this.Name = "FrmTableChange";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Coordinator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlUp.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ControlBox btnX;
        private System.Windows.Forms.Panel pnlUp;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
    }
}