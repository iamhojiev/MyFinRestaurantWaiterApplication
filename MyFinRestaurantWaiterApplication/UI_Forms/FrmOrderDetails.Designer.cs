namespace MyFinCassa.UI_Forms
{
    partial class FrmOrderDetails
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
            this.dgvMain = new Guna.UI2.WinForms.Guna2DataGridView();
            this.detailscommentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailscountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getProductPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getProductCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getProductTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onStatusTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
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
            this.detailscommentDataGridViewTextBoxColumn,
            this.detailscountDataGridViewTextBoxColumn,
            this.getProductPriceDataGridViewTextBoxColumn,
            this.getProductCountDataGridViewTextBoxColumn,
            this.getProductTypeNameDataGridViewTextBoxColumn,
            this.onStatusTextDataGridViewTextBoxColumn});
            this.dgvMain.DataSource = this.orderDetailsBindingSource;
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
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowTemplate.Height = 40;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(884, 561);
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
            // 
            // detailscommentDataGridViewTextBoxColumn
            // 
            this.detailscommentDataGridViewTextBoxColumn.DataPropertyName = "GetProductName";
            this.detailscommentDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.detailscommentDataGridViewTextBoxColumn.Name = "detailscommentDataGridViewTextBoxColumn";
            this.detailscommentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detailscountDataGridViewTextBoxColumn
            // 
            this.detailscountDataGridViewTextBoxColumn.DataPropertyName = "details_count";
            this.detailscountDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.detailscountDataGridViewTextBoxColumn.Name = "detailscountDataGridViewTextBoxColumn";
            this.detailscountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getProductPriceDataGridViewTextBoxColumn
            // 
            this.getProductPriceDataGridViewTextBoxColumn.DataPropertyName = "GetProductPrice";
            this.getProductPriceDataGridViewTextBoxColumn.HeaderText = "Стоимость (х1)";
            this.getProductPriceDataGridViewTextBoxColumn.Name = "getProductPriceDataGridViewTextBoxColumn";
            this.getProductPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getProductCountDataGridViewTextBoxColumn
            // 
            this.getProductCountDataGridViewTextBoxColumn.DataPropertyName = "GetProductCount";
            this.getProductCountDataGridViewTextBoxColumn.HeaderText = "Объем (х1)";
            this.getProductCountDataGridViewTextBoxColumn.Name = "getProductCountDataGridViewTextBoxColumn";
            this.getProductCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getProductTypeNameDataGridViewTextBoxColumn
            // 
            this.getProductTypeNameDataGridViewTextBoxColumn.DataPropertyName = "GetProductTypeName";
            this.getProductTypeNameDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.getProductTypeNameDataGridViewTextBoxColumn.Name = "getProductTypeNameDataGridViewTextBoxColumn";
            this.getProductTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // onStatusTextDataGridViewTextBoxColumn
            // 
            this.onStatusTextDataGridViewTextBoxColumn.DataPropertyName = "OnStatusText";
            this.onStatusTextDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.onStatusTextDataGridViewTextBoxColumn.Name = "onStatusTextDataGridViewTextBoxColumn";
            this.onStatusTextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataSource = typeof(MyFinCassa.Model.OrderDetails);
            // 
            // FrmOrderDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.dgvMain);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOrderDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Подробности заказа";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailscommentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailscountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getProductPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getProductCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getProductTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onStatusTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
    }
}