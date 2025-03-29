namespace MyFinCassa.UC
{
    partial class UC_CassaInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CassaInfo));
            this.txtCashCassa = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.txtCashMoney = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.rbtPut = new System.Windows.Forms.RadioButton();
            this.rbtGet = new System.Windows.Forms.RadioButton();
            this.txtComment = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnCardsInfo = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // txtCashCassa
            // 
            this.txtCashCassa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCashCassa.AutoSize = true;
            this.txtCashCassa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtCashCassa.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.txtCashCassa.Location = new System.Drawing.Point(460, 149);
            this.txtCashCassa.Name = "txtCashCassa";
            this.txtCashCassa.Size = new System.Drawing.Size(377, 37);
            this.txtCashCassa.TabIndex = 17;
            this.txtCashCassa.Text = "Наличные деньги: 800 рублей";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(460, 132);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(360, 10);
            this.guna2Separator1.TabIndex = 18;
            // 
            // txtCashMoney
            // 
            this.txtCashMoney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCashMoney.AutoSize = true;
            this.txtCashMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtCashMoney.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.txtCashMoney.Location = new System.Drawing.Point(460, 213);
            this.txtCashMoney.Name = "txtCashMoney";
            this.txtCashMoney.Size = new System.Drawing.Size(386, 37);
            this.txtCashMoney.TabIndex = 17;
            this.txtCashMoney.Text = "Безналичные деньги: 0 рублей";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.Location = new System.Drawing.Point(460, 196);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(360, 10);
            this.guna2Separator2.TabIndex = 18;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator3.Location = new System.Drawing.Point(460, 260);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(360, 10);
            this.guna2Separator3.TabIndex = 18;
            // 
            // rbtPut
            // 
            this.rbtPut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtPut.AutoSize = true;
            this.rbtPut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rbtPut.Checked = true;
            this.rbtPut.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.rbtPut.Location = new System.Drawing.Point(460, 277);
            this.rbtPut.Name = "rbtPut";
            this.rbtPut.Size = new System.Drawing.Size(205, 41);
            this.rbtPut.TabIndex = 0;
            this.rbtPut.TabStop = true;
            this.rbtPut.Text = "Внести деньги";
            this.rbtPut.UseVisualStyleBackColor = false;
            this.rbtPut.CheckedChanged += new System.EventHandler(this.MoneyTypeChange_CheckedChanged);
            // 
            // rbtGet
            // 
            this.rbtGet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbtGet.AutoSize = true;
            this.rbtGet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.rbtGet.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.rbtGet.Location = new System.Drawing.Point(460, 328);
            this.rbtGet.Name = "rbtGet";
            this.rbtGet.Size = new System.Drawing.Size(207, 41);
            this.rbtGet.TabIndex = 1;
            this.rbtGet.Text = "Изъять деньги";
            this.rbtGet.UseVisualStyleBackColor = false;
            this.rbtGet.CheckedChanged += new System.EventHandler(this.MoneyTypeChange_CheckedChanged);
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.DefaultText = "";
            this.txtComment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtComment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtComment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComment.DisabledState.Parent = this.txtComment;
            this.txtComment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtComment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComment.FocusedState.Parent = this.txtComment;
            this.txtComment.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.txtComment.ForeColor = System.Drawing.Color.Black;
            this.txtComment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComment.HoverState.Parent = this.txtComment;
            this.txtComment.Location = new System.Drawing.Point(460, 435);
            this.txtComment.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.txtComment.Name = "txtComment";
            this.txtComment.PasswordChar = '\0';
            this.txtComment.PlaceholderText = "Комментарий";
            this.txtComment.SelectedText = "";
            this.txtComment.ShadowDecoration.Parent = this.txtComment;
            this.txtComment.Size = new System.Drawing.Size(360, 50);
            this.txtComment.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtComment.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI Semilight", 20F);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.Location = new System.Drawing.Point(460, 379);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "Сумма";
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(360, 50);
            this.txtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPrice.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNext.BorderRadius = 10;
            this.btnNext.BorderThickness = 1;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Location = new System.Drawing.Point(460, 499);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(361, 50);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Далее";
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnCardsInfo
            // 
            this.btnCardsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCardsInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCardsInfo.CheckedState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnCardsInfo.CheckedState.Parent = this.btnCardsInfo;
            this.btnCardsInfo.HoverState.ImageSize = new System.Drawing.Size(45, 45);
            this.btnCardsInfo.HoverState.Parent = this.btnCardsInfo;
            this.btnCardsInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnCardsInfo.Image")));
            this.btnCardsInfo.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCardsInfo.Location = new System.Drawing.Point(842, 213);
            this.btnCardsInfo.Name = "btnCardsInfo";
            this.btnCardsInfo.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCardsInfo.PressedState.Parent = this.btnCardsInfo;
            this.btnCardsInfo.Size = new System.Drawing.Size(40, 40);
            this.btnCardsInfo.TabIndex = 19;
            this.btnCardsInfo.Click += new System.EventHandler(this.btnCardsInfo_Click);
            // 
            // UC_CassaInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.btnCardsInfo);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.rbtPut);
            this.Controls.Add(this.rbtGet);
            this.Controls.Add(this.guna2Separator3);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.txtCashMoney);
            this.Controls.Add(this.txtCashCassa);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UC_CassaInfo";
            this.Size = new System.Drawing.Size(1280, 680);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtCashCassa;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label txtCashMoney;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private System.Windows.Forms.RadioButton rbtPut;
        private System.Windows.Forms.RadioButton rbtGet;
        private Guna.UI2.WinForms.Guna2TextBox txtComment;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2ImageButton btnCardsInfo;
    }
}
