namespace MyFinCassa.UI_Forms
{
    partial class FrmDeliveryType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeliveryType));
            this.txtTittle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtDelivery1Info = new System.Windows.Forms.Label();
            this.picDelivery1 = new System.Windows.Forms.PictureBox();
            this.txtDelivery1 = new System.Windows.Forms.Label();
            this.btnDelivery1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.txtDelivery2Info = new System.Windows.Forms.Label();
            this.btnDelivery2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.picDelivery2 = new System.Windows.Forms.PictureBox();
            this.txtDelivery2 = new System.Windows.Forms.Label();
            this.txtDelivery3Info = new System.Windows.Forms.Label();
            this.btnDelivery3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.picDelivery3 = new System.Windows.Forms.PictureBox();
            this.txtDelivery3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelivery1)).BeginInit();
            this.btnDelivery1.SuspendLayout();
            this.btnDelivery2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelivery2)).BeginInit();
            this.btnDelivery3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelivery3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTittle
            // 
            this.txtTittle.AutoSize = true;
            this.txtTittle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTittle.ForeColor = System.Drawing.Color.White;
            this.txtTittle.Location = new System.Drawing.Point(12, 8);
            this.txtTittle.Name = "txtTittle";
            this.txtTittle.Size = new System.Drawing.Size(274, 32);
            this.txtTittle.TabIndex = 0;
            this.txtTittle.Text = "Выберите тип доставки";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.txtTittle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 48);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageSize = new System.Drawing.Size(35, 35);
            this.btnClose.Location = new System.Drawing.Point(702, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.PressedState.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(42, 41);
            this.btnClose.TabIndex = 3;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtDelivery1Info
            // 
            this.txtDelivery1Info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDelivery1Info.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDelivery1Info.Location = new System.Drawing.Point(51, 239);
            this.txtDelivery1Info.Name = "txtDelivery1Info";
            this.txtDelivery1Info.Size = new System.Drawing.Size(185, 86);
            this.txtDelivery1Info.TabIndex = 57;
            this.txtDelivery1Info.Text = "Доставка в пригороды и смежные районы.";
            this.txtDelivery1Info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picDelivery1
            // 
            this.picDelivery1.BackColor = System.Drawing.Color.Transparent;
            this.picDelivery1.Dock = System.Windows.Forms.DockStyle.Top;
            this.picDelivery1.Image = ((System.Drawing.Image)(resources.GetObject("picDelivery1.Image")));
            this.picDelivery1.Location = new System.Drawing.Point(0, 0);
            this.picDelivery1.Name = "picDelivery1";
            this.picDelivery1.Size = new System.Drawing.Size(185, 75);
            this.picDelivery1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDelivery1.TabIndex = 0;
            this.picDelivery1.TabStop = false;
            this.picDelivery1.Click += new System.EventHandler(this.Delivery1_Click);
            this.picDelivery1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDelivery3_MouseDown);
            this.picDelivery1.MouseEnter += new System.EventHandler(this.btnDelivery3_MouseEnter);
            this.picDelivery1.MouseLeave += new System.EventHandler(this.btnDelivery3_MouseLeave);
            // 
            // txtDelivery1
            // 
            this.txtDelivery1.BackColor = System.Drawing.Color.Transparent;
            this.txtDelivery1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDelivery1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDelivery1.Location = new System.Drawing.Point(0, 73);
            this.txtDelivery1.Name = "txtDelivery1";
            this.txtDelivery1.Size = new System.Drawing.Size(185, 77);
            this.txtDelivery1.TabIndex = 1;
            this.txtDelivery1.Text = "Ближние районы\r\nЦена: 99смн";
            this.txtDelivery1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtDelivery1.Click += new System.EventHandler(this.Delivery1_Click);
            this.txtDelivery1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDelivery3_MouseDown);
            this.txtDelivery1.MouseEnter += new System.EventHandler(this.btnDelivery3_MouseEnter);
            this.txtDelivery1.MouseLeave += new System.EventHandler(this.btnDelivery3_MouseLeave);
            // 
            // btnDelivery1
            // 
            this.btnDelivery1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelivery1.BorderRadius = 20;
            this.btnDelivery1.Controls.Add(this.picDelivery1);
            this.btnDelivery1.Controls.Add(this.txtDelivery1);
            this.btnDelivery1.FillColor = System.Drawing.Color.LightBlue;
            this.btnDelivery1.FillColor2 = System.Drawing.Color.LightBlue;
            this.btnDelivery1.Location = new System.Drawing.Point(51, 75);
            this.btnDelivery1.Name = "btnDelivery1";
            this.btnDelivery1.ShadowDecoration.Parent = this.btnDelivery1;
            this.btnDelivery1.Size = new System.Drawing.Size(185, 150);
            this.btnDelivery1.TabIndex = 59;
            this.btnDelivery1.Click += new System.EventHandler(this.Delivery1_Click);
            // 
            // txtDelivery2Info
            // 
            this.txtDelivery2Info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDelivery2Info.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDelivery2Info.Location = new System.Drawing.Point(281, 239);
            this.txtDelivery2Info.Name = "txtDelivery2Info";
            this.txtDelivery2Info.Size = new System.Drawing.Size(185, 86);
            this.txtDelivery2Info.TabIndex = 57;
            this.txtDelivery2Info.Text = "Быстрая доставка в пределах городских границ.\r\n";
            this.txtDelivery2Info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDelivery2
            // 
            this.btnDelivery2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelivery2.BorderRadius = 20;
            this.btnDelivery2.Controls.Add(this.picDelivery2);
            this.btnDelivery2.Controls.Add(this.txtDelivery2);
            this.btnDelivery2.FillColor = System.Drawing.Color.LightBlue;
            this.btnDelivery2.FillColor2 = System.Drawing.Color.LightBlue;
            this.btnDelivery2.Location = new System.Drawing.Point(281, 75);
            this.btnDelivery2.Name = "btnDelivery2";
            this.btnDelivery2.ShadowDecoration.Parent = this.btnDelivery2;
            this.btnDelivery2.Size = new System.Drawing.Size(185, 150);
            this.btnDelivery2.TabIndex = 59;
            this.btnDelivery2.Click += new System.EventHandler(this.Delivery2_Click);
            // 
            // picDelivery2
            // 
            this.picDelivery2.BackColor = System.Drawing.Color.Transparent;
            this.picDelivery2.Dock = System.Windows.Forms.DockStyle.Top;
            this.picDelivery2.Image = ((System.Drawing.Image)(resources.GetObject("picDelivery2.Image")));
            this.picDelivery2.Location = new System.Drawing.Point(0, 0);
            this.picDelivery2.Name = "picDelivery2";
            this.picDelivery2.Size = new System.Drawing.Size(185, 75);
            this.picDelivery2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDelivery2.TabIndex = 0;
            this.picDelivery2.TabStop = false;
            this.picDelivery2.Click += new System.EventHandler(this.Delivery2_Click);
            this.picDelivery2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDelivery3_MouseDown);
            this.picDelivery2.MouseEnter += new System.EventHandler(this.btnDelivery3_MouseEnter);
            this.picDelivery2.MouseLeave += new System.EventHandler(this.btnDelivery3_MouseLeave);
            // 
            // txtDelivery2
            // 
            this.txtDelivery2.BackColor = System.Drawing.Color.Transparent;
            this.txtDelivery2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDelivery2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDelivery2.Location = new System.Drawing.Point(0, 73);
            this.txtDelivery2.Name = "txtDelivery2";
            this.txtDelivery2.Size = new System.Drawing.Size(185, 77);
            this.txtDelivery2.TabIndex = 1;
            this.txtDelivery2.Text = "Внутри города\r\nЦена: 159смн";
            this.txtDelivery2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtDelivery2.Click += new System.EventHandler(this.Delivery2_Click);
            this.txtDelivery2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDelivery3_MouseDown);
            this.txtDelivery2.MouseEnter += new System.EventHandler(this.btnDelivery3_MouseEnter);
            this.txtDelivery2.MouseLeave += new System.EventHandler(this.btnDelivery3_MouseLeave);
            // 
            // txtDelivery3Info
            // 
            this.txtDelivery3Info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDelivery3Info.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtDelivery3Info.Location = new System.Drawing.Point(511, 239);
            this.txtDelivery3Info.Name = "txtDelivery3Info";
            this.txtDelivery3Info.Size = new System.Drawing.Size(185, 86);
            this.txtDelivery3Info.TabIndex = 57;
            this.txtDelivery3Info.Text = "Доставка в отдаленные районы за городом.\r\n";
            this.txtDelivery3Info.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDelivery3
            // 
            this.btnDelivery3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelivery3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelivery3.BorderRadius = 20;
            this.btnDelivery3.Controls.Add(this.picDelivery3);
            this.btnDelivery3.Controls.Add(this.txtDelivery3);
            this.btnDelivery3.FillColor = System.Drawing.Color.LightBlue;
            this.btnDelivery3.FillColor2 = System.Drawing.Color.LightBlue;
            this.btnDelivery3.Location = new System.Drawing.Point(511, 75);
            this.btnDelivery3.Name = "btnDelivery3";
            this.btnDelivery3.ShadowDecoration.Parent = this.btnDelivery3;
            this.btnDelivery3.Size = new System.Drawing.Size(185, 150);
            this.btnDelivery3.TabIndex = 59;
            this.btnDelivery3.Click += new System.EventHandler(this.Delivery3_Click);
            // 
            // picDelivery3
            // 
            this.picDelivery3.BackColor = System.Drawing.Color.Transparent;
            this.picDelivery3.Dock = System.Windows.Forms.DockStyle.Top;
            this.picDelivery3.Image = ((System.Drawing.Image)(resources.GetObject("picDelivery3.Image")));
            this.picDelivery3.Location = new System.Drawing.Point(0, 0);
            this.picDelivery3.Name = "picDelivery3";
            this.picDelivery3.Size = new System.Drawing.Size(185, 75);
            this.picDelivery3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDelivery3.TabIndex = 0;
            this.picDelivery3.TabStop = false;
            this.picDelivery3.Click += new System.EventHandler(this.Delivery3_Click);
            this.picDelivery3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDelivery3_MouseDown);
            this.picDelivery3.MouseEnter += new System.EventHandler(this.btnDelivery3_MouseEnter);
            this.picDelivery3.MouseLeave += new System.EventHandler(this.btnDelivery3_MouseLeave);
            // 
            // txtDelivery3
            // 
            this.txtDelivery3.BackColor = System.Drawing.Color.Transparent;
            this.txtDelivery3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDelivery3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDelivery3.Location = new System.Drawing.Point(0, 73);
            this.txtDelivery3.Name = "txtDelivery3";
            this.txtDelivery3.Size = new System.Drawing.Size(185, 77);
            this.txtDelivery3.TabIndex = 1;
            this.txtDelivery3.Text = "Загородная\r\nЦена: 199смн";
            this.txtDelivery3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtDelivery3.Click += new System.EventHandler(this.Delivery3_Click);
            this.txtDelivery3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnDelivery3_MouseDown);
            this.txtDelivery3.MouseEnter += new System.EventHandler(this.btnDelivery3_MouseEnter);
            this.txtDelivery3.MouseLeave += new System.EventHandler(this.btnDelivery3_MouseLeave);
            // 
            // FrmDeliveryType
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(747, 339);
            this.Controls.Add(this.btnDelivery3);
            this.Controls.Add(this.btnDelivery2);
            this.Controls.Add(this.txtDelivery3Info);
            this.Controls.Add(this.txtDelivery2Info);
            this.Controls.Add(this.btnDelivery1);
            this.Controls.Add(this.txtDelivery1Info);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDeliveryType";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDelivery1)).EndInit();
            this.btnDelivery1.ResumeLayout(false);
            this.btnDelivery2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDelivery2)).EndInit();
            this.btnDelivery3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDelivery3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txtTittle;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtDelivery1Info;
        private System.Windows.Forms.PictureBox picDelivery1;
        private System.Windows.Forms.Label txtDelivery1;
        private Guna.UI2.WinForms.Guna2GradientPanel btnDelivery1;
        private System.Windows.Forms.Label txtDelivery2Info;
        private Guna.UI2.WinForms.Guna2GradientPanel btnDelivery2;
        private System.Windows.Forms.PictureBox picDelivery2;
        private System.Windows.Forms.Label txtDelivery2;
        private System.Windows.Forms.Label txtDelivery3Info;
        private Guna.UI2.WinForms.Guna2GradientPanel btnDelivery3;
        private System.Windows.Forms.PictureBox picDelivery3;
        private System.Windows.Forms.Label txtDelivery3;
    }
}