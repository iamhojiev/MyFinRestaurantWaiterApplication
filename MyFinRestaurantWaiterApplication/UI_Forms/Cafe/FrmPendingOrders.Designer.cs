namespace MyFinCassa.UI_Forms.Cafe
{
    partial class FrmPendingOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPendingOrders));
            this.dgvOrders = new Guna.UI2.WinForms.Guna2DataGridView();
            this.orderNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GetOrderComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.detailsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GetDetailComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtOrderInfo = new System.Windows.Forms.Label();
            this.txtDetailsInfo = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnToBasket = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PanelDetails = new System.Windows.Forms.Panel();
            this.PanelOrder = new System.Windows.Forms.Panel();
            this.PanelsButton = new System.Windows.Forms.Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.PanelDetails.SuspendLayout();
            this.PanelOrder.SuspendLayout();
            this.PanelsButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrders.AutoGenerateColumns = false;
            this.dgvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrders.ColumnHeadersHeight = 40;
            this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumDataGridViewTextBoxColumn,
            this.GetOrderComment});
            this.dgvOrders.DataSource = this.orderBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOrders.EnableHeadersVisualStyles = false;
            this.dgvOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvOrders.Location = new System.Drawing.Point(3, -3);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.RowHeadersWidth = 62;
            this.dgvOrders.RowTemplate.Height = 40;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(1149, 315);
            this.dgvOrders.TabIndex = 2;
            this.dgvOrders.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvOrders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvOrders.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrders.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvOrders.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvOrders.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvOrders.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrders.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvOrders.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvOrders.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvOrders.ThemeStyle.ReadOnly = true;
            this.dgvOrders.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvOrders.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvOrders.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrders.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvOrders.ThemeStyle.RowsStyle.Height = 40;
            this.dgvOrders.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvOrders.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvOrders.SelectionChanged += new System.EventHandler(this.dgvOrders_SelectionChanged);
            // 
            // orderNumDataGridViewTextBoxColumn
            // 
            this.orderNumDataGridViewTextBoxColumn.DataPropertyName = "OrderNum";
            this.orderNumDataGridViewTextBoxColumn.HeaderText = "№";
            this.orderNumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderNumDataGridViewTextBoxColumn.Name = "orderNumDataGridViewTextBoxColumn";
            this.orderNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GetOrderComment
            // 
            this.GetOrderComment.DataPropertyName = "GetOrderComment";
            this.GetOrderComment.HeaderText = "Коментарий";
            this.GetOrderComment.MinimumWidth = 8;
            this.GetOrderComment.Name = "GetOrderComment";
            this.GetOrderComment.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(MyFinCassa.Model.Order);
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetails.AutoGenerateColumns = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetails.ColumnHeadersHeight = 40;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detailsidDataGridViewTextBoxColumn,
            this.details_count,
            this.GetDetailComment});
            this.dgvDetails.DataSource = this.orderDetailsBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetails.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetails.EnableHeadersVisualStyles = false;
            this.dgvDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvDetails.Location = new System.Drawing.Point(0, 2);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersVisible = false;
            this.dgvDetails.RowHeadersWidth = 62;
            this.dgvDetails.RowTemplate.Height = 40;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(1278, 299);
            this.dgvDetails.TabIndex = 3;
            this.dgvDetails.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDetails.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvDetails.ThemeStyle.ReadOnly = true;
            this.dgvDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDetails.ThemeStyle.RowsStyle.Height = 40;
            this.dgvDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // detailsidDataGridViewTextBoxColumn
            // 
            this.detailsidDataGridViewTextBoxColumn.DataPropertyName = "GetProductName";
            this.detailsidDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.detailsidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.detailsidDataGridViewTextBoxColumn.Name = "detailsidDataGridViewTextBoxColumn";
            this.detailsidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // details_count
            // 
            this.details_count.DataPropertyName = "details_count";
            this.details_count.HeaderText = "Количество";
            this.details_count.MinimumWidth = 6;
            this.details_count.Name = "details_count";
            this.details_count.ReadOnly = true;
            // 
            // GetDetailComment
            // 
            this.GetDetailComment.DataPropertyName = "GetDetailComment";
            this.GetDetailComment.HeaderText = "Коментарий";
            this.GetDetailComment.MinimumWidth = 8;
            this.GetDetailComment.Name = "GetDetailComment";
            this.GetDetailComment.ReadOnly = true;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataSource = typeof(MyFinCassa.Model.OrderDetails);
            // 
            // txtOrderInfo
            // 
            this.txtOrderInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtOrderInfo.AutoSize = true;
            this.txtOrderInfo.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.txtOrderInfo.Location = new System.Drawing.Point(5, 314);
            this.txtOrderInfo.Name = "txtOrderInfo";
            this.txtOrderInfo.Size = new System.Drawing.Size(190, 23);
            this.txtOrderInfo.TabIndex = 58;
            this.txtOrderInfo.Text = "Заказов 0  |  Сумма 0  |";
            // 
            // txtDetailsInfo
            // 
            this.txtDetailsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDetailsInfo.AutoSize = true;
            this.txtDetailsInfo.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.txtDetailsInfo.Location = new System.Drawing.Point(5, 309);
            this.txtDetailsInfo.Name = "txtDetailsInfo";
            this.txtDetailsInfo.Size = new System.Drawing.Size(441, 23);
            this.txtDetailsInfo.TabIndex = 58;
            this.txtDetailsInfo.Text = "Наименований  0  |  Общая количество 0  |  Сумма 0  |";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(40, 40);
            this.btnDelete.Location = new System.Drawing.Point(0, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(123, 60);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnToBasket
            // 
            this.btnToBasket.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToBasket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnToBasket.BorderRadius = 5;
            this.btnToBasket.CheckedState.Parent = this.btnToBasket;
            this.btnToBasket.CustomImages.Parent = this.btnToBasket;
            this.btnToBasket.FillColor = System.Drawing.Color.SteelBlue;
            this.btnToBasket.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnToBasket.ForeColor = System.Drawing.Color.White;
            this.btnToBasket.HoverState.Parent = this.btnToBasket;
            this.btnToBasket.Image = ((System.Drawing.Image)(resources.GetObject("btnToBasket.Image")));
            this.btnToBasket.ImageSize = new System.Drawing.Size(40, 40);
            this.btnToBasket.Location = new System.Drawing.Point(0, 0);
            this.btnToBasket.Name = "btnToBasket";
            this.btnToBasket.ShadowDecoration.Parent = this.btnToBasket;
            this.btnToBasket.Size = new System.Drawing.Size(123, 60);
            this.btnToBasket.TabIndex = 59;
            this.btnToBasket.Text = "Перенос";
            this.btnToBasket.Click += new System.EventHandler(this.btnToBasket_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.PanelDetails, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PanelOrder, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PanelsButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1284, 689);
            this.tableLayoutPanel1.TabIndex = 61;
            // 
            // PanelDetails
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.PanelDetails, 2);
            this.PanelDetails.Controls.Add(this.txtDetailsInfo);
            this.PanelDetails.Controls.Add(this.dgvDetails);
            this.PanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDetails.Location = new System.Drawing.Point(3, 347);
            this.PanelDetails.Name = "PanelDetails";
            this.PanelDetails.Size = new System.Drawing.Size(1278, 339);
            this.PanelDetails.TabIndex = 63;
            // 
            // PanelOrder
            // 
            this.PanelOrder.Controls.Add(this.dgvOrders);
            this.PanelOrder.Controls.Add(this.txtOrderInfo);
            this.PanelOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelOrder.Location = new System.Drawing.Point(3, 3);
            this.PanelOrder.Name = "PanelOrder";
            this.PanelOrder.Size = new System.Drawing.Size(1149, 338);
            this.PanelOrder.TabIndex = 62;
            // 
            // PanelsButton
            // 
            this.PanelsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PanelsButton.Controls.Add(this.btnCancel);
            this.PanelsButton.Controls.Add(this.btnPrint);
            this.PanelsButton.Controls.Add(this.btnToBasket);
            this.PanelsButton.Controls.Add(this.btnDelete);
            this.PanelsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelsButton.Location = new System.Drawing.Point(1158, 3);
            this.PanelsButton.Name = "PanelsButton";
            this.PanelsButton.Size = new System.Drawing.Size(123, 338);
            this.PanelsButton.TabIndex = 62;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCancel.Location = new System.Drawing.Point(0, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(123, 60);
            this.btnCancel.TabIndex = 62;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrint.BorderRadius = 5;
            this.btnPrint.CheckedState.Parent = this.btnPrint;
            this.btnPrint.CustomImages.Parent = this.btnPrint;
            this.btnPrint.FillColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.Parent = this.btnPrint;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPrint.Location = new System.Drawing.Point(0, 70);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(123, 60);
            this.btnPrint.TabIndex = 61;
            this.btnPrint.Text = "Печать";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FrmPendingOrders
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1284, 689);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPendingOrders";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Список активных заказов";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.PanelDetails.ResumeLayout(false);
            this.PanelDetails.PerformLayout();
            this.PanelOrder.ResumeLayout(false);
            this.PanelOrder.PerformLayout();
            this.PanelsButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvOrders;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDetails;
        private System.Windows.Forms.Label txtOrderInfo;
        private System.Windows.Forms.Label txtDetailsInfo;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnToBasket;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PanelOrder;
        private System.Windows.Forms.Panel PanelsButton;
        private System.Windows.Forms.Panel PanelDetails;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GetOrderComment;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn details_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn GetDetailComment;
    }
}
