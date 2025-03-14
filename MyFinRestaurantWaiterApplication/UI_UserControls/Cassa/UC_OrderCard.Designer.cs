namespace MyFinCassa.UI_UserControls.Cassa
{
    partial class UC_OrderCard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_OrderCard));
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.pnlOrderInfo = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.txtDate = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.txtTable = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlWaiter = new System.Windows.Forms.Panel();
            this.txtWaiter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlPlace = new System.Windows.Forms.Panel();
            this.txtHall = new System.Windows.Forms.Label();
            this.picOrderType = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPrice = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnlBtn.SuspendLayout();
            this.pnlOrderInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlWaiter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlPlace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOrderType)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBtn
            // 
            this.pnlBtn.BackColor = System.Drawing.Color.White;
            this.pnlBtn.Controls.Add(this.pnlOrderInfo);
            this.pnlBtn.Controls.Add(this.btnAdd);
            this.pnlBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBtn.Location = new System.Drawing.Point(0, 0);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(272, 260);
            this.pnlBtn.TabIndex = 0;
            // 
            // pnlOrderInfo
            // 
            this.pnlOrderInfo.Controls.Add(this.flowLayoutPanel);
            this.pnlOrderInfo.Controls.Add(this.panel2);
            this.pnlOrderInfo.Controls.Add(this.panel1);
            this.pnlOrderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlOrderInfo.Name = "pnlOrderInfo";
            this.pnlOrderInfo.Size = new System.Drawing.Size(272, 260);
            this.pnlOrderInfo.TabIndex = 1;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 73);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(272, 147);
            this.flowLayoutPanel.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(106)))), ((int)(((byte)(156)))));
            this.panel2.Controls.Add(this.pnlTime);
            this.panel2.Controls.Add(this.pnlTable);
            this.panel2.Controls.Add(this.pnlWaiter);
            this.panel2.Controls.Add(this.pnlPlace);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 73);
            this.panel2.TabIndex = 7;
            // 
            // pnlTime
            // 
            this.pnlTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(106)))), ((int)(((byte)(156)))));
            this.pnlTime.Controls.Add(this.txtDate);
            this.pnlTime.Controls.Add(this.pictureBox3);
            this.pnlTime.Location = new System.Drawing.Point(169, 3);
            this.pnlTime.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(100, 30);
            this.pnlTime.TabIndex = 7;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(106)))), ((int)(((byte)(156)))));
            this.txtDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Location = new System.Drawing.Point(30, 0);
            this.txtDate.Margin = new System.Windows.Forms.Padding(0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(70, 30);
            this.txtDate.TabIndex = 1;
            this.txtDate.Text = "20:20";
            this.txtDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pnlTable
            // 
            this.pnlTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(106)))), ((int)(((byte)(156)))));
            this.pnlTable.Controls.Add(this.txtTable);
            this.pnlTable.Controls.Add(this.pictureBox4);
            this.pnlTable.Location = new System.Drawing.Point(169, 40);
            this.pnlTable.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(100, 30);
            this.pnlTable.TabIndex = 6;
            // 
            // txtTable
            // 
            this.txtTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(106)))), ((int)(((byte)(156)))));
            this.txtTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTable.ForeColor = System.Drawing.Color.White;
            this.txtTable.Location = new System.Drawing.Point(30, 0);
            this.txtTable.Margin = new System.Windows.Forms.Padding(0);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(70, 30);
            this.txtTable.TabIndex = 2;
            this.txtTable.Text = "№12";
            this.txtTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(106)))), ((int)(((byte)(156)))));
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pnlWaiter
            // 
            this.pnlWaiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(106)))), ((int)(((byte)(156)))));
            this.pnlWaiter.Controls.Add(this.txtWaiter);
            this.pnlWaiter.Controls.Add(this.pictureBox1);
            this.pnlWaiter.Location = new System.Drawing.Point(3, 3);
            this.pnlWaiter.Name = "pnlWaiter";
            this.pnlWaiter.Size = new System.Drawing.Size(163, 30);
            this.pnlWaiter.TabIndex = 3;
            // 
            // txtWaiter
            // 
            this.txtWaiter.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtWaiter.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtWaiter.ForeColor = System.Drawing.Color.White;
            this.txtWaiter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.txtWaiter.Location = new System.Drawing.Point(34, 0);
            this.txtWaiter.Name = "txtWaiter";
            this.txtWaiter.Size = new System.Drawing.Size(129, 30);
            this.txtWaiter.TabIndex = 1;
            this.txtWaiter.Text = "Название офиц";
            this.txtWaiter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlPlace
            // 
            this.pnlPlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(106)))), ((int)(((byte)(156)))));
            this.pnlPlace.Controls.Add(this.txtHall);
            this.pnlPlace.Controls.Add(this.picOrderType);
            this.pnlPlace.Location = new System.Drawing.Point(3, 40);
            this.pnlPlace.Name = "pnlPlace";
            this.pnlPlace.Size = new System.Drawing.Size(163, 30);
            this.pnlPlace.TabIndex = 4;
            // 
            // txtHall
            // 
            this.txtHall.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtHall.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHall.ForeColor = System.Drawing.Color.White;
            this.txtHall.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.txtHall.Location = new System.Drawing.Point(34, 0);
            this.txtHall.Name = "txtHall";
            this.txtHall.Size = new System.Drawing.Size(129, 30);
            this.txtHall.TabIndex = 1;
            this.txtHall.Text = "Название зала";
            this.txtHall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picOrderType
            // 
            this.picOrderType.Dock = System.Windows.Forms.DockStyle.Left;
            this.picOrderType.Image = ((System.Drawing.Image)(resources.GetObject("picOrderType.Image")));
            this.picOrderType.Location = new System.Drawing.Point(0, 0);
            this.picOrderType.Name = "picOrderType";
            this.picOrderType.Size = new System.Drawing.Size(30, 30);
            this.picOrderType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOrderType.TabIndex = 0;
            this.picOrderType.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 40);
            this.panel1.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(106)))), ((int)(((byte)(156)))));
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(0, 0);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(272, 40);
            this.txtPrice.TabIndex = 1;
            this.txtPrice.Text = "1999,00 р";
            this.txtPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.HoverState.ImageSize = new System.Drawing.Size(75, 75);
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(70, 70);
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedState.ImageSize = new System.Drawing.Size(65, 65);
            this.btnAdd.PressedState.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(272, 260);
            this.btnAdd.TabIndex = 0;
            // 
            // UC_OrderCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.pnlBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UC_OrderCard";
            this.Size = new System.Drawing.Size(272, 260);
            this.pnlBtn.ResumeLayout(false);
            this.pnlOrderInfo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlWaiter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlPlace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOrderType)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBtn;
        private Guna.UI2.WinForms.Guna2ImageButton btnAdd;
        private System.Windows.Forms.Panel pnlOrderInfo;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel pnlWaiter;
        private System.Windows.Forms.Label txtWaiter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlPlace;
        private System.Windows.Forms.Label txtHall;
        private System.Windows.Forms.PictureBox picOrderType;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtPrice;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label txtTable;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
    }
}
