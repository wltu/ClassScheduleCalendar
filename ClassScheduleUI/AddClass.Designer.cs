namespace ClassScheduleUI
{
    partial class AddClass
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
            this.className = new System.Windows.Forms.TextBox();
            this.classNameText = new System.Windows.Forms.Label();
            this.discussionButton = new System.Windows.Forms.RadioButton();
            this.labButton = new System.Windows.Forms.RadioButton();
            this.lectureButton = new System.Windows.Forms.RadioButton();
            this.classTypeText = new System.Windows.Forms.Label();
            this.confirmClass = new System.Windows.Forms.Button();
            this.cancelClass = new System.Windows.Forms.Button();
            this.classDescriptionText = new System.Windows.Forms.Label();
            this.classDescription = new System.Windows.Forms.TextBox();
            this.classDays = new System.Windows.Forms.CheckedListBox();
            this.classDaysText = new System.Windows.Forms.Label();
            this.startDateText = new System.Windows.Forms.Label();
            this.endDateText = new System.Windows.Forms.Label();
            this.startTimeText = new System.Windows.Forms.Label();
            this.endTimeText = new System.Windows.Forms.Label();
            this.startMonth = new System.Windows.Forms.ComboBox();
            this.endMonth = new System.Windows.Forms.ComboBox();
            this.startDay = new System.Windows.Forms.ComboBox();
            this.endDay = new System.Windows.Forms.ComboBox();
            this.startYear = new System.Windows.Forms.ComboBox();
            this.endYear = new System.Windows.Forms.ComboBox();
            this.startHour = new System.Windows.Forms.ComboBox();
            this.endHour = new System.Windows.Forms.ComboBox();
            this.startMinute = new System.Windows.Forms.ComboBox();
            this.endMinute = new System.Windows.Forms.ComboBox();
            this.startMeridiem = new System.Windows.Forms.ComboBox();
            this.endMeridiem = new System.Windows.Forms.ComboBox();
            this.dateExampleText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // className
            // 
            this.className.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.className.Location = new System.Drawing.Point(193, 69);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(198, 22);
            this.className.TabIndex = 14;
            // 
            // classNameText
            // 
            this.classNameText.AutoSize = true;
            this.classNameText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classNameText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classNameText.Location = new System.Drawing.Point(41, 65);
            this.classNameText.Name = "classNameText";
            this.classNameText.Size = new System.Drawing.Size(128, 26);
            this.classNameText.TabIndex = 13;
            this.classNameText.Text = "Class Name:";
            // 
            // discussionButton
            // 
            this.discussionButton.AutoSize = true;
            this.discussionButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discussionButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.discussionButton.Location = new System.Drawing.Point(432, 143);
            this.discussionButton.Name = "discussionButton";
            this.discussionButton.Size = new System.Drawing.Size(114, 26);
            this.discussionButton.TabIndex = 11;
            this.discussionButton.TabStop = true;
            this.discussionButton.Text = "Discussion";
            this.discussionButton.UseVisualStyleBackColor = true;
            // 
            // labButton
            // 
            this.labButton.AutoSize = true;
            this.labButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labButton.Location = new System.Drawing.Point(432, 120);
            this.labButton.Name = "labButton";
            this.labButton.Size = new System.Drawing.Size(57, 26);
            this.labButton.TabIndex = 10;
            this.labButton.TabStop = true;
            this.labButton.Text = "Lab";
            this.labButton.UseVisualStyleBackColor = true;
            // 
            // lectureButton
            // 
            this.lectureButton.AutoSize = true;
            this.lectureButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lectureButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lectureButton.Location = new System.Drawing.Point(432, 97);
            this.lectureButton.Name = "lectureButton";
            this.lectureButton.Size = new System.Drawing.Size(87, 26);
            this.lectureButton.TabIndex = 9;
            this.lectureButton.TabStop = true;
            this.lectureButton.Text = "Lecture";
            this.lectureButton.UseVisualStyleBackColor = true;
            // 
            // classTypeText
            // 
            this.classTypeText.AutoSize = true;
            this.classTypeText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classTypeText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classTypeText.Location = new System.Drawing.Point(429, 69);
            this.classTypeText.Name = "classTypeText";
            this.classTypeText.Size = new System.Drawing.Size(118, 26);
            this.classTypeText.TabIndex = 15;
            this.classTypeText.Text = "Class Type:";
            // 
            // confirmClass
            // 
            this.confirmClass.BackColor = System.Drawing.Color.LightSteelBlue;
            this.confirmClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmClass.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmClass.Location = new System.Drawing.Point(133, 459);
            this.confirmClass.Margin = new System.Windows.Forms.Padding(0);
            this.confirmClass.Name = "confirmClass";
            this.confirmClass.Size = new System.Drawing.Size(100, 45);
            this.confirmClass.TabIndex = 16;
            this.confirmClass.Text = "Add Class";
            this.confirmClass.UseVisualStyleBackColor = false;
            this.confirmClass.Click += new System.EventHandler(this.confirmClass_Click);
            // 
            // cancelClass
            // 
            this.cancelClass.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cancelClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelClass.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelClass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelClass.Location = new System.Drawing.Point(343, 459);
            this.cancelClass.Name = "cancelClass";
            this.cancelClass.Size = new System.Drawing.Size(100, 45);
            this.cancelClass.TabIndex = 17;
            this.cancelClass.Text = "Cancel";
            this.cancelClass.UseVisualStyleBackColor = false;
            this.cancelClass.Click += new System.EventHandler(this.cancelClass_Click);
            // 
            // classDescriptionText
            // 
            this.classDescriptionText.AutoSize = true;
            this.classDescriptionText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classDescriptionText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classDescriptionText.Location = new System.Drawing.Point(41, 118);
            this.classDescriptionText.Name = "classDescriptionText";
            this.classDescriptionText.Size = new System.Drawing.Size(127, 26);
            this.classDescriptionText.TabIndex = 18;
            this.classDescriptionText.Text = "Description:";
            // 
            // classDescription
            // 
            this.classDescription.Location = new System.Drawing.Point(193, 124);
            this.classDescription.Name = "classDescription";
            this.classDescription.Size = new System.Drawing.Size(198, 20);
            this.classDescription.TabIndex = 19;
            // 
            // classDays
            // 
            this.classDays.BackColor = System.Drawing.Color.RoyalBlue;
            this.classDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classDays.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classDays.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classDays.FormattingEnabled = true;
            this.classDays.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.classDays.Location = new System.Drawing.Point(432, 222);
            this.classDays.Margin = new System.Windows.Forms.Padding(0);
            this.classDays.Name = "classDays";
            this.classDays.Size = new System.Drawing.Size(115, 161);
            this.classDays.TabIndex = 20;
            // 
            // classDaysText
            // 
            this.classDaysText.AutoSize = true;
            this.classDaysText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classDaysText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.classDaysText.Location = new System.Drawing.Point(454, 193);
            this.classDaysText.Name = "classDaysText";
            this.classDaysText.Size = new System.Drawing.Size(63, 26);
            this.classDaysText.TabIndex = 21;
            this.classDaysText.Text = "Days:";
            this.classDaysText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startDateText
            // 
            this.startDateText.AutoSize = true;
            this.startDateText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDateText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startDateText.Location = new System.Drawing.Point(41, 212);
            this.startDateText.Name = "startDateText";
            this.startDateText.Size = new System.Drawing.Size(114, 26);
            this.startDateText.TabIndex = 23;
            this.startDateText.Text = "Start Date:";
            // 
            // endDateText
            // 
            this.endDateText.AutoSize = true;
            this.endDateText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDateText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.endDateText.Location = new System.Drawing.Point(41, 237);
            this.endDateText.Name = "endDateText";
            this.endDateText.Size = new System.Drawing.Size(104, 26);
            this.endDateText.TabIndex = 24;
            this.endDateText.Text = "End Date:";
            // 
            // startTimeText
            // 
            this.startTimeText.AutoSize = true;
            this.startTimeText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startTimeText.Location = new System.Drawing.Point(41, 305);
            this.startTimeText.Name = "startTimeText";
            this.startTimeText.Size = new System.Drawing.Size(117, 26);
            this.startTimeText.TabIndex = 25;
            this.startTimeText.Text = "Start Time:";
            // 
            // endTimeText
            // 
            this.endTimeText.AutoSize = true;
            this.endTimeText.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.endTimeText.Location = new System.Drawing.Point(41, 330);
            this.endTimeText.Name = "endTimeText";
            this.endTimeText.Size = new System.Drawing.Size(107, 26);
            this.endTimeText.TabIndex = 26;
            this.endTimeText.Text = "End Time:";
            // 
            // startMonth
            // 
            this.startMonth.DropDownHeight = 100;
            this.startMonth.FormattingEnabled = true;
            this.startMonth.IntegralHeight = false;
            this.startMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.startMonth.Location = new System.Drawing.Point(168, 217);
            this.startMonth.Name = "startMonth";
            this.startMonth.Size = new System.Drawing.Size(43, 21);
            this.startMonth.TabIndex = 27;
            // 
            // endMonth
            // 
            this.endMonth.DropDownHeight = 100;
            this.endMonth.FormattingEnabled = true;
            this.endMonth.IntegralHeight = false;
            this.endMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.endMonth.Location = new System.Drawing.Point(168, 244);
            this.endMonth.Name = "endMonth";
            this.endMonth.Size = new System.Drawing.Size(43, 21);
            this.endMonth.TabIndex = 28;
            // 
            // startDay
            // 
            this.startDay.DropDownHeight = 100;
            this.startDay.FormattingEnabled = true;
            this.startDay.IntegralHeight = false;
            this.startDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.startDay.Location = new System.Drawing.Point(217, 217);
            this.startDay.Name = "startDay";
            this.startDay.Size = new System.Drawing.Size(43, 21);
            this.startDay.TabIndex = 29;
            // 
            // endDay
            // 
            this.endDay.DropDownHeight = 100;
            this.endDay.FormattingEnabled = true;
            this.endDay.IntegralHeight = false;
            this.endDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.endDay.Location = new System.Drawing.Point(217, 244);
            this.endDay.Name = "endDay";
            this.endDay.Size = new System.Drawing.Size(43, 21);
            this.endDay.TabIndex = 30;
            // 
            // startYear
            // 
            this.startYear.FormattingEnabled = true;
            this.startYear.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.startYear.Location = new System.Drawing.Point(267, 217);
            this.startYear.Name = "startYear";
            this.startYear.Size = new System.Drawing.Size(66, 21);
            this.startYear.TabIndex = 31;
            // 
            // endYear
            // 
            this.endYear.FormattingEnabled = true;
            this.endYear.Items.AddRange(new object[] {
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.endYear.Location = new System.Drawing.Point(267, 244);
            this.endYear.Name = "endYear";
            this.endYear.Size = new System.Drawing.Size(66, 21);
            this.endYear.TabIndex = 32;
            // 
            // startHour
            // 
            this.startHour.FormattingEnabled = true;
            this.startHour.Location = new System.Drawing.Point(168, 305);
            this.startHour.Name = "startHour";
            this.startHour.Size = new System.Drawing.Size(43, 21);
            this.startHour.TabIndex = 33;
            // 
            // endHour
            // 
            this.endHour.FormattingEnabled = true;
            this.endHour.Location = new System.Drawing.Point(168, 330);
            this.endHour.Name = "endHour";
            this.endHour.Size = new System.Drawing.Size(43, 21);
            this.endHour.TabIndex = 34;
            // 
            // startMinute
            // 
            this.startMinute.FormattingEnabled = true;
            this.startMinute.Location = new System.Drawing.Point(217, 305);
            this.startMinute.Name = "startMinute";
            this.startMinute.Size = new System.Drawing.Size(43, 21);
            this.startMinute.TabIndex = 35;
            // 
            // endMinute
            // 
            this.endMinute.FormattingEnabled = true;
            this.endMinute.Location = new System.Drawing.Point(217, 330);
            this.endMinute.Name = "endMinute";
            this.endMinute.Size = new System.Drawing.Size(43, 21);
            this.endMinute.TabIndex = 36;
            // 
            // startMeridiem
            // 
            this.startMeridiem.FormattingEnabled = true;
            this.startMeridiem.Location = new System.Drawing.Point(267, 305);
            this.startMeridiem.Name = "startMeridiem";
            this.startMeridiem.Size = new System.Drawing.Size(43, 21);
            this.startMeridiem.TabIndex = 37;
            // 
            // endMeridiem
            // 
            this.endMeridiem.FormattingEnabled = true;
            this.endMeridiem.Location = new System.Drawing.Point(267, 330);
            this.endMeridiem.Name = "endMeridiem";
            this.endMeridiem.Size = new System.Drawing.Size(43, 21);
            this.endMeridiem.TabIndex = 38;
            // 
            // dateExampleText
            // 
            this.dateExampleText.AutoSize = true;
            this.dateExampleText.BackColor = System.Drawing.Color.RoyalBlue;
            this.dateExampleText.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateExampleText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateExampleText.Location = new System.Drawing.Point(168, 193);
            this.dateExampleText.Name = "dateExampleText";
            this.dateExampleText.Size = new System.Drawing.Size(149, 20);
            this.dateExampleText.TabIndex = 39;
            this.dateExampleText.Text = "MM   /  DD   /  YYYY";
            // 
            // AddClass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.dateExampleText);
            this.Controls.Add(this.endMeridiem);
            this.Controls.Add(this.startMeridiem);
            this.Controls.Add(this.endMinute);
            this.Controls.Add(this.startMinute);
            this.Controls.Add(this.endHour);
            this.Controls.Add(this.startHour);
            this.Controls.Add(this.endYear);
            this.Controls.Add(this.startYear);
            this.Controls.Add(this.endDay);
            this.Controls.Add(this.startDay);
            this.Controls.Add(this.endMonth);
            this.Controls.Add(this.startMonth);
            this.Controls.Add(this.endTimeText);
            this.Controls.Add(this.startTimeText);
            this.Controls.Add(this.endDateText);
            this.Controls.Add(this.startDateText);
            this.Controls.Add(this.classDaysText);
            this.Controls.Add(this.classDays);
            this.Controls.Add(this.classDescription);
            this.Controls.Add(this.classDescriptionText);
            this.Controls.Add(this.cancelClass);
            this.Controls.Add(this.confirmClass);
            this.Controls.Add(this.classTypeText);
            this.Controls.Add(this.className);
            this.Controls.Add(this.classNameText);
            this.Controls.Add(this.discussionButton);
            this.Controls.Add(this.labButton);
            this.Controls.Add(this.lectureButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Class";
            this.Load += new System.EventHandler(this.AddClass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox className;
        private System.Windows.Forms.Label classNameText;
        private System.Windows.Forms.RadioButton discussionButton;
        private System.Windows.Forms.RadioButton labButton;
        private System.Windows.Forms.RadioButton lectureButton;
        private System.Windows.Forms.Label classTypeText;
        private System.Windows.Forms.Button confirmClass;
        private System.Windows.Forms.Button cancelClass;
        private System.Windows.Forms.Label classDescriptionText;
        private System.Windows.Forms.TextBox classDescription;
        private System.Windows.Forms.CheckedListBox classDays;
        private System.Windows.Forms.Label classDaysText;
        private System.Windows.Forms.Label startDateText;
        private System.Windows.Forms.Label endDateText;
        private System.Windows.Forms.Label startTimeText;
        private System.Windows.Forms.Label endTimeText;
        private System.Windows.Forms.ComboBox startMonth;
        private System.Windows.Forms.ComboBox endMonth;
        private System.Windows.Forms.ComboBox startDay;
        private System.Windows.Forms.ComboBox endDay;
        private System.Windows.Forms.ComboBox startYear;
        private System.Windows.Forms.ComboBox endYear;
        private System.Windows.Forms.ComboBox startHour;
        private System.Windows.Forms.ComboBox endHour;
        private System.Windows.Forms.ComboBox startMinute;
        private System.Windows.Forms.ComboBox endMinute;
        private System.Windows.Forms.ComboBox startMeridiem;
        private System.Windows.Forms.ComboBox endMeridiem;
        private System.Windows.Forms.Label dateExampleText;
    }
}