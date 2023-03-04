namespace Airport.FormApp
{
    partial class CabinCrewForm
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
            this.listBoxAircrafts = new System.Windows.Forms.ListBox();
            this.listBoxPilots = new System.Windows.Forms.ListBox();
            this.listBoxCabinCrew = new System.Windows.Forms.ListBox();
            this.labelAircraft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAircraftPrevious = new System.Windows.Forms.Button();
            this.btnAircraftNext = new System.Windows.Forms.Button();
            this.labelAircraftPage = new System.Windows.Forms.Label();
            this.btnPilotsPrevious = new System.Windows.Forms.Button();
            this.btnPilotsNext = new System.Windows.Forms.Button();
            this.labelPilotsPage = new System.Windows.Forms.Label();
            this.comboBoxCrewCount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxAircrafts
            // 
            this.listBoxAircrafts.FormattingEnabled = true;
            this.listBoxAircrafts.ItemHeight = 31;
            this.listBoxAircrafts.Location = new System.Drawing.Point(33, 76);
            this.listBoxAircrafts.Name = "listBoxAircrafts";
            this.listBoxAircrafts.Size = new System.Drawing.Size(345, 438);
            this.listBoxAircrafts.TabIndex = 0;
            this.listBoxAircrafts.DoubleClick += new System.EventHandler(this.listBoxAircrafts_DoubleClick);
            // 
            // listBoxPilots
            // 
            this.listBoxPilots.FormattingEnabled = true;
            this.listBoxPilots.ItemHeight = 31;
            this.listBoxPilots.Location = new System.Drawing.Point(413, 76);
            this.listBoxPilots.Name = "listBoxPilots";
            this.listBoxPilots.Size = new System.Drawing.Size(330, 438);
            this.listBoxPilots.TabIndex = 1;
            this.listBoxPilots.DoubleClick += new System.EventHandler(this.listBoxPilots_DoubleClick);
            // 
            // listBoxCabinCrew
            // 
            this.listBoxCabinCrew.FormattingEnabled = true;
            this.listBoxCabinCrew.ItemHeight = 31;
            this.listBoxCabinCrew.Location = new System.Drawing.Point(788, 138);
            this.listBoxCabinCrew.Name = "listBoxCabinCrew";
            this.listBoxCabinCrew.Size = new System.Drawing.Size(315, 376);
            this.listBoxCabinCrew.TabIndex = 2;
            // 
            // labelAircraft
            // 
            this.labelAircraft.AutoSize = true;
            this.labelAircraft.Location = new System.Drawing.Point(788, 76);
            this.labelAircraft.Name = "labelAircraft";
            this.labelAircraft.Size = new System.Drawing.Size(23, 31);
            this.labelAircraft.TabIndex = 3;
            this.labelAircraft.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Step 1 - Select aircraft";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(864, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAircraftPrevious
            // 
            this.btnAircraftPrevious.Location = new System.Drawing.Point(59, 555);
            this.btnAircraftPrevious.Name = "btnAircraftPrevious";
            this.btnAircraftPrevious.Size = new System.Drawing.Size(103, 45);
            this.btnAircraftPrevious.TabIndex = 6;
            this.btnAircraftPrevious.Text = "<<";
            this.btnAircraftPrevious.UseVisualStyleBackColor = true;
            this.btnAircraftPrevious.Click += new System.EventHandler(this.btnAircraftPrevious_Click);
            // 
            // btnAircraftNext
            // 
            this.btnAircraftNext.Location = new System.Drawing.Point(184, 555);
            this.btnAircraftNext.Name = "btnAircraftNext";
            this.btnAircraftNext.Size = new System.Drawing.Size(106, 45);
            this.btnAircraftNext.TabIndex = 7;
            this.btnAircraftNext.Text = ">>";
            this.btnAircraftNext.UseVisualStyleBackColor = true;
            this.btnAircraftNext.Click += new System.EventHandler(this.btnAircraftNext_Click);
            // 
            // labelAircraftPage
            // 
            this.labelAircraftPage.AutoSize = true;
            this.labelAircraftPage.Location = new System.Drawing.Point(141, 521);
            this.labelAircraftPage.Name = "labelAircraftPage";
            this.labelAircraftPage.Size = new System.Drawing.Size(76, 31);
            this.labelAircraftPage.TabIndex = 8;
            this.labelAircraftPage.Text = "label2";
            // 
            // btnPilotsPrevious
            // 
            this.btnPilotsPrevious.Location = new System.Drawing.Point(533, 555);
            this.btnPilotsPrevious.Name = "btnPilotsPrevious";
            this.btnPilotsPrevious.Size = new System.Drawing.Size(101, 44);
            this.btnPilotsPrevious.TabIndex = 9;
            this.btnPilotsPrevious.Text = "<<";
            this.btnPilotsPrevious.UseVisualStyleBackColor = true;
            this.btnPilotsPrevious.Click += new System.EventHandler(this.btnPilotsPrevious_Click);
            // 
            // btnPilotsNext
            // 
            this.btnPilotsNext.Location = new System.Drawing.Point(640, 556);
            this.btnPilotsNext.Name = "btnPilotsNext";
            this.btnPilotsNext.Size = new System.Drawing.Size(103, 44);
            this.btnPilotsNext.TabIndex = 10;
            this.btnPilotsNext.Text = ">>";
            this.btnPilotsNext.UseVisualStyleBackColor = true;
            this.btnPilotsNext.Click += new System.EventHandler(this.btnPilotsNext_Click);
            // 
            // labelPilotsPage
            // 
            this.labelPilotsPage.AutoSize = true;
            this.labelPilotsPage.Location = new System.Drawing.Point(610, 521);
            this.labelPilotsPage.Name = "labelPilotsPage";
            this.labelPilotsPage.Size = new System.Drawing.Size(76, 31);
            this.labelPilotsPage.TabIndex = 11;
            this.labelPilotsPage.Text = "label2";
            // 
            // comboBoxCrewCount
            // 
            this.comboBoxCrewCount.FormattingEnabled = true;
            this.comboBoxCrewCount.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBoxCrewCount.Location = new System.Drawing.Point(424, 556);
            this.comboBoxCrewCount.Name = "comboBoxCrewCount";
            this.comboBoxCrewCount.Size = new System.Drawing.Size(95, 39);
            this.comboBoxCrewCount.TabIndex = 12;
            this.comboBoxCrewCount.SelectedIndexChanged += new System.EventHandler(this.comboBoxCrewCount_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Crew count";
            // 
            // CabinCrewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 624);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCrewCount);
            this.Controls.Add(this.labelPilotsPage);
            this.Controls.Add(this.btnPilotsNext);
            this.Controls.Add(this.btnPilotsPrevious);
            this.Controls.Add(this.labelAircraftPage);
            this.Controls.Add(this.btnAircraftNext);
            this.Controls.Add(this.btnAircraftPrevious);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAircraft);
            this.Controls.Add(this.listBoxCabinCrew);
            this.Controls.Add(this.listBoxPilots);
            this.Controls.Add(this.listBoxAircrafts);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CabinCrewForm";
            this.Text = "CabinCrewForm";
            this.Load += new System.EventHandler(this.CabinCrewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAircrafts;
        private System.Windows.Forms.ListBox listBoxPilots;
        private System.Windows.Forms.ListBox listBoxCabinCrew;
        private System.Windows.Forms.Label labelAircraft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAircraftPrevious;
        private System.Windows.Forms.Button btnAircraftNext;
        private System.Windows.Forms.Label labelAircraftPage;
        private System.Windows.Forms.Button btnPilotsPrevious;
        private System.Windows.Forms.Button btnPilotsNext;
        private System.Windows.Forms.Label labelPilotsPage;
        private System.Windows.Forms.ComboBox comboBoxCrewCount;
        private System.Windows.Forms.Label label2;
    }
}