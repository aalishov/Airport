namespace Airport.FormApp
{
    partial class DestinationForm
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
            this.listBoxFrom = new System.Windows.Forms.ListBox();
            this.listBoxTo = new System.Windows.Forms.ListBox();
            this.listBoxAircraft = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTicketsCount = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCreate = new System.Windows.Forms.Button();
            this.labelStepInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxFrom
            // 
            this.listBoxFrom.FormattingEnabled = true;
            this.listBoxFrom.ItemHeight = 20;
            this.listBoxFrom.Location = new System.Drawing.Point(40, 82);
            this.listBoxFrom.Name = "listBoxFrom";
            this.listBoxFrom.Size = new System.Drawing.Size(312, 384);
            this.listBoxFrom.TabIndex = 0;
            this.listBoxFrom.DoubleClick += new System.EventHandler(this.listBoxFrom_DoubleClick);
            // 
            // listBoxTo
            // 
            this.listBoxTo.FormattingEnabled = true;
            this.listBoxTo.ItemHeight = 20;
            this.listBoxTo.Location = new System.Drawing.Point(385, 82);
            this.listBoxTo.Name = "listBoxTo";
            this.listBoxTo.Size = new System.Drawing.Size(304, 384);
            this.listBoxTo.TabIndex = 1;
            this.listBoxTo.DoubleClick += new System.EventHandler(this.listBoxTo_DoubleClick);
            // 
            // listBoxAircraft
            // 
            this.listBoxAircraft.FormattingEnabled = true;
            this.listBoxAircraft.ItemHeight = 20;
            this.listBoxAircraft.Location = new System.Drawing.Point(716, 84);
            this.listBoxAircraft.Name = "listBoxAircraft";
            this.listBoxAircraft.Size = new System.Drawing.Size(283, 384);
            this.listBoxAircraft.TabIndex = 2;
            this.listBoxAircraft.DoubleClick += new System.EventHandler(this.listBoxAircraft_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTicketsCount);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(40, 486);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 106);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtTicketsCount
            // 
            this.txtTicketsCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtTicketsCount.Location = new System.Drawing.Point(666, 64);
            this.txtTicketsCount.Name = "txtTicketsCount";
            this.txtTicketsCount.Size = new System.Drawing.Size(223, 27);
            this.txtTicketsCount.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtPrice.Location = new System.Drawing.Point(376, 64);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(223, 27);
            this.txtPrice.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(316, 27);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(40, 620);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(177, 77);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "button1";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // labelStepInfo
            // 
            this.labelStepInfo.AutoSize = true;
            this.labelStepInfo.Location = new System.Drawing.Point(468, 40);
            this.labelStepInfo.Name = "labelStepInfo";
            this.labelStepInfo.Size = new System.Drawing.Size(255, 20);
            this.labelStepInfo.TabIndex = 5;
            this.labelStepInfo.Text = "Step 1 - Select destination start point";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 77);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DestinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 743);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelStepInfo);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBoxAircraft);
            this.Controls.Add(this.listBoxTo);
            this.Controls.Add(this.listBoxFrom);
            this.Name = "DestinationForm";
            this.Text = "DestinationForm";
            this.Load += new System.EventHandler(this.DestinationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFrom;
        private System.Windows.Forms.ListBox listBoxTo;
        private System.Windows.Forms.ListBox listBoxAircraft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTicketsCount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label labelStepInfo;
        private System.Windows.Forms.Button button1;
    }
}