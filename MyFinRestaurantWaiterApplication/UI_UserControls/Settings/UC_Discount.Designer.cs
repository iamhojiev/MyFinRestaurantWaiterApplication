namespace MyFinCassa.UC
{
    partial class UC_Discount
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
            this.txtDiscountTitle = new System.Windows.Forms.Label();
            this.tsDiscount = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tsPrint = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txtPrint = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtColumnCount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tsTableDivide = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.txtDivideTable = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDiscountTitle
            // 
            this.txtDiscountTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiscountTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtDiscountTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.txtDiscountTitle.Location = new System.Drawing.Point(21, 69);
            this.txtDiscountTitle.Name = "txtDiscountTitle";
            this.txtDiscountTitle.Size = new System.Drawing.Size(352, 45);
            this.txtDiscountTitle.TabIndex = 16;
            this.txtDiscountTitle.Text = "Скидка: вкл/выкл";
            this.txtDiscountTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tsDiscount
            // 
            this.tsDiscount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tsDiscount.Animated = true;
            this.tsDiscount.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsDiscount.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsDiscount.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsDiscount.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsDiscount.CheckedState.Parent = this.tsDiscount;
            this.tsDiscount.Location = new System.Drawing.Point(164, 26);
            this.tsDiscount.Name = "tsDiscount";
            this.tsDiscount.ShadowDecoration.Parent = this.tsDiscount;
            this.tsDiscount.Size = new System.Drawing.Size(66, 33);
            this.tsDiscount.TabIndex = 17;
            this.tsDiscount.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsDiscount.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsDiscount.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsDiscount.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tsDiscount.UncheckedState.Parent = this.tsDiscount;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(215, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 147);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel2.Controls.Add(this.tsDiscount);
            this.panel2.Controls.Add(this.txtDiscountTitle);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 141);
            this.panel2.TabIndex = 0;
            // 
            // tsPrint
            // 
            this.tsPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tsPrint.Animated = true;
            this.tsPrint.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsPrint.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsPrint.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsPrint.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsPrint.CheckedState.Parent = this.tsPrint;
            this.tsPrint.Location = new System.Drawing.Point(164, 26);
            this.tsPrint.Name = "tsPrint";
            this.tsPrint.ShadowDecoration.Parent = this.tsPrint;
            this.tsPrint.Size = new System.Drawing.Size(66, 33);
            this.tsPrint.TabIndex = 17;
            this.tsPrint.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsPrint.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsPrint.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsPrint.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tsPrint.UncheckedState.Parent = this.tsPrint;
            // 
            // txtPrint
            // 
            this.txtPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtPrint.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.txtPrint.Location = new System.Drawing.Point(21, 69);
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.Size = new System.Drawing.Size(352, 45);
            this.txtPrint.TabIndex = 16;
            this.txtPrint.Text = "Печать: вкл/выкл";
            this.txtPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(215, 349);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 147);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel4.Controls.Add(this.tsPrint);
            this.panel4.Controls.Add(this.txtPrint);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 141);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel5.Controls.Add(this.txtColumnCount);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(395, 141);
            this.panel5.TabIndex = 0;
            // 
            // txtColumnCount
            // 
            this.txtColumnCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtColumnCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColumnCount.DefaultText = "";
            this.txtColumnCount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtColumnCount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtColumnCount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtColumnCount.DisabledState.Parent = this.txtColumnCount;
            this.txtColumnCount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtColumnCount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtColumnCount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtColumnCount.FocusedState.Parent = this.txtColumnCount;
            this.txtColumnCount.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.txtColumnCount.ForeColor = System.Drawing.Color.Black;
            this.txtColumnCount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtColumnCount.HoverState.Parent = this.txtColumnCount;
            this.txtColumnCount.Location = new System.Drawing.Point(32, 64);
            this.txtColumnCount.Margin = new System.Windows.Forms.Padding(6);
            this.txtColumnCount.Name = "txtColumnCount";
            this.txtColumnCount.PasswordChar = '\0';
            this.txtColumnCount.PlaceholderText = "";
            this.txtColumnCount.SelectedText = "";
            this.txtColumnCount.ShadowDecoration.Parent = this.txtColumnCount;
            this.txtColumnCount.Size = new System.Drawing.Size(330, 40);
            this.txtColumnCount.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtColumnCount.TabIndex = 17;
            this.txtColumnCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "Карточек в ряду:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Location = new System.Drawing.Point(662, 185);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(401, 147);
            this.panel6.TabIndex = 19;
            // 
            // panel7
            // 
            this.panel7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(665, 349);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(401, 147);
            this.panel7.TabIndex = 18;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel8.Controls.Add(this.tsTableDivide);
            this.panel8.Controls.Add(this.txtDivideTable);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(395, 141);
            this.panel8.TabIndex = 0;
            // 
            // tsTableDivide
            // 
            this.tsTableDivide.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tsTableDivide.Animated = true;
            this.tsTableDivide.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsTableDivide.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsTableDivide.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsTableDivide.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsTableDivide.CheckedState.Parent = this.tsTableDivide;
            this.tsTableDivide.Location = new System.Drawing.Point(164, 26);
            this.tsTableDivide.Name = "tsTableDivide";
            this.tsTableDivide.ShadowDecoration.Parent = this.tsTableDivide;
            this.tsTableDivide.Size = new System.Drawing.Size(66, 33);
            this.tsTableDivide.TabIndex = 17;
            this.tsTableDivide.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsTableDivide.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsTableDivide.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsTableDivide.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tsTableDivide.UncheckedState.Parent = this.tsTableDivide;
            // 
            // txtDivideTable
            // 
            this.txtDivideTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDivideTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtDivideTable.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDivideTable.Location = new System.Drawing.Point(3, 69);
            this.txtDivideTable.Name = "txtDivideTable";
            this.txtDivideTable.Size = new System.Drawing.Size(389, 72);
            this.txtDivideTable.TabIndex = 16;
            this.txtDivideTable.Text = "Разделить стол: вкл/выкл";
            this.txtDivideTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Discount
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UC_Discount";
            this.Size = new System.Drawing.Size(1280, 680);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label txtDiscountTitle;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsDiscount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsPrint;
        private System.Windows.Forms.Label txtPrint;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtColumnCount;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsTableDivide;
        private System.Windows.Forms.Label txtDivideTable;
    }
}
