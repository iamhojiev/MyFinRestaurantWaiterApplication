namespace MyFinCassa.UC
{
    partial class UC_CasheHistory
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
            this.cassaLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactioncassaoperationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getSourceStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionwithdrawaltypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsourcebalanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getSourceDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cassaLogBindingSource)).BeginInit();
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
            this.transactioncassaoperationDataGridViewTextBoxColumn,
            this.transactionamountDataGridViewTextBoxColumn,
            this.getSourceStringDataGridViewTextBoxColumn,
            this.transactionwithdrawaltypeDataGridViewTextBoxColumn,
            this.transactionsourcebalanceDataGridViewTextBoxColumn,
            this.getSourceDescriptionDataGridViewTextBoxColumn,
            this.transactiondateDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn});
            this.dgvMain.DataSource = this.cassaLogBindingSource;
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
            this.dgvMain.Size = new System.Drawing.Size(1280, 680);
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
            // 
            // cassaLogBindingSource
            // 
            this.cassaLogBindingSource.DataSource = typeof(MyFinCassa.Model.CassaLog);
            // 
            // transactioncassaoperationDataGridViewTextBoxColumn
            // 
            this.transactioncassaoperationDataGridViewTextBoxColumn.DataPropertyName = "transaction_cassa_operation";
            this.transactioncassaoperationDataGridViewTextBoxColumn.HeaderText = "Операция";
            this.transactioncassaoperationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.transactioncassaoperationDataGridViewTextBoxColumn.Name = "transactioncassaoperationDataGridViewTextBoxColumn";
            this.transactioncassaoperationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionamountDataGridViewTextBoxColumn
            // 
            this.transactionamountDataGridViewTextBoxColumn.DataPropertyName = "transaction_amount";
            this.transactionamountDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.transactionamountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.transactionamountDataGridViewTextBoxColumn.Name = "transactionamountDataGridViewTextBoxColumn";
            this.transactionamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getSourceStringDataGridViewTextBoxColumn
            // 
            this.getSourceStringDataGridViewTextBoxColumn.DataPropertyName = "GetSourceString";
            this.getSourceStringDataGridViewTextBoxColumn.HeaderText = "Источник";
            this.getSourceStringDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.getSourceStringDataGridViewTextBoxColumn.Name = "getSourceStringDataGridViewTextBoxColumn";
            this.getSourceStringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionwithdrawaltypeDataGridViewTextBoxColumn
            // 
            this.transactionwithdrawaltypeDataGridViewTextBoxColumn.DataPropertyName = "transaction_withdrawal_type";
            this.transactionwithdrawaltypeDataGridViewTextBoxColumn.HeaderText = "Способ";
            this.transactionwithdrawaltypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.transactionwithdrawaltypeDataGridViewTextBoxColumn.Name = "transactionwithdrawaltypeDataGridViewTextBoxColumn";
            this.transactionwithdrawaltypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionsourcebalanceDataGridViewTextBoxColumn
            // 
            this.transactionsourcebalanceDataGridViewTextBoxColumn.DataPropertyName = "transaction_source_balance";
            this.transactionsourcebalanceDataGridViewTextBoxColumn.HeaderText = "После операции";
            this.transactionsourcebalanceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.transactionsourcebalanceDataGridViewTextBoxColumn.Name = "transactionsourcebalanceDataGridViewTextBoxColumn";
            this.transactionsourcebalanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getSourceDescriptionDataGridViewTextBoxColumn
            // 
            this.getSourceDescriptionDataGridViewTextBoxColumn.DataPropertyName = "GetSourceDescription";
            this.getSourceDescriptionDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.getSourceDescriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.getSourceDescriptionDataGridViewTextBoxColumn.Name = "getSourceDescriptionDataGridViewTextBoxColumn";
            this.getSourceDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactiondateDataGridViewTextBoxColumn
            // 
            this.transactiondateDataGridViewTextBoxColumn.DataPropertyName = "transaction_date";
            this.transactiondateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.transactiondateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.transactiondateDataGridViewTextBoxColumn.Name = "transactiondateDataGridViewTextBoxColumn";
            this.transactiondateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "user";
            this.userDataGridViewTextBoxColumn.HeaderText = "Работал";
            this.userDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UC_CasheHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.dgvMain);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UC_CasheHistory";
            this.Size = new System.Drawing.Size(1280, 680);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cassaLogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactioncassaoperationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getSourceStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionwithdrawaltypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionsourcebalanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn getSourceDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cassaLogBindingSource;
    }
}
