namespace MyFinCassa
{
    partial class RestaurantMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaurantMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnOperations = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShift = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCassaInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMainMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLists = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShiftHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCassaHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHallTableCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFinance = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIncomingInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWaiterStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.btnChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogs = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDiscount = new System.Windows.Forms.ToolStripMenuItem();
            this.mainContainer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOperations,
            this.btnMainMenu,
            this.btnLists,
            this.btnFinance,
            this.btnStatistic,
            this.btnSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1280, 58);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnOperations
            // 
            this.btnOperations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShift,
            this.btnCassaInfo,
            this.btnClose,
            this.btnQuit});
            this.btnOperations.Name = "btnOperations";
            this.btnOperations.Size = new System.Drawing.Size(206, 54);
            this.btnOperations.Text = "Операции";
            // 
            // btnShift
            // 
            this.btnShift.Image = ((System.Drawing.Image)(resources.GetObject("btnShift.Image")));
            this.btnShift.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(274, 56);
            this.btnShift.Text = "Смена";
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // btnCassaInfo
            // 
            this.btnCassaInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnCassaInfo.Image")));
            this.btnCassaInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCassaInfo.Name = "btnCassaInfo";
            this.btnCassaInfo.Size = new System.Drawing.Size(274, 56);
            this.btnCassaInfo.Text = "Касса";
            this.btnCassaInfo.Click += new System.EventHandler(this.btnCassaInfo_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(274, 56);
            this.btnClose.Text = "Закрыть";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(274, 56);
            this.btnQuit.Text = "Выход";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(170, 54);
            this.btnMainMenu.Text = "Главное";
            this.btnMainMenu.Click += new System.EventHandler(this.btnCassa_Click);
            // 
            // btnLists
            // 
            this.btnLists.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsers,
            this.btnShiftHistory,
            this.btnCassaHistory,
            this.btnHallTableCategories});
            this.btnLists.Name = "btnLists";
            this.btnLists.Size = new System.Drawing.Size(156, 54);
            this.btnLists.Text = "Списки";
            // 
            // btnUsers
            // 
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(629, 56);
            this.btnUsers.Text = "Сотрудники";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnShiftHistory
            // 
            this.btnShiftHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnShiftHistory.Image")));
            this.btnShiftHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnShiftHistory.Name = "btnShiftHistory";
            this.btnShiftHistory.Size = new System.Drawing.Size(629, 56);
            this.btnShiftHistory.Text = "История смен";
            this.btnShiftHistory.Click += new System.EventHandler(this.btnShiftHistory_Click);
            // 
            // btnCassaHistory
            // 
            this.btnCassaHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnCassaHistory.Image")));
            this.btnCassaHistory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCassaHistory.Name = "btnCassaHistory";
            this.btnCassaHistory.Size = new System.Drawing.Size(629, 56);
            this.btnCassaHistory.Text = "История кассы";
            this.btnCassaHistory.Click += new System.EventHandler(this.btnCassaHistory_Click);
            // 
            // btnHallTableCategories
            // 
            this.btnHallTableCategories.Image = ((System.Drawing.Image)(resources.GetObject("btnHallTableCategories.Image")));
            this.btnHallTableCategories.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHallTableCategories.Name = "btnHallTableCategories";
            this.btnHallTableCategories.Size = new System.Drawing.Size(629, 56);
            this.btnHallTableCategories.Text = "Залы/Столы/Kухни/Категории";
            this.btnHallTableCategories.Click += new System.EventHandler(this.btnHallTableCategories_Click);
            // 
            // btnFinance
            // 
            this.btnFinance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIncomingInfo});
            this.btnFinance.Name = "btnFinance";
            this.btnFinance.Size = new System.Drawing.Size(186, 54);
            this.btnFinance.Text = "Финансы";
            // 
            // btnIncomingInfo
            // 
            this.btnIncomingInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnIncomingInfo.Image")));
            this.btnIncomingInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnIncomingInfo.Name = "btnIncomingInfo";
            this.btnIncomingInfo.Size = new System.Drawing.Size(528, 56);
            this.btnIncomingInfo.Text = "Информация о доходах";
            this.btnIncomingInfo.Click += new System.EventHandler(this.btnIncomingInfo_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnWaiterStatistic});
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(216, 54);
            this.btnStatistic.Text = "Статистика";
            // 
            // btnWaiterStatistic
            // 
            this.btnWaiterStatistic.Image = ((System.Drawing.Image)(resources.GetObject("btnWaiterStatistic.Image")));
            this.btnWaiterStatistic.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnWaiterStatistic.Name = "btnWaiterStatistic";
            this.btnWaiterStatistic.Size = new System.Drawing.Size(528, 56);
            this.btnWaiterStatistic.Text = "Статистика официантов";
            this.btnWaiterStatistic.Click += new System.EventHandler(this.btnWaiterStatistic_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChangePass,
            this.btnLogs,
            this.btnDiscount});
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(214, 54);
            this.btnSettings.Text = "Настройки";
            // 
            // btnChangePass
            // 
            this.btnChangePass.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePass.Image")));
            this.btnChangePass.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(367, 56);
            this.btnChangePass.Text = "Смена пароля";
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.Image = ((System.Drawing.Image)(resources.GetObject("btnLogs.Image")));
            this.btnLogs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(367, 56);
            this.btnLogs.Text = "Логи";
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscount.Image")));
            this.btnDiscount.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(367, 56);
            this.btnDiscount.Text = "Опции кассы";
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // mainContainer
            // 
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 58);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(1280, 662);
            this.mainContainer.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnOperations;
        private System.Windows.Forms.ToolStripMenuItem btnShift;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripMenuItem btnQuit;
        private System.Windows.Forms.ToolStripMenuItem btnMainMenu;
        private System.Windows.Forms.ToolStripMenuItem btnLists;
        private System.Windows.Forms.ToolStripMenuItem btnUsers;
        private System.Windows.Forms.ToolStripMenuItem btnShiftHistory;
        private System.Windows.Forms.ToolStripMenuItem btnCassaHistory;
        private System.Windows.Forms.ToolStripMenuItem btnHallTableCategories;
        private System.Windows.Forms.ToolStripMenuItem btnFinance;
        private System.Windows.Forms.ToolStripMenuItem btnIncomingInfo;
        private System.Windows.Forms.ToolStripMenuItem btnStatistic;
        private System.Windows.Forms.ToolStripMenuItem btnWaiterStatistic;
        private System.Windows.Forms.ToolStripMenuItem btnSettings;
        private System.Windows.Forms.ToolStripMenuItem btnChangePass;
        private System.Windows.Forms.ToolStripMenuItem btnLogs;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.ToolStripMenuItem btnDiscount;
        private System.Windows.Forms.ToolStripMenuItem btnCassaInfo;
    }
}