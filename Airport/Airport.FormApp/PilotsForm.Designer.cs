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
            this.groupBoxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAdd
            // 
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
            this.groupBoxAdd.Location = new System.Drawing.Point(47, 38);
            this.groupBoxAdd.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxAdd.Size = new System.Drawing.Size(509, 428);
            this.groupBoxAdd.TabIndex = 0;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Create";
            this.groupBoxAdd.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // PilotsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 569);
            this.Controls.Add(this.groupBoxAdd);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PilotsForm";
            this.Text = "PilotsForm";
            this.Load += new System.EventHandler(this.PilotsForm_Load);
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.ResumeLayout(false);

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
    }
}