namespace Airport.FormApp
{
    partial class PilotsForm
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
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.btnClearAdd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboRating = new System.Windows.Forms.ComboBox();
            this.comboAge = new System.Windows.Forms.ComboBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPilots = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.comboBoxItemsPerPage = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPageInfo = new System.Windows.Forms.Label();
            this.groupBoxOpt = new System.Windows.Forms.GroupBox();
            this.radioEdit = new System.Windows.Forms.RadioButton();
            this.radioAdd = new System.Windows.Forms.RadioButton();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxOpt.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.checkBoxDelete);
            this.groupBoxAdd.Controls.Add(this.btnClearAdd);
            this.groupBoxAdd.Controls.Add(this.btnAdd);
            this.groupBoxAdd.Controls.Add(this.comboRating);
            this.groupBoxAdd.Controls.Add(this.comboAge);
            this.groupBoxAdd.Controls.Add(this.txtLastName);
            this.groupBoxAdd.Controls.Add(this.txtFirstName);
            this.groupBoxAdd.Controls.Add(this.label4);
            this.groupBoxAdd.Controls.Add(this.label3);
            this.groupBoxAdd.Controls.Add(this.label2);
            this.groupBoxAdd.Controls.Add(this.label1);
            this.groupBoxAdd.Location = new System.Drawing.Point(50, 80);
            this.groupBoxAdd.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxAdd.Size = new System.Drawing.Size(509, 428);
            this.groupBoxAdd.TabIndex = 0;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Create";
            this.groupBoxAdd.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.AutoSize = true;
            this.checkBoxDelete.Location = new System.Drawing.Point(10, 280);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(155, 35);
            this.checkBoxDelete.TabIndex = 10;
            this.checkBoxDelete.Text = "Delete pilot";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            this.checkBoxDelete.CheckedChanged += new System.EventHandler(this.checkBoxDelete_CheckedChanged);
            // 
            // btnClearAdd
            // 
            this.btnClearAdd.Location = new System.Drawing.Point(279, 328);
            this.btnClearAdd.Name = "btnClearAdd";
            this.btnClearAdd.Size = new System.Drawing.Size(168, 79);
            this.btnClearAdd.TabIndex = 9;
            this.btnClearAdd.Text = "Clear";
            this.btnClearAdd.UseVisualStyleBackColor = true;
            this.btnClearAdd.Click += new System.EventHandler(this.btnClearAdd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 328);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 80);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboRating
            // 
            this.comboRating.FormattingEnabled = true;
            this.comboRating.Location = new System.Drawing.Point(151, 235);
            this.comboRating.Name = "comboRating";
            this.comboRating.Size = new System.Drawing.Size(313, 39);
            this.comboRating.TabIndex = 7;
            this.comboRating.SelectedIndexChanged += new System.EventHandler(this.comboRating_SelectedIndexChanged);
            // 
            // comboAge
            // 
            this.comboAge.FormattingEnabled = true;
            this.comboAge.Location = new System.Drawing.Point(151, 177);
            this.comboAge.Name = "comboAge";
            this.comboAge.Size = new System.Drawing.Size(313, 39);
            this.comboAge.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(151, 122);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(313, 38);
            this.txtLastName.TabIndex = 5;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(151, 69);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(313, 38);
            this.txtFirstName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rating";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "First name";
            // 
            // listBoxPilots
            // 
            this.listBoxPilots.FormattingEnabled = true;
            this.listBoxPilots.ItemHeight = 31;
            this.listBoxPilots.Location = new System.Drawing.Point(596, 95);
            this.listBoxPilots.Name = "listBoxPilots";
            this.listBoxPilots.Size = new System.Drawing.Size(425, 407);
            this.listBoxPilots.TabIndex = 1;
            this.listBoxPilots.DoubleClick += new System.EventHandler(this.listBoxPilots_DoubleClick);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(636, 549);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(119, 58);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "<<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(761, 549);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(117, 58);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // comboBoxItemsPerPage
            // 
            this.comboBoxItemsPerPage.FormattingEnabled = true;
            this.comboBoxItemsPerPage.Items.AddRange(new object[] {
            "10",
            "20",
            "30"});
            this.comboBoxItemsPerPage.Location = new System.Drawing.Point(911, 560);
            this.comboBoxItemsPerPage.Name = "comboBoxItemsPerPage";
            this.comboBoxItemsPerPage.Size = new System.Drawing.Size(110, 39);
            this.comboBoxItemsPerPage.TabIndex = 4;
            this.comboBoxItemsPerPage.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemsPerPage_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MingLiU-ExtB", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(414, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 43);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pilots manager";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelPageInfo
            // 
            this.labelPageInfo.AutoSize = true;
            this.labelPageInfo.Location = new System.Drawing.Point(761, 505);
            this.labelPageInfo.Name = "labelPageInfo";
            this.labelPageInfo.Size = new System.Drawing.Size(23, 31);
            this.labelPageInfo.TabIndex = 6;
            this.labelPageInfo.Text = "-";
            // 
            // groupBoxOpt
            // 
            this.groupBoxOpt.Controls.Add(this.radioEdit);
            this.groupBoxOpt.Controls.Add(this.radioAdd);
            this.groupBoxOpt.Location = new System.Drawing.Point(50, 526);
            this.groupBoxOpt.Name = "groupBoxOpt";
            this.groupBoxOpt.Size = new System.Drawing.Size(403, 83);
            this.groupBoxOpt.TabIndex = 7;
            this.groupBoxOpt.TabStop = false;
            this.groupBoxOpt.Text = "Options";
            // 
            // radioEdit
            // 
            this.radioEdit.AutoSize = true;
            this.radioEdit.Location = new System.Drawing.Point(207, 37);
            this.radioEdit.Name = "radioEdit";
            this.radioEdit.Size = new System.Drawing.Size(75, 35);
            this.radioEdit.TabIndex = 1;
            this.radioEdit.TabStop = true;
            this.radioEdit.Text = "Edit";
            this.radioEdit.UseVisualStyleBackColor = true;
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Location = new System.Drawing.Point(60, 40);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(78, 35);
            this.radioAdd.TabIndex = 0;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "Add";
            this.radioAdd.UseVisualStyleBackColor = true;
            this.radioAdd.CheckedChanged += new System.EventHandler(this.radioAdd_CheckedChanged);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(471, 526);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(142, 81);
            this.btnStatistics.TabIndex = 8;
            this.btnStatistics.Text = "Show statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // PilotsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 621);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.groupBoxOpt);
            this.Controls.Add(this.labelPageInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxItemsPerPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.listBoxPilots);
            this.Controls.Add(this.groupBoxAdd);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PilotsForm";
            this.Text = "PilotsForm";
            this.Load += new System.EventHandler(this.PilotsForm_Load);
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.groupBoxOpt.ResumeLayout(false);
            this.groupBoxOpt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.ComboBox comboRating;
        private System.Windows.Forms.ComboBox comboAge;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClearAdd;
        private System.Windows.Forms.ListBox listBoxPilots;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox comboBoxItemsPerPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPageInfo;
        private System.Windows.Forms.GroupBox groupBoxOpt;
        private System.Windows.Forms.RadioButton radioEdit;
        private System.Windows.Forms.RadioButton radioAdd;
        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.Button btnStatistics;
    }
}