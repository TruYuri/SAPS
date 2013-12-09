namespace SAPS
{
    partial class SAPS
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.tabSystems = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.labelTitle = new System.Windows.Forms.Label();
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
            this.buttonPrintApplication = new System.Windows.Forms.Button();
            this.applicationList = new System.Windows.Forms.DataGridView();
            this.buttonModifyApplication = new System.Windows.Forms.Button();
            this.buttonSearchApplications = new System.Windows.Forms.Button();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.buttonPrintEvent = new System.Windows.Forms.Button();
            this.buttonSearchEvents = new System.Windows.Forms.Button();
            this.buttonCreateEvent = new System.Windows.Forms.Button();
            this.buttonModifyEvent = new System.Windows.Forms.Button();
            this.eventList = new System.Windows.Forms.DataGridView();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.tabStats = new System.Windows.Forms.TabControl();
            this.tabCollege = new System.Windows.Forms.TabPage();
            this.buttonSaveCollege = new System.Windows.Forms.Button();
            this.buttonPrintCollege = new System.Windows.Forms.Button();
            this.labelCollegeType = new System.Windows.Forms.Label();
            this.comboCollegeType = new System.Windows.Forms.ComboBox();
            this.chartCollege = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabACT = new System.Windows.Forms.TabPage();
            this.buttonPrintACT = new System.Windows.Forms.Button();
            this.labelACTType = new System.Windows.Forms.Label();
            this.comboACTType = new System.Windows.Forms.ComboBox();
            this.chartACT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabCustom = new System.Windows.Forms.TabPage();
            this.buttonPrintCustom = new System.Windows.Forms.Button();
            this.labelCustomType = new System.Windows.Forms.Label();
            this.comboCustomType = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonSaveACT = new System.Windows.Forms.Button();
            this.buttonSaveCustom = new System.Windows.Forms.Button();
            this.tabSystems.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.applicationList)).BeginInit();
            this.tabEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventList)).BeginInit();
            this.tabStatistics.SuspendLayout();
            this.tabStats.SuspendLayout();
            this.tabCollege.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCollege)).BeginInit();
            this.tabACT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartACT)).BeginInit();
            this.tabCustom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.tabLogin.Controls.Add(this.labelTitle);
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
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(289, 106);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(324, 40);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "SAPS\r\nStudent Application Processing System";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.textPassword.UseSystemPasswordChar = true;
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
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
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
            this.tabApplications.Controls.Add(this.buttonPrintApplication);
            this.tabApplications.Controls.Add(this.applicationList);
            this.tabApplications.Controls.Add(this.buttonModifyApplication);
            this.tabApplications.Controls.Add(this.buttonSearchApplications);
            this.tabApplications.Location = new System.Drawing.Point(4, 22);
            this.tabApplications.Name = "tabApplications";
            this.tabApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabApplications.Size = new System.Drawing.Size(884, 428);
            this.tabApplications.TabIndex = 1;
            this.tabApplications.Text = "Applications";
            this.tabApplications.UseVisualStyleBackColor = true;
            // 
            // buttonPrintApplication
            // 
            this.buttonPrintApplication.Location = new System.Drawing.Point(750, 35);
            this.buttonPrintApplication.Name = "buttonPrintApplication";
            this.buttonPrintApplication.Size = new System.Drawing.Size(128, 23);
            this.buttonPrintApplication.TabIndex = 4;
            this.buttonPrintApplication.Text = "Print";
            this.buttonPrintApplication.UseVisualStyleBackColor = true;
            this.buttonPrintApplication.Click += new System.EventHandler(this.buttonPrintApplication_Click);
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
            // buttonSearchApplications
            // 
            this.buttonSearchApplications.Location = new System.Drawing.Point(750, 399);
            this.buttonSearchApplications.Name = "buttonSearchApplications";
            this.buttonSearchApplications.Size = new System.Drawing.Size(128, 23);
            this.buttonSearchApplications.TabIndex = 1;
            this.buttonSearchApplications.Text = "Search";
            this.buttonSearchApplications.UseVisualStyleBackColor = true;
            // 
            // tabEvents
            // 
            this.tabEvents.Controls.Add(this.buttonPrintEvent);
            this.tabEvents.Controls.Add(this.buttonSearchEvents);
            this.tabEvents.Controls.Add(this.buttonCreateEvent);
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
            // buttonPrintEvent
            // 
            this.buttonPrintEvent.Location = new System.Drawing.Point(750, 64);
            this.buttonPrintEvent.Name = "buttonPrintEvent";
            this.buttonPrintEvent.Size = new System.Drawing.Size(128, 23);
            this.buttonPrintEvent.TabIndex = 8;
            this.buttonPrintEvent.Text = "Print";
            this.buttonPrintEvent.UseVisualStyleBackColor = true;
            this.buttonPrintEvent.Click += new System.EventHandler(this.buttonPrintEvent_Click);
            // 
            // buttonSearchEvents
            // 
            this.buttonSearchEvents.Location = new System.Drawing.Point(750, 399);
            this.buttonSearchEvents.Name = "buttonSearchEvents";
            this.buttonSearchEvents.Size = new System.Drawing.Size(128, 23);
            this.buttonSearchEvents.TabIndex = 7;
            this.buttonSearchEvents.Text = "Search";
            this.buttonSearchEvents.UseVisualStyleBackColor = true;
            // 
            // buttonCreateEvent
            // 
            this.buttonCreateEvent.Location = new System.Drawing.Point(750, 6);
            this.buttonCreateEvent.Name = "buttonCreateEvent";
            this.buttonCreateEvent.Size = new System.Drawing.Size(128, 23);
            this.buttonCreateEvent.TabIndex = 6;
            this.buttonCreateEvent.Text = "Create";
            this.buttonCreateEvent.UseVisualStyleBackColor = true;
            this.buttonCreateEvent.Click += new System.EventHandler(this.buttonCreateEvent_Click);
            // 
            // buttonModifyEvent
            // 
            this.buttonModifyEvent.Location = new System.Drawing.Point(750, 35);
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
            this.tabStats.Controls.Add(this.tabCollege);
            this.tabStats.Controls.Add(this.tabACT);
            this.tabStats.Controls.Add(this.tabCustom);
            this.tabStats.Location = new System.Drawing.Point(-4, 0);
            this.tabStats.Multiline = true;
            this.tabStats.Name = "tabStats";
            this.tabStats.SelectedIndex = 0;
            this.tabStats.Size = new System.Drawing.Size(888, 432);
            this.tabStats.TabIndex = 0;
            // 
            // tabCollege
            // 
            this.tabCollege.Controls.Add(this.buttonSaveCollege);
            this.tabCollege.Controls.Add(this.buttonPrintCollege);
            this.tabCollege.Controls.Add(this.labelCollegeType);
            this.tabCollege.Controls.Add(this.comboCollegeType);
            this.tabCollege.Controls.Add(this.chartCollege);
            this.tabCollege.Location = new System.Drawing.Point(4, 4);
            this.tabCollege.Name = "tabCollege";
            this.tabCollege.Padding = new System.Windows.Forms.Padding(3);
            this.tabCollege.Size = new System.Drawing.Size(861, 424);
            this.tabCollege.TabIndex = 0;
            this.tabCollege.Text = "College";
            this.tabCollege.UseVisualStyleBackColor = true;
            // 
            // buttonSaveCollege
            // 
            this.buttonSaveCollege.Location = new System.Drawing.Point(607, 398);
            this.buttonSaveCollege.Name = "buttonSaveCollege";
            this.buttonSaveCollege.Size = new System.Drawing.Size(121, 23);
            this.buttonSaveCollege.TabIndex = 9;
            this.buttonSaveCollege.Text = "Save";
            this.buttonSaveCollege.UseVisualStyleBackColor = true;
            this.buttonSaveCollege.Click += new System.EventHandler(this.buttonSaveCollege_Click);
            // 
            // buttonPrintCollege
            // 
            this.buttonPrintCollege.Location = new System.Drawing.Point(734, 398);
            this.buttonPrintCollege.Name = "buttonPrintCollege";
            this.buttonPrintCollege.Size = new System.Drawing.Size(121, 23);
            this.buttonPrintCollege.TabIndex = 8;
            this.buttonPrintCollege.Text = "Print";
            this.buttonPrintCollege.UseVisualStyleBackColor = true;
            this.buttonPrintCollege.Click += new System.EventHandler(this.buttonPrintCollege_Click);
            // 
            // labelCollegeType
            // 
            this.labelCollegeType.AutoSize = true;
            this.labelCollegeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCollegeType.Location = new System.Drawing.Point(3, 398);
            this.labelCollegeType.Name = "labelCollegeType";
            this.labelCollegeType.Size = new System.Drawing.Size(74, 16);
            this.labelCollegeType.TabIndex = 3;
            this.labelCollegeType.Text = "Chart Type";
            // 
            // comboCollegeType
            // 
            this.comboCollegeType.FormattingEnabled = true;
            this.comboCollegeType.Location = new System.Drawing.Point(83, 398);
            this.comboCollegeType.Name = "comboCollegeType";
            this.comboCollegeType.Size = new System.Drawing.Size(121, 21);
            this.comboCollegeType.TabIndex = 2;
            this.comboCollegeType.SelectedIndexChanged += new System.EventHandler(this.comboCollegeChart_SelectedIndexChanged);
            // 
            // chartCollege
            // 
            chartArea4.Name = "ChartArea1";
            this.chartCollege.ChartAreas.Add(chartArea4);
            this.chartCollege.Location = new System.Drawing.Point(0, 0);
            this.chartCollege.Name = "chartCollege";
            this.chartCollege.Size = new System.Drawing.Size(863, 396);
            this.chartCollege.TabIndex = 0;
            this.chartCollege.Text = "College";
            // 
            // tabACT
            // 
            this.tabACT.Controls.Add(this.buttonSaveACT);
            this.tabACT.Controls.Add(this.buttonPrintACT);
            this.tabACT.Controls.Add(this.labelACTType);
            this.tabACT.Controls.Add(this.comboACTType);
            this.tabACT.Controls.Add(this.chartACT);
            this.tabACT.Location = new System.Drawing.Point(4, 4);
            this.tabACT.Name = "tabACT";
            this.tabACT.Size = new System.Drawing.Size(861, 424);
            this.tabACT.TabIndex = 2;
            this.tabACT.Text = "ACT";
            this.tabACT.UseVisualStyleBackColor = true;
            // 
            // buttonPrintACT
            // 
            this.buttonPrintACT.Location = new System.Drawing.Point(734, 398);
            this.buttonPrintACT.Name = "buttonPrintACT";
            this.buttonPrintACT.Size = new System.Drawing.Size(121, 23);
            this.buttonPrintACT.TabIndex = 7;
            this.buttonPrintACT.Text = "Print";
            this.buttonPrintACT.UseVisualStyleBackColor = true;
            this.buttonPrintACT.Click += new System.EventHandler(this.buttonPrintACT_Click);
            // 
            // labelACTType
            // 
            this.labelACTType.AutoSize = true;
            this.labelACTType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelACTType.Location = new System.Drawing.Point(3, 398);
            this.labelACTType.Name = "labelACTType";
            this.labelACTType.Size = new System.Drawing.Size(74, 16);
            this.labelACTType.TabIndex = 6;
            this.labelACTType.Text = "Chart Type";
            // 
            // comboACTType
            // 
            this.comboACTType.FormattingEnabled = true;
            this.comboACTType.Location = new System.Drawing.Point(83, 398);
            this.comboACTType.Name = "comboACTType";
            this.comboACTType.Size = new System.Drawing.Size(121, 21);
            this.comboACTType.TabIndex = 5;
            this.comboACTType.SelectedIndexChanged += new System.EventHandler(this.comboACTType_SelectedIndexChanged);
            // 
            // chartACT
            // 
            chartArea5.Name = "ChartArea1";
            this.chartACT.ChartAreas.Add(chartArea5);
            this.chartACT.Location = new System.Drawing.Point(0, 0);
            this.chartACT.Name = "chartACT";
            this.chartACT.Size = new System.Drawing.Size(863, 396);
            this.chartACT.TabIndex = 4;
            this.chartACT.Text = "ACT Scores";
            // 
            // tabCustom
            // 
            this.tabCustom.Controls.Add(this.buttonSaveCustom);
            this.tabCustom.Controls.Add(this.buttonPrintCustom);
            this.tabCustom.Controls.Add(this.labelCustomType);
            this.tabCustom.Controls.Add(this.comboCustomType);
            this.tabCustom.Controls.Add(this.chart1);
            this.tabCustom.Location = new System.Drawing.Point(4, 4);
            this.tabCustom.Name = "tabCustom";
            this.tabCustom.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustom.Size = new System.Drawing.Size(861, 424);
            this.tabCustom.TabIndex = 1;
            this.tabCustom.Text = "Custom";
            this.tabCustom.UseVisualStyleBackColor = true;
            // 
            // buttonPrintCustom
            // 
            this.buttonPrintCustom.Location = new System.Drawing.Point(734, 398);
            this.buttonPrintCustom.Name = "buttonPrintCustom";
            this.buttonPrintCustom.Size = new System.Drawing.Size(121, 23);
            this.buttonPrintCustom.TabIndex = 11;
            this.buttonPrintCustom.Text = "Print";
            this.buttonPrintCustom.UseVisualStyleBackColor = true;
            this.buttonPrintCustom.Click += new System.EventHandler(this.buttonPrintCustom_Click);
            // 
            // labelCustomType
            // 
            this.labelCustomType.AutoSize = true;
            this.labelCustomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomType.Location = new System.Drawing.Point(3, 398);
            this.labelCustomType.Name = "labelCustomType";
            this.labelCustomType.Size = new System.Drawing.Size(74, 16);
            this.labelCustomType.TabIndex = 10;
            this.labelCustomType.Text = "Chart Type";
            // 
            // comboCustomType
            // 
            this.comboCustomType.FormattingEnabled = true;
            this.comboCustomType.Location = new System.Drawing.Point(83, 398);
            this.comboCustomType.Name = "comboCustomType";
            this.comboCustomType.Size = new System.Drawing.Size(121, 21);
            this.comboCustomType.TabIndex = 9;
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(863, 396);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "ACT Scores";
            // 
            // buttonSaveACT
            // 
            this.buttonSaveACT.Location = new System.Drawing.Point(607, 398);
            this.buttonSaveACT.Name = "buttonSaveACT";
            this.buttonSaveACT.Size = new System.Drawing.Size(121, 23);
            this.buttonSaveACT.TabIndex = 10;
            this.buttonSaveACT.Text = "Save";
            this.buttonSaveACT.UseVisualStyleBackColor = true;
            this.buttonSaveACT.Click += new System.EventHandler(this.buttonSaveACT_Click);
            // 
            // buttonSaveCustom
            // 
            this.buttonSaveCustom.Location = new System.Drawing.Point(607, 398);
            this.buttonSaveCustom.Name = "buttonSaveCustom";
            this.buttonSaveCustom.Size = new System.Drawing.Size(121, 23);
            this.buttonSaveCustom.TabIndex = 12;
            this.buttonSaveCustom.Text = "Save";
            this.buttonSaveCustom.UseVisualStyleBackColor = true;
            this.buttonSaveCustom.Click += new System.EventHandler(this.buttonSaveCustom_Click);
            // 
            // SAPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 478);
            this.Controls.Add(this.tabSystems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SAPS";
            this.Text = "Student Application Processing System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SAPS_FormClosing);
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
            this.tabCollege.ResumeLayout(false);
            this.tabCollege.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCollege)).EndInit();
            this.tabACT.ResumeLayout(false);
            this.tabACT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartACT)).EndInit();
            this.tabCustom.ResumeLayout(false);
            this.tabCustom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSystems;
        private System.Windows.Forms.TabPage tabApplications;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.TabPage tabStatistics;
        private System.Windows.Forms.TabControl tabStats;
        private System.Windows.Forms.TabPage tabCollege;
        private System.Windows.Forms.TabPage tabCustom;
        private System.Windows.Forms.Button buttonModifyApplication;
        private System.Windows.Forms.Button buttonSearchApplications;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label textName;
        private System.Windows.Forms.Label textSAPS;
        private System.Windows.Forms.Label textWelcome;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.WebBrowser feedNews;
        private System.Windows.Forms.MonthCalendar calenderHome;
        private System.Windows.Forms.DataGridView applicationList;
        private System.Windows.Forms.DataGridView eventList;
        private System.Windows.Forms.Button buttonModifyEvent;
        private System.Windows.Forms.Button buttonSearchEvents;
        private System.Windows.Forms.Button buttonCreateEvent;
        private System.Windows.Forms.Button buttonPrintApplication;
        private System.Windows.Forms.Button buttonPrintEvent;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCollege;
        private System.Windows.Forms.Label labelCollegeType;
        private System.Windows.Forms.ComboBox comboCollegeType;
        private System.Windows.Forms.TabPage tabACT;
        private System.Windows.Forms.Label labelACTType;
        private System.Windows.Forms.ComboBox comboACTType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartACT;
        private System.Windows.Forms.Button buttonPrintACT;
        private System.Windows.Forms.Button buttonPrintCollege;
        private System.Windows.Forms.Button buttonPrintCustom;
        private System.Windows.Forms.Label labelCustomType;
        private System.Windows.Forms.ComboBox comboCustomType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonSaveCollege;
        private System.Windows.Forms.Button buttonSaveACT;
        private System.Windows.Forms.Button buttonSaveCustom;
    }
}

