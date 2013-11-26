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
            this.tabHome = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tabApplications = new System.Windows.Forms.TabPage();
            this.btnEdit = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.applicationList = new System.Windows.Forms.ListBox();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.tabStatistics = new System.Windows.Forms.TabPage();
            this.tabStats = new System.Windows.Forms.TabControl();
            this.tabDefault = new System.Windows.Forms.TabPage();
            this.tabCustom = new System.Windows.Forms.TabPage();
            this.tabSystems.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabApplications.SuspendLayout();
            this.tabStatistics.SuspendLayout();
            this.tabStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSystems
            // 
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
            // tabHome
            // 
            this.tabHome.Controls.Add(this.label1);
            this.tabHome.Controls.Add(this.labelPassword);
            this.tabHome.Controls.Add(this.labelEmail);
            this.tabHome.Controls.Add(this.textBox2);
            this.tabHome.Controls.Add(this.textBox1);
            this.tabHome.Controls.Add(this.btnLogin);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(884, 428);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 40);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(376, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(376, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 1;
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
            // tabApplications
            // 
            this.tabApplications.Controls.Add(this.btnEdit);
            this.tabApplications.Controls.Add(this.buttonSearch);
            this.tabApplications.Controls.Add(this.applicationList);
            this.tabApplications.Location = new System.Drawing.Point(4, 22);
            this.tabApplications.Name = "tabApplications";
            this.tabApplications.Padding = new System.Windows.Forms.Padding(3);
            this.tabApplications.Size = new System.Drawing.Size(884, 428);
            this.tabApplications.TabIndex = 1;
            this.tabApplications.Text = "Applications";
            this.tabApplications.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(750, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
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
            // applicationList
            // 
            this.applicationList.FormattingEnabled = true;
            this.applicationList.Location = new System.Drawing.Point(3, 6);
            this.applicationList.Name = "applicationList";
            this.applicationList.Size = new System.Drawing.Size(741, 420);
            this.applicationList.Sorted = true;
            this.applicationList.TabIndex = 0;
            // 
            // tabEvents
            // 
            this.tabEvents.Location = new System.Drawing.Point(4, 22);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabEvents.Size = new System.Drawing.Size(884, 428);
            this.tabEvents.TabIndex = 2;
            this.tabEvents.Text = "Events";
            this.tabEvents.UseVisualStyleBackColor = true;
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
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabApplications.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox applicationList;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
    }
}

