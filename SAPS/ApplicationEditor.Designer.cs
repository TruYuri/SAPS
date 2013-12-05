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
            this.textGPA = new System.Windows.Forms.TextBox();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textState = new System.Windows.Forms.TextBox();
            this.textZip = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.labelZip = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.textScore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelMName
            // 
            this.labelMName.AutoSize = true;
            this.labelMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMName.Location = new System.Drawing.Point(119, 56);
            this.labelMName.Name = "labelMName";
            this.labelMName.Size = new System.Drawing.Size(82, 15);
            this.labelMName.TabIndex = 5;
            this.labelMName.Text = "Middle Name";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFName.Location = new System.Drawing.Point(12, 56);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(67, 15);
            this.labelFName.TabIndex = 6;
            this.labelFName.Text = "First Name";
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLName.Location = new System.Drawing.Point(226, 56);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(67, 15);
            this.labelLName.TabIndex = 7;
            this.labelLName.Text = "Last Name";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(12, 74);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(104, 20);
            this.textFirstName.TabIndex = 8;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DisplayMember = "Male;Female";
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Location = new System.Drawing.Point(12, 115);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(101, 21);
            this.comboBoxGender.TabIndex = 11;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(12, 97);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(48, 15);
            this.labelGender.TabIndex = 12;
            this.labelGender.Text = "Gender";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.Location = new System.Drawing.Point(119, 97);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(74, 15);
            this.labelDOB.TabIndex = 13;
            this.labelDOB.Text = "Date of Birth";
            // 
            // labelGPA
            // 
            this.labelGPA.AutoSize = true;
            this.labelGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGPA.Location = new System.Drawing.Point(12, 259);
            this.labelGPA.Name = "labelGPA";
            this.labelGPA.Size = new System.Drawing.Size(31, 15);
            this.labelGPA.TabIndex = 16;
            this.labelGPA.Text = "GPA";
            // 
            // textGPA
            // 
            this.textGPA.Location = new System.Drawing.Point(12, 277);
            this.textGPA.Name = "textGPA";
            this.textGPA.Size = new System.Drawing.Size(101, 20);
            this.textGPA.TabIndex = 17;
            // 
            // labelSubDate
            // 
            this.labelSubDate.AutoSize = true;
            this.labelSubDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubDate.Location = new System.Drawing.Point(12, 20);
            this.labelSubDate.Name = "labelSubDate";
            this.labelSubDate.Size = new System.Drawing.Size(101, 15);
            this.labelSubDate.TabIndex = 18;
            this.labelSubDate.Text = "Submission Date";
            // 
            // labelMinor
            // 
            this.labelMinor.AutoSize = true;
            this.labelMinor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinor.Location = new System.Drawing.Point(119, 300);
            this.labelMinor.Name = "labelMinor";
            this.labelMinor.Size = new System.Drawing.Size(45, 15);
            this.labelMinor.TabIndex = 20;
            this.labelMinor.Text = "Minors";
            // 
            // labelMajor
            // 
            this.labelMajor.AutoSize = true;
            this.labelMajor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMajor.Location = new System.Drawing.Point(12, 300);
            this.labelMajor.Name = "labelMajor";
            this.labelMajor.Size = new System.Drawing.Size(45, 15);
            this.labelMajor.TabIndex = 21;
            this.labelMajor.Text = "Majors";
            // 
            // labelComments
            // 
            this.labelComments.AutoSize = true;
            this.labelComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComments.Location = new System.Drawing.Point(134, 445);
            this.labelComments.Name = "labelComments";
            this.labelComments.Size = new System.Drawing.Size(67, 15);
            this.labelComments.TabIndex = 22;
            this.labelComments.Text = "Comments";
            // 
            // labelGraduateVotes
            // 
            this.labelGraduateVotes.AutoSize = true;
            this.labelGraduateVotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGraduateVotes.Location = new System.Drawing.Point(226, 300);
            this.labelGraduateVotes.Name = "labelGraduateVotes";
            this.labelGraduateVotes.Size = new System.Drawing.Size(37, 15);
            this.labelGraduateVotes.TabIndex = 24;
            this.labelGraduateVotes.Text = "Votes";
            // 
            // textMiddleName
            // 
            this.textMiddleName.Location = new System.Drawing.Point(122, 74);
            this.textMiddleName.Name = "textMiddleName";
            this.textMiddleName.Size = new System.Drawing.Size(101, 20);
            this.textMiddleName.TabIndex = 25;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(229, 74);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(101, 20);
            this.textLastName.TabIndex = 26;
            // 
            // textDescriptionComments
            // 
            this.textDescriptionComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDescriptionComments.Location = new System.Drawing.Point(12, 463);
            this.textDescriptionComments.Multiline = true;
            this.textDescriptionComments.Name = "textDescriptionComments";
            this.textDescriptionComments.Size = new System.Drawing.Size(318, 134);
            this.textDescriptionComments.TabIndex = 33;
            // 
            // listVotes
            // 
            this.listVotes.FormattingEnabled = true;
            this.listVotes.Location = new System.Drawing.Point(229, 318);
            this.listVotes.Name = "listVotes";
            this.listVotes.Size = new System.Drawing.Size(101, 95);
            this.listVotes.TabIndex = 36;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(122, 603);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(101, 23);
            this.buttonRemove.TabIndex = 39;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // listMajors
            // 
            this.listMajors.FormattingEnabled = true;
            this.listMajors.Location = new System.Drawing.Point(12, 318);
            this.listMajors.Name = "listMajors";
            this.listMajors.Size = new System.Drawing.Size(101, 95);
            this.listMajors.TabIndex = 41;
            // 
            // listMinors
            // 
            this.listMinors.FormattingEnabled = true;
            this.listMinors.Location = new System.Drawing.Point(122, 318);
            this.listMinors.Name = "listMinors";
            this.listMinors.Size = new System.Drawing.Size(101, 95);
            this.listMinors.TabIndex = 42;
            // 
            // buttonAddMajor
            // 
            this.buttonAddMajor.Location = new System.Drawing.Point(12, 419);
            this.buttonAddMajor.Name = "buttonAddMajor";
            this.buttonAddMajor.Size = new System.Drawing.Size(48, 23);
            this.buttonAddMajor.TabIndex = 43;
            this.buttonAddMajor.Text = "+";
            this.buttonAddMajor.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveMajor
            // 
            this.buttonRemoveMajor.Location = new System.Drawing.Point(66, 419);
            this.buttonRemoveMajor.Name = "buttonRemoveMajor";
            this.buttonRemoveMajor.Size = new System.Drawing.Size(47, 23);
            this.buttonRemoveMajor.TabIndex = 44;
            this.buttonRemoveMajor.Text = "-";
            this.buttonRemoveMajor.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveMinor
            // 
            this.buttonRemoveMinor.Location = new System.Drawing.Point(176, 419);
            this.buttonRemoveMinor.Name = "buttonRemoveMinor";
            this.buttonRemoveMinor.Size = new System.Drawing.Size(47, 23);
            this.buttonRemoveMinor.TabIndex = 46;
            this.buttonRemoveMinor.Text = "-";
            this.buttonRemoveMinor.UseVisualStyleBackColor = true;
            // 
            // buttonAddMinor
            // 
            this.buttonAddMinor.Location = new System.Drawing.Point(122, 419);
            this.buttonAddMinor.Name = "buttonAddMinor";
            this.buttonAddMinor.Size = new System.Drawing.Size(48, 23);
            this.buttonAddMinor.TabIndex = 45;
            this.buttonAddMinor.Text = "+";
            this.buttonAddMinor.UseVisualStyleBackColor = true;
            // 
            // comboVote
            // 
            this.comboVote.FormattingEnabled = true;
            this.comboVote.Location = new System.Drawing.Point(231, 421);
            this.comboVote.Name = "comboVote";
            this.comboVote.Size = new System.Drawing.Size(101, 21);
            this.comboVote.TabIndex = 47;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(229, 603);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 23);
            this.buttonCancel.TabIndex = 48;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(12, 603);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(101, 23);
            this.buttonSubmit.TabIndex = 49;
            this.buttonSubmit.Text = "Accept";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // timeDOB
            // 
            this.timeDOB.CustomFormat = "MM : dd : yyyy";
            this.timeDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeDOB.Location = new System.Drawing.Point(122, 115);
            this.timeDOB.Name = "timeDOB";
            this.timeDOB.Size = new System.Drawing.Size(101, 20);
            this.timeDOB.TabIndex = 50;
            // 
            // timeSubmission
            // 
            this.timeSubmission.Enabled = false;
            this.timeSubmission.Location = new System.Drawing.Point(122, 20);
            this.timeSubmission.Name = "timeSubmission";
            this.timeSubmission.Size = new System.Drawing.Size(208, 20);
            this.timeSubmission.TabIndex = 51;
            // 
            // textSocial
            // 
            this.textSocial.Location = new System.Drawing.Point(229, 115);
            this.textSocial.Name = "textSocial";
            this.textSocial.Size = new System.Drawing.Size(101, 20);
            this.textSocial.TabIndex = 52;
            // 
            // labelSocial
            // 
            this.labelSocial.AutoSize = true;
            this.labelSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSocial.Location = new System.Drawing.Point(226, 97);
            this.labelSocial.Name = "labelSocial";
            this.labelSocial.Size = new System.Drawing.Size(97, 15);
            this.labelSocial.TabIndex = 53;
            this.labelSocial.Text = "Social Security #";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 20);
            this.textBox1.TabIndex = 54;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(12, 139);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(86, 15);
            this.labelAddress.TabIndex = 55;
            this.labelAddress.Text = "Street Address";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(12, 180);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(26, 15);
            this.labelCity.TabIndex = 56;
            this.labelCity.Text = "City";
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(12, 196);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(101, 20);
            this.textCity.TabIndex = 57;
            // 
            // textState
            // 
            this.textState.Location = new System.Drawing.Point(122, 196);
            this.textState.Name = "textState";
            this.textState.Size = new System.Drawing.Size(101, 20);
            this.textState.TabIndex = 58;
            // 
            // textZip
            // 
            this.textZip.Location = new System.Drawing.Point(229, 196);
            this.textZip.Name = "textZip";
            this.textZip.Size = new System.Drawing.Size(101, 20);
            this.textZip.TabIndex = 59;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(119, 180);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(35, 15);
            this.labelState.TabIndex = 60;
            this.labelState.Text = "State";
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZip.Location = new System.Drawing.Point(226, 180);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(56, 15);
            this.labelZip.TabIndex = 61;
            this.labelZip.Text = "Zip Code";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(12, 219);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(91, 15);
            this.labelPhone.TabIndex = 62;
            this.labelPhone.Text = "Phone Number";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 237);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(318, 20);
            this.textBox2.TabIndex = 63;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(119, 261);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(89, 15);
            this.labelScore.TabIndex = 64;
            this.labelScore.Text = "ACT/SAT Score";
            // 
            // textScore
            // 
            this.textScore.Location = new System.Drawing.Point(122, 277);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(101, 20);
            this.textScore.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 67;
            this.label1.Text = "Class Rank (%)";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(229, 277);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(101, 20);
            this.maskedTextBox1.TabIndex = 68;
            // 
            // ApplicationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 643);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelZip);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.textZip);
            this.Controls.Add(this.textState);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textBox1);
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
            this.Controls.Add(this.textGPA);
            this.Controls.Add(this.labelGPA);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.labelLName);
            this.Controls.Add(this.labelFName);
            this.Controls.Add(this.labelMName);
            this.Name = "ApplicationEditor";
            this.Text = "ApplicationEditor";
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
        private System.Windows.Forms.TextBox textGPA;
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
        private TextBox textBox1;
        private Label labelAddress;
        private Label labelCity;
        private TextBox textCity;
        private TextBox textState;
        private TextBox textZip;
        private Label labelState;
        private Label labelZip;
        private Label labelPhone;
        private TextBox textBox2;
        private Label labelScore;
        private TextBox textScore;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
    }
}