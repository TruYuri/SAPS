using System;
using System.Windows.Forms;

namespace SAPS
{
    partial class ApplicationEditor
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
            this.labelMName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelLName = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelGPA = new System.Windows.Forms.Label();
            this.labelSubDate = new System.Windows.Forms.Label();
            this.labelMinor = new System.Windows.Forms.Label();
            this.labelMajor = new System.Windows.Forms.Label();
            this.labelComments = new System.Windows.Forms.Label();
            this.labelGraduateVotes = new System.Windows.Forms.Label();
            this.textMiddleName = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textDescriptionComments = new System.Windows.Forms.TextBox();
            this.listVotes = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listMajors = new System.Windows.Forms.ListBox();
            this.listMinors = new System.Windows.Forms.ListBox();
            this.buttonAddMajor = new System.Windows.Forms.Button();
            this.buttonRemoveMajor = new System.Windows.Forms.Button();
            this.buttonRemoveMinor = new System.Windows.Forms.Button();
            this.buttonAddMinor = new System.Windows.Forms.Button();
            this.comboVote = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.timeDOB = new System.Windows.Forms.DateTimePicker();
            this.timeSubmission = new System.Windows.Forms.DateTimePicker();
            this.textSocial = new System.Windows.Forms.TextBox();
            this.labelSocial = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textState = new System.Windows.Forms.TextBox();
            this.textZip = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.labelZip = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textRank = new System.Windows.Forms.MaskedTextBox();
            this.textGPA = new System.Windows.Forms.MaskedTextBox();
            this.textScore = new System.Windows.Forms.MaskedTextBox();
            this.printApplication = new System.Drawing.Printing.PrintDocument();
            this.printApplicationDialog = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // labelMName
            // 
            this.labelMName.AutoSize = true;
            this.labelMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMName.Location = new System.Drawing.Point(119, 48);
            this.labelMName.Name = "labelMName";
            this.labelMName.Size = new System.Drawing.Size(82, 15);
            this.labelMName.TabIndex = 5;
            this.labelMName.Text = "Middle Name";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.Location = new System.Drawing.Point(12, 48);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(67, 15);
            this.labelFName.TabIndex = 6;
            this.labelFName.Text = "First Name";
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLName.Location = new System.Drawing.Point(226, 48);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(67, 15);
            this.labelLName.TabIndex = 7;
            this.labelLName.Text = "Last Name";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(12, 66);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(104, 20);
            this.textFirstName.TabIndex = 8;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DisplayMember = "Male;Female";
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(12, 107);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(101, 21);
            this.comboBoxGender.TabIndex = 11;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(12, 89);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(48, 15);
            this.labelGender.TabIndex = 12;
            this.labelGender.Text = "Gender";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.Location = new System.Drawing.Point(119, 89);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(74, 15);
            this.labelDOB.TabIndex = 13;
            this.labelDOB.Text = "Date of Birth";
            // 
            // labelGPA
            // 
            this.labelGPA.AutoSize = true;
            this.labelGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGPA.Location = new System.Drawing.Point(12, 251);
            this.labelGPA.Name = "labelGPA";
            this.labelGPA.Size = new System.Drawing.Size(31, 15);
            this.labelGPA.TabIndex = 16;
            this.labelGPA.Text = "GPA";
            // 
            // labelSubDate
            // 
            this.labelSubDate.AutoSize = true;
            this.labelSubDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubDate.Location = new System.Drawing.Point(12, 12);
            this.labelSubDate.Name = "labelSubDate";
            this.labelSubDate.Size = new System.Drawing.Size(101, 15);
            this.labelSubDate.TabIndex = 18;
            this.labelSubDate.Text = "Submission Date";
            // 
            // labelMinor
            // 
            this.labelMinor.AutoSize = true;
            this.labelMinor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinor.Location = new System.Drawing.Point(119, 292);
            this.labelMinor.Name = "labelMinor";
            this.labelMinor.Size = new System.Drawing.Size(45, 15);
            this.labelMinor.TabIndex = 20;
            this.labelMinor.Text = "Minors";
            // 
            // labelMajor
            // 
            this.labelMajor.AutoSize = true;
            this.labelMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMajor.Location = new System.Drawing.Point(12, 292);
            this.labelMajor.Name = "labelMajor";
            this.labelMajor.Size = new System.Drawing.Size(45, 15);
            this.labelMajor.TabIndex = 21;
            this.labelMajor.Text = "Majors";
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComments.Location = new System.Drawing.Point(134, 437);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(67, 15);
            this.labelComments.TabIndex = 22;
            this.labelComments.Text = "Comments";
            // 
            // labelGraduateVotes
            // 
            this.labelGraduateVotes.AutoSize = true;
            this.labelGraduateVotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGraduateVotes.Location = new System.Drawing.Point(226, 292);
            this.labelGraduateVotes.Name = "labelGraduateVotes";
            this.labelGraduateVotes.Size = new System.Drawing.Size(37, 15);
            this.labelGraduateVotes.TabIndex = 24;
            this.labelGraduateVotes.Text = "Votes";
            // 
            // textMiddleName
            // 
            this.textMiddleName.Location = new System.Drawing.Point(122, 66);
            this.textMiddleName.Name = "textMiddleName";
            this.textMiddleName.Size = new System.Drawing.Size(101, 20);
            this.textMiddleName.TabIndex = 25;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(229, 66);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(101, 20);
            this.textLastName.TabIndex = 26;
            // 
            // textDescriptionComments
            // 
            this.textDescriptionComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDescriptionComments.Location = new System.Drawing.Point(12, 455);
            this.textDescriptionComments.Multiline = true;
            this.textDescriptionComments.Name = "textDescriptionComments";
            this.textDescriptionComments.Size = new System.Drawing.Size(318, 134);
            this.textDescriptionComments.TabIndex = 33;
            // 
            // listVotes
            // 
            this.listVotes.FormattingEnabled = true;
            this.listVotes.Location = new System.Drawing.Point(229, 310);
            this.listVotes.Name = "listVotes";
            this.listVotes.Size = new System.Drawing.Size(101, 95);
            this.listVotes.TabIndex = 36;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(122, 595);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(101, 23);
            this.buttonRemove.TabIndex = 39;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // listMajors
            // 
            this.listMajors.FormattingEnabled = true;
            this.listMajors.Location = new System.Drawing.Point(12, 310);
            this.listMajors.Name = "listMajors";
            this.listMajors.Size = new System.Drawing.Size(101, 95);
            this.listMajors.TabIndex = 41;
            // 
            // listMinors
            // 
            this.listMinors.FormattingEnabled = true;
            this.listMinors.Location = new System.Drawing.Point(122, 310);
            this.listMinors.Name = "listMinors";
            this.listMinors.Size = new System.Drawing.Size(101, 95);
            this.listMinors.TabIndex = 42;
            // 
            // buttonAddMajor
            // 
            this.buttonAddMajor.Location = new System.Drawing.Point(12, 411);
            this.buttonAddMajor.Name = "buttonAddMajor";
            this.buttonAddMajor.Size = new System.Drawing.Size(48, 23);
            this.buttonAddMajor.TabIndex = 43;
            this.buttonAddMajor.Text = "+";
            this.buttonAddMajor.UseVisualStyleBackColor = true;
            this.buttonAddMajor.Click += new System.EventHandler(this.buttonAddMajor_Click);
            // 
            // buttonRemoveMajor
            // 
            this.buttonRemoveMajor.Location = new System.Drawing.Point(66, 411);
            this.buttonRemoveMajor.Name = "buttonRemoveMajor";
            this.buttonRemoveMajor.Size = new System.Drawing.Size(47, 23);
            this.buttonRemoveMajor.TabIndex = 44;
            this.buttonRemoveMajor.Text = "-";
            this.buttonRemoveMajor.UseVisualStyleBackColor = true;
            this.buttonRemoveMajor.Click += new System.EventHandler(this.buttonRemoveMajor_Click);
            // 
            // buttonRemoveMinor
            // 
            this.buttonRemoveMinor.Location = new System.Drawing.Point(176, 411);
            this.buttonRemoveMinor.Name = "buttonRemoveMinor";
            this.buttonRemoveMinor.Size = new System.Drawing.Size(47, 23);
            this.buttonRemoveMinor.TabIndex = 46;
            this.buttonRemoveMinor.Text = "-";
            this.buttonRemoveMinor.UseVisualStyleBackColor = true;
            this.buttonRemoveMinor.Click += new System.EventHandler(this.buttonRemoveMinor_Click);
            // 
            // buttonAddMinor
            // 
            this.buttonAddMinor.Location = new System.Drawing.Point(122, 411);
            this.buttonAddMinor.Name = "buttonAddMinor";
            this.buttonAddMinor.Size = new System.Drawing.Size(48, 23);
            this.buttonAddMinor.TabIndex = 45;
            this.buttonAddMinor.Text = "+";
            this.buttonAddMinor.UseVisualStyleBackColor = true;
            this.buttonAddMinor.Click += new System.EventHandler(this.buttonAddMinor_Click);
            // 
            // comboVote
            // 
            this.comboVote.FormattingEnabled = true;
            this.comboVote.Location = new System.Drawing.Point(231, 413);
            this.comboVote.Name = "comboVote";
            this.comboVote.Size = new System.Drawing.Size(101, 21);
            this.comboVote.TabIndex = 47;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(229, 595);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 23);
            this.buttonCancel.TabIndex = 48;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 595);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(101, 23);
            this.buttonSubmit.TabIndex = 49;
            this.buttonSubmit.Text = "Accept";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // timeDOB
            // 
            this.timeDOB.CustomFormat = "MM : dd : yyyy";
            this.timeDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeDOB.Location = new System.Drawing.Point(122, 107);
            this.timeDOB.Name = "timeDOB";
            this.timeDOB.Size = new System.Drawing.Size(101, 20);
            this.timeDOB.TabIndex = 50;
            // 
            // timeSubmission
            // 
            this.timeSubmission.Enabled = false;
            this.timeSubmission.Location = new System.Drawing.Point(122, 12);
            this.timeSubmission.Name = "timeSubmission";
            this.timeSubmission.Size = new System.Drawing.Size(208, 20);
            this.timeSubmission.TabIndex = 51;
            // 
            // textSocial
            // 
            this.textSocial.Location = new System.Drawing.Point(229, 107);
            this.textSocial.Name = "textSocial";
            this.textSocial.Size = new System.Drawing.Size(101, 20);
            this.textSocial.TabIndex = 52;
            // 
            // labelSocial
            // 
            this.labelSocial.AutoSize = true;
            this.labelSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSocial.Location = new System.Drawing.Point(226, 89);
            this.labelSocial.Name = "labelSocial";
            this.labelSocial.Size = new System.Drawing.Size(97, 15);
            this.labelSocial.TabIndex = 53;
            this.labelSocial.Text = "Social Security #";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(12, 149);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(318, 20);
            this.textAddress.TabIndex = 54;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(12, 131);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(86, 15);
            this.labelAddress.TabIndex = 55;
            this.labelAddress.Text = "Street Address";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(12, 172);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(26, 15);
            this.labelCity.TabIndex = 56;
            this.labelCity.Text = "City";
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(12, 188);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(101, 20);
            this.textCity.TabIndex = 57;
            // 
            // textState
            // 
            this.textState.Location = new System.Drawing.Point(122, 188);
            this.textState.Name = "textState";
            this.textState.Size = new System.Drawing.Size(101, 20);
            this.textState.TabIndex = 58;
            // 
            // textZip
            // 
            this.textZip.Location = new System.Drawing.Point(229, 188);
            this.textZip.Name = "textZip";
            this.textZip.Size = new System.Drawing.Size(101, 20);
            this.textZip.TabIndex = 59;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(119, 172);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(35, 15);
            this.labelState.TabIndex = 60;
            this.labelState.Text = "State";
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZip.Location = new System.Drawing.Point(226, 172);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(56, 15);
            this.labelZip.TabIndex = 61;
            this.labelZip.Text = "Zip Code";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(12, 211);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(91, 15);
            this.labelPhone.TabIndex = 62;
            this.labelPhone.Text = "Phone Number";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(12, 229);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(318, 20);
            this.textPhone.TabIndex = 63;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(119, 253);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(89, 15);
            this.labelScore.TabIndex = 64;
            this.labelScore.Text = "ACT/SAT Score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 67;
            this.label1.Text = "Class Rank (%)";
            // 
            // textRank
            // 
            this.textRank.BeepOnError = true;
            this.textRank.Location = new System.Drawing.Point(229, 269);
            this.textRank.Mask = "00%";
            this.textRank.Name = "textRank";
            this.textRank.Size = new System.Drawing.Size(101, 20);
            this.textRank.TabIndex = 68;
            // 
            // textGPA
            // 
            this.textGPA.Location = new System.Drawing.Point(12, 269);
            this.textGPA.Name = "textGPA";
            this.textGPA.Size = new System.Drawing.Size(101, 20);
            this.textGPA.TabIndex = 69;
            this.textGPA.Validating += new System.ComponentModel.CancelEventHandler(this.textGPA_Validating);
            // 
            // textScore
            // 
            this.textScore.Location = new System.Drawing.Point(122, 269);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(101, 20);
            this.textScore.TabIndex = 70;
            this.textScore.Validating += new System.ComponentModel.CancelEventHandler(this.textScore_Validating);
            // 
            // printApplication
            // 
            this.printApplication.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printApplicationDialog
            // 
            this.printApplicationDialog.UseEXDialog = true;
            // 
            // ApplicationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 626);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.textGPA);
            this.Controls.Add(this.textRank);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelZip);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textZip);
            this.Controls.Add(this.textState);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.labelSocial);
            this.Controls.Add(this.textSocial);
            this.Controls.Add(this.timeSubmission);
            this.Controls.Add(this.timeDOB);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboVote);
            this.Controls.Add(this.buttonRemoveMinor);
            this.Controls.Add(this.buttonAddMinor);
            this.Controls.Add(this.buttonRemoveMajor);
            this.Controls.Add(this.buttonAddMajor);
            this.Controls.Add(this.listMinors);
            this.Controls.Add(this.listMajors);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listVotes);
            this.Controls.Add(this.textDescriptionComments);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textMiddleName);
            this.Controls.Add(this.labelGraduateVotes);
            this.Controls.Add(this.labelComments);
            this.Controls.Add(this.labelMajor);
            this.Controls.Add(this.labelMinor);
            this.Controls.Add(this.labelSubDate);
            this.Controls.Add(this.labelGPA);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.labelMName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ApplicationEditor";
            this.Text = "Application Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMName;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelGPA;
        private System.Windows.Forms.Label labelSubDate;
        private System.Windows.Forms.Label labelMinor;
        private System.Windows.Forms.Label labelMajor;
        private System.Windows.Forms.Label labelComments;
        private System.Windows.Forms.Label labelGraduateVotes;
        private System.Windows.Forms.TextBox textMiddleName;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textDescriptionComments;
        private System.Windows.Forms.ListBox listVotes;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ListBox listMajors;
        private System.Windows.Forms.ListBox listMinors;
        private System.Windows.Forms.Button buttonAddMajor;
        private System.Windows.Forms.Button buttonRemoveMajor;
        private System.Windows.Forms.Button buttonRemoveMinor;
        private System.Windows.Forms.Button buttonAddMinor;
        private System.Windows.Forms.ComboBox comboVote;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSubmit;
        private DateTimePicker timeDOB;
        private DateTimePicker timeSubmission;
        private TextBox textSocial;
        private Label labelSocial;
        private TextBox textAddress;
        private Label labelAddress;
        private Label labelCity;
        private TextBox textCity;
        private TextBox textState;
        private TextBox textZip;
        private Label labelState;
        private Label labelZip;
        private Label labelPhone;
        private TextBox textPhone;
        private Label labelScore;
        private Label label1;
        private MaskedTextBox textRank;
        private MaskedTextBox textGPA;
        private MaskedTextBox textScore;
        private System.Drawing.Printing.PrintDocument printApplication;
        private PrintDialog printApplicationDialog;
    }
}