namespace MyFinCassa.UC
{
    partial class UC_WaiterStats
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
            this.dgvMain = new Guna.UI2.WinForms.Guna2DataGridView();
            this.getHallNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getTableNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordertableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getUserNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbUser = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.getHallNameDataGridViewTextBoxColumn,
            this.getTableNameDataGridViewTextBoxColumn,
            this.orderidDataGridViewTextBoxColumn,
            this.orderpriceDataGridViewTextBoxColumn,
            this.ordertableDataGridViewTextBoxColumn,
            this.orderStatusDataGridViewTextBoxColumn1,
            this.getUserNameDataGridViewTextBoxColumn});
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
            this.dgvMain.Size = new System.Drawing.Size(1280, 580);
            this.dgvMain.TabIndex = 1;
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
            this.dgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellDoubleClick);
            // 
            // getHallNameDataGridViewTextBoxColumn
            // 
            this.getHallNameDataGridViewTextBoxColumn.DataPropertyName = "GetHallName";
            this.getHallNameDataGridViewTextBoxColumn.HeaderText = "Зал";
            this.getHallNameDataGridViewTextBoxColumn.Name = "getHallNameDataGridViewTextBoxColumn";
            this.getHallNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getTableNameDataGridViewTextBoxColumn
            // 
            this.getTableNameDataGridViewTextBoxColumn.DataPropertyName = "GetTableName";
            this.getTableNameDataGridViewTextBoxColumn.HeaderText = "Столик";
            this.getTableNameDataGridViewTextBoxColumn.Name = "getTableNameDataGridViewTextBoxColumn";
            this.getTableNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderidDataGridViewTextBoxColumn
            // 
            this.orderidDataGridViewTextBoxColumn.DataPropertyName = "order_date";
            this.orderidDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.orderidDataGridViewTextBoxColumn.Name = "orderidDataGridViewTextBoxColumn";
            this.orderidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderpriceDataGridViewTextBoxColumn
            // 
            this.orderpriceDataGridViewTextBoxColumn.DataPropertyName = "order_price";
            this.orderpriceDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.orderpriceDataGridViewTextBoxColumn.Name = "orderpriceDataGridViewTextBoxColumn";
            this.orderpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordertableDataGridViewTextBoxColumn
            // 
            this.ordertableDataGridViewTextBoxColumn.DataPropertyName = "order_price_waiter";
            this.ordertableDataGridViewTextBoxColumn.HeaderText = "Официанту";
            this.ordertableDataGridViewTextBoxColumn.Name = "ordertableDataGridViewTextBoxColumn";
            this.ordertableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderStatusDataGridViewTextBoxColumn1
            // 
            this.orderStatusDataGridViewTextBoxColumn1.DataPropertyName = "OrderStatus";
            this.orderStatusDataGridViewTextBoxColumn1.HeaderText = "Статус";
            this.orderStatusDataGridViewTextBoxColumn1.Name = "orderStatusDataGridViewTextBoxColumn1";
            this.orderStatusDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // getUserNameDataGridViewTextBoxColumn
            // 
            this.getUserNameDataGridViewTextBoxColumn.DataPropertyName = "GetUserName";
            this.getUserNameDataGridViewTextBoxColumn.HeaderText = "Официант";
            this.getUserNameDataGridViewTextBoxColumn.Name = "getUserNameDataGridViewTextBoxColumn";
            this.getUserNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(MyFinCassa.Model.Order);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbUser);
            this.panel1.Controls.Add(this.cmbFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 50);
            this.panel1.TabIndex = 2;
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
            "Все"});
            this.cmbUser.ItemsAppearance.Parent = this.cmbUser;
            this.cmbUser.Location = new System.Drawing.Point(258, 10);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.ShadowDecoration.Parent = this.cmbUser;
            this.cmbUser.Size = new System.Drawing.Size(220, 36);
            this.cmbUser.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbUser.TabIndex = 38;
            this.cmbUser.SelectedIndexChanged += new System.EventHandler(this.CmbFilter_SelectionChanged);
            // 
            // cmbFilter
            // 
            this.cmbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cmbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.cmbFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cmbFilter.FocusedState.Parent = this.cmbFilter;
            this.cmbFilter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.HoverState.Parent = this.cmbFilter;
            this.cmbFilter.ItemHeight = 30;
            this.cmbFilter.Items.AddRange(new object[] {
            "Показать все",
            "Оплаченные",
            "Не оплаченные"});
            this.cmbFilter.ItemsAppearance.Parent = this.cmbFilter;
            this.cmbFilter.Location = new System.Drawing.Point(15, 10);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.ShadowDecoration.Parent = this.cmbFilter;
            this.cmbFilter.Size = new System.Drawing.Size(220, 36);
            this.cmbFilter.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbFilter.TabIndex = 39;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.CmbFilter_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1280, 580);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "{info}";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 630);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1280, 50);
            this.panel3.TabIndex = 4;
            // 
            // UC_WaiterStats
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UC_WaiterStats";
            this.Size = new System.Drawing.Size(1280, 680);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvMain;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbUser;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn getHallNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getTableNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn getUserNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderBindingSource;
    }
}
