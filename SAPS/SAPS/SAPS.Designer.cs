namespace SAPS
{
    partial class winSAPS
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
            this.tabSystems = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.Label();
            this.textSAPS = new System.Windows.Forms.Label();
            this.textWelcome = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.feedNews = new System.Windows.Forms.WebBrowser();
            this.calenderHome = new System.Windows.Forms.MonthCalendar();
            this.tabApplications = new System.Windows.Forms.TabPage();
            this.applicationList = new System.Windows.Forms.DataGridView();
            this.buttonModifyApplication = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.buttonModifyEvent = new System.Windows.Forms.Button();
            this.eventList = new System.Windows.Forms.DataGridView();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.tabStats = new System.Windows.Forms.TabControl();
            this.tabDefault = new System.Windows.Forms.TabPage();
            this.tabCustom = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabSystems.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationList)).BeginInit();
            this.tabEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventList)).BeginInit();
            this.tabStatistics.SuspendLayout();
            this.tabStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSystems
            // 
            this.tabSystems.Controls.Add(this.tabLogin);
            this.tabSystems.Controls.Add(this.tabHome);
            this.tabSystems.Controls.Add(this.tabApplications);
            this.tabSystems.Controls.Add(this.tabEvents);
            this.tabSystems.Controls.Add(this.tabStatistics);
            this.tabSystems.ItemSize = new System.Drawing.Size(100, 18);
            this.tabSystems.Location = new System.Drawing.Point(12, 12);
            this.tabSystems.Name = "tabSystems";
            this.tabSystems.SelectedIndex = 0;
            this.tabSystems.Size = new System.Drawing.Size(892, 454);
            this.tabSystems.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.label1);
            this.tabLogin.Controls.Add(this.labelPassword);
            this.tabLogin.Controls.Add(this.labelEmail);
            this.tabLogin.Controls.Add(this.textEmail);
            this.tabLogin.Controls.Add(this.textPassword);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(884, 428);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Log In";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "SAPS\r\nStudent Application Processing System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(425, 223);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(435, 168);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(376, 184);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(150, 20);
            this.textEmail.TabIndex = 2;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(376, 239);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(150, 20);
            this.textPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(376, 265);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.buttonUpdate);
            this.tabHome.Controls.Add(this.textName);
            this.tabHome.Controls.Add(this.textSAPS);
            this.tabHome.Controls.Add(this.textWelcome);
            this.tabHome.Controls.Add(this.buttonLogout);
            this.tabHome.Controls.Add(this.feedNews);
            this.tabHome.Controls.Add(this.calenderHome);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(884, 428);
            this.tabHome.TabIndex = 4;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(683, 371);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(156, 23);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // textName
            // 
            this.textName.AutoSize = true;
            this.textName.Location = new System.Drawing.Point(726, 67);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(56, 13);
            this.textName.TabIndex = 7;
            this.textName.Text = "user name";
            // 
            // textSAPS
            // 
            this.textSAPS.AutoSize = true;
            this.textSAPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSAPS.Location = new System.Drawing.Point(645, 18);
            this.textSAPS.Name = "textSAPS";
            this.textSAPS.Size = new System.Drawing.Size(228, 26);
            this.textSAPS.TabIndex = 6;
            this.textSAPS.Text = "SAPS\r\nStudent Application Processing System";
            this.textSAPS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textWelcome
            // 
            this.textWelcome.AutoSize = true;
            this.textWelcome.Location = new System.Drawing.Point(727, 54);
            this.textWelcome.Name = "textWelcome";
            this.textWelcome.Size = new System.Drawing.Size(55, 13);
            this.textWelcome.TabIndex = 3;
            this.textWelcome.Text = "Welcome,";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(683, 400);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(156, 23);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // feedNews
            // 
            this.feedNews.Location = new System.Drawing.Point(-4, 0);
            this.feedNews.MinimumSize = new System.Drawing.Size(20, 20);
            this.feedNews.Name = "feedNews";
            this.feedNews.Size = new System.Drawing.Size(640, 432);
            this.feedNews.TabIndex = 1;
            // 
            // calenderHome
            // 
            this.calenderHome.Location = new System.Drawing.Point(648, 89);
            this.calenderHome.Name = "calenderHome";
            this.calenderHome.TabIndex = 0;
            // 
            // tabApplications
            // 
            this.tabApplications.Controls.Add(this.applicationList);
            this.tabApplications.Controls.Add(this.buttonModifyApplication);
            this.tabApplications.Controls.Add(this.buttonSearch);
            this.tabApplications.Location = new System.Drawing.Point(4, 22);
            this.tabApplications.Name = "tabApplications";
            this.tabApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabApplications.Size = new System.Drawing.Size(884, 428);
            this.tabApplications.TabIndex = 1;
            this.tabApplications.Text = "Applications";
            this.tabApplications.UseVisualStyleBackColor = true;
            // 
            // applicationList
            // 
            this.applicationList.AllowUserToAddRows = false;
            this.applicationList.AllowUserToDeleteRows = false;
            this.applicationList.AllowUserToResizeColumns = false;
            this.applicationList.AllowUserToResizeRows = false;
            this.applicationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applicationList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.applicationList.Location = new System.Drawing.Point(-4, 0);
            this.applicationList.MultiSelect = false;
            this.applicationList.Name = "applicationList";
            this.applicationList.ReadOnly = true;
            this.applicationList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.applicationList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.applicationList.Size = new System.Drawing.Size(748, 432);
            this.applicationList.TabIndex = 3;
            this.applicationList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.applicationList_CellContentDoubleClick);
            this.applicationList.SelectionChanged += new System.EventHandler(this.applicationList_SelectionChanged);
            // 
            // buttonModifyApplication
            // 
            this.buttonModifyApplication.Enabled = false;
            this.buttonModifyApplication.Location = new System.Drawing.Point(750, 6);
            this.buttonModifyApplication.Name = "buttonModifyApplication";
            this.buttonModifyApplication.Size = new System.Drawing.Size(128, 23);
            this.buttonModifyApplication.TabIndex = 2;
            this.buttonModifyApplication.Text = "Modify";
            this.buttonModifyApplication.UseVisualStyleBackColor = true;
            this.buttonModifyApplication.Click += new System.EventHandler(this.buttonModifyApplication_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(750, 402);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(128, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // tabEvents
            // 
            this.tabEvents.Controls.Add(this.buttonModifyEvent);
            this.tabEvents.Controls.Add(this.eventList);
            this.tabEvents.Location = new System.Drawing.Point(4, 22);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabEvents.Size = new System.Drawing.Size(884, 428);
            this.tabEvents.TabIndex = 2;
            this.tabEvents.Text = "Events";
            this.tabEvents.UseVisualStyleBackColor = true;
            // 
            // buttonModifyEvent
            // 
            this.buttonModifyEvent.Enabled = false;
            this.buttonModifyEvent.Location = new System.Drawing.Point(750, 6);
            this.buttonModifyEvent.Name = "buttonModifyEvent";
            this.buttonModifyEvent.Size = new System.Drawing.Size(128, 23);
            this.buttonModifyEvent.TabIndex = 5;
            this.buttonModifyEvent.Text = "Modify";
            this.buttonModifyEvent.UseVisualStyleBackColor = true;
            this.buttonModifyEvent.Click += new System.EventHandler(this.buttonModifyEvent_Click);
            // 
            // eventList
            // 
            this.eventList.AllowUserToAddRows = false;
            this.eventList.AllowUserToDeleteRows = false;
            this.eventList.AllowUserToResizeColumns = false;
            this.eventList.AllowUserToResizeRows = false;
            this.eventList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.eventList.Location = new System.Drawing.Point(-4, 0);
            this.eventList.MultiSelect = false;
            this.eventList.Name = "eventList";
            this.eventList.ReadOnly = true;
            this.eventList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.eventList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventList.Size = new System.Drawing.Size(748, 432);
            this.eventList.TabIndex = 4;
            this.eventList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventList_CellContentDoubleClick);
            this.eventList.SelectionChanged += new System.EventHandler(this.eventList_SelectionChanged);
            // 
            // tabStatistics
            // 
            this.tabStatistics.Controls.Add(this.tabStats);
            this.tabStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabStatistics.Name = "tabStatistics";
            this.tabStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatistics.Size = new System.Drawing.Size(884, 428);
            this.tabStatistics.TabIndex = 3;
            this.tabStatistics.Text = "Statistics";
            this.tabStatistics.UseVisualStyleBackColor = true;
            // 
            // tabStats
            // 
            this.tabStats.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabStats.Controls.Add(this.tabDefault);
            this.tabStats.Controls.Add(this.tabCustom);
            this.tabStats.Location = new System.Drawing.Point(-4, 0);
            this.tabStats.Multiline = true;
            this.tabStats.Name = "tabStats";
            this.tabStats.SelectedIndex = 0;
            this.tabStats.Size = new System.Drawing.Size(888, 432);
            this.tabStats.TabIndex = 0;
            // 
            // tabDefault
            // 
            this.tabDefault.Location = new System.Drawing.Point(4, 4);
            this.tabDefault.Name = "tabDefault";
            this.tabDefault.Padding = new System.Windows.Forms.Padding(3);
            this.tabDefault.Size = new System.Drawing.Size(861, 424);
            this.tabDefault.TabIndex = 0;
            this.tabDefault.Text = "Default";
            this.tabDefault.UseVisualStyleBackColor = true;
            // 
            // tabCustom
            // 
            this.tabCustom.Location = new System.Drawing.Point(4, 4);
            this.tabCustom.Name = "tabCustom";
            this.tabCustom.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustom.Size = new System.Drawing.Size(861, 424);
            this.tabCustom.TabIndex = 1;
            this.tabCustom.Text = "Custom";
            this.tabCustom.UseVisualStyleBackColor = true;
            // 
            // winSAPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 478);
            this.Controls.Add(this.tabSystems);
            this.Name = "winSAPS";
            this.Text = "Student Application Processing System";
            this.tabSystems.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.applicationList)).EndInit();
            this.tabEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventList)).EndInit();
            this.tabStatistics.ResumeLayout(false);
            this.tabStats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSystems;
        private System.Windows.Forms.TabPage tabApplications;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.TabPage tabStatistics;
        private System.Windows.Forms.TabControl tabStats;
        private System.Windows.Forms.TabPage tabDefault;
        private System.Windows.Forms.TabPage tabCustom;
        private System.Windows.Forms.Button buttonModifyApplication;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label textName;
        private System.Windows.Forms.Label textSAPS;
        private System.Windows.Forms.Label textWelcome;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.WebBrowser feedNews;
        private System.Windows.Forms.MonthCalendar calenderHome;
        private System.Windows.Forms.DataGridView applicationList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView eventList;
        private System.Windows.Forms.Button buttonModifyEvent;
    }
}

