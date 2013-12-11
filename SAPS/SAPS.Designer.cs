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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
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
            this.labelName = new System.Windows.Forms.Label();
            this.textSAPS = new System.Windows.Forms.Label();
            this.textWelcome = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.feedNews = new System.Windows.Forms.WebBrowser();
            this.calenderHome = new System.Windows.Forms.MonthCalendar();
            this.tabApplications = new System.Windows.Forms.TabPage();
            this.buttonResetApplications = new System.Windows.Forms.Button();
            this.buttonPrintApplication = new System.Windows.Forms.Button();
            this.applicationList = new System.Windows.Forms.DataGridView();
            this.buttonModifyApplication = new System.Windows.Forms.Button();
            this.buttonSearchApplications = new System.Windows.Forms.Button();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.buttonResetEvents = new System.Windows.Forms.Button();
            this.buttonPrintEvent = new System.Windows.Forms.Button();
            this.buttonSearchEvents = new System.Windows.Forms.Button();
            this.buttonCreateEvent = new System.Windows.Forms.Button();
            this.buttonModifyEvent = new System.Windows.Forms.Button();
            this.eventList = new System.Windows.Forms.DataGridView();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.tabStats = new System.Windows.Forms.TabControl();
            this.tabCollege = new System.Windows.Forms.TabPage();
            this.labelCollegeColor = new System.Windows.Forms.Label();
            this.comboCollegeColor = new System.Windows.Forms.ComboBox();
            this.buttonSaveCollege = new System.Windows.Forms.Button();
            this.buttonPrintCollege = new System.Windows.Forms.Button();
            this.labelCollegeType = new System.Windows.Forms.Label();
            this.comboCollegeType = new System.Windows.Forms.ComboBox();
            this.chartCollege = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabACT = new System.Windows.Forms.TabPage();
            this.buttonSaveACT = new System.Windows.Forms.Button();
            this.labelACTColor = new System.Windows.Forms.Label();
            this.comboACTColor = new System.Windows.Forms.ComboBox();
            this.buttonPrintACT = new System.Windows.Forms.Button();
            this.labelACTType = new System.Windows.Forms.Label();
            this.comboACTType = new System.Windows.Forms.ComboBox();
            this.chartACT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabCustom = new System.Windows.Forms.TabPage();
            this.chartCustom = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelYAxis = new System.Windows.Forms.Label();
            this.comboYAxis = new System.Windows.Forms.ComboBox();
            this.labelXAxis = new System.Windows.Forms.Label();
            this.comboXAxis = new System.Windows.Forms.ComboBox();
            this.buttonSaveCustom = new System.Windows.Forms.Button();
            this.labelCustomColor = new System.Windows.Forms.Label();
            this.comboCustomColor = new System.Windows.Forms.ComboBox();
            this.buttonPrintCustom = new System.Windows.Forms.Button();
            this.labelCustomType = new System.Windows.Forms.Label();
            this.comboCustomType = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.saveStatisticDialog = new System.Windows.Forms.SaveFileDialog();
            this.printStatisticDialog = new System.Windows.Forms.PrintDialog();
            this.printStatistic = new System.Drawing.Printing.PrintDocument();
            this.progressBarFake = new System.Windows.Forms.ProgressBar();
            this.labelNameError = new System.Windows.Forms.Label();
            this.labelPasswordError = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.chartCustom)).BeginInit();
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
            this.tabLogin.Controls.Add(this.labelPasswordError);
            this.tabLogin.Controls.Add(this.labelNameError);
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
            this.textEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(376, 239);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(150, 20);
            this.textPassword.TabIndex = 1;
            this.textPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.tabHome.Controls.Add(this.progressBarFake);
            this.tabHome.Controls.Add(this.buttonUpdate);
            this.tabHome.Controls.Add(this.labelName);
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
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(648, 67);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(227, 13);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "user name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.textWelcome.Location = new System.Drawing.Point(648, 54);
            this.textWelcome.Name = "textWelcome";
            this.textWelcome.Size = new System.Drawing.Size(227, 13);
            this.textWelcome.TabIndex = 3;
            this.textWelcome.Text = "Welcome,";
            this.textWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.feedNews.AllowNavigation = false;
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
            this.tabApplications.Controls.Add(this.buttonResetApplications);
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
            // buttonResetApplications
            // 
            this.buttonResetApplications.Location = new System.Drawing.Point(750, 402);
            this.buttonResetApplications.Name = "buttonResetApplications";
            this.buttonResetApplications.Size = new System.Drawing.Size(128, 23);
            this.buttonResetApplications.TabIndex = 5;
            this.buttonResetApplications.Text = "Reset";
            this.buttonResetApplications.UseVisualStyleBackColor = true;
            this.buttonResetApplications.Click += new System.EventHandler(this.buttonResetApplications_Click);
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
            this.buttonSearchApplications.Location = new System.Drawing.Point(750, 373);
            this.buttonSearchApplications.Name = "buttonSearchApplications";
            this.buttonSearchApplications.Size = new System.Drawing.Size(128, 23);
            this.buttonSearchApplications.TabIndex = 1;
            this.buttonSearchApplications.Text = "Search";
            this.buttonSearchApplications.UseVisualStyleBackColor = true;
            this.buttonSearchApplications.Click += new System.EventHandler(this.buttonSearchApplications_Click);
            // 
            // tabEvents
            // 
            this.tabEvents.Controls.Add(this.buttonResetEvents);
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
            // buttonResetEvents
            // 
            this.buttonResetEvents.Location = new System.Drawing.Point(750, 402);
            this.buttonResetEvents.Name = "buttonResetEvents";
            this.buttonResetEvents.Size = new System.Drawing.Size(128, 23);
            this.buttonResetEvents.TabIndex = 9;
            this.buttonResetEvents.Text = "Reset";
            this.buttonResetEvents.UseVisualStyleBackColor = true;
            this.buttonResetEvents.Click += new System.EventHandler(this.buttonResetEvents_Click);
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
            this.buttonSearchEvents.Location = new System.Drawing.Point(750, 373);
            this.buttonSearchEvents.Name = "buttonSearchEvents";
            this.buttonSearchEvents.Size = new System.Drawing.Size(128, 23);
            this.buttonSearchEvents.TabIndex = 7;
            this.buttonSearchEvents.Text = "Search";
            this.buttonSearchEvents.UseVisualStyleBackColor = true;
            this.buttonSearchEvents.Click += new System.EventHandler(this.buttonSearchEvents_Click);
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
            this.tabCollege.Controls.Add(this.labelCollegeColor);
            this.tabCollege.Controls.Add(this.comboCollegeColor);
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
            // labelCollegeColor
            // 
            this.labelCollegeColor.AutoSize = true;
            this.labelCollegeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCollegeColor.Location = new System.Drawing.Point(179, 399);
            this.labelCollegeColor.Name = "labelCollegeColor";
            this.labelCollegeColor.Size = new System.Drawing.Size(40, 16);
            this.labelCollegeColor.TabIndex = 11;
            this.labelCollegeColor.Text = "Color";
            // 
            // comboCollegeColor
            // 
            this.comboCollegeColor.FormattingEnabled = true;
            this.comboCollegeColor.Location = new System.Drawing.Point(225, 397);
            this.comboCollegeColor.Name = "comboCollegeColor";
            this.comboCollegeColor.Size = new System.Drawing.Size(121, 21);
            this.comboCollegeColor.TabIndex = 10;
            this.comboCollegeColor.SelectedIndexChanged += new System.EventHandler(this.comboCollegeColor_SelectedIndexChanged);
            // 
            // buttonSaveCollege
            // 
            this.buttonSaveCollege.Location = new System.Drawing.Point(714, 397);
            this.buttonSaveCollege.Name = "buttonSaveCollege";
            this.buttonSaveCollege.Size = new System.Drawing.Size(69, 23);
            this.buttonSaveCollege.TabIndex = 9;
            this.buttonSaveCollege.Text = "Save";
            this.buttonSaveCollege.UseVisualStyleBackColor = true;
            this.buttonSaveCollege.Click += new System.EventHandler(this.buttonSaveCollege_Click);
            // 
            // buttonPrintCollege
            // 
            this.buttonPrintCollege.Location = new System.Drawing.Point(789, 397);
            this.buttonPrintCollege.Name = "buttonPrintCollege";
            this.buttonPrintCollege.Size = new System.Drawing.Size(69, 23);
            this.buttonPrintCollege.TabIndex = 8;
            this.buttonPrintCollege.Text = "Print";
            this.buttonPrintCollege.UseVisualStyleBackColor = true;
            this.buttonPrintCollege.Click += new System.EventHandler(this.buttonPrintCollege_Click);
            // 
            // labelCollegeType
            // 
            this.labelCollegeType.AutoSize = true;
            this.labelCollegeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCollegeType.Location = new System.Drawing.Point(6, 399);
            this.labelCollegeType.Name = "labelCollegeType";
            this.labelCollegeType.Size = new System.Drawing.Size(40, 16);
            this.labelCollegeType.TabIndex = 3;
            this.labelCollegeType.Text = "Type";
            // 
            // comboCollegeType
            // 
            this.comboCollegeType.FormattingEnabled = true;
            this.comboCollegeType.Location = new System.Drawing.Point(52, 397);
            this.comboCollegeType.Name = "comboCollegeType";
            this.comboCollegeType.Size = new System.Drawing.Size(121, 21);
            this.comboCollegeType.TabIndex = 2;
            this.comboCollegeType.SelectedIndexChanged += new System.EventHandler(this.comboCollegeChart_SelectedIndexChanged);
            // 
            // chartCollege
            // 
            this.chartCollege.Location = new System.Drawing.Point(0, 0);
            this.chartCollege.Name = "chartCollege";
            this.chartCollege.Size = new System.Drawing.Size(863, 396);
            this.chartCollege.TabIndex = 0;
            this.chartCollege.Text = "College";
            // 
            // tabACT
            // 
            this.tabACT.Controls.Add(this.buttonSaveACT);
            this.tabACT.Controls.Add(this.labelACTColor);
            this.tabACT.Controls.Add(this.comboACTColor);
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
            // buttonSaveACT
            // 
            this.buttonSaveACT.Location = new System.Drawing.Point(714, 397);
            this.buttonSaveACT.Name = "buttonSaveACT";
            this.buttonSaveACT.Size = new System.Drawing.Size(69, 23);
            this.buttonSaveACT.TabIndex = 14;
            this.buttonSaveACT.Text = "Save";
            this.buttonSaveACT.UseVisualStyleBackColor = true;
            this.buttonSaveACT.Click += new System.EventHandler(this.buttonSaveACT_Click);
            // 
            // labelACTColor
            // 
            this.labelACTColor.AutoSize = true;
            this.labelACTColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelACTColor.Location = new System.Drawing.Point(179, 399);
            this.labelACTColor.Name = "labelACTColor";
            this.labelACTColor.Size = new System.Drawing.Size(40, 16);
            this.labelACTColor.TabIndex = 13;
            this.labelACTColor.Text = "Color";
            // 
            // comboACTColor
            // 
            this.comboACTColor.FormattingEnabled = true;
            this.comboACTColor.Location = new System.Drawing.Point(225, 397);
            this.comboACTColor.Name = "comboACTColor";
            this.comboACTColor.Size = new System.Drawing.Size(121, 21);
            this.comboACTColor.TabIndex = 12;
            this.comboACTColor.SelectedIndexChanged += new System.EventHandler(this.comboACTColor_SelectedIndexChanged);
            // 
            // buttonPrintACT
            // 
            this.buttonPrintACT.Location = new System.Drawing.Point(789, 397);
            this.buttonPrintACT.Name = "buttonPrintACT";
            this.buttonPrintACT.Size = new System.Drawing.Size(69, 23);
            this.buttonPrintACT.TabIndex = 7;
            this.buttonPrintACT.Text = "Print";
            this.buttonPrintACT.UseVisualStyleBackColor = true;
            this.buttonPrintACT.Click += new System.EventHandler(this.buttonPrintACT_Click);
            // 
            // labelACTType
            // 
            this.labelACTType.AutoSize = true;
            this.labelACTType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelACTType.Location = new System.Drawing.Point(6, 399);
            this.labelACTType.Name = "labelACTType";
            this.labelACTType.Size = new System.Drawing.Size(40, 16);
            this.labelACTType.TabIndex = 6;
            this.labelACTType.Text = "Type";
            // 
            // comboACTType
            // 
            this.comboACTType.FormattingEnabled = true;
            this.comboACTType.Location = new System.Drawing.Point(52, 397);
            this.comboACTType.Name = "comboACTType";
            this.comboACTType.Size = new System.Drawing.Size(121, 21);
            this.comboACTType.TabIndex = 5;
            this.comboACTType.SelectedIndexChanged += new System.EventHandler(this.comboACTType_SelectedIndexChanged);
            // 
            // chartACT
            // 
            this.chartACT.Location = new System.Drawing.Point(0, 0);
            this.chartACT.Name = "chartACT";
            this.chartACT.Size = new System.Drawing.Size(863, 396);
            this.chartACT.TabIndex = 4;
            this.chartACT.Text = "ACT Scores";
            // 
            // tabCustom
            // 
            this.tabCustom.Controls.Add(this.chartCustom);
            this.tabCustom.Controls.Add(this.labelYAxis);
            this.tabCustom.Controls.Add(this.comboYAxis);
            this.tabCustom.Controls.Add(this.labelXAxis);
            this.tabCustom.Controls.Add(this.comboXAxis);
            this.tabCustom.Controls.Add(this.buttonSaveCustom);
            this.tabCustom.Controls.Add(this.labelCustomColor);
            this.tabCustom.Controls.Add(this.comboCustomColor);
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
            // chartCustom
            // 
            this.chartCustom.Location = new System.Drawing.Point(0, 0);
            this.chartCustom.Name = "chartCustom";
            this.chartCustom.Size = new System.Drawing.Size(863, 396);
            this.chartCustom.TabIndex = 23;
            this.chartCustom.Text = "College";
            // 
            // labelYAxis
            // 
            this.labelYAxis.AutoSize = true;
            this.labelYAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYAxis.Location = new System.Drawing.Point(530, 399);
            this.labelYAxis.Name = "labelYAxis";
            this.labelYAxis.Size = new System.Drawing.Size(46, 16);
            this.labelYAxis.TabIndex = 22;
            this.labelYAxis.Text = "Y-Axis";
            // 
            // comboYAxis
            // 
            this.comboYAxis.FormattingEnabled = true;
            this.comboYAxis.Location = new System.Drawing.Point(581, 398);
            this.comboYAxis.Name = "comboYAxis";
            this.comboYAxis.Size = new System.Drawing.Size(121, 21);
            this.comboYAxis.TabIndex = 21;
            this.comboYAxis.SelectedIndexChanged += new System.EventHandler(this.comboYAxis_SelectedIndexChanged);
            // 
            // labelXAxis
            // 
            this.labelXAxis.AutoSize = true;
            this.labelXAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXAxis.Location = new System.Drawing.Point(352, 399);
            this.labelXAxis.Name = "labelXAxis";
            this.labelXAxis.Size = new System.Drawing.Size(45, 16);
            this.labelXAxis.TabIndex = 20;
            this.labelXAxis.Text = "X-Axis";
            // 
            // comboXAxis
            // 
            this.comboXAxis.FormattingEnabled = true;
            this.comboXAxis.Location = new System.Drawing.Point(403, 397);
            this.comboXAxis.Name = "comboXAxis";
            this.comboXAxis.Size = new System.Drawing.Size(121, 21);
            this.comboXAxis.TabIndex = 19;
            this.comboXAxis.SelectedIndexChanged += new System.EventHandler(this.comboXAxis_SelectedIndexChanged);
            // 
            // buttonSaveCustom
            // 
            this.buttonSaveCustom.Location = new System.Drawing.Point(714, 397);
            this.buttonSaveCustom.Name = "buttonSaveCustom";
            this.buttonSaveCustom.Size = new System.Drawing.Size(69, 23);
            this.buttonSaveCustom.TabIndex = 18;
            this.buttonSaveCustom.Text = "Save";
            this.buttonSaveCustom.UseVisualStyleBackColor = true;
            this.buttonSaveCustom.Click += new System.EventHandler(this.buttonSaveCustom_Click);
            // 
            // labelCustomColor
            // 
            this.labelCustomColor.AutoSize = true;
            this.labelCustomColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomColor.Location = new System.Drawing.Point(179, 399);
            this.labelCustomColor.Name = "labelCustomColor";
            this.labelCustomColor.Size = new System.Drawing.Size(40, 16);
            this.labelCustomColor.TabIndex = 17;
            this.labelCustomColor.Text = "Color";
            // 
            // comboCustomColor
            // 
            this.comboCustomColor.FormattingEnabled = true;
            this.comboCustomColor.Location = new System.Drawing.Point(225, 397);
            this.comboCustomColor.Name = "comboCustomColor";
            this.comboCustomColor.Size = new System.Drawing.Size(121, 21);
            this.comboCustomColor.TabIndex = 16;
            this.comboCustomColor.SelectedIndexChanged += new System.EventHandler(this.comboCustomColor_SelectedIndexChanged);
            // 
            // buttonPrintCustom
            // 
            this.buttonPrintCustom.Location = new System.Drawing.Point(789, 397);
            this.buttonPrintCustom.Name = "buttonPrintCustom";
            this.buttonPrintCustom.Size = new System.Drawing.Size(69, 23);
            this.buttonPrintCustom.TabIndex = 15;
            this.buttonPrintCustom.Text = "Print";
            this.buttonPrintCustom.UseVisualStyleBackColor = true;
            this.buttonPrintCustom.Click += new System.EventHandler(this.buttonPrintCustom_Click);
            // 
            // labelCustomType
            // 
            this.labelCustomType.AutoSize = true;
            this.labelCustomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomType.Location = new System.Drawing.Point(6, 399);
            this.labelCustomType.Name = "labelCustomType";
            this.labelCustomType.Size = new System.Drawing.Size(40, 16);
            this.labelCustomType.TabIndex = 10;
            this.labelCustomType.Text = "Type";
            // 
            // comboCustomType
            // 
            this.comboCustomType.FormattingEnabled = true;
            this.comboCustomType.Location = new System.Drawing.Point(52, 397);
            this.comboCustomType.Name = "comboCustomType";
            this.comboCustomType.Size = new System.Drawing.Size(121, 21);
            this.comboCustomType.TabIndex = 9;
            this.comboCustomType.SelectedIndexChanged += new System.EventHandler(this.comboCustomType_SelectedIndexChanged);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(863, 396);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "ACT Scores";
            // 
            // printStatisticDialog
            // 
            this.printStatisticDialog.UseEXDialog = true;
            // 
            // printStatistic
            // 
            this.printStatistic.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printStatistic_PrintPage);
            // 
            // progressBarFake
            // 
            this.progressBarFake.Location = new System.Drawing.Point(683, 371);
            this.progressBarFake.Name = "progressBarFake";
            this.progressBarFake.Size = new System.Drawing.Size(156, 23);
            this.progressBarFake.Step = 1;
            this.progressBarFake.TabIndex = 9;
            this.progressBarFake.Visible = false;
            // 
            // labelNameError
            // 
            this.labelNameError.AutoSize = true;
            this.labelNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameError.ForeColor = System.Drawing.Color.Red;
            this.labelNameError.Location = new System.Drawing.Point(532, 187);
            this.labelNameError.Name = "labelNameError";
            this.labelNameError.Size = new System.Drawing.Size(33, 13);
            this.labelNameError.TabIndex = 6;
            this.labelNameError.Text = "error";
            this.labelNameError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNameError.Visible = false;
            // 
            // labelPasswordError
            // 
            this.labelPasswordError.AutoSize = true;
            this.labelPasswordError.BackColor = System.Drawing.Color.Transparent;
            this.labelPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordError.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordError.Location = new System.Drawing.Point(532, 242);
            this.labelPasswordError.Name = "labelPasswordError";
            this.labelPasswordError.Size = new System.Drawing.Size(33, 13);
            this.labelPasswordError.TabIndex = 7;
            this.labelPasswordError.Text = "error";
            this.labelPasswordError.Visible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.chartCustom)).EndInit();
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
        private System.Windows.Forms.Label labelName;
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
        private System.Windows.Forms.Label labelCustomType;
        private System.Windows.Forms.ComboBox comboCustomType;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonSaveCollege;
        private System.Windows.Forms.Label labelCollegeColor;
        private System.Windows.Forms.ComboBox comboCollegeColor;
        private System.Windows.Forms.Button buttonSaveACT;
        private System.Windows.Forms.Label labelACTColor;
        private System.Windows.Forms.ComboBox comboACTColor;
        private System.Windows.Forms.Button buttonSaveCustom;
        private System.Windows.Forms.Label labelCustomColor;
        private System.Windows.Forms.ComboBox comboCustomColor;
        private System.Windows.Forms.Button buttonPrintCustom;
        private System.Windows.Forms.Label labelXAxis;
        private System.Windows.Forms.ComboBox comboXAxis;
        private System.Windows.Forms.Label labelYAxis;
        private System.Windows.Forms.ComboBox comboYAxis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCustom;
        private System.Windows.Forms.SaveFileDialog saveStatisticDialog;
        private System.Windows.Forms.PrintDialog printStatisticDialog;
        private System.Drawing.Printing.PrintDocument printStatistic;
        private System.Windows.Forms.Button buttonResetApplications;
        private System.Windows.Forms.Button buttonResetEvents;
        private System.Windows.Forms.ProgressBar progressBarFake;
        private System.Windows.Forms.Label labelPasswordError;
        private System.Windows.Forms.Label labelNameError;
    }
}

