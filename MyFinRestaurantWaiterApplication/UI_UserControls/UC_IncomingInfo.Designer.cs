namespace MyFinCassa.UC
{
    partial class UC_IncomingInfo
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.cmbTable = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbHall = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbUser = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.otDate = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPeriod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.doDate = new MetroFramework.Controls.MetroDateTime();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMain = new Guna.UI2.WinForms.Guna2DataGridView();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordertableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderclosedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdiscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel6.Controls.Add(this.cmbTable);
            this.panel6.Controls.Add(this.cmbHall);
            this.panel6.Controls.Add(this.cmbUser);
            this.panel6.Controls.Add(this.cmbStatus);
            this.panel6.Controls.Add(this.otDate);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.cmbPeriod);
            this.panel6.Controls.Add(this.doDate);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1280, 150);
            this.panel6.TabIndex = 14;
            // 
            // cmbTable
            // 
            this.cmbTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cmbTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cmbTable.FocusedColor = System.Drawing.Color.Empty;
            this.cmbTable.FocusedState.Parent = this.cmbTable;
            this.cmbTable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.HoverState.Parent = this.cmbTable;
            this.cmbTable.ItemHeight = 30;
            this.cmbTable.ItemsAppearance.Parent = this.cmbTable;
            this.cmbTable.Location = new System.Drawing.Point(637, 105);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.ShadowDecoration.Parent = this.cmbTable;
            this.cmbTable.Size = new System.Drawing.Size(220, 36);
            this.cmbTable.TabIndex = 40;
            this.cmbTable.SelectedIndexChanged += new System.EventHandler(this.cmbFiltersChangeIndex);
            // 
            // cmbHall
            // 
            this.cmbHall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cmbHall.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHall.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cmbHall.FocusedColor = System.Drawing.Color.Empty;
            this.cmbHall.FocusedState.Parent = this.cmbHall;
            this.cmbHall.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbHall.FormattingEnabled = true;
            this.cmbHall.HoverState.Parent = this.cmbHall;
            this.cmbHall.ItemHeight = 30;
            this.cmbHall.ItemsAppearance.Parent = this.cmbHall;
            this.cmbHall.Location = new System.Drawing.Point(637, 34);
            this.cmbHall.Name = "cmbHall";
            this.cmbHall.ShadowDecoration.Parent = this.cmbHall;
            this.cmbHall.Size = new System.Drawing.Size(220, 36);
            this.cmbHall.TabIndex = 40;
            this.cmbHall.SelectedIndexChanged += new System.EventHandler(this.cmbFiltersChangeIndex);
            // 
            // cmbUser
            // 
            this.cmbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cmbUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cmbUser.FocusedColor = System.Drawing.Color.Empty;
            this.cmbUser.FocusedState.Parent = this.cmbUser;
            this.cmbUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.HoverState.Parent = this.cmbUser;
            this.cmbUser.ItemHeight = 30;
            this.cmbUser.Items.AddRange(new object[] {
            ""});
            this.cmbUser.ItemsAppearance.Parent = this.cmbUser;
            this.cmbUser.Location = new System.Drawing.Point(967, 34);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.ShadowDecoration.Parent = this.cmbUser;
            this.cmbUser.Size = new System.Drawing.Size(220, 36);
            this.cmbUser.TabIndex = 40;
            this.cmbUser.SelectedIndexChanged += new System.EventHandler(this.cmbFiltersChangeIndex);
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cmbStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cmbStatus.FocusedState.Parent = this.cmbStatus;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.HoverState.Parent = this.cmbStatus;
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Items.AddRange(new object[] {
            "Показать все",
            "Оплаченные",
            "Не оплаченные"});
            this.cmbStatus.ItemsAppearance.Parent = this.cmbStatus;
            this.cmbStatus.Location = new System.Drawing.Point(967, 105);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.ShadowDecoration.Parent = this.cmbStatus;
            this.cmbStatus.Size = new System.Drawing.Size(220, 36);
            this.cmbStatus.TabIndex = 41;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbFiltersChangeIndex);
            // 
            // otDate
            // 
            this.otDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.otDate.Location = new System.Drawing.Point(290, 37);
            this.otDate.MaxDate = new System.DateTime(2029, 12, 30, 0, 0, 0, 0);
            this.otDate.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.otDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.otDate.Name = "otDate";
            this.otDate.Size = new System.Drawing.Size(200, 33);
            this.otDate.TabIndex = 4;
            this.otDate.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.otDate.CloseUp += new System.EventHandler(this.cmbPeriodIndexChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Доходы";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label6.Location = new System.Drawing.Point(632, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Столик:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label8.Location = new System.Drawing.Point(962, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Статус:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label7.Location = new System.Drawing.Point(962, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Официант:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label5.Location = new System.Drawing.Point(632, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Зал:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(285, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите началную дату:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label3.Location = new System.Drawing.Point(285, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите конечную дату:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label4.Location = new System.Drawing.Point(10, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Выберите период:";
            // 
            // cmbPeriod
            // 
            this.cmbPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cmbPeriod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriod.FocusedColor = System.Drawing.Color.Empty;
            this.cmbPeriod.FocusedState.Parent = this.cmbPeriod;
            this.cmbPeriod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPeriod.FormattingEnabled = true;
            this.cmbPeriod.HoverState.Parent = this.cmbPeriod;
            this.cmbPeriod.ItemHeight = 30;
            this.cmbPeriod.Items.AddRange(new object[] {
            "За последний день",
            "За последнюю неделью",
            "За последний месяц",
            "За последние 3 месяца",
            "За последние 6 месяцев",
            "За последний год",
            "За весь период"});
            this.cmbPeriod.ItemsAppearance.Parent = this.cmbPeriod;
            this.cmbPeriod.Location = new System.Drawing.Point(12, 95);
            this.cmbPeriod.Name = "cmbPeriod";
            this.cmbPeriod.ShadowDecoration.Parent = this.cmbPeriod;
            this.cmbPeriod.Size = new System.Drawing.Size(230, 36);
            this.cmbPeriod.TabIndex = 11;
            this.cmbPeriod.SelectedIndexChanged += new System.EventHandler(this.cmbPeriodIndexChange);
            // 
            // doDate
            // 
            this.doDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.doDate.Location = new System.Drawing.Point(290, 98);
            this.doDate.MaxDate = new System.DateTime(2029, 12, 30, 0, 0, 0, 0);
            this.doDate.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.doDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.doDate.Name = "doDate";
            this.doDate.Size = new System.Drawing.Size(200, 33);
            this.doDate.TabIndex = 6;
            this.doDate.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.doDate.CloseUp += new System.EventHandler(this.cmbPeriodIndexChange);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 630);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 50);
            this.panel1.TabIndex = 15;
            // 
            // txtInfo
            // 
            this.txtInfo.AutoSize = true;
            this.txtInfo.Location = new System.Drawing.Point(10, 12);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(45, 25);
            this.txtInfo.TabIndex = 0;
            this.txtInfo.Text = "info";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 480);
            this.panel2.TabIndex = 16;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMain.ColumnHeadersHeight = 40;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderidDataGridViewTextBoxColumn,
            this.ordertableDataGridViewTextBoxColumn,
            this.orderdateDataGridViewTextBoxColumn,
            this.orderpriceDataGridViewTextBoxColumn,
            this.orderclosedateDataGridViewTextBoxColumn,
            this.orderdiscountDataGridViewTextBoxColumn});
            this.dgvMain.DataSource = this.orderBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMain.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.EnableHeadersVisualStyles = false;
            this.dgvMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidth = 62;
            this.dgvMain.RowTemplate.Height = 40;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(1280, 480);
            this.dgvMain.TabIndex = 2;
            this.dgvMain.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            this.dgvMain.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMain.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMain.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMain.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMain.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMain.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMain.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvMain.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.dgvMain.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMain.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMain.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMain.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMain.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvMain.ThemeStyle.ReadOnly = true;
            this.dgvMain.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMain.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMain.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMain.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvMain.ThemeStyle.RowsStyle.Height = 40;
            this.dgvMain.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.dgvMain.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvMain.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentDoubleClick);
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "GetHallName";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "Зал";
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordertableDataGridViewTextBoxColumn
            // 
            this.ordertableDataGridViewTextBoxColumn.DataPropertyName = "GetTableName";
            this.ordertableDataGridViewTextBoxColumn.HeaderText = "Столик";
            this.ordertableDataGridViewTextBoxColumn.Name = "ordertableDataGridViewTextBoxColumn";
            this.ordertableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date";
            this.orderdateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            this.orderdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderpriceDataGridViewTextBoxColumn
            // 
            this.orderpriceDataGridViewTextBoxColumn.DataPropertyName = "order_price";
            this.orderpriceDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.orderpriceDataGridViewTextBoxColumn.Name = "orderpriceDataGridViewTextBoxColumn";
            this.orderpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderclosedateDataGridViewTextBoxColumn
            // 
            this.orderclosedateDataGridViewTextBoxColumn.DataPropertyName = "OrderStatus";
            this.orderclosedateDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.orderclosedateDataGridViewTextBoxColumn.Name = "orderclosedateDataGridViewTextBoxColumn";
            this.orderclosedateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderdiscountDataGridViewTextBoxColumn
            // 
            this.orderdiscountDataGridViewTextBoxColumn.DataPropertyName = "GetUserName";
            this.orderdiscountDataGridViewTextBoxColumn.HeaderText = "Официант";
            this.orderdiscountDataGridViewTextBoxColumn.Name = "orderdiscountDataGridViewTextBoxColumn";
            this.orderdiscountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(MyFinCassa.Model.Order);
            // 
            // UC_IncomingInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UC_IncomingInfo";
            this.Size = new System.Drawing.Size(1280, 680);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel6;
        private MetroFramework.Controls.MetroDateTime otDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPeriod;
        private MetroFramework.Controls.MetroDateTime doDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtInfo;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderclosedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdiscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTable;
        private Guna.UI2.WinForms.Guna2ComboBox cmbHall;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUser;
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}
