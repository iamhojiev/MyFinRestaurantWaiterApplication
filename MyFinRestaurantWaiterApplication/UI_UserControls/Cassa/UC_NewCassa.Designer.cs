namespace MyFinCassa.UI_UserControls.Cassa
{
    partial class UC_NewCassa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_NewCassa));
            this.pnlUp = new System.Windows.Forms.Panel();
            this.btnExitBig = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlUserFilter = new System.Windows.Forms.Panel();
            this.cmbUser = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFastOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelivery = new Guna.UI2.WinForms.Guna2Button();
            this.btnCassa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSmenaBig = new Guna.UI2.WinForms.Guna2Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pnlShiftInfo = new System.Windows.Forms.Panel();
            this.txtSumma = new System.Windows.Forms.Label();
            this.txtShift = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tbl = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnPreviousPage = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnNextPage = new Guna.UI2.WinForms.Guna2ImageButton();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemPay = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSubOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemChangeTable = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemChangeOfficiant = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pnlUp.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlUserFilter.SuspendLayout();
            this.pnlShiftInfo.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlUp.Controls.Add(this.btnExitBig);
            this.pnlUp.Controls.Add(this.flowLayoutPanel1);
            this.pnlUp.Controls.Add(this.pnlShiftInfo);
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUp.Location = new System.Drawing.Point(0, 0);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(1677, 100);
            this.pnlUp.TabIndex = 3;
            // 
            // btnExitBig
            // 
            this.btnExitBig.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExitBig.CheckedState.Parent = this.btnExitBig;
            this.btnExitBig.CustomImages.Parent = this.btnExitBig;
            this.btnExitBig.FillColor = System.Drawing.Color.IndianRed;
            this.btnExitBig.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitBig.ForeColor = System.Drawing.Color.White;
            this.btnExitBig.HoverState.Parent = this.btnExitBig;
            this.btnExitBig.Image = ((System.Drawing.Image)(resources.GetObject("btnExitBig.Image")));
            this.btnExitBig.ImageSize = new System.Drawing.Size(40, 40);
            this.btnExitBig.Location = new System.Drawing.Point(1547, 27);
            this.btnExitBig.Name = "btnExitBig";
            this.btnExitBig.ShadowDecoration.Parent = this.btnExitBig;
            this.btnExitBig.Size = new System.Drawing.Size(118, 50);
            this.btnExitBig.TabIndex = 53;
            this.btnExitBig.Text = "Выйти";
            this.btnExitBig.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.flowLayoutPanel1.Controls.Add(this.pnlUserFilter);
            this.flowLayoutPanel1.Controls.Add(this.btnFastOrder);
            this.flowLayoutPanel1.Controls.Add(this.btnDelivery);
            this.flowLayoutPanel1.Controls.Add(this.btnCassa);
            this.flowLayoutPanel1.Controls.Add(this.btnSmenaBig);
            this.flowLayoutPanel1.Controls.Add(this.lblTimer);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(331, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1210, 76);
            this.flowLayoutPanel1.TabIndex = 50;
            // 
            // pnlUserFilter
            // 
            this.pnlUserFilter.Controls.Add(this.cmbUser);
            this.pnlUserFilter.Controls.Add(this.label7);
            this.pnlUserFilter.Location = new System.Drawing.Point(3, 3);
            this.pnlUserFilter.Name = "pnlUserFilter";
            this.pnlUserFilter.Size = new System.Drawing.Size(232, 70);
            this.pnlUserFilter.TabIndex = 49;
            // 
            // cmbUser
            // 
            this.cmbUser.BackColor = System.Drawing.Color.Transparent;
            this.cmbUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.FocusedColor = System.Drawing.Color.Empty;
            this.cmbUser.FocusedState.Parent = this.cmbUser;
            this.cmbUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.HoverState.Parent = this.cmbUser;
            this.cmbUser.ItemHeight = 30;
            this.cmbUser.ItemsAppearance.Parent = this.cmbUser;
            this.cmbUser.Location = new System.Drawing.Point(2, 34);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.ShadowDecoration.Parent = this.cmbUser;
            this.cmbUser.Size = new System.Drawing.Size(227, 36);
            this.cmbUser.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 32);
            this.label7.TabIndex = 42;
            this.label7.Text = "Официант:";
            // 
            // btnFastOrder
            // 
            this.btnFastOrder.Animated = true;
            this.btnFastOrder.BorderRadius = 5;
            this.btnFastOrder.CheckedState.Parent = this.btnFastOrder;
            this.btnFastOrder.CustomImages.Parent = this.btnFastOrder;
            this.btnFastOrder.FillColor = System.Drawing.Color.Teal;
            this.btnFastOrder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastOrder.ForeColor = System.Drawing.Color.White;
            this.btnFastOrder.HoverState.Parent = this.btnFastOrder;
            this.btnFastOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnFastOrder.Image")));
            this.btnFastOrder.ImageSize = new System.Drawing.Size(40, 40);
            this.btnFastOrder.Location = new System.Drawing.Point(248, 15);
            this.btnFastOrder.Margin = new System.Windows.Forms.Padding(10, 15, 3, 3);
            this.btnFastOrder.Name = "btnFastOrder";
            this.btnFastOrder.ShadowDecoration.Parent = this.btnFastOrder;
            this.btnFastOrder.Size = new System.Drawing.Size(150, 50);
            this.btnFastOrder.TabIndex = 55;
            this.btnFastOrder.Text = "С собой";
            this.btnFastOrder.Click += new System.EventHandler(this.btnWithMySelf_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.Animated = true;
            this.btnDelivery.BorderRadius = 5;
            this.btnDelivery.CheckedState.Parent = this.btnDelivery;
            this.btnDelivery.CustomImages.Parent = this.btnDelivery;
            this.btnDelivery.FillColor = System.Drawing.Color.SeaGreen;
            this.btnDelivery.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.HoverState.Parent = this.btnDelivery;
            this.btnDelivery.Image = ((System.Drawing.Image)(resources.GetObject("btnDelivery.Image")));
            this.btnDelivery.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDelivery.Location = new System.Drawing.Point(411, 15);
            this.btnDelivery.Margin = new System.Windows.Forms.Padding(10, 15, 3, 3);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.ShadowDecoration.Parent = this.btnDelivery;
            this.btnDelivery.Size = new System.Drawing.Size(150, 50);
            this.btnDelivery.TabIndex = 56;
            this.btnDelivery.Text = "Доставка";
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnCassa
            // 
            this.btnCassa.Animated = true;
            this.btnCassa.BorderRadius = 5;
            this.btnCassa.CheckedState.Parent = this.btnCassa;
            this.btnCassa.CustomImages.Parent = this.btnCassa;
            this.btnCassa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(106)))));
            this.btnCassa.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCassa.ForeColor = System.Drawing.Color.White;
            this.btnCassa.HoverState.Parent = this.btnCassa;
            this.btnCassa.Image = ((System.Drawing.Image)(resources.GetObject("btnCassa.Image")));
            this.btnCassa.ImageSize = new System.Drawing.Size(45, 45);
            this.btnCassa.Location = new System.Drawing.Point(574, 15);
            this.btnCassa.Margin = new System.Windows.Forms.Padding(10, 15, 3, 3);
            this.btnCassa.Name = "btnCassa";
            this.btnCassa.ShadowDecoration.Parent = this.btnCassa;
            this.btnCassa.Size = new System.Drawing.Size(150, 50);
            this.btnCassa.TabIndex = 57;
            this.btnCassa.Text = "Касса";
            this.btnCassa.Click += new System.EventHandler(this.btnCassa_Click);
            // 
            // btnSmenaBig
            // 
            this.btnSmenaBig.Animated = true;
            this.btnSmenaBig.BorderRadius = 5;
            this.btnSmenaBig.CheckedState.Parent = this.btnSmenaBig;
            this.btnSmenaBig.CustomImages.Parent = this.btnSmenaBig;
            this.btnSmenaBig.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(70)))));
            this.btnSmenaBig.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSmenaBig.ForeColor = System.Drawing.Color.White;
            this.btnSmenaBig.HoverState.Parent = this.btnSmenaBig;
            this.btnSmenaBig.Image = ((System.Drawing.Image)(resources.GetObject("btnSmenaBig.Image")));
            this.btnSmenaBig.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSmenaBig.Location = new System.Drawing.Point(737, 15);
            this.btnSmenaBig.Margin = new System.Windows.Forms.Padding(10, 15, 3, 3);
            this.btnSmenaBig.Name = "btnSmenaBig";
            this.btnSmenaBig.ShadowDecoration.Parent = this.btnSmenaBig;
            this.btnSmenaBig.Size = new System.Drawing.Size(129, 50);
            this.btnSmenaBig.TabIndex = 52;
            this.btnSmenaBig.Text = "Смена";
            this.btnSmenaBig.Click += new System.EventHandler(this.BtnSmenaBig_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(872, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(192, 76);
            this.lblTimer.TabIndex = 54;
            this.lblTimer.Text = "29.01.2022 11:59";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlShiftInfo
            // 
            this.pnlShiftInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlShiftInfo.Controls.Add(this.txtSumma);
            this.pnlShiftInfo.Controls.Add(this.txtShift);
            this.pnlShiftInfo.Controls.Add(this.txtName);
            this.pnlShiftInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlShiftInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlShiftInfo.Name = "pnlShiftInfo";
            this.pnlShiftInfo.Size = new System.Drawing.Size(325, 100);
            this.pnlShiftInfo.TabIndex = 3;
            // 
            // txtSumma
            // 
            this.txtSumma.AutoSize = true;
            this.txtSumma.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSumma.Location = new System.Drawing.Point(7, 68);
            this.txtSumma.Name = "txtSumma";
            this.txtSumma.Size = new System.Drawing.Size(152, 37);
            this.txtSumma.TabIndex = 0;
            this.txtSumma.Text = "{txtSumma}";
            // 
            // txtShift
            // 
            this.txtShift.AutoSize = true;
            this.txtShift.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShift.Location = new System.Drawing.Point(7, 38);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(116, 37);
            this.txtShift.TabIndex = 0;
            this.txtShift.Text = "{txtShift}";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(6, 1);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 46);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "{txtName}";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Controls.Add(this.tbl);
            this.pnlMain.Controls.Add(this.pnlLeft);
            this.pnlMain.Controls.Add(this.pnlRight);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 100);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1677, 580);
            this.pnlMain.TabIndex = 4;
            // 
            // tbl
            // 
            this.tbl.BackColor = System.Drawing.Color.LightGray;
            this.tbl.ColumnCount = 5;
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl.Location = new System.Drawing.Point(20, 0);
            this.tbl.Name = "tbl";
            this.tbl.RowCount = 3;
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbl.Size = new System.Drawing.Size(1637, 580);
            this.tbl.TabIndex = 0;
            this.tbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownHandler);
            this.tbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpHandler);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.LightGray;
            this.pnlLeft.Controls.Add(this.btnPreviousPage);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(20, 580);
            this.pnlLeft.TabIndex = 1;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.BackColor = System.Drawing.Color.LightGray;
            this.btnPreviousPage.CheckedState.Parent = this.btnPreviousPage;
            this.btnPreviousPage.HoverState.ImageSize = new System.Drawing.Size(-30, 30);
            this.btnPreviousPage.HoverState.Parent = this.btnPreviousPage;
            this.btnPreviousPage.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviousPage.Image")));
            this.btnPreviousPage.ImageSize = new System.Drawing.Size(-24, 24);
            this.btnPreviousPage.Location = new System.Drawing.Point(0, 275);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.PressedState.ImageSize = new System.Drawing.Size(-20, 20);
            this.btnPreviousPage.PressedState.Parent = this.btnPreviousPage;
            this.btnPreviousPage.Size = new System.Drawing.Size(24, 30);
            this.btnPreviousPage.TabIndex = 0;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.LightGray;
            this.pnlRight.Controls.Add(this.btnNextPage);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(1657, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(20, 580);
            this.pnlRight.TabIndex = 2;
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.LightGray;
            this.btnNextPage.CheckedState.Parent = this.btnNextPage;
            this.btnNextPage.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNextPage.HoverState.Parent = this.btnNextPage;
            this.btnNextPage.Image = ((System.Drawing.Image)(resources.GetObject("btnNextPage.Image")));
            this.btnNextPage.ImageSize = new System.Drawing.Size(24, 24);
            this.btnNextPage.Location = new System.Drawing.Point(-4, 275);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.PressedState.Parent = this.btnNextPage;
            this.btnNextPage.Size = new System.Drawing.Size(24, 30);
            this.btnNextPage.TabIndex = 0;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPay,
            this.menuItemSubOrder,
            this.menuItemChangeTable,
            this.menuItemChangeOfficiant,
            this.menuItemPrint,
            this.menuItemCancel});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(350, 340);
            // 
            // menuItemPay
            // 
            this.menuItemPay.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemPay.Image = ((System.Drawing.Image)(resources.GetObject("menuItemPay.Image")));
            this.menuItemPay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItemPay.Name = "menuItemPay";
            this.menuItemPay.Size = new System.Drawing.Size(349, 56);
            this.menuItemPay.Text = "Оплатить";
            this.menuItemPay.Click += new System.EventHandler(this.MenuItemPay_Click);
            // 
            // menuItemSubOrder
            // 
            this.menuItemSubOrder.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemSubOrder.Image = ((System.Drawing.Image)(resources.GetObject("menuItemSubOrder.Image")));
            this.menuItemSubOrder.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItemSubOrder.Name = "menuItemSubOrder";
            this.menuItemSubOrder.Size = new System.Drawing.Size(349, 56);
            this.menuItemSubOrder.Text = "Дозаказ";
            this.menuItemSubOrder.Click += new System.EventHandler(this.MenuItemSubOrder_Click);
            // 
            // menuItemChangeTable
            // 
            this.menuItemChangeTable.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.menuItemChangeTable.Image = ((System.Drawing.Image)(resources.GetObject("menuItemChangeTable.Image")));
            this.menuItemChangeTable.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItemChangeTable.Name = "menuItemChangeTable";
            this.menuItemChangeTable.Size = new System.Drawing.Size(349, 56);
            this.menuItemChangeTable.Text = "Сменить стол";
            this.menuItemChangeTable.Click += new System.EventHandler(this.menuItemChangeTable_Click);
            // 
            // menuItemChangeOfficiant
            // 
            this.menuItemChangeOfficiant.Font = new System.Drawing.Font("Segoe UI", 19.8F);
            this.menuItemChangeOfficiant.Image = ((System.Drawing.Image)(resources.GetObject("menuItemChangeOfficiant.Image")));
            this.menuItemChangeOfficiant.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItemChangeOfficiant.Name = "menuItemChangeOfficiant";
            this.menuItemChangeOfficiant.Size = new System.Drawing.Size(349, 56);
            this.menuItemChangeOfficiant.Text = "Сменить офиц.";
            this.menuItemChangeOfficiant.Click += new System.EventHandler(this.menuItemChangeOfficiant_Click);
            // 
            // menuItemPrint
            // 
            this.menuItemPrint.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemPrint.Image = ((System.Drawing.Image)(resources.GetObject("menuItemPrint.Image")));
            this.menuItemPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItemPrint.Name = "menuItemPrint";
            this.menuItemPrint.Size = new System.Drawing.Size(349, 56);
            this.menuItemPrint.Text = "Печать";
            this.menuItemPrint.Click += new System.EventHandler(this.MenuItemPrint_Click);
            // 
            // menuItemCancel
            // 
            this.menuItemCancel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemCancel.Image = ((System.Drawing.Image)(resources.GetObject("menuItemCancel.Image")));
            this.menuItemCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuItemCancel.Name = "menuItemCancel";
            this.menuItemCancel.Size = new System.Drawing.Size(349, 56);
            this.menuItemCancel.Text = "Отменить";
            this.menuItemCancel.Click += new System.EventHandler(this.MenuItemCancel_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 8000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // UC_NewCassa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlUp);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UC_NewCassa";
            this.Size = new System.Drawing.Size(1677, 680);
            this.pnlUp.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlUserFilter.ResumeLayout(false);
            this.pnlUserFilter.PerformLayout();
            this.pnlShiftInfo.ResumeLayout(false);
            this.pnlShiftInfo.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlUp;
        private System.Windows.Forms.Panel pnlShiftInfo;
        private System.Windows.Forms.Label txtSumma;
        private System.Windows.Forms.Label txtShift;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem menuItemPay;
        private System.Windows.Forms.ToolStripMenuItem menuItemSubOrder;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem menuItemPrint;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem menuItemCancel;
        private Guna.UI2.WinForms.Guna2Button btnSmenaBig;
        private Guna.UI2.WinForms.Guna2Button btnExitBig;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel pnlUserFilter;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUser;
        private Guna.UI2.WinForms.Guna2Button btnFastOrder;
        private System.Windows.Forms.ToolStripMenuItem menuItemChangeTable;
        private System.Windows.Forms.ToolStripMenuItem menuItemChangeOfficiant;
        private System.Windows.Forms.TableLayoutPanel tbl;
        private Guna.UI2.WinForms.Guna2ImageButton btnPreviousPage;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private Guna.UI2.WinForms.Guna2ImageButton btnNextPage;
        private Guna.UI2.WinForms.Guna2Button btnDelivery;
        private Guna.UI2.WinForms.Guna2Button btnCassa;
    }
}
