namespace MyFinCassa.UI_UserControls.PageCashe
{
    partial class UC_ProductWidget
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
            this.txtProdPrice = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.Label();
            this.Container = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.picProd = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtCount = new System.Windows.Forms.Label();
            this.Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtProdPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtProdPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdPrice.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtProdPrice.Location = new System.Drawing.Point(12, 87);
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(146, 35);
            this.txtProdPrice.TabIndex = 7;
            this.txtProdPrice.Text = "100 sum/kg";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.txtTitle.Location = new System.Drawing.Point(10, 11);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(148, 81);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.Text = "ProdName";
            // 
            // Container
            // 
            this.Container.AutoSize = true;
            this.Container.BackColor = System.Drawing.Color.Transparent;
            this.Container.Controls.Add(this.picProd);
            this.Container.Controls.Add(this.txtCount);
            this.Container.Controls.Add(this.txtProdPrice);
            this.Container.Controls.Add(this.txtTitle);
            this.Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Container.FillColor = System.Drawing.Color.White;
            this.Container.Location = new System.Drawing.Point(0, 0);
            this.Container.Name = "Container";
            this.Container.Radius = 10;
            this.Container.ShadowColor = System.Drawing.Color.Black;
            this.Container.Size = new System.Drawing.Size(246, 132);
            this.Container.TabIndex = 1;
            // 
            // picProd
            // 
            this.picProd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picProd.BackColor = System.Drawing.Color.Transparent;
            this.picProd.BorderRadius = 10;
            this.picProd.Image = global::MyFinCassa.Properties.Resources.cameraOf_high;
            this.picProd.Location = new System.Drawing.Point(157, 15);
            this.picProd.Name = "picProd";
            this.picProd.ShadowDecoration.Parent = this.picProd;
            this.picProd.Size = new System.Drawing.Size(80, 80);
            this.picProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProd.TabIndex = 6;
            this.picProd.TabStop = false;
            // 
            // txtCount
            // 
            this.txtCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCount.BackColor = System.Drawing.Color.Transparent;
            this.txtCount.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCount.ForeColor = System.Drawing.Color.Black;
            this.txtCount.Location = new System.Drawing.Point(179, 94);
            this.txtCount.Margin = new System.Windows.Forms.Padding(0);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(59, 30);
            this.txtCount.TabIndex = 8;
            this.txtCount.Text = "x99";
            this.txtCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UC_ProductWidget
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Container);
            this.Name = "UC_ProductWidget";
            this.Size = new System.Drawing.Size(246, 132);
            this.Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public new Guna.UI2.WinForms.Guna2ShadowPanel Container;
        public System.Windows.Forms.Label txtTitle;
        public Guna.UI2.WinForms.Guna2PictureBox picProd;
        public System.Windows.Forms.Label txtProdPrice;
        public System.Windows.Forms.Label txtCount;
    }
}
