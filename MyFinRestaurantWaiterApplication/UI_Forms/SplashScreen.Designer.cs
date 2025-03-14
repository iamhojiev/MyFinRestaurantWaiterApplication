using System.Drawing;
using System.Windows.Forms;

namespace MyFinCassa.UI_Forms
{
    partial class SplashScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.txtLoadingText = new System.Windows.Forms.Label();
            this.progresLoading = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.txtVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLoadingText
            // 
            this.txtLoadingText.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLoadingText.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.txtLoadingText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoadingText.Location = new System.Drawing.Point(0, 0);
            this.txtLoadingText.Name = "txtLoadingText";
            this.txtLoadingText.Size = new System.Drawing.Size(1039, 66);
            this.txtLoadingText.TabIndex = 3;
            this.txtLoadingText.Text = "🏨 Система управления рестораном";
            this.txtLoadingText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progresLoading
            // 
            this.progresLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progresLoading.BackColor = System.Drawing.Color.Transparent;
            this.progresLoading.BorderRadius = 10;
            this.progresLoading.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progresLoading.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.progresLoading.Location = new System.Drawing.Point(12, 500);
            this.progresLoading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progresLoading.Name = "progresLoading";
            this.progresLoading.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.progresLoading.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progresLoading.ShadowDecoration.Parent = this.progresLoading;
            this.progresLoading.ShowPercentage = true;
            this.progresLoading.Size = new System.Drawing.Size(1015, 36);
            this.progresLoading.TabIndex = 9;
            this.progresLoading.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "🔄 Подготовка системы, немного терпения...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1039, 70);
            this.label2.TabIndex = 3;
            this.label2.Text = "🛠 Разработано командой MYFIN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerProgress
            // 
            this.timerProgress.Interval = 10;
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // txtVersion
            // 
            this.txtVersion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtVersion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtVersion.Location = new System.Drawing.Point(360, 396);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(267, 43);
            this.txtVersion.TabIndex = 10;
            this.txtVersion.Text = "Версия 1.0.0.0";
            this.txtVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(332, 116);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 308);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1039, 565);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoadingText);
            this.Controls.Add(this.progresLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyFin Setup";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label txtLoadingText;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ProgressBar progresLoading;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ShadowForm shadowForm;
        private Timer timerProgress;
        private Label txtVersion;
    }
}