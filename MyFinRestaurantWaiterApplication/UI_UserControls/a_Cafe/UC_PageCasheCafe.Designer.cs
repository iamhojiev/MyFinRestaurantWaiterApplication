namespace MyFinCassa.UC
{
    partial class UC_PageCasheCafe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PageCasheCafe));
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.productParent = new System.Windows.Forms.Panel();
            this.productsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.categoriesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaved = new Guna.UI2.WinForms.Guna2Button();
            this.panelRightSide = new System.Windows.Forms.Panel();
            this.btnClearBasket = new Guna.UI2.WinForms.Guna2Button();
            this.txtOrderNum = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtTotal = new System.Windows.Forms.Label();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator5 = new Guna.UI2.WinForms.Guna2Separator();
            this.pnlComment = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toggleComment = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.btnToPending = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelivery = new Guna.UI2.WinForms.Guna2Button();
            this.panelMyProducts = new System.Windows.Forms.Panel();
            this.dgvProduct = new Guna.UI2.WinForms.Guna2DataGridView();
            this.GridBtnAddOne = new System.Windows.Forms.DataGridViewImageColumn();
            this.GridBtnMinusOne = new System.Windows.Forms.DataGridViewImageColumn();
            this.GridBtnRemoveAll = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.timerInit = new System.Windows.Forms.Timer(this.components);
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelLeftSide.SuspendLayout();
            this.productParent.SuspendLayout();
            this.categoriesFlowPanel.SuspendLayout();
            this.panelRightSide.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.pnlComment.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelMyProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLeftSide.BackColor = System.Drawing.Color.White;
            this.panelLeftSide.Controls.Add(this.productParent);
            this.panelLeftSide.Controls.Add(this.categoriesFlowPanel);
            this.panelLeftSide.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(866, 720);
            this.panelLeftSide.TabIndex = 0;
            // 
            // productParent
            // 
            this.productParent.BackColor = System.Drawing.Color.White;
            this.productParent.Controls.Add(this.productsFlowPanel);
            this.productParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productParent.Location = new System.Drawing.Point(188, 0);
            this.productParent.Name = "productParent";
            this.productParent.Size = new System.Drawing.Size(678, 720);
            this.productParent.TabIndex = 2;
            // 
            // productsFlowPanel
            // 
            this.productsFlowPanel.AutoScroll = true;
            this.productsFlowPanel.BackColor = System.Drawing.Color.White;
            this.productsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.productsFlowPanel.Name = "productsFlowPanel";
            this.productsFlowPanel.Size = new System.Drawing.Size(678, 720);
            this.productsFlowPanel.TabIndex = 0;
            // 
            // categoriesFlowPanel
            // 
            this.categoriesFlowPanel.AutoScroll = true;
            this.categoriesFlowPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.categoriesFlowPanel.Controls.Add(this.btnSaved);
            this.categoriesFlowPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoriesFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.categoriesFlowPanel.Name = "categoriesFlowPanel";
            this.categoriesFlowPanel.Size = new System.Drawing.Size(188, 720);
            this.categoriesFlowPanel.TabIndex = 1;
            // 
            // btnSaved
            // 
            this.btnSaved.BorderRadius = 10;
            this.btnSaved.CheckedState.Parent = this.btnSaved;
            this.btnSaved.CustomImages.Parent = this.btnSaved;
            this.btnSaved.FillColor = System.Drawing.Color.DarkCyan;
            this.btnSaved.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaved.ForeColor = System.Drawing.Color.White;
            this.btnSaved.HoverState.Parent = this.btnSaved;
            this.btnSaved.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSaved.Location = new System.Drawing.Point(3, 3);
            this.btnSaved.Name = "btnSaved";
            this.btnSaved.ShadowDecoration.Parent = this.btnSaved;
            this.btnSaved.Size = new System.Drawing.Size(179, 57);
            this.btnSaved.TabIndex = 6;
            this.btnSaved.Text = "Отложенные";
            this.btnSaved.Click += new System.EventHandler(this.btnSaved_Click);
            // 
            // panelRightSide
            // 
            this.panelRightSide.BackColor = System.Drawing.Color.White;
            this.panelRightSide.Controls.Add(this.btnClearBasket);
            this.panelRightSide.Controls.Add(this.txtOrderNum);
            this.panelRightSide.Controls.Add(this.flowLayoutPanel2);
            this.panelRightSide.Controls.Add(this.flowLayoutPanel1);
            this.panelRightSide.Controls.Add(this.panelMyProducts);
            this.panelRightSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightSide.Location = new System.Drawing.Point(870, 0);
            this.panelRightSide.Name = "panelRightSide";
            this.panelRightSide.Size = new System.Drawing.Size(410, 720);
            this.panelRightSide.TabIndex = 1;
            // 
            // btnClearBasket
            // 
            this.btnClearBasket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearBasket.BorderRadius = 10;
            this.btnClearBasket.CheckedState.Parent = this.btnClearBasket;
            this.btnClearBasket.CustomImages.Parent = this.btnClearBasket;
            this.btnClearBasket.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(61)))), ((int)(((byte)(67)))));
            this.btnClearBasket.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.btnClearBasket.ForeColor = System.Drawing.Color.White;
            this.btnClearBasket.HoverState.Parent = this.btnClearBasket;
            this.btnClearBasket.Location = new System.Drawing.Point(277, 0);
            this.btnClearBasket.Name = "btnClearBasket";
            this.btnClearBasket.ShadowDecoration.Parent = this.btnClearBasket;
            this.btnClearBasket.Size = new System.Drawing.Size(130, 43);
            this.btnClearBasket.TabIndex = 6;
            this.btnClearBasket.Text = "Очистить";
            this.btnClearBasket.Click += new System.EventHandler(this.BtnClearBasket_Click);
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Font = new System.Drawing.Font("Consolas", 19F);
            this.txtOrderNum.Location = new System.Drawing.Point(0, 0);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(209, 43);
            this.txtOrderNum.TabIndex = 5;
            this.txtOrderNum.Text = "Заказ: 12";
            this.txtOrderNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Controls.Add(this.guna2Separator3);
            this.flowLayoutPanel2.Controls.Add(this.txtTotal);
            this.flowLayoutPanel2.Controls.Add(this.txtDiscount);
            this.flowLayoutPanel2.Controls.Add(this.guna2Separator5);
            this.flowLayoutPanel2.Controls.Add(this.pnlComment);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(46, 479);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(30, 5, 0, 5);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(364, 160);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Separator3.Location = new System.Drawing.Point(91, 137);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(248, 10);
            this.guna2Separator3.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.Location = new System.Drawing.Point(33, 104);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(306, 30);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "Итого: 0 руб.";
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtDiscount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.DisabledState.Parent = this.txtDiscount;
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.FocusedState.Parent = this.txtDiscount;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.HoverState.Parent = this.txtDiscount;
            this.txtDiscount.Location = new System.Drawing.Point(177, 69);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDiscount.PlaceholderText = "Скидка";
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.ShadowDecoration.Parent = this.txtDiscount;
            this.txtDiscount.Size = new System.Drawing.Size(159, 29);
            this.txtDiscount.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDiscount.TabIndex = 3;
            this.txtDiscount.TextChanged += new System.EventHandler(this.TxtDiscont_TextChanged);
            this.txtDiscount.Enter += new System.EventHandler(this.txtDiscount_Enter);
            this.txtDiscount.Leave += new System.EventHandler(this.txtDiscount_Leave);
            // 
            // guna2Separator5
            // 
            this.guna2Separator5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Separator5.Location = new System.Drawing.Point(63, 50);
            this.guna2Separator5.Name = "guna2Separator5";
            this.guna2Separator5.Size = new System.Drawing.Size(276, 10);
            this.guna2Separator5.TabIndex = 4;
            // 
            // pnlComment
            // 
            this.pnlComment.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlComment.Controls.Add(this.label1);
            this.pnlComment.Controls.Add(this.toggleComment);
            this.pnlComment.Location = new System.Drawing.Point(118, 11);
            this.pnlComment.Name = "pnlComment";
            this.pnlComment.Size = new System.Drawing.Size(221, 33);
            this.pnlComment.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Комментария:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toggleComment
            // 
            this.toggleComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleComment.Animated = true;
            this.toggleComment.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleComment.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleComment.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleComment.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleComment.CheckedState.Parent = this.toggleComment;
            this.toggleComment.Location = new System.Drawing.Point(173, 3);
            this.toggleComment.Name = "toggleComment";
            this.toggleComment.ShadowDecoration.Parent = this.toggleComment;
            this.toggleComment.Size = new System.Drawing.Size(45, 26);
            this.toggleComment.TabIndex = 5;
            this.toggleComment.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleComment.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.toggleComment.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleComment.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleComment.UncheckedState.Parent = this.toggleComment;
            this.toggleComment.CheckedChanged += new System.EventHandler(this.ToggleComment_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.btnPay);
            this.flowLayoutPanel1.Controls.Add(this.btnToPending);
            this.flowLayoutPanel1.Controls.Add(this.btnDelivery);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 638);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(409, 79);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnPay
            // 
            this.btnPay.BorderRadius = 10;
            this.btnPay.CheckedState.Parent = this.btnPay;
            this.btnPay.CustomImages.Parent = this.btnPay;
            this.btnPay.FillColor = System.Drawing.Color.SeaGreen;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.HoverState.Parent = this.btnPay;
            this.btnPay.Location = new System.Drawing.Point(276, 3);
            this.btnPay.Name = "btnPay";
            this.btnPay.ShadowDecoration.Parent = this.btnPay;
            this.btnPay.Size = new System.Drawing.Size(130, 75);
            this.btnPay.TabIndex = 0;
            this.btnPay.Text = "Оплата";
            this.btnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // btnToPending
            // 
            this.btnToPending.BorderRadius = 10;
            this.btnToPending.CheckedState.Parent = this.btnToPending;
            this.btnToPending.CustomImages.Parent = this.btnToPending;
            this.btnToPending.FillColor = System.Drawing.Color.DarkCyan;
            this.btnToPending.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToPending.ForeColor = System.Drawing.Color.White;
            this.btnToPending.HoverState.Parent = this.btnToPending;
            this.btnToPending.Location = new System.Drawing.Point(140, 3);
            this.btnToPending.Name = "btnToPending";
            this.btnToPending.ShadowDecoration.Parent = this.btnToPending;
            this.btnToPending.Size = new System.Drawing.Size(130, 75);
            this.btnToPending.TabIndex = 2;
            this.btnToPending.Text = "Отложить";
            this.btnToPending.Click += new System.EventHandler(this.BtnPending_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.BorderRadius = 10;
            this.btnDelivery.CheckedState.Parent = this.btnDelivery;
            this.btnDelivery.CustomImages.Parent = this.btnDelivery;
            this.btnDelivery.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.HoverState.Parent = this.btnDelivery;
            this.btnDelivery.Location = new System.Drawing.Point(4, 3);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.ShadowDecoration.Parent = this.btnDelivery;
            this.btnDelivery.Size = new System.Drawing.Size(130, 75);
            this.btnDelivery.TabIndex = 1;
            this.btnDelivery.Text = "Доставка";
            this.btnDelivery.Click += new System.EventHandler(this.BtnDelivery_Click);
            // 
            // panelMyProducts
            // 
            this.panelMyProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMyProducts.Controls.Add(this.dgvProduct);
            this.panelMyProducts.Location = new System.Drawing.Point(3, 46);
            this.panelMyProducts.Name = "panelMyProducts";
            this.panelMyProducts.Size = new System.Drawing.Size(407, 430);
            this.panelMyProducts.TabIndex = 0;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.ColumnHeadersHeight = 40;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodnameDataGridViewTextBoxColumn,
            this.prodpriceDataGridViewTextBoxColumn,
            this.prodtotalDataGridViewTextBoxColumn,
            this.sumDataGridViewTextBoxColumn,
            this.GridBtnAddOne,
            this.GridBtnMinusOne,
            this.GridBtnRemoveAll});
            this.dgvProduct.DataSource = this.productBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.MultiSelect = false;
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 62;
            this.dgvProduct.RowTemplate.Height = 40;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(407, 430);
            this.dgvProduct.TabIndex = 4;
            this.dgvProduct.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProduct.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvProduct.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvProduct.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProduct.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProduct.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProduct.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvProduct.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvProduct.ThemeStyle.ReadOnly = true;
            this.dgvProduct.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProduct.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProduct.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProduct.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProduct.ThemeStyle.RowsStyle.Height = 40;
            this.dgvProduct.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvProduct.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduct_CellContentClick);
            this.dgvProduct.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduct_CellContentDoubleClick);
            // 
            // GridBtnAddOne
            // 
            this.GridBtnAddOne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GridBtnAddOne.HeaderText = "      ";
            this.GridBtnAddOne.Image = ((System.Drawing.Image)(resources.GetObject("GridBtnAddOne.Image")));
            this.GridBtnAddOne.MinimumWidth = 8;
            this.GridBtnAddOne.Name = "GridBtnAddOne";
            this.GridBtnAddOne.ReadOnly = true;
            this.GridBtnAddOne.Width = 34;
            // 
            // GridBtnMinusOne
            // 
            this.GridBtnMinusOne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GridBtnMinusOne.HeaderText = "      ";
            this.GridBtnMinusOne.Image = ((System.Drawing.Image)(resources.GetObject("GridBtnMinusOne.Image")));
            this.GridBtnMinusOne.MinimumWidth = 8;
            this.GridBtnMinusOne.Name = "GridBtnMinusOne";
            this.GridBtnMinusOne.ReadOnly = true;
            this.GridBtnMinusOne.Width = 34;
            // 
            // GridBtnRemoveAll
            // 
            this.GridBtnRemoveAll.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GridBtnRemoveAll.HeaderText = "      ";
            this.GridBtnRemoveAll.Image = ((System.Drawing.Image)(resources.GetObject("GridBtnRemoveAll.Image")));
            this.GridBtnRemoveAll.MinimumWidth = 8;
            this.GridBtnRemoveAll.Name = "GridBtnRemoveAll";
            this.GridBtnRemoveAll.ReadOnly = true;
            this.GridBtnRemoveAll.Width = 34;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "      ";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "      ";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.MinimumWidth = 8;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "      ";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.MinimumWidth = 8;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            // 
            // timerInit
            // 
            this.timerInit.Interval = 500;
            this.timerInit.Tick += new System.EventHandler(this.timerInit_Tick);
            // 
            // prodnameDataGridViewTextBoxColumn
            // 
            this.prodnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.prodnameDataGridViewTextBoxColumn.DataPropertyName = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.HeaderText = "Наимено.";
            this.prodnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodnameDataGridViewTextBoxColumn.Name = "prodnameDataGridViewTextBoxColumn";
            this.prodnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodnameDataGridViewTextBoxColumn.Width = 101;
            // 
            // prodpriceDataGridViewTextBoxColumn
            // 
            this.prodpriceDataGridViewTextBoxColumn.DataPropertyName = "prod_price";
            this.prodpriceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.prodpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodpriceDataGridViewTextBoxColumn.Name = "prodpriceDataGridViewTextBoxColumn";
            this.prodpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prodtotalDataGridViewTextBoxColumn
            // 
            this.prodtotalDataGridViewTextBoxColumn.DataPropertyName = "prod_total";
            this.prodtotalDataGridViewTextBoxColumn.HeaderText = "Кол.";
            this.prodtotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodtotalDataGridViewTextBoxColumn.Name = "prodtotalDataGridViewTextBoxColumn";
            this.prodtotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumDataGridViewTextBoxColumn
            // 
            this.sumDataGridViewTextBoxColumn.DataPropertyName = "Sum";
            this.sumDataGridViewTextBoxColumn.HeaderText = "Итого";
            this.sumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sumDataGridViewTextBoxColumn.Name = "sumDataGridViewTextBoxColumn";
            this.sumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(MyFinCassa.Model.Product);
            // 
            // UC_PageCasheCafe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panelRightSide);
            this.Controls.Add(this.panelLeftSide);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UC_PageCasheCafe";
            this.Size = new System.Drawing.Size(1280, 720);
            this.panelLeftSide.ResumeLayout(false);
            this.productParent.ResumeLayout(false);
            this.categoriesFlowPanel.ResumeLayout(false);
            this.panelRightSide.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.pnlComment.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelMyProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.Panel panelRightSide;
        private System.Windows.Forms.Panel panelMyProducts;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProduct;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2Button btnDelivery;
        private Guna.UI2.WinForms.Guna2Button btnToPending;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.FlowLayoutPanel categoriesFlowPanel;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.FlowLayoutPanel productsFlowPanel;
        private System.Windows.Forms.Panel productParent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private System.Windows.Forms.Panel pnlComment;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleComment;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator5;
        private System.Windows.Forms.Timer timerInit;
        private Guna.UI2.WinForms.Guna2Button btnSaved;
        private System.Windows.Forms.Label txtOrderNum;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn GridBtnAddOne;
        private System.Windows.Forms.DataGridViewImageColumn GridBtnMinusOne;
        private System.Windows.Forms.DataGridViewImageColumn GridBtnRemoveAll;
        private Guna.UI2.WinForms.Guna2Button btnClearBasket;
    }
}
