namespace Airport.FormApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPilotForm = new System.Windows.Forms.Button();
            this.btnAircraft = new System.Windows.Forms.Button();
            this.btnCabinCrew = new System.Windows.Forms.Button();
            this.btnAirports = new System.Windows.Forms.Button();
            this.btnDestinations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPilotForm
            // 
            this.btnPilotForm.Location = new System.Drawing.Point(42, 39);
            this.btnPilotForm.Name = "btnPilotForm";
            this.btnPilotForm.Size = new System.Drawing.Size(171, 114);
            this.btnPilotForm.TabIndex = 0;
            this.btnPilotForm.Text = "Pilots";
            this.btnPilotForm.UseVisualStyleBackColor = true;
            this.btnPilotForm.Click += new System.EventHandler(this.btnPilotForm_Click);
            // 
            // btnAircraft
            // 
            this.btnAircraft.Location = new System.Drawing.Point(219, 39);
            this.btnAircraft.Name = "btnAircraft";
            this.btnAircraft.Size = new System.Drawing.Size(160, 114);
            this.btnAircraft.TabIndex = 1;
            this.btnAircraft.Text = "Aircrafts";
            this.btnAircraft.UseVisualStyleBackColor = true;
            this.btnAircraft.Click += new System.EventHandler(this.btnAircraft_Click);
            // 
            // btnCabinCrew
            // 
            this.btnCabinCrew.Location = new System.Drawing.Point(385, 42);
            this.btnCabinCrew.Name = "btnCabinCrew";
            this.btnCabinCrew.Size = new System.Drawing.Size(172, 111);
            this.btnCabinCrew.TabIndex = 2;
            this.btnCabinCrew.Text = "Cabin crew";
            this.btnCabinCrew.UseVisualStyleBackColor = true;
            this.btnCabinCrew.Click += new System.EventHandler(this.btnCabinCrew_Click);
            // 
            // btnAirports
            // 
            this.btnAirports.Location = new System.Drawing.Point(563, 43);
            this.btnAirports.Name = "btnAirports";
            this.btnAirports.Size = new System.Drawing.Size(149, 108);
            this.btnAirports.TabIndex = 3;
            this.btnAirports.Text = "Airports";
            this.btnAirports.UseVisualStyleBackColor = true;
            this.btnAirports.Click += new System.EventHandler(this.btnAirports_Click);
            // 
            // btnDestinations
            // 
            this.btnDestinations.Location = new System.Drawing.Point(51, 171);
            this.btnDestinations.Name = "btnDestinations";
            this.btnDestinations.Size = new System.Drawing.Size(164, 100);
            this.btnDestinations.TabIndex = 4;
            this.btnDestinations.Text = "Destinations";
            this.btnDestinations.UseVisualStyleBackColor = true;
            this.btnDestinations.Click += new System.EventHandler(this.btnDestinations_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDestinations);
            this.Controls.Add(this.btnAirports);
            this.Controls.Add(this.btnCabinCrew);
            this.Controls.Add(this.btnAircraft);
            this.Controls.Add(this.btnPilotForm);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPilotForm;
        private System.Windows.Forms.Button btnAircraft;
        private System.Windows.Forms.Button btnCabinCrew;
        private System.Windows.Forms.Button btnAirports;
        private System.Windows.Forms.Button btnDestinations;
    }
}
