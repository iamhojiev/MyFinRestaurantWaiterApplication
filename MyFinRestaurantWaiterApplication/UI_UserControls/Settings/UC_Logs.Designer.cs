namespace MyFinCassa.UC
{
    partial class UC_Logs
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
            this.getUserNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debugdateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debugtextDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debugBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.getUserNameDataGridViewTextBoxColumn1,
            this.debugdateDataGridViewTextBoxColumn1,
            this.debugtextDataGridViewTextBoxColumn1});
            this.dgvMain.DataSource = this.debugBindingSource;
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
            // getUserNameDataGridViewTextBoxColumn1
            // 
            this.getUserNameDataGridViewTextBoxColumn1.DataPropertyName = "GetUserName";
            this.getUserNameDataGridViewTextBoxColumn1.FillWeight = 30F;
            this.getUserNameDataGridViewTextBoxColumn1.HeaderText = "Пользователь";
            this.getUserNameDataGridViewTextBoxColumn1.Name = "getUserNameDataGridViewTextBoxColumn1";
            this.getUserNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // debugdateDataGridViewTextBoxColumn1
            // 
            this.debugdateDataGridViewTextBoxColumn1.DataPropertyName = "debug_date";
            this.debugdateDataGridViewTextBoxColumn1.FillWeight = 25F;
            this.debugdateDataGridViewTextBoxColumn1.HeaderText = "Дата";
            this.debugdateDataGridViewTextBoxColumn1.Name = "debugdateDataGridViewTextBoxColumn1";
            this.debugdateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // debugtextDataGridViewTextBoxColumn1
            // 
            this.debugtextDataGridViewTextBoxColumn1.DataPropertyName = "debug_text";
            this.debugtextDataGridViewTextBoxColumn1.FillWeight = 200F;
            this.debugtextDataGridViewTextBoxColumn1.HeaderText = "Текст";
            this.debugtextDataGridViewTextBoxColumn1.Name = "debugtextDataGridViewTextBoxColumn1";
            this.debugtextDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // debugBindingSource
            // 
            this.debugBindingSource.DataSource = typeof(MyFinCassa.Model.Debug);
            // 
            // UC_Logs
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.dgvMain);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UC_Logs";
            this.Size = new System.Drawing.Size(1280, 680);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debugBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource debugBindingSource;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn getUserNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn debugdateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn debugtextDataGridViewTextBoxColumn1;
    }
}
